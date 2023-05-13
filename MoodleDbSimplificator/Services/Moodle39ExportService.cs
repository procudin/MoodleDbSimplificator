using EFCore.BulkExtensions;
using FuzzySharp;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MoodleDbSimplificator.ExportDb;
using MoodleDbSimplificator.ExportDb.Entities;
using MoodleDbSimplificator.ExportDb.Entities.Enums;
using MoodleDbSimplificator.MoodleDb.V39;
using MoodleDbSimplificator.Utils;
using System.Globalization;
using System.Text.Json;

namespace MoodleDbSimplificator.Services;

public interface IMoodle39ExportService
{
    Task Export(CancellationToken cancellationToken = default);
}

public class Moodle39ExportService : IMoodle39ExportService
{
    private const int PAGE_SIZE = 30000;
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
        await ExportQuizGrades(cancellationToken);
        await ExportQuizAttempts(cancellationToken);
        await ExportQuestionAttempts(cancellationToken);
        await ExportQuestionAttemptSteps(cancellationToken);
        //await ExportExamGrades(cancellationToken);
    }

    private async Task ExportUsers(CancellationToken cancellationToken)
    {
        var usersToAdd = await _moodleDb.MdlUsers
            .Select(mdlUser =>
                new User
                {
                    UserId = mdlUser.Id,
                    Username = mdlUser.Username,
                    FullName = mdlUser.Lastname + " " + mdlUser.Firstname,
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
        var courcesToAdd = await _moodleDb.MdlCourses
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
        var quizzesToAdd = await _moodleDb.MdlQuizzes
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
        var qqToAdd = await _moodleDb.MdlQuizSlots
            .Select(q => new QuizQuestion
            {
                QuizId          = q.Quizid,
                QuestionId      = q.Questionid,
                Order           = q.Slot,
                PageNumber      = q.Page,
            })
            .ToListAsync(cancellationToken: cancellationToken);
        await _exportDb.BulkInsertAsync(qqToAdd, cancellationToken: cancellationToken);
        _logger.LogInformation("Exported {} quiz-questions", qqToAdd.Count);
    }

    private async Task ExportQuestions(CancellationToken cancellationToken)
    {
        var query =
            from q in _moodleDb.MdlQuestions
            join qc in _moodleDb.MdlQuestionCategories
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

    private async Task ExportQuizGrades(CancellationToken cancellationToken)
    {
        var query =
            from quizGrade in _moodleDb.MdlQuizGrades
            join user in _moodleDb.MdlUsers on quizGrade.Userid equals user.Id
            join quiz in _moodleDb.MdlQuizzes on quizGrade.Quiz equals quiz.Id
            select new QuizGrade
            {
                QuizId    = quizGrade.Quiz,
                UserId    = quizGrade.Userid,
                Grade     = quizGrade.Grade,
                UpdatedAt = DateTimeOffset.FromUnixTimeSeconds(quizGrade.Timemodified).UtcDateTime,
            };
        var gradesToAdd = await query.ToListAsync(cancellationToken: cancellationToken);
        await _exportDb.BulkInsertAsync(gradesToAdd, cancellationToken: cancellationToken);
        _logger.LogInformation("Exported {} quiz grades", gradesToAdd.Count);
    }

    private async Task ExportQuizAttempts(CancellationToken cancellationToken)
    {
        var query =
            from quizAttempt in _moodleDb.MdlQuizAttempts
            orderby quizAttempt.Quiz, quizAttempt.Userid, quizAttempt.Attempt
            join user in _moodleDb.MdlUsers on quizAttempt.Userid equals user.Id
            join quiz in _moodleDb.MdlQuizzes on quizAttempt.Quiz equals quiz.Id
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
            from quizAttempt in _moodleDb.MdlQuizAttempts
            join questionUsage in _moodleDb.MdlQuestionUsages
                on quizAttempt.Uniqueid equals questionUsage.Id
            join questionAttempt in _moodleDb.MdlQuestionAttempts
                on questionUsage.Id equals questionAttempt.Questionusageid
            join user in _moodleDb.MdlUsers on quizAttempt.Userid equals user.Id
            join quiz in _moodleDb.MdlQuizzes on quizAttempt.Quiz equals quiz.Id
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
        await foreach (var attemptChunk in query.AsChunkedAsyncEnumerable(PAGE_SIZE).WithCancellation(cancellationToken))
        {
            await _exportDb.BulkInsertAsync(attemptChunk, cancellationToken: cancellationToken);
            loadedCount += attemptChunk.Count;
            _logger.LogInformation("Exported {}/{} question attempts", loadedCount, totalCount);
        }
    }
    
    private async Task ExportQuestionAttemptSteps(CancellationToken cancellationToken)
    {
        var savedAttempsIds = await _exportDb.QuestionAttempts
            .OrderBy(x => x.QuestionAttemptId)
            .Select(x => x.QuestionAttemptId)
            .ToListAsync(cancellationToken: cancellationToken);

        var loadedCount = 0;
        foreach (var attemptsChunk in savedAttempsIds.Chunk(10000))
        {
            var query = 
                from questionAttempt in _moodleDb.MdlQuestionAttempts
                join question in _moodleDb.MdlQuestions
                    on questionAttempt.Questionid equals question.Id
                join questionAttemptStep in _moodleDb.MdlQuestionAttemptSteps
                    on questionAttempt.Id equals questionAttemptStep.Questionattemptid
                where attemptsChunk.Contains(questionAttempt.Id)
                select new
                {
                    QType                 = question.Qtype,
                    QBeh                  = questionAttempt.Behaviour,
                    QuestionAttemptStepId = questionAttemptStep.Id,
                    QuestionAttemptId     = questionAttemptStep.Questionattemptid,
                    Order                 = questionAttemptStep.Sequencenumber,
                    State                 = questionAttemptStep.State,
                    StateData             = _moodleDb.MdlQuestionAttemptStepData
                        .Where(z => z.Attemptstepid == questionAttemptStep.Id)
                        .Select(z => new { z.Name, z.Value })
                        .ToArray(),
                    CreatedAt             = DateTimeOffset.FromUnixTimeSeconds(questionAttemptStep.Timecreated).UtcDateTime,
                };
            var attemptsWithSteps = (await query.ToListAsync(cancellationToken: cancellationToken))
                .GroupBy(x => x.QuestionAttemptId)
                .Select(x => x.OrderBy(z => z.Order).ToList())
                .ToList();

            var valuesToAdd = new List<QuestionAttemptStep>();
            foreach (var attemptSteps in attemptsWithSteps)
            {
                int order = 0;
                
                foreach (var (attemptStep, nextAttemptSteps) in attemptSteps.WithRest())
                {
                    // первый стейт всегда 'todo', поэтому его пропускаем
                    // такэе пропускаем все отрицательные действия
                    if (attemptStep.Order <= 0)
                        continue;
                    
                    // особый странный кейс, который нужно пропуситить
                    if (attemptStep.State == "invalid")
                        continue;

                    if (attemptStep.State is "mangrright" or "mangrwrong" or "mangrpartial")
                        continue;
                    if (attemptStep.State is "gradedright" or "gradedwrong" or "gradedpartial")
                    {
                        var state = attemptStep.State switch
                        {
                            _ when nextAttemptSteps.Any(x => x.State == "mangrright") => QuestionAttemptStepState.GradedRight,
                            _ when nextAttemptSteps.Any(x => x.State == "mangrwrong") => QuestionAttemptStepState.GradedWrong,
                            _ when nextAttemptSteps.Any(x => x.State == "mangrpartial") => QuestionAttemptStepState.GradedPartial,
                            "gradedright" => QuestionAttemptStepState.GradedRight,
                            "gradedwrong" => QuestionAttemptStepState.GradedWrong,
                            "gradedpartial" => QuestionAttemptStepState.GradedPartial,
                            _ => throw new ArgumentOutOfRangeException(),
                        };
                        valuesToAdd.Add(new QuestionAttemptStep
                        {
                            QuestionAttemptStepId = attemptStep.QuestionAttemptStepId,
                            QuestionAttemptId = attemptStep.QuestionAttemptId,
                            Order = order++,
                            State = state,
                            CreatedAt = attemptStep.CreatedAt,
                        });
                        
                        continue;
                    }
                    
                    // gaveup добавялем если нашли состояние gaveup
                    if (attemptStep.State is "gaveup")
                    {
                        valuesToAdd.Add(new QuestionAttemptStep
                        {
                            QuestionAttemptStepId = attemptStep.QuestionAttemptStepId,
                            QuestionAttemptId = attemptStep.QuestionAttemptId,
                            Order = order++,
                            State = QuestionAttemptStepState.GaveUp,
                            CreatedAt = attemptStep.CreatedAt,
                        });
                        continue;
                    }
                    
                    // использована подсказка
                    if (attemptStep.StateData.Any(x => x.Name == "-_hashint" && x.Value == "1"))
                    {
                        var state = true switch
                        {
                            _ when attemptStep.StateData.Any(x => x.Name.StartsWith("-wherepic_") && x.Value == "1") => QuestionAttemptStepState.HintWherePic,
                            _ when attemptStep.StateData.Any(x => x.Name.StartsWith("-whatis_") && x.Value == "1") => QuestionAttemptStepState.HintWhatIs,
                            _ when attemptStep.StateData.Any(x => x.Name.StartsWith("-wheretxt_") && x.Value == "1") => QuestionAttemptStepState.HintWhereText,
                            _ when attemptStep.StateData.Any(x => x.Name.StartsWith("-hintnextlexembtn") && x.Value == "1") => QuestionAttemptStepState.HintNextLexem,
                            _ when attemptStep.StateData.Any(x => x.Name.StartsWith("-hintnextcharbtn") && x.Value == "1") => QuestionAttemptStepState.HintNextChar,
                            _ => throw new InvalidOperationException($"Wtf??? - {JsonSerializer.Serialize(attemptStep)}"),
                        };

                        valuesToAdd.Add(new QuestionAttemptStep
                        {
                            QuestionAttemptStepId = attemptStep.QuestionAttemptStepId,
                            QuestionAttemptId = attemptStep.QuestionAttemptId,
                            Order = order++,
                            State = state,
                            CreatedAt = attemptStep.CreatedAt,
                        });
                        continue;
                    }

                    // дан ответ
                    // не уверен, что тут учел все случаи. Конкретно тут учтены следующие:
                    // 1) когда одновременно есть -submit и -_try в стейте - в основном это встречается в адаптивных попытках
                    // 2) когда в стейте содержится только 'answer' и больше ничего, такое может встретиться во многих типах вопросов, не стал перечислять явно все виды
                    // 3) match и multianswer могут хранить свои ответы в полях вида sub\d и sub\d_answer, поэтому считаем ответами все шаги, содержащие в стейте только таки поля
                    // 4) multichoice хранит свои ответы в полях вида choice\d, поэтому считаем ответами все шаги, содержащие в стейте только таки поля
                    // 5) немного релаксируем правило (2) для correctwriting и preg, так как там answer может встретиться в окружении других полей. Возможно в будущем можно будет смержить с правилом (2), но пока не решился
                    if (attemptStep.State.IsActiveMdlAttemptStemp() && attemptStep.StateData.Any(x => x.Name is "-submit" && x.Value == "1") && attemptStep.StateData.Any(x => x.Name is "-_try")
                        || attemptStep.State.IsActiveMdlAttemptStemp() && attemptStep.StateData is [{ Name: "answer"}]
                        || attemptStep.State.IsActiveMdlAttemptStemp() && attemptStep.QType is "match" or "multianswer" && attemptStep.StateData.All(x => x.Name.StartsWith("sub"))
                        || attemptStep.State.IsActiveMdlAttemptStemp() && attemptStep.QType is "multichoice" && attemptStep.StateData.All(x => x.Name.StartsWith("choice"))
                        || attemptStep.State.IsActiveMdlAttemptStemp() && attemptStep.QType is "correctwriting" or "preg" && attemptStep.StateData.Any(x => x.Name is "answer")
                        )
                    {
                        // пытаемся опредить правильность ответа
                        var fraction = attemptStep.StateData.FirstOrDefault(x => x.Name == "-_rawfraction")?.Value is { } rawFrastionStr 
                                       && double.TryParse(rawFrastionStr, CultureInfo.InvariantCulture, out var rawFraction)
                                ? (decimal)rawFraction
                                : (decimal?)null;
                        var state = fraction switch
                        {
                            null => QuestionAttemptStepState.Answer,
                            1.0M => QuestionAttemptStepState.RightAnswer,
                            0.0M => QuestionAttemptStepState.WrongAnswer,
                            _ => QuestionAttemptStepState.PartialCorrectAnswer,
                        };
                        
                        // особый кейс для случая ответа перед gaveUp-оп. Мы пропускаем такой ответ, потому что он всегда пустой
                        if (state == QuestionAttemptStepState.Answer && nextAttemptSteps.FirstOrDefault() is { State: "gaveup" })
                            continue;
                        
                        // еще один особый кейс для preg и cw - генерируется какой-то странный неоцениваемый ответ на шаге 1 для адаптивных попыток
                        if (attemptStep.QType is "preg" or "correctwriting" && attemptStep.QBeh.StartsWith("adaptive") && attemptStep.Order == 1 
                            && attemptStep.StateData.Any(sd => sd.Name == "answer")
                            && nextAttemptSteps.Any(x => x.StateData.Any(sd => sd.Name == "answer" && !string.IsNullOrEmpty(sd.Value))))
                            continue;
                        
                        valuesToAdd.Add(new QuestionAttemptStep
                        {
                            QuestionAttemptStepId = attemptStep.QuestionAttemptStepId,
                            QuestionAttemptId = attemptStep.QuestionAttemptId,
                            Order = order++,
                            State = state,
                            CreatedAt = attemptStep.CreatedAt,
                        });
                        continue;
                    }

                    // этот кейс чисто выступает маркером того, что мы упустили обработать какое-то состояние
                    valuesToAdd.Add(new QuestionAttemptStep
                    {
                        QuestionAttemptStepId = attemptStep.QuestionAttemptStepId,
                        QuestionAttemptId = attemptStep.QuestionAttemptId,
                        Order = order++,
                        State = QuestionAttemptStepState.Undefined,
                        CreatedAt = attemptStep.CreatedAt,
                    });
                }
            }
            
            await _exportDb.BulkInsertAsync(valuesToAdd, cancellationToken: cancellationToken);
            loadedCount += attemptsChunk.Length;
            _logger.LogInformation("Exported {}/{} question attempt steps", loadedCount, savedAttempsIds.Count);
        }
        
        
        // валидация на отсутвие состояния Undefined
        var undefinedStatements = await _exportDb.QuestionAttemptSteps.AsNoTracking()
            .Where(x => x.State == QuestionAttemptStepState.Undefined)
            .ToListAsync(cancellationToken: cancellationToken);
        foreach (var undefinedStatement in undefinedStatements)
        {
            _logger.LogWarning("Undefined attempt step: {}", JsonSerializer.Serialize(undefinedStatement));
        }
        /*
        await _exportDb.QuestionAttemptSteps
            .Where(x => x.State == QuestionAttemptStepState.Undefined)
            .ExecuteDeleteAsync(cancellationToken: cancellationToken);
        */
    }

    private async Task ExportExamGrades(CancellationToken cancellationToken)
    {
        var examData = Parsers.ParseCsvWithTotalTable(@"C:\Users\Administrator\Downloads\full_table.csv")
            .GroupBy(x => x.FullName.Split(' ').First().Replace('ё', 'е').Trim())
            .ToDictionary(x => x.Key, x => x.ToList(), new FirstWordComparer());
        var exportedUsers = await _exportDb.Users
            .Select(x => new { x.UserId, x.FullName })
            .ToListAsync(cancellationToken: cancellationToken);

        var dataToAdd = new List<ExamGrade>();
        foreach (var user in exportedUsers)
        {
            var examUserData = examData.GetValueOrDefault(user.FullName);
            if (examUserData is null or { Count: 0 })
                continue;

            if (examUserData.Count > 1)
            {
                
            }

            dataToAdd.Add(new ExamGrade
            {
                UserId = user.UserId,
                RawNormalizedGrade = 0,
            });
        }
    }
}


/// <summary>
/// Компаратор, сравнивающий строки только по первому слову
/// </summary>
public class FirstWordComparer : IEqualityComparer<string>
{
    public bool Equals(string? x, string? y)
    {
        if (x == null && y == null)
            return true;
        if (x == null || y == null)
            return false;

        // сначала проверям по совпадении с фамилией, которая идет первой
        var xSpan = x.IndexOf(' ') is var xIdx && xIdx != -1
            ? x.AsSpan(0, xIdx)
            : x.AsSpan();
        var ySpan = y.IndexOf(' ') is var yIdx && yIdx != -1
            ? y.AsSpan(0, yIdx)
            : y.AsSpan();
        if (xSpan.Length != ySpan.Length)
            return false;
        for(var i = 0; i < xSpan.Length; ++i)
        {
            var (xi, yi) = (xSpan[i], ySpan[i]);
            
            if (xi != yi && !(xi is 'е' or 'ё' && yi is 'е' or 'ё'))
                return false;
        }
        
        return true;
    }
    
    public int GetHashCode(string obj)
    {
        // расчитываем хэш чисто по фамилии, игнорируем букву 'ё'
        var span = obj.IndexOf(' ') is var xIdx && xIdx != -1
            ? obj.AsSpan(0, xIdx)
            : obj.AsSpan();
        unchecked
        {
            int hash1 = 5381;
            int hash2 = hash1;

            for (int i = 0; i < span.Length && span[i] != '\0'; i += 2)
            {
                var spani = char.ToLower(span[i]);
                if (spani == 'ё')
                    spani = 'е';
                
                hash1 = ((hash1 << 5) + hash1) ^ spani;
                if (i == span.Length - 1 || span[i + 1] == '\0')
                    break;
                var spani1 = char.ToLower(span[i + 1]);
                if (spani1 == 'ё')
                    spani1 = 'е';
                hash2 = ((hash2 << 5) + hash2) ^ spani1;
            }

            return hash1 + (hash2 * 1566083941);
        }
    }
    
}

public class FuzzyFullNameComparer : IEqualityComparer<string>
{
    public bool Equals(string? x, string? y)
    {
        if (x == null && y == null)
            return true;
        if (x == null || y == null)
            return false;

        // сначала проверям по совпадении с фамилией, которая идет первой
        var xSpan = x.IndexOf(' ') is var xIdx && xIdx != -1
            ? x.AsSpan(0, xIdx)
            : x.AsSpan();
        var ySpan = y.IndexOf(' ') is var yIdx && yIdx != -1
            ? y.AsSpan(0, yIdx)
            : y.AsSpan();
        if (xSpan.Length != ySpan.Length)
            return false;
        for(var i = 0; i < xSpan.Length; ++i)
        {
            var (xi, yi) = (xSpan[i], ySpan[i]);
            
            if (xi != yi && !(xi is 'е' or 'ё' && yi is 'е' or 'ё'))
                return false;
        }
        
        // фамилии совпали = проверяем по нечеткому сравнению
        return Fuzz.PartialRatio(x, y) > 97;
    }

    public int GetHashCode(string obj)
    {
        // расчитываем хэш чисто по фамилии, игнорируем букву 'ё'
        var span = obj.IndexOf(' ') is var xIdx && xIdx != -1
            ? obj.AsSpan(0, xIdx)
            : obj.AsSpan();
        unchecked
        {
            int hash1 = 5381;
            int hash2 = hash1;

            for (int i = 0; i < span.Length && span[i] != '\0'; i += 2)
            {
                var spani = char.ToLower(span[i]);
                if (spani == 'ё')
                    spani = 'е';
                
                hash1 = ((hash1 << 5) + hash1) ^ spani;
                if (i == span.Length - 1 || span[i + 1] == '\0')
                    break;
                var spani1 = char.ToLower(span[i + 1]);
                if (spani1 == 'ё')
                    spani1 = 'е';
                hash2 = ((hash2 << 5) + hash2) ^ spani1;
            }

            return hash1 + (hash2 * 1566083941);
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

    public static IEnumerable<ValueTuple<T, T?>> WithNextElem<T>(this IList<T> source)
        where T : class
    {
        return source.Select((x, i) => ValueTuple.Create(x, i < source.Count - 1 ? source[i + 1] : null));
    }

    public static IEnumerable<ValueTuple<T, IReadOnlyList<T>>> WithRest<T>(this IReadOnlyList<T> source)
        where T : class
    {
        return source.Select((x, i) => ValueTuple.Create(x, (IReadOnlyList<T>)new ReadOnlyListSlice<T>(source, i + 1)));
    }

    public static bool IsActiveMdlAttemptStemp(this string s) => s is "todo" or "invalid" or "complete";
}
