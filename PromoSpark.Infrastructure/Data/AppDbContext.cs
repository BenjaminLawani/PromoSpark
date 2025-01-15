using Microsoft.EntityFrameworkCore;
using PromoSpark.Domain.Entities;

namespace PromoSpark.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Challenge> Challenges { get; set; }
        public DbSet<Submission> Submissions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();

         

            modelBuilder.Entity<Challenge>()
                .HasOne(c => c.Creative)
                .WithMany()
                .HasForeignKey(c => c.CreativeId);

            modelBuilder.Entity<Submission>()
                .HasOne(s => s.Challenge)
                .WithMany(c => c.Submissions)
                .HasForeignKey(s => s.ChallengeId);

            modelBuilder.Entity<Submission>()
                .HasOne(s => s.Participant)
                .WithMany()
                .HasForeignKey(s => s.ParticipantId);

            //SeedData.Seed(modelBuilder);
        }
    }

}
