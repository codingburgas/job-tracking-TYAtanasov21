using JobTracking.DataAccess.Data.Base;
using Microsoft.EntityFrameworkCore;

namespace JobTracking.DataAccess;
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}
        public DbSet<Job> Jobs { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<JobRecommendation> JobRecommendations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<JobRecommendation>()
                .HasOne(jr => jr.User)
                .WithMany(u => u.JobRecommendations)
                .HasForeignKey(jr => jr.UserId);

            modelBuilder.Entity<JobRecommendation>()
                .HasOne(jr => jr.Job)
                .WithMany(j => j.JobRecommendations)
                .HasForeignKey(jr => jr.JobId);
        }
    }