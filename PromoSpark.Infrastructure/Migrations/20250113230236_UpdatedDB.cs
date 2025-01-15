using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PromoSpark.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: new Guid("52401446-0c9d-444e-8898-bbe23d0a0c00"));

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: new Guid("f29e34f0-67ed-4e45-a8f7-b14cd9048cb4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("da1a9c9d-efb2-44dc-b05e-2d3ec5694e7a"));

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: new Guid("f3ea0403-b43f-40da-8019-448322ec451f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9035a7c6-1f1d-46a6-8575-794ee89244fa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f940797a-3b54-4230-93b3-31ddd02bbcc9"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("9035a7c6-1f1d-46a6-8575-794ee89244fa"), null, new DateTime(2025, 1, 13, 22, 40, 33, 433, DateTimeKind.Utc).AddTicks(7606), "participant@example.com", "John Doe", true, "hashedpassword1", null, 1, null, null, 0m },
                    { new Guid("da1a9c9d-efb2-44dc-b05e-2d3ec5694e7a"), null, new DateTime(2025, 1, 13, 22, 40, 33, 433, DateTimeKind.Utc).AddTicks(8605), "admin@example.com", "Admin User", true, "hashedpassword3", null, 3, null, null, 0m },
                    { new Guid("f940797a-3b54-4230-93b3-31ddd02bbcc9"), null, new DateTime(2025, 1, 13, 22, 40, 33, 433, DateTimeKind.Utc).AddTicks(8598), "creative@example.com", "Jane Smith", true, "hashedpassword2", null, 2, null, null, 100.50m }
                });

            migrationBuilder.InsertData(
                table: "Challenges",
                columns: new[] { "Id", "AllowedPlatforms", "CreatedAt", "CreativeId", "Deadline", "Description", "NumberOfWinners", "RewardPool", "SongUrl", "Status", "Title", "UpdatedAt" },
                values: new object[] { new Guid("f3ea0403-b43f-40da-8019-448322ec451f"), new[] { 2, 1 }, new DateTime(2025, 1, 13, 22, 40, 33, 436, DateTimeKind.Utc).AddTicks(5446), new Guid("f940797a-3b54-4230-93b3-31ddd02bbcc9"), new DateTime(2025, 1, 23, 22, 40, 33, 435, DateTimeKind.Utc).AddTicks(6430), "Submit your best dance video to win!", 3, 1000m, "https://example.com/song1", 2, "Dance Challenge 2025", null });

            migrationBuilder.InsertData(
                table: "Submissions",
                columns: new[] { "Id", "Caption", "ChallengeId", "CreatedAt", "IsVerified", "ParticipantId", "Platform", "PlatformPostUrl", "Rank", "RewardAmount", "UpdatedAt", "VideoUrl" },
                values: new object[,]
                {
                    { new Guid("52401446-0c9d-444e-8898-bbe23d0a0c00"), "My best dance moves!", new Guid("f3ea0403-b43f-40da-8019-448322ec451f"), new DateTime(2025, 1, 13, 22, 40, 33, 437, DateTimeKind.Utc).AddTicks(3641), true, new Guid("9035a7c6-1f1d-46a6-8575-794ee89244fa"), 2, "https://tiktok.com/post1", null, null, null, "https://example.com/video1" },
                    { new Guid("f29e34f0-67ed-4e45-a8f7-b14cd9048cb4"), "Another submission!", new Guid("f3ea0403-b43f-40da-8019-448322ec451f"), new DateTime(2025, 1, 13, 22, 40, 33, 437, DateTimeKind.Utc).AddTicks(4453), false, new Guid("9035a7c6-1f1d-46a6-8575-794ee89244fa"), 1, "https://instagram.com/post2", null, null, null, "https://example.com/video2" }
                });
        }
    }
}
