using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PromoSpark.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class gs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: new Guid("695f1bc5-b3b0-4b44-8fff-60e524dfc9fa"));

            migrationBuilder.DeleteData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: new Guid("92ba0366-3bfb-4fbe-9f76-28c0f0e8eb25"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9c267625-7ec2-4287-989b-cc75019cb4ed"));

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "Id",
                keyValue: new Guid("34c9890a-f9a9-4023-84c8-d05f43422659"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fd0acec0-89a6-48e2-a5bf-e81ceacf3334"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3dbbf54f-5230-426e-9291-9871a9539cf4"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "Email", "FullName", "IsEmailVerified", "PasswordHash", "PayoutAccountNumber", "Role", "SocialMediaLinks", "UpdatedAt", "WalletBalance" },
                values: new object[,]
                {
                    { new Guid("3dbbf54f-5230-426e-9291-9871a9539cf4"), null, new DateTime(2025, 1, 14, 0, 57, 5, 838, DateTimeKind.Utc).AddTicks(2159), "creative@example.com", "Jane Smith", true, "hashedpassword2", null, 2, null, null, 100.50m },
                    { new Guid("9c267625-7ec2-4287-989b-cc75019cb4ed"), null, new DateTime(2025, 1, 14, 0, 57, 5, 838, DateTimeKind.Utc).AddTicks(2166), "admin@example.com", "Admin User", true, "hashedpassword3", null, 3, null, null, 0m },
                    { new Guid("fd0acec0-89a6-48e2-a5bf-e81ceacf3334"), null, new DateTime(2025, 1, 14, 0, 57, 5, 838, DateTimeKind.Utc).AddTicks(1393), "participant@example.com", "John Doe", true, "hashedpassword1", null, 1, null, null, 0m }
                });

            migrationBuilder.InsertData(
                table: "Challenges",
                columns: new[] { "Id", "AllowedPlatforms", "CreatedAt", "CreativeId", "Deadline", "Description", "NumberOfWinners", "RewardPool", "SongUrl", "Status", "Title", "UpdatedAt" },
                values: new object[] { new Guid("34c9890a-f9a9-4023-84c8-d05f43422659"), new[] { 2, 1 }, new DateTime(2025, 1, 14, 0, 57, 5, 840, DateTimeKind.Utc).AddTicks(9581), new Guid("3dbbf54f-5230-426e-9291-9871a9539cf4"), new DateTime(2025, 1, 24, 0, 57, 5, 840, DateTimeKind.Utc).AddTicks(488), "Submit your best dance video to win!", 3, 1000m, "https://example.com/song1", 2, "Dance Challenge 2025", null });

            migrationBuilder.InsertData(
                table: "Submissions",
                columns: new[] { "Id", "Caption", "ChallengeId", "CreatedAt", "IsVerified", "ParticipantId", "Platform", "PlatformPostUrl", "Rank", "RewardAmount", "UpdatedAt", "VideoUrl" },
                values: new object[,]
                {
                    { new Guid("695f1bc5-b3b0-4b44-8fff-60e524dfc9fa"), "Another submission!", new Guid("34c9890a-f9a9-4023-84c8-d05f43422659"), new DateTime(2025, 1, 14, 0, 57, 5, 841, DateTimeKind.Utc).AddTicks(8333), false, new Guid("fd0acec0-89a6-48e2-a5bf-e81ceacf3334"), 1, "https://instagram.com/post2", null, null, null, "https://example.com/video2" },
                    { new Guid("92ba0366-3bfb-4fbe-9f76-28c0f0e8eb25"), "My best dance moves!", new Guid("34c9890a-f9a9-4023-84c8-d05f43422659"), new DateTime(2025, 1, 14, 0, 57, 5, 841, DateTimeKind.Utc).AddTicks(7658), true, new Guid("fd0acec0-89a6-48e2-a5bf-e81ceacf3334"), 2, "https://tiktok.com/post1", null, null, null, "https://example.com/video1" }
                });
        }
    }
}
