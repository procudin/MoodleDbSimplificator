using EFCore.BulkExtensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MoodleDbSimplificator.ExportDb;
using MoodleDbSimplificator.ExportDb.Entities;
using MoodleDbSimplificator.ExportDb.Entities.Enums;
using MoodleDbSimplificator.MoodleDb.V39;
using MoodleDbSimplificator.MoodleDb.V39.Entities;

namespace MoodleDbSimplificator.Services;

public interface IMoodle39ExportService
{
    Task Export(CancellationToken cancellationToken = default);
}

public class Moodle39ExportService : IMoodle39ExportService
{
    private readonly int PageSize = 30000;
    private readonly ExportDbContext _exportDb;
    private readonly Moodle39DbContext _moodleDb;
    private readonly ILogger<Moodle39ExportService> _logger;

    public Moodle39ExportService(Moodle39DbContext moodleDb, ILogger<Moodle39ExportService> logger, ExportDbContext exportDb)
    {
        _moodleDb = moodleDb;
        _logger   = logger;
        _exportDb = exportDb;
    }

    public async Task Export(CancellationToken cancellationToken)
    {
        await _exportDb.Database.EnsureDeletedAsync(cancellationToken);
        await _exportDb.Database.EnsureCreatedAsync(cancellationToken);
        _logger.LogInformation("Db recreated");

        await ExportCources(cancellationToken);
        await ExportQuizzes(cancellationToken);
        await ExportQuestions(cancellationToken);
        await ExportQuizQuestions(cancellationToken);
        await ExportUsers(cancellationToken);
        await ExportQuizAttempts(cancellationToken);
        await ExportQuestionAttempts(cancellationToken);
        
    }

    private async Task ExportUsers(CancellationToken cancellationToken)
    {
        var usersToAdd = await _moodleDb.MdlUsers.AsNoTracking()
            .Select(mdlUser => 
                new User
                {
                    UserId = mdlUser.Id,
                    Username = mdlUser.Username,
                    Sex = null,
                    Country = mdlUser.Country,
                    Lang = mdlUser.Lang,
                    Firstaccess = DateTimeOffset.FromUnixTimeSeconds(mdlUser.Firstaccess).UtcDateTime,
                    Lastaccess = DateTimeOffset.FromUnixTimeSeconds(mdlUser.Lastaccess).UtcDateTime,
                })
            .ToListAsync(cancellationToken: cancellationToken);
        await _exportDb.BulkInsertAsync(usersToAdd, cancellationToken: cancellationToken);
        _logger.LogInformation("Exported {} users", usersToAdd.Count);
    }
    
    private async Task ExportCources(CancellationToken cancellationToken)
    {
        var courcesToAdd = await _moodleDb.MdlCourses.AsNoTracking()
            .Select(cource => 
                new Course
                {
                    CourseId  = cource.Id,
                    FullName  = cource.Fullname,
                    ShortName = cource.Shortname,
                    Lang      = cource.Lang, 
                    CreatedAt = DateTimeOffset.FromUnixTimeSeconds(cource.Timecreated).UtcDateTime,
                    UpdatedAt = DateTimeOffset.FromUnixTimeSeconds(cource.Timemodified).UtcDateTime,
                })
            .ToListAsync(cancellationToken: cancellationToken);
        await _exportDb.BulkInsertAsync(courcesToAdd, cancellationToken: cancellationToken);
        _logger.LogInformation("Exported {} cources", courcesToAdd.Count);
    }

    private async Task ExportQuizzes(CancellationToken cancellationToken)
    {
        var quizzesToAdd = await _moodleDb.MdlQuizzes.AsNoTracking()
            .Select(q => new Quiz
            {
                QuizId      = q.Id,
                CourceId    = q.Course,
                Name        = q.Name,
                Intro       = q.Intro,
                TimeLimit   = TimeSpan.FromSeconds(q.Timelimit),
                Behaviour   = QuestionBehaviourParser.Parse(q.Preferredbehaviour),
                GradeMethod = (QuizGradeMethod)q.Grademethod,
                Grade       = q.Grade,
                SumGrades   = q.Sumgrades,
            })
            .ToListAsync(cancellationToken: cancellationToken);
        await _exportDb.BulkInsertAsync(quizzesToAdd, cancellationToken: cancellationToken);
        _logger.LogInformation("Exported {} quizzes", quizzesToAdd.Count);
    }
    
    private async Task ExportQuizQuestions(CancellationToken cancellationToken)
    {
        var qqToAdd = await _moodleDb.MdlQuizSlots.AsNoTracking()
            .Select(q => new QuizQuestion
            {
                QuizId          = q.Quizid,
                QuestionId      = q.Questionid,
                Order           = q.Slot,
                PageNumber      = q.Page,
                RequirePrevious = q.Requireprevious != 0,
            })
            .ToListAsync(cancellationToken: cancellationToken);
        await _exportDb.BulkInsertAsync(qqToAdd, cancellationToken: cancellationToken);
        _logger.LogInformation("Exported {} quiz-questions", qqToAdd.Count);
    }
    
    private async Task ExportQuestions(CancellationToken cancellationToken)
    {
        var query = 
            from q in _moodleDb.MdlQuestions.AsNoTracking()
            join qc in _moodleDb.MdlQuestionCategories.AsNoTracking()
                on q.Category equals qc.Id
            select new Question
            {
                QuestionId          = q.Id,
                CategoryName        = qc.Name,
                CategoryDescription = qc.Info,
                Name                = q.Name,
                Type                = q.Qtype,
                DefaultMark         = q.Defaultmark,
                Penalty             = q.Penalty,
            };
        var questionsToAdd = await query.ToListAsync(cancellationToken: cancellationToken);
        await _exportDb.BulkInsertAsync(questionsToAdd, cancellationToken: cancellationToken);
        _logger.LogInformation("Exported {} questions", questionsToAdd.Count);
    }

    private async Task ExportQuizAttempts(CancellationToken cancellationToken)
    {
        var query = 
            from quizAttempt in _moodleDb.MdlQuizAttempts.AsNoTracking()
                orderby quizAttempt.Quiz, quizAttempt.Userid, quizAttempt.Attempt
            join user in _moodleDb.MdlUsers.AsNoTracking() on quizAttempt.Userid equals user.Id 
            join quiz in _moodleDb.MdlQuizzes.AsNoTracking() on quizAttempt.Quiz equals quiz.Id
            select new QuizAttempt
            {
                QuizAttemptId = quizAttempt.Id,
                QuizId        = quizAttempt.Quiz,
                UserId        = quizAttempt.Userid,
                AttemptNumber = quizAttempt.Attempt,
                State         = QuizAttemptStateParser.Parse(quizAttempt.State),
                TimeStart     = DateTimeOffset.FromUnixTimeSeconds(quizAttempt.Timestart).UtcDateTime,
                TimeFinish    = DateTimeOffset.FromUnixTimeSeconds(quizAttempt.Timefinish).UtcDateTime,
                SumGrades     = quizAttempt.Sumgrades,
            };
        var qaToAdd = await query.ToListAsync(cancellationToken: cancellationToken);
        await _exportDb.BulkInsertAsync(qaToAdd, cancellationToken: cancellationToken);
        _logger.LogInformation("Exported {} quiz attempts", qaToAdd.Count);
    }

    private async Task ExportQuestionAttempts(CancellationToken cancellationToken)
    {
        var query =
            from quizAttempt in _moodleDb.MdlQuizAttempts.AsNoTracking()
            join questionUsage in _moodleDb.MdlQuestionUsages.AsNoTracking()
                on quizAttempt.Uniqueid equals questionUsage.Id
            join questionAttempt in _moodleDb.MdlQuestionAttempts.AsNoTracking()
                on questionUsage.Id equals questionAttempt.Questionusageid
            join user in _moodleDb.MdlUsers.AsNoTracking() on quizAttempt.Userid equals user.Id 
            join quiz in _moodleDb.MdlQuizzes.AsNoTracking() on quizAttempt.Quiz equals quiz.Id
            orderby questionAttempt.Id
            select new QuestionAttempt
            {
                QuestionAttemptId = questionAttempt.Id,
                QuestionId = questionAttempt.Questionid,
                QuizAttemptId = quizAttempt.Id,
                Behaviour = QuestionBehaviourParser.Parse(questionAttempt.Behaviour),
                UpdatedAt = DateTimeOffset.FromUnixTimeSeconds(questionAttempt.Timemodified).UtcDateTime,
            };
        
        var totalCount = await query.CountAsync(cancellationToken: cancellationToken);
        var loadedCount = 0;
        await foreach (var attemptChunk in query.AsChunkedAsyncEnumerable(PageSize).WithCancellation(cancellationToken))
        {
            await _exportDb.BulkInsertAsync(attemptChunk, cancellationToken: cancellationToken);
            loadedCount += attemptChunk.Count;
            _logger.LogInformation("Exported {}/{} question attempts", loadedCount, totalCount);
        }
    }
}

public static class Extensions
{
    public static async IAsyncEnumerable<IList<T>> AsChunkedAsyncEnumerable<T>(this IQueryable<T> source, int chunkSize)
    {
        var offset = 0;
        List<T> chunk;
        do
        {
            chunk = await source.Skip(offset).Take(chunkSize).ToListAsync();
            yield return chunk;
            offset += chunk.Count;
        } while (chunk.Count == chunkSize);
    }
}
