using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using MoodleDbSimplificator.ExportDb.Entities;
using MoodleDbSimplificator.ExportDb.Entities.Enums;
using System.Text.Json;

namespace MoodleDbSimplificator.ExportDb;

public class ExportDbContext : DbContext
{
    public ExportDbContext(DbContextOptions<ExportDbContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users { get; set; } = null!;
    public DbSet<Course> Courses { get; set; } = null!;
    public DbSet<Quiz> Quizzes { get; set; } = null!;
    public DbSet<QuizGrade> QuizGrades { get; set; } = null!;
    public DbSet<QuizQuestion> QuizQuestions { get; set; } = null!;
    public DbSet<QuizAttempt> QuizAttempts { get; set; } = null!;
    public DbSet<Question> Questions { get; set; } = null!;
    public DbSet<QuestionAttempt> QuestionAttempts { get; set; } = null!;
    public DbSet<QuestionAttemptStep> QuestionAttemptSteps { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSnakeCaseNamingConvention();
    }

    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {
        configurationBuilder
            .Properties<QuestionBehaviour>()
            .HaveConversion<string>();
        configurationBuilder
            .Properties<QuizGradeMethod>()
            .HaveConversion<string>();
        configurationBuilder
            .Properties<QuizAttemptState>()
            .HaveConversion<string>();
        configurationBuilder
            .Properties<QuestionAttemptStepState>()
            .HaveConversion<string>();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(user =>
        {
            user.HasKey(x => x.UserId);
        });
        
        modelBuilder.Entity<Course>(user =>
        {
            user.HasKey(x => x.CourseId);
        });
        
        modelBuilder.Entity<Quiz>(quiz =>
        {
            quiz.HasKey(x => x.QuizId);

            quiz.HasOne(x => x.Course)
                .WithMany()
                .HasForeignKey(x => x.CourceId);
        });
        
        modelBuilder.Entity<Question>(question =>
        {
            question.HasKey(x => x.QuestionId);
        });

        modelBuilder.Entity<QuestionAttempt>(qa =>
        {
            qa.HasKey(x => x.QuestionAttemptId);
            
            qa.HasOne(x => x.Question)
                .WithMany()
                .HasForeignKey(x => x.QuestionId);
            
            qa.HasOne(x => x.QuizAttempt)
                .WithMany(x => x.QuestionAttempts)
                .HasForeignKey(x => x.QuizAttemptId);
        });
        
        modelBuilder.Entity<QuestionAttemptStep>(qas =>
        {
            qas.HasKey(x => x.QuestionAttemptStepId);
            
            qas.HasOne(x => x.QuestionAttempt)
                .WithMany(x => x.Steps)
                .HasForeignKey(x => x.QuestionAttemptId);
            
            /*
            qas.Property(x => x.RawStateData)
                .HasColumnType("json");
            qas.Property(x => x.RawStateData)
                .HasConversion(
                    v => JsonSerializer.Serialize(v, JsonSerializerOptions.Default),
                    v => JsonSerializer.Deserialize<Dictionary<string, string>>(v, JsonSerializerOptions.Default));
            */
        });
        
        modelBuilder.Entity<QuizGrade>(qg =>
        {
            qg.HasKey(x => new { x.QuizId, x.UserId });

            qg.HasOne(x => x.Quiz)
                .WithMany(x => x.Grades)
                .HasForeignKey(x => x.QuizId);
            
            qg.HasOne(x => x.User)
                .WithMany()
                .HasForeignKey(x => x.UserId);
        });
        
        modelBuilder.Entity<QuizQuestion>(qq =>
        {
            qq.HasKey(x => new { x.QuizId, x.QuestionId });

            qq.HasOne(x => x.Quiz)
                .WithMany(x => x.Questions)
                .HasForeignKey(x => x.QuizId);
            
            qq.HasOne(x => x.Question)
                .WithMany()
                .HasForeignKey(x => x.QuestionId);
        });
        
        modelBuilder.Entity<QuizAttempt>(qa =>
        {
            qa.HasKey(x => x.QuizAttemptId);

            qa.HasOne(x => x.Quiz)
                .WithMany(x => x.Attempts)
                .HasForeignKey(x => x.QuizId);
            
            qa.HasOne(x => x.User)
                .WithMany()
                .HasForeignKey(x => x.UserId);
        });
    }
}
