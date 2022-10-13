using Microsoft.EntityFrameworkCore;
using RusLabTest.Models;

namespace RusLabTest
{
    public partial class RusLabDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public RusLabDbContext() { }

        public RusLabDbContext(DbContextOptions<RusLabDbContext> options)
            : base(options) { }
        
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseReview> CourseReviews { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Server=localhost;Database=RusLabDb;Trusted_Connection=True;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>()
                .HasKey(k => k.Id);
            modelBuilder.Entity<CourseReview>()
                .HasKey(k => k.Id);
            modelBuilder.Entity<Student>()
                .HasKey(k => k.Id);

            modelBuilder.Entity<Course>()
                .HasMany(v => v.CourseReviews)
                .WithOne(c => c.Course)
                .OnDelete(DeleteBehavior.Cascade);
 
            modelBuilder.Entity<Course>()
                .HasMany(s => s.Students)
                .WithOne(c => c.Course);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}


