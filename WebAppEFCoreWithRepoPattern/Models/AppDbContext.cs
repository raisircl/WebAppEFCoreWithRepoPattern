using Microsoft.EntityFrameworkCore;

namespace WebAppEFCoreWithRepoPattern.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            //modelBuilder.Entity<Student>().Property(s=>s.PhNo).HasMaxLength(13);
            modelBuilder.Entity<Student>().HasIndex(s=>s.PhNo).IsUnique();
            modelBuilder.Entity<Student>()
                .HasOne(s => s.Course)
                .WithMany(c => c.Students)
                .HasForeignKey(s => s.CourseId)
                .OnDelete(DeleteBehavior.Restrict);

        }

    }
}
