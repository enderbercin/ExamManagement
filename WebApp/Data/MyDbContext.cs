using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApp.Data.Domain;
namespace WebApp.Data
{
    public class MyDbContext : IdentityDbContext<User>
    {
        public DbSet<ExamCategory> ExamCategories { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<QuestionCategory> QuestionCategories { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<QuestionOption> QuestionOptions { get; set; }
        public DbSet<UserExam> UserExams { get; set; }
        public DbSet<UserExamAnswer> UserExamAnswers { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            string sqlConnectionString = "Data Source=DESKTOP-HB0P8D7\\SQLEXPRESS;Database=ExamManagement;Integrated Security=True;MultipleActiveResultSets=true;";

            optionsBuilder.UseLazyLoadingProxies();

            optionsBuilder.UseSqlServer(sqlConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
