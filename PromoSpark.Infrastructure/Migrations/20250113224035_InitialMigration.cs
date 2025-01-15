using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PromoSpark.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    FullName = table.Column<string>(type: "text", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: false),
                    Role = table.Column<int>(type: "integer", nullable: false),
                    Bio = table.Column<string>(type: "text", nullable: true),
                    SocialMediaLinks = table.Column<string>(type: "text", nullable: true),
                    PayoutAccountNumber = table.Column<string>(type: "text", nullable: true),
                    WalletBalance = table.Column<decimal>(type: "numeric", nullable: false),
                    IsEmailVerified = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Challenges",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CreativeId = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    SongUrl = table.Column<string>(type: "text", nullable: false),
                    RewardPool = table.Column<decimal>(type: "numeric", nullable: false),
                    NumberOfWinners = table.Column<int>(type: "integer", nullable: false),
                    Deadline = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    AllowedPlatforms = table.Column<int[]>(type: "integer[]", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Challenges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Challenges_Users_CreativeId",
                        column: x => x.CreativeId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Submissions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ChallengeId = table.Column<Guid>(type: "uuid", nullable: false),
                    ParticipantId = table.Column<Guid>(type: "uuid", nullable: false),
                    VideoUrl = table.Column<string>(type: "text", nullable: false),
                    Caption = table.Column<string>(type: "text", nullable: false),
                    Platform = table.Column<int>(type: "integer", nullable: false),
                    PlatformPostUrl = table.Column<string>(type: "text", nullable: false),
                    Rank = table.Column<int>(type: "integer", nullable: true),
                    RewardAmount = table.Column<decimal>(type: "numeric", nullable: true),
                    IsVerified = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Submissions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Submissions_Challenges_ChallengeId",
                        column: x => x.ChallengeId,
                        principalTable: "Challenges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Submissions_Users_ParticipantId",
                        column: x => x.ParticipantId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Challenges_CreativeId",
                table: "Challenges",
                column: "CreativeId");

            migrationBuilder.CreateIndex(
                name: "IX_Submissions_ChallengeId",
                table: "Submissions",
                column: "ChallengeId");

            migrationBuilder.CreateIndex(
                name: "IX_Submissions_ParticipantId",
                table: "Submissions",
                column: "ParticipantId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Submissions");

            migrationBuilder.DropTable(
                name: "Challenges");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
