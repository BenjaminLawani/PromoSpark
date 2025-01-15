using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PromoSpark.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ChangeForm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("5b9af0fc-06b7-469d-be7f-79054f30a6ca"), null, new DateTime(2025, 1, 13, 23, 58, 21, 268, DateTimeKind.Utc).AddTicks(117), "creative@example.com", "Jane Smith", true, "hashedpassword2", null, 2, null, null, 100.50m },
                    { new Guid("bd17505f-9f00-412a-afba-7afd75853dfa"), null, new DateTime(2025, 1, 13, 23, 58, 21, 267, DateTimeKind.Utc).AddTicks(9344), "participant@example.com", "John Doe", true, "hashedpassword1", null, 1, null, null, 0m },
                    { new Guid("ee01a14e-6421-4290-ac28-b6e34552d511"), null, new DateTime(2025, 1, 13, 23, 58, 21, 268, DateTimeKind.Utc).AddTicks(123), "admin@example.com", "Admin User", true, "hashedpassword3", null, 3, null, null, 0m }
                });

            migrationBuilder.InsertData(
                table: "Challenges",
                columns: new[] { "Id", "AllowedPlatforms", "CreatedAt", "CreativeId", "Deadline", "Description", "NumberOfWinners", "RewardPool", "SongUrl", "Status", "Title", "UpdatedAt" },
                values: new object[] { new Guid("300ff83f-acaa-4a76-be7e-058609f97757"), new List<int> { 2, 1 }, new DateTime(2025, 1, 13, 23, 58, 21, 270, DateTimeKind.Utc).AddTicks(8244), new Guid("5b9af0fc-06b7-469d-be7f-79054f30a6ca"), new DateTime(2025, 1, 23, 23, 58, 21, 269, DateTimeKind.Utc).AddTicks(9075), "Submit your best dance video to win!", 3, 1000m, "https://example.com/song1", 2, "Dance Challenge 2025", null });

            migrationBuilder.InsertData(
                table: "Submissions",
                columns: new[] { "Id", "Caption", "ChallengeId", "CreatedAt", "IsVerified", "ParticipantId", "Platform", "PlatformPostUrl", "Rank", "RewardAmount", "UpdatedAt", "VideoUrl" },
                values: new object[,]
                {
                    { new Guid("c2d51d1f-d1a2-4534-95d2-4618379df8df"), "Another submission!", new Guid("300ff83f-acaa-4a76-be7e-058609f97757"), new DateTime(2025, 1, 13, 23, 58, 21, 271, DateTimeKind.Utc).AddTicks(7426), false, new Guid("bd17505f-9f00-412a-afba-7afd75853dfa"), 1, "https://instagram.com/post2", null, null, null, "https://example.com/video2" },
                    { new Guid("d3bcb41f-8f96-4fb4-9dac-e16f46e7f2f8"), "My best dance moves!", new Guid("300ff83f-acaa-4a76-be7e-058609f97757"), new DateTime(2025, 1, 13, 23, 58, 21, 271, DateTimeKind.Utc).AddTicks(6744), true, new Guid("bd17505f-9f00-412a-afba-7afd75853dfa"), 2, "https://tiktok.com/post1", null, null, null, "https://example.com/video1" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: new Guid("c2d51d1f-d1a2-4534-95d2-4618379df8df"));

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: new Guid("d3bcb41f-8f96-4fb4-9dac-e16f46e7f2f8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ee01a14e-6421-4290-ac28-b6e34552d511"));

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: new Guid("300ff83f-acaa-4a76-be7e-058609f97757"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bd17505f-9f00-412a-afba-7afd75853dfa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5b9af0fc-06b7-469d-be7f-79054f30a6ca"));

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
    }
}
