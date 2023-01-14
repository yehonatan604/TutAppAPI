﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tut.Model.SiteDbContext;

#nullable disable

namespace TutApp.Data.Migrations
{
    [DbContext(typeof(SiteDbContext))]
    [Migration("20230112153318_seedRoles")]
    partial class seedRoles
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "347683df-63bf-46da-aab8-02814a991932",
                            ConcurrencyStamp = "932abc05-8b8e-4450-868f-13cde76d2da6",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "b66fe689-545e-4e8f-8087-39c5e5d590cd",
                            ConcurrencyStamp = "0651f1a4-2a8b-40eb-b488-f4ddf914aa9f",
                            Name = "Creator",
                            NormalizedName = "CREATOR"
                        },
                        new
                        {
                            Id = "7dd0e2f5-2e5b-411c-adce-f38b2683e431",
                            ConcurrencyStamp = "966ed505-5af1-46ea-b1dd-184c62e0e789",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("TutApp.Data.Models.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int>("ImageId")
                        .HasColumnType("int");

                    b.Property<int>("Stars")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Views")
                        .HasColumnType("int");

                    b.Property<int>("category")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ImageId");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("TutApp.Data.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ArticleId")
                        .HasColumnType("int");

                    b.Property<int>("CommentStatus")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ArticleId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("TutApp.Data.Models.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Images");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Location = "/assets/Images/programming1.png",
                            Title = "Programming1"
                        },
                        new
                        {
                            Id = 2,
                            Location = "/assets/Images/programming2.png",
                            Title = "Programming2"
                        },
                        new
                        {
                            Id = 3,
                            Location = "/assets/Images/programming3.png",
                            Title = "Programming3"
                        },
                        new
                        {
                            Id = 4,
                            Location = "/assets/Images/programming4.png",
                            Title = "Programming4"
                        },
                        new
                        {
                            Id = 5,
                            Location = "/assets/Images/iot1.png",
                            Title = "Iot1"
                        },
                        new
                        {
                            Id = 6,
                            Location = "/assets/Images/iot2.png",
                            Title = "Iot2"
                        },
                        new
                        {
                            Id = 7,
                            Location = "/assets/Images/iot3.png",
                            Title = "Iot3"
                        },
                        new
                        {
                            Id = 8,
                            Location = "/assets/Images/iot4.png",
                            Title = "Iot4"
                        },
                        new
                        {
                            Id = 9,
                            Location = "/assets/Images/internet1.png",
                            Title = "Internet1"
                        },
                        new
                        {
                            Id = 10,
                            Location = "/assets/Images/internet2.png",
                            Title = "Internet2"
                        },
                        new
                        {
                            Id = 11,
                            Location = "/assets/Images/internet3.png",
                            Title = "Internet3"
                        },
                        new
                        {
                            Id = 12,
                            Location = "/assets/Images/internet4.png",
                            Title = "Internet4"
                        },
                        new
                        {
                            Id = 13,
                            Location = "/assets/Images/design1.png",
                            Title = "Design1"
                        },
                        new
                        {
                            Id = 14,
                            Location = "/assets/Images/design2.png",
                            Title = "Design2"
                        },
                        new
                        {
                            Id = 15,
                            Location = "/assets/Images/design3.png",
                            Title = "Design3"
                        },
                        new
                        {
                            Id = 16,
                            Location = "/assets/Images/design4.png",
                            Title = "Design4"
                        });
                });

            modelBuilder.Entity("TutApp.Data.Models.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("ReciverId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SenderId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ReciverId");

                    b.HasIndex("SenderId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("TutApp.Data.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AboutMe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FavCategoriesList")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HobbiesList")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<int>("UserStatus")
                        .HasColumnType("int");

                    b.Property<int>("UserType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "54106e20-e15f-4ab2-b3bb-5bf463ddef14",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e0d604e9-feb7-4da6-bdc9-e2f3b80b5ea3",
                            DOB = new DateTime(2023, 1, 12, 17, 33, 18, 133, DateTimeKind.Local).AddTicks(9033),
                            Email = "admin@email.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Password = "123#Abc123",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "b2ba04a9-0c9b-4b82-842c-2c6c16c4d29a",
                            TwoFactorEnabled = false,
                            UserName = "Admin",
                            UserStatus = 1,
                            UserType = 3
                        },
                        new
                        {
                            Id = "3c371b4e-dfd8-4640-9d17-03f9046c0e44",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "f7e7b6d2-2bb8-4fc2-8021-bdbe36f10c72",
                            DOB = new DateTime(2023, 1, 12, 17, 33, 18, 133, DateTimeKind.Local).AddTicks(9075),
                            Email = "melon@email.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Password = "123#Abc123",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "b7d78196-ded7-4b54-aada-0b425cb65062",
                            TwoFactorEnabled = false,
                            UserName = "Rickey Melon",
                            UserStatus = 1,
                            UserType = 1
                        },
                        new
                        {
                            Id = "621f1602-9039-4dd8-8796-befa62bce930",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "073ee739-6705-417c-bccc-377eaf75da6c",
                            DOB = new DateTime(2023, 1, 12, 17, 33, 18, 133, DateTimeKind.Local).AddTicks(9087),
                            Email = "abed@email.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Password = "123#Abc123",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "068ac5b5-00df-4112-853e-a26f4aed9a1f",
                            TwoFactorEnabled = false,
                            UserName = "Abed Zuhil",
                            UserStatus = 1,
                            UserType = 2
                        },
                        new
                        {
                            Id = "e2cc165f-d134-43c7-8adc-c9c14a8a6b42",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "30dc0511-02ff-4ce5-8624-a077872bdeb9",
                            DOB = new DateTime(2023, 1, 12, 17, 33, 18, 133, DateTimeKind.Local).AddTicks(9101),
                            Email = "erik@email.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Password = "123#Abc123",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "672f6b22-883a-4167-94df-7df42ad91856",
                            TwoFactorEnabled = false,
                            UserName = "Erik Lemon",
                            UserStatus = 1,
                            UserType = 2
                        },
                        new
                        {
                            Id = "054e8fce-b6f1-4c01-b30c-b5d4a4587adf",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "703a4016-8a31-4217-bebb-0a25cc0b5c22",
                            DOB = new DateTime(2023, 1, 12, 17, 33, 18, 133, DateTimeKind.Local).AddTicks(9112),
                            Email = "chan@email.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Password = "123#Abc123",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "a04df066-9984-4f30-b61d-bf16b9df2450",
                            TwoFactorEnabled = false,
                            UserName = "Chan Don Ma",
                            UserStatus = 1,
                            UserType = 1
                        },
                        new
                        {
                            Id = "2d99222c-2815-4f0c-9308-43f3b0541c59",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "24f557fa-b1ae-45fb-b72a-1eea62588dce",
                            DOB = new DateTime(2023, 1, 12, 17, 33, 18, 133, DateTimeKind.Local).AddTicks(9121),
                            Email = "al@email.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Password = "123#Abc123",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "60cd8d52-6fef-495b-9445-a4f239bd7b39",
                            TwoFactorEnabled = false,
                            UserName = "Al Viss",
                            UserStatus = 1,
                            UserType = 2
                        },
                        new
                        {
                            Id = "36ce988a-fd41-409a-980c-4405a8d5bd56",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "00352156-b5f1-4726-874a-b97cd008a7a2",
                            DOB = new DateTime(2023, 1, 12, 17, 33, 18, 133, DateTimeKind.Local).AddTicks(9129),
                            Email = "donna@email.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Password = "123#Abc123",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "d7d50082-535e-4e71-be02-49c06dc738f8",
                            TwoFactorEnabled = false,
                            UserName = "Donna Eyzer",
                            UserStatus = 1,
                            UserType = 1
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("TutApp.Data.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("TutApp.Data.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TutApp.Data.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("TutApp.Data.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TutApp.Data.Models.Article", b =>
                {
                    b.HasOne("TutApp.Data.Models.Image", "Image")
                        .WithMany("Articles")
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Image");
                });

            modelBuilder.Entity("TutApp.Data.Models.Comment", b =>
                {
                    b.HasOne("TutApp.Data.Models.Article", "Article")
                        .WithMany("Comments")
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Article");
                });

            modelBuilder.Entity("TutApp.Data.Models.Message", b =>
                {
                    b.HasOne("TutApp.Data.Models.User", "Reciver")
                        .WithMany()
                        .HasForeignKey("ReciverId");

                    b.HasOne("TutApp.Data.Models.User", "Sender")
                        .WithMany()
                        .HasForeignKey("SenderId");

                    b.Navigation("Reciver");

                    b.Navigation("Sender");
                });

            modelBuilder.Entity("TutApp.Data.Models.Article", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("TutApp.Data.Models.Image", b =>
                {
                    b.Navigation("Articles");
                });
#pragma warning restore 612, 618
        }
    }
}