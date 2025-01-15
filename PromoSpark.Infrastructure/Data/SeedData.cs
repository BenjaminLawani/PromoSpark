using Microsoft.EntityFrameworkCore;
using PromoSpark.Domain.Entities;
using PromoSpark.Domain.Common.Enums;
public static class SeedData
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        // Seed Users
        var users = new List<User>
        {
            new User
            {
                Id = Guid.NewGuid(),
                Email = "participant@example.com",
                FullName = "John Doe",
                PasswordHash = "hashedpassword1",
                Role = RoleEnum.Participant,
                WalletBalance = 0,
                IsEmailVerified = true,
                CreatedAt = DateTime.UtcNow
            },
            new User
            {
                Id = Guid.NewGuid(),
                Email = "creative@example.com",
                FullName = "Jane Smith",
                PasswordHash = "hashedpassword2",
                Role = RoleEnum.Creative,
                WalletBalance = 100.50m,
                IsEmailVerified = true,
                CreatedAt = DateTime.UtcNow
            },
            new User
            {
                Id = Guid.NewGuid(),
                Email = "admin@example.com",
                FullName = "Admin User",
                PasswordHash = "hashedpassword3",
                Role = RoleEnum.Admin,
                WalletBalance = 0,
                IsEmailVerified = true,
                CreatedAt = DateTime.UtcNow
            }
        };

        modelBuilder.Entity<User>().HasData(users);

        // Seed Challenges
        var challenges = new List<Challenge>
        {
            new Challenge
            {
                Id = Guid.NewGuid(),
                CreativeId = users[1].Id,
                Title = "Dance Challenge 2025",
                Description = "Submit your best dance video to win!",
                SongUrl = "https://example.com/song1",
                RewardPool = 1000m,
                NumberOfWinners = 3,
                Deadline = DateTime.UtcNow.AddDays(10),
                AllowedPlatforms = new List<PlatformEnum> { PlatformEnum.TikTok, PlatformEnum.Instagram },
                Status = StatusEnum.Active,
                CreatedAt = DateTime.UtcNow
            }
        };

        modelBuilder.Entity<Challenge>().HasData(challenges);

        // Seed Submissions
        var submissions = new List<Submission>
        {
            new Submission
            {
                Id = Guid.NewGuid(),
                ChallengeId = challenges[0].Id,
                ParticipantId = users[0].Id,
                VideoUrl = "https://example.com/video1",
                Caption = "My best dance moves!",
                Platform = PlatformEnum.TikTok,
                PlatformPostUrl = "https://tiktok.com/post1",
                IsVerified = true,
                CreatedAt = DateTime.UtcNow
            },
            new Submission
            {
                Id = Guid.NewGuid(),
                ChallengeId = challenges[0].Id,
                ParticipantId = users[0].Id,
                VideoUrl = "https://example.com/video2",
                Caption = "Another submission!",
                Platform = PlatformEnum.Instagram,
                PlatformPostUrl = "https://instagram.com/post2",
                IsVerified = false,
                CreatedAt = DateTime.UtcNow
            }
        };

        modelBuilder.Entity<Submission>().HasData(submissions);
    }
}
