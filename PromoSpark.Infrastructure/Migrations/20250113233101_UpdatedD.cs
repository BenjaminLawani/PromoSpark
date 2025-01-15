using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PromoSpark.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedD : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: new Guid("56f2ffc5-7826-4816-8e38-b7b76f0b41d9"));

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: new Guid("6024f119-4f1e-49b6-9344-f0efbf5976c2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4e1b7d4c-33b6-47d2-b36b-95434a9d3e67"));

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: new Guid("1a271f15-41c5-4c70-849b-c19aa2e02e4e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8cb79fa2-df52-4c32-8ea0-d8179164d7f2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("022dab84-9b44-42c6-8bec-ee870fd2e7f8"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("022dab84-9b44-42c6-8bec-ee870fd2e7f8"), null, new DateTime(2025, 1, 13, 23, 2, 34, 678, DateTimeKind.Utc).AddTicks(9845), "creative@example.com", "Jane Smith", true, "hashedpassword2", null, 2, null, null, 100.50m },
                    { new Guid("4e1b7d4c-33b6-47d2-b36b-95434a9d3e67"), null, new DateTime(2025, 1, 13, 23, 2, 34, 678, DateTimeKind.Utc).AddTicks(9851), "admin@example.com", "Admin User", true, "hashedpassword3", null, 3, null, null, 0m },
                    { new Guid("8cb79fa2-df52-4c32-8ea0-d8179164d7f2"), null, new DateTime(2025, 1, 13, 23, 2, 34, 678, DateTimeKind.Utc).AddTicks(8809), "participant@example.com", "John Doe", true, "hashedpassword1", null, 1, null, null, 0m }
                });

            migrationBuilder.InsertData(
                table: "Challenges",
                columns: new[] { "Id", "AllowedPlatforms", "CreatedAt", "CreativeId", "Deadline", "Description", "NumberOfWinners", "RewardPool", "SongUrl", "Status", "Title", "UpdatedAt" },
                values: new object[] { new Guid("1a271f15-41c5-4c70-849b-c19aa2e02e4e"), new[] { 2, 1 }, new DateTime(2025, 1, 13, 23, 2, 34, 681, DateTimeKind.Utc).AddTicks(6650), new Guid("022dab84-9b44-42c6-8bec-ee870fd2e7f8"), new DateTime(2025, 1, 23, 23, 2, 34, 680, DateTimeKind.Utc).AddTicks(7635), "Submit your best dance video to win!", 3, 1000m, "https://example.com/song1", 2, "Dance Challenge 2025", null });

            migrationBuilder.InsertData(
                table: "Submissions",
                columns: new[] { "Id", "Caption", "ChallengeId", "CreatedAt", "IsVerified", "ParticipantId", "Platform", "PlatformPostUrl", "Rank", "RewardAmount", "UpdatedAt", "VideoUrl" },
                values: new object[,]
                {
                    { new Guid("56f2ffc5-7826-4816-8e38-b7b76f0b41d9"), "Another submission!", new Guid("1a271f15-41c5-4c70-849b-c19aa2e02e4e"), new DateTime(2025, 1, 13, 23, 2, 34, 682, DateTimeKind.Utc).AddTicks(5647), false, new Guid("8cb79fa2-df52-4c32-8ea0-d8179164d7f2"), 1, "https://instagram.com/post2", null, null, null, "https://example.com/video2" },
                    { new Guid("6024f119-4f1e-49b6-9344-f0efbf5976c2"), "My best dance moves!", new Guid("1a271f15-41c5-4c70-849b-c19aa2e02e4e"), new DateTime(2025, 1, 13, 23, 2, 34, 682, DateTimeKind.Utc).AddTicks(4976), true, new Guid("8cb79fa2-df52-4c32-8ea0-d8179164d7f2"), 2, "https://tiktok.com/post1", null, null, null, "https://example.com/video1" }
                });
        }
    }
}
