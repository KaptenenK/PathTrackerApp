using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Diagnostics;
using Microsoft.EntityFrameworkCore;
using PathTracker.Models;

namespace PathTracker.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Course> courses { get; set; }
        public DbSet<CoursePath> CoursePaths { get; set; }
        public DbSet<UserTimeSpent> UserTimeSpendings { get; set;}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<UserTimeSpent>(opt =>
            {
                opt.HasKey(a => new {a.CourseId, a.UserId});

                opt.HasOne(bc => bc.Course)
                .WithMany(b=>b.UserTimeSpendings)
                .HasForeignKey(bc => bc.CourseId)
                .OnDelete(DeleteBehavior.Cascade);

                opt.HasOne(bc => bc.User)
                .WithMany(b => b.UserTimeSpendings)
                .HasForeignKey(bc => bc.UserId)
                .OnDelete(DeleteBehavior.Cascade);
            });
        }
    }
}