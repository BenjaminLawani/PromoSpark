﻿// <auto-generated />
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PromoSpark.Infrastructure.Data;

#nullable disable

namespace PromoSpark.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250113235823_ChangeForm")]
    partial class ChangeForm
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("PromoSpark.Domain.Entities.Challenge", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<List<int>>("AllowedPlatforms")
                        .IsRequired()
                        .HasColumnType("integer[]");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("CreativeId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("Deadline")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("NumberOfWinners")
                        .HasColumnType("integer");

                    b.Property<decimal>("RewardPool")
                        .HasColumnType("numeric");

                    b.Property<string>("SongUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("CreativeId");

                    b.ToTable("Challenges");

                    b.HasData(
                        new
                        {
                            Id = new Guid("300ff83f-acaa-4a76-be7e-058609f97757"),
                            AllowedPlatforms = new List<int> { 2, 1 },
                            CreatedAt = new DateTime(2025, 1, 13, 23, 58, 21, 270, DateTimeKind.Utc).AddTicks(8244),
                            CreativeId = new Guid("5b9af0fc-06b7-469d-be7f-79054f30a6ca"),
                            Deadline = new DateTime(2025, 1, 23, 23, 58, 21, 269, DateTimeKind.Utc).AddTicks(9075),
                            Description = "Submit your best dance video to win!",
                            NumberOfWinners = 3,
                            RewardPool = 1000m,
                            SongUrl = "https://example.com/song1",
                            Status = 2,
                            Title = "Dance Challenge 2025"
                        });
                });

            modelBuilder.Entity("PromoSpark.Domain.Entities.Submission", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Caption")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("ChallengeId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsVerified")
                        .HasColumnType("boolean");

                    b.Property<Guid>("ParticipantId")
                        .HasColumnType("uuid");

                    b.Property<int>("Platform")
                        .HasColumnType("integer");

                    b.Property<string>("PlatformPostUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("Rank")
                        .HasColumnType("integer");

                    b.Property<decimal?>("RewardAmount")
                        .HasColumnType("numeric");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("VideoUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ChallengeId");

                    b.HasIndex("ParticipantId");

                    b.ToTable("Submissions");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d3bcb41f-8f96-4fb4-9dac-e16f46e7f2f8"),
                            Caption = "My best dance moves!",
                            ChallengeId = new Guid("300ff83f-acaa-4a76-be7e-058609f97757"),
                            CreatedAt = new DateTime(2025, 1, 13, 23, 58, 21, 271, DateTimeKind.Utc).AddTicks(6744),
                            IsVerified = true,
                            ParticipantId = new Guid("bd17505f-9f00-412a-afba-7afd75853dfa"),
                            Platform = 2,
                            PlatformPostUrl = "https://tiktok.com/post1",
                            VideoUrl = "https://example.com/video1"
                        },
                        new
                        {
                            Id = new Guid("c2d51d1f-d1a2-4534-95d2-4618379df8df"),
                            Caption = "Another submission!",
                            ChallengeId = new Guid("300ff83f-acaa-4a76-be7e-058609f97757"),
                            CreatedAt = new DateTime(2025, 1, 13, 23, 58, 21, 271, DateTimeKind.Utc).AddTicks(7426),
                            IsVerified = false,
                            ParticipantId = new Guid("bd17505f-9f00-412a-afba-7afd75853dfa"),
                            Platform = 1,
                            PlatformPostUrl = "https://instagram.com/post2",
                            VideoUrl = "https://example.com/video2"
                        });
                });

            modelBuilder.Entity("PromoSpark.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Bio")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsEmailVerified")
                        .HasColumnType("boolean");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PayoutAccountNumber")
                        .HasColumnType("text");

                    b.Property<int>("Role")
                        .HasColumnType("integer");

                    b.Property<string>("SocialMediaLinks")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<decimal>("WalletBalance")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("bd17505f-9f00-412a-afba-7afd75853dfa"),
                            CreatedAt = new DateTime(2025, 1, 13, 23, 58, 21, 267, DateTimeKind.Utc).AddTicks(9344),
                            Email = "participant@example.com",
                            FullName = "John Doe",
                            IsEmailVerified = true,
                            PasswordHash = "hashedpassword1",
                            Role = 1,
                            WalletBalance = 0m
                        },
                        new
                        {
                            Id = new Guid("5b9af0fc-06b7-469d-be7f-79054f30a6ca"),
                            CreatedAt = new DateTime(2025, 1, 13, 23, 58, 21, 268, DateTimeKind.Utc).AddTicks(117),
                            Email = "creative@example.com",
                            FullName = "Jane Smith",
                            IsEmailVerified = true,
                            PasswordHash = "hashedpassword2",
                            Role = 2,
                            WalletBalance = 100.50m
                        },
                        new
                        {
                            Id = new Guid("ee01a14e-6421-4290-ac28-b6e34552d511"),
                            CreatedAt = new DateTime(2025, 1, 13, 23, 58, 21, 268, DateTimeKind.Utc).AddTicks(123),
                            Email = "admin@example.com",
                            FullName = "Admin User",
                            IsEmailVerified = true,
                            PasswordHash = "hashedpassword3",
                            Role = 3,
                            WalletBalance = 0m
                        });
                });

            modelBuilder.Entity("PromoSpark.Domain.Entities.Challenge", b =>
                {
                    b.HasOne("PromoSpark.Domain.Entities.User", "Creative")
                        .WithMany()
                        .HasForeignKey("CreativeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Creative");
                });

            modelBuilder.Entity("PromoSpark.Domain.Entities.Submission", b =>
                {
                    b.HasOne("PromoSpark.Domain.Entities.Challenge", "Challenge")
                        .WithMany("Submissions")
                        .HasForeignKey("ChallengeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PromoSpark.Domain.Entities.User", "Participant")
                        .WithMany()
                        .HasForeignKey("ParticipantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Challenge");

                    b.Navigation("Participant");
                });

            modelBuilder.Entity("PromoSpark.Domain.Entities.Challenge", b =>
                {
                    b.Navigation("Submissions");
                });
#pragma warning restore 612, 618
        }
    }
}
