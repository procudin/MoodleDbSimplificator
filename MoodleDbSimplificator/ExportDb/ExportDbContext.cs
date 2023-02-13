using Microsoft.EntityFrameworkCore;
using MoodleDbSimplificator.ExportDb.Entities;

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
    public DbSet<QuizQuestion> QuizQuestions { get; set; } = null!;
    public DbSet<QuizAttempt> QuizAttempts { get; set; } = null!;
    public DbSet<Question> Questions { get; set; } = null!;

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
                .WithMany()
                .HasForeignKey(x => x.QuizId);
            
            qa.HasOne(x => x.User)
                .WithMany()
                .HasForeignKey(x => x.UserId);
        });
    }
}
