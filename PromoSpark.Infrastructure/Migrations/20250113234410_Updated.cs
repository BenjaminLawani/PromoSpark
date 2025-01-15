using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PromoSpark.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Updated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: new Guid("83ac48a8-e7c5-41de-b6a3-f0029f34dfa6"));

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: new Guid("f57a28bf-a632-42b6-a843-948804d2c73b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("79f30a2d-c7c0-4d00-aa05-b5d7ee235f98"));

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: new Guid("f973e27d-dc09-492e-a0cb-32a9c3abc2e2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("abcdabf7-a9bb-4531-8c58-188f258c3146"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f3b75726-55c8-45ee-b5dc-8fa99485579b"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "Email", "FullName", "IsEmailVerified", "PasswordHash", "PayoutAccountNumber", "Role", "SocialMediaLinks", "UpdatedAt", "WalletBalance" },
                values: new object[,]
                {
                    { new Guid("175a0cdd-425e-4098-9fce-b99b408471e7"), null, new DateTime(2025, 1, 13, 23, 44, 8, 594, DateTimeKind.Utc).AddTicks(8250), "participant@example.com", "John Doe", true, "hashedpassword1", null, 1, null, null, 0m },
                    { new Guid("26fda9be-7ccb-4c38-a720-ef0ed9320c3f"), null, new DateTime(2025, 1, 13, 23, 44, 8, 594, DateTimeKind.Utc).AddTicks(9328), "admin@example.com", "Admin User", true, "hashedpassword3", null, 3, null, null, 0m },
                    { new Guid("e5d4549f-0607-4716-9818-e6c6a6bb33a0"), null, new DateTime(2025, 1, 13, 23, 44, 8, 594, DateTimeKind.Utc).AddTicks(9320), "creative@example.com", "Jane Smith", true, "hashedpassword2", null, 2, null, null, 100.50m }
                });

            migrationBuilder.InsertData(
                table: "Challenges",
                columns: new[] { "Id", "AllowedPlatforms", "CreatedAt", "CreativeId", "Deadline", "Description", "NumberOfWinners", "RewardPool", "SongUrl", "Status", "Title", "UpdatedAt" },
                values: new object[] { new Guid("0b096b84-0f1b-4f20-9c31-0e0c60acb2a4"), new[] { 2, 1 }, new DateTime(2025, 1, 13, 23, 44, 8, 597, DateTimeKind.Utc).AddTicks(7467), new Guid("e5d4549f-0607-4716-9818-e6c6a6bb33a0"), new DateTime(2025, 1, 23, 23, 44, 8, 596, DateTimeKind.Utc).AddTicks(8031), "Submit your best dance video to win!", 3, 1000m, "https://example.com/song1", 2, "Dance Challenge 2025", null });

            migrationBuilder.InsertData(
                table: "Submissions",
                columns: new[] { "Id", "Caption", "ChallengeId", "CreatedAt", "IsVerified", "ParticipantId", "Platform", "PlatformPostUrl", "Rank", "RewardAmount", "UpdatedAt", "VideoUrl" },
                values: new object[,]
                {
                    { new Guid("0d03a999-f26b-47eb-ac93-f3072e501c2b"), "Another submission!", new Guid("0b096b84-0f1b-4f20-9c31-0e0c60acb2a4"), new DateTime(2025, 1, 13, 23, 44, 8, 598, DateTimeKind.Utc).AddTicks(6996), false, new Guid("175a0cdd-425e-4098-9fce-b99b408471e7"), 1, "https://instagram.com/post2", null, null, null, "https://example.com/video2" },
                    { new Guid("d40cb34c-92b5-4a77-8750-bc10cb661b5d"), "My best dance moves!", new Guid("0b096b84-0f1b-4f20-9c31-0e0c60acb2a4"), new DateTime(2025, 1, 13, 23, 44, 8, 598, DateTimeKind.Utc).AddTicks(6276), true, new Guid("175a0cdd-425e-4098-9fce-b99b408471e7"), 2, "https://tiktok.com/post1", null, null, null, "https://example.com/video1" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: new Guid("0d03a999-f26b-47eb-ac93-f3072e501c2b"));

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: new Guid("d40cb34c-92b5-4a77-8750-bc10cb661b5d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("26fda9be-7ccb-4c38-a720-ef0ed9320c3f"));

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: new Guid("0b096b84-0f1b-4f20-9c31-0e0c60acb2a4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("175a0cdd-425e-4098-9fce-b99b408471e7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e5d4549f-0607-4716-9818-e6c6a6bb33a0"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "Email", "FullName", "IsEmailVerified", "PasswordHash", "PayoutAccountNumber", "Role", "SocialMediaLinks", "UpdatedAt", "WalletBalance" },
                values: new object[,]
                {
                    { new Guid("79f30a2d-c7c0-4d00-aa05-b5d7ee235f98"), null, new DateTime(2025, 1, 13, 23, 30, 59, 564, DateTimeKind.Utc).AddTicks(6392), "admin@example.com", "Admin User", true, "hashedpassword3", null, 3, null, null, 0m },
                    { new Guid("abcdabf7-a9bb-4531-8c58-188f258c3146"), null, new DateTime(2025, 1, 13, 23, 30, 59, 564, DateTimeKind.Utc).AddTicks(5372), "participant@example.com", "John Doe", true, "hashedpassword1", null, 1, null, null, 0m },
                    { new Guid("f3b75726-55c8-45ee-b5dc-8fa99485579b"), null, new DateTime(2025, 1, 13, 23, 30, 59, 564, DateTimeKind.Utc).AddTicks(6385), "creative@example.com", "Jane Smith", true, "hashedpassword2", null, 2, null, null, 100.50m }
                });

            migrationBuilder.InsertData(
                table: "Challenges",
                columns: new[] { "Id", "AllowedPlatforms", "CreatedAt", "CreativeId", "Deadline", "Description", "NumberOfWinners", "RewardPool", "SongUrl", "Status", "Title", "UpdatedAt" },
                values: new object[] { new Guid("f973e27d-dc09-492e-a0cb-32a9c3abc2e2"), new[] { 2, 1 }, new DateTime(2025, 1, 13, 23, 30, 59, 567, DateTimeKind.Utc).AddTicks(4284), new Guid("f3b75726-55c8-45ee-b5dc-8fa99485579b"), new DateTime(2025, 1, 23, 23, 30, 59, 566, DateTimeKind.Utc).AddTicks(4747), "Submit your best dance video to win!", 3, 1000m, "https://example.com/song1", 2, "Dance Challenge 2025", null });

            migrationBuilder.InsertData(
                table: "Submissions",
                columns: new[] { "Id", "Caption", "ChallengeId", "CreatedAt", "IsVerified", "ParticipantId", "Platform", "PlatformPostUrl", "Rank", "RewardAmount", "UpdatedAt", "VideoUrl" },
                values: new object[,]
                {
                    { new Guid("83ac48a8-e7c5-41de-b6a3-f0029f34dfa6"), "Another submission!", new Guid("f973e27d-dc09-492e-a0cb-32a9c3abc2e2"), new DateTime(2025, 1, 13, 23, 30, 59, 568, DateTimeKind.Utc).AddTicks(3677), false, new Guid("abcdabf7-a9bb-4531-8c58-188f258c3146"), 1, "https://instagram.com/post2", null, null, null, "https://example.com/video2" },
                    { new Guid("f57a28bf-a632-42b6-a843-948804d2c73b"), "My best dance moves!", new Guid("f973e27d-dc09-492e-a0cb-32a9c3abc2e2"), new DateTime(2025, 1, 13, 23, 30, 59, 568, DateTimeKind.Utc).AddTicks(3009), true, new Guid("abcdabf7-a9bb-4531-8c58-188f258c3146"), 2, "https://tiktok.com/post1", null, null, null, "https://example.com/video1" }
                });
        }
    }
}
