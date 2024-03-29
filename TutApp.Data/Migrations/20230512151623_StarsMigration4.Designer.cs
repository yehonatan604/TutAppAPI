﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tut.Data.SiteDbContext;

#nullable disable

namespace TutApp.Data.Migrations
{
    [DbContext(typeof(SiteDbContext))]
    [Migration("20230512151623_StarsMigration4")]
    partial class StarsMigration4
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
                            Id = "c32f66ed-c960-4cb7-a468-90662e1fb37a",
                            ConcurrencyStamp = "ee09dc21-0ae4-43e4-b65d-f5f8949a8074",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "ddc1ddb9-2495-40d6-b278-633bc6ca29c6",
                            ConcurrencyStamp = "ce890806-4cbd-4f68-b8fb-a66bfed43987",
                            Name = "Creator",
                            NormalizedName = "CREATOR"
                        },
                        new
                        {
                            Id = "4a8a52b2-8c3d-45d2-9fe5-ff01895c5c29",
                            ConcurrencyStamp = "8b8cae8d-3c6f-4bdb-b920-feee26f3d102",
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

                    b.HasData(
                        new
                        {
                            UserId = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                            RoleId = "c32f66ed-c960-4cb7-a468-90662e1fb37a"
                        },
                        new
                        {
                            UserId = "afa4728b-351f-4e2c-a903-3c80e77848e7",
                            RoleId = "ddc1ddb9-2495-40d6-b278-633bc6ca29c6"
                        },
                        new
                        {
                            UserId = "59f65e3a-706c-4056-a0bc-c4597e08599e",
                            RoleId = "ddc1ddb9-2495-40d6-b278-633bc6ca29c6"
                        },
                        new
                        {
                            UserId = "41e09971-aa5d-44f2-8dd2-37ab94cb7708",
                            RoleId = "ddc1ddb9-2495-40d6-b278-633bc6ca29c6"
                        });
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

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Views")
                        .HasColumnType("int");

                    b.Property<int>("category")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ImageId");

                    b.ToTable("Articles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "*",
                            Created = new DateTime(2021, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageId = 1,
                            Stars = 0,
                            Title = "איך להשתמש ב-Github?",
                            UserEmail = "al@email.com",
                            Views = 0,
                            category = 0
                        },
                        new
                        {
                            Id = 2,
                            Content = "*",
                            Created = new DateTime(2021, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageId = 2,
                            Stars = 0,
                            Title = "מה זה תכנות מונחה עצמים?",
                            UserEmail = "al@email.com",
                            Views = 0,
                            category = 0
                        },
                        new
                        {
                            Id = 3,
                            Content = "*",
                            Created = new DateTime(2021, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageId = 3,
                            Stars = 0,
                            Title = "מבוא לאנגולר",
                            UserEmail = "abed@email.com",
                            Views = 0,
                            category = 0
                        },
                        new
                        {
                            Id = 4,
                            Content = "*",
                            Created = new DateTime(2022, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageId = 4,
                            Stars = 0,
                            Title = "תכנות אסינכרוני ב-JS",
                            UserEmail = "erik@email.com",
                            Views = 0,
                            category = 0
                        },
                        new
                        {
                            Id = 5,
                            Content = "*",
                            Created = new DateTime(2021, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageId = 5,
                            Stars = 0,
                            Title = "10 טיפים לבית החכם",
                            UserEmail = "al@email.com",
                            Views = 0,
                            category = 2
                        },
                        new
                        {
                            Id = 6,
                            Content = "*",
                            Created = new DateTime(2022, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageId = 6,
                            Stars = 0,
                            Title = "איך לתכנת את שואב הדייסון שלכם?",
                            UserEmail = "erik@email.com",
                            Views = 0,
                            category = 2
                        },
                        new
                        {
                            Id = 7,
                            Content = "*",
                            Created = new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageId = 5,
                            Stars = 0,
                            Title = "התקנת מנעול חכם לבית",
                            UserEmail = "erik@email.com",
                            Views = 0,
                            category = 2
                        },
                        new
                        {
                            Id = 8,
                            Content = "*",
                            Created = new DateTime(2020, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageId = 6,
                            Stars = 0,
                            Title = "5 מוצרים חכמים לכל בית",
                            UserEmail = "abed@email.com",
                            Views = 0,
                            category = 2
                        },
                        new
                        {
                            Id = 9,
                            Content = "*",
                            Created = new DateTime(2022, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageId = 9,
                            Stars = 0,
                            Title = "איך להתקין חוסם פרסומות בדפדפן?",
                            UserEmail = "abed@email.com",
                            Views = 0,
                            category = 1
                        },
                        new
                        {
                            Id = 10,
                            Content = "*",
                            Created = new DateTime(2022, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageId = 10,
                            Stars = 0,
                            Title = "מה זה קוד 404?",
                            UserEmail = "abed@email.com",
                            Views = 0,
                            category = 1
                        },
                        new
                        {
                            Id = 11,
                            Content = "*",
                            Created = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageId = 11,
                            Stars = 0,
                            Title = "7 טיפים לגלישה בטוחה באינטרנט",
                            UserEmail = "erik@email.com",
                            Views = 0,
                            category = 1
                        },
                        new
                        {
                            Id = 12,
                            Content = "*",
                            Created = new DateTime(2022, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageId = 10,
                            Stars = 0,
                            Title = "המדריך המלא ל-Gmail",
                            UserEmail = "al@email.com",
                            Views = 0,
                            category = 1
                        },
                        new
                        {
                            Id = 13,
                            Content = "*",
                            Created = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageId = 13,
                            Stars = 0,
                            Title = "איך לעשות רקע שקוף לתמונה?",
                            UserEmail = "abed@email.com",
                            Views = 0,
                            category = 3
                        },
                        new
                        {
                            Id = 14,
                            Content = "*",
                            Created = new DateTime(2021, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageId = 14,
                            Stars = 0,
                            Title = "המדריך המלא ל-Gimp",
                            UserEmail = "abed@email.com",
                            Views = 0,
                            category = 3
                        },
                        new
                        {
                            Id = 15,
                            Content = "*",
                            Created = new DateTime(2021, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageId = 13,
                            Stars = 0,
                            Title = "המדריך המלא ל-PhotoShop",
                            UserEmail = "erik@email.com",
                            Views = 0,
                            category = 3
                        },
                        new
                        {
                            Id = 16,
                            Content = "*",
                            Created = new DateTime(2020, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageId = 14,
                            Stars = 0,
                            Title = "איך ליצור תמונות מונפשות?",
                            UserEmail = "al@email.com",
                            Views = 0,
                            category = 3
                        });
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
                            Id = 13,
                            Location = "/assets/Images/design1.png",
                            Title = "Design1"
                        },
                        new
                        {
                            Id = 14,
                            Location = "/assets/Images/design2.png",
                            Title = "Design2"
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

                    b.Property<string>("ReciverEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SenderEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("TutApp.Data.Models.Stars", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ArticleId")
                        .HasColumnType("int");

                    b.Property<int>("StarsGiven")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("ArticleId");

                    b.HasIndex("UserId");

                    b.ToTable("Stars");
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
                            Id = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "bb8b97f8-71d6-40fc-983a-48ab0c7a84ac",
                            DOB = new DateTime(2023, 5, 12, 18, 16, 23, 130, DateTimeKind.Local).AddTicks(2177),
                            Email = "admin@email.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@EMAIL.COM",
                            NormalizedUserName = "ADMIN",
                            Password = "123#Abc123",
                            PasswordHash = "AQAAAAEAACcQAAAAEDwc0Wys6wynewOJi08a0WdMyy9WklrQGpDuSz/YK6REk+HWn9hNF05GB+HZt6oibQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "69f9bee7-94f6-4975-ac5e-5e2b28ccec3b",
                            TwoFactorEnabled = false,
                            UserName = "Admin",
                            UserStatus = 1,
                            UserType = 3
                        },
                        new
                        {
                            Id = "afa4728b-351f-4e2c-a903-3c80e77848e7",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "3469aa9a-7c9d-49ad-8fee-ed72254a62ad",
                            DOB = new DateTime(2023, 5, 12, 18, 16, 23, 137, DateTimeKind.Local).AddTicks(8181),
                            Email = "abed@email.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "ABED@EMAIL.COM",
                            NormalizedUserName = "ABED ZUHIL",
                            Password = "123#Abc123",
                            PasswordHash = "AQAAAAEAACcQAAAAEKMGTRjaEEEXpnO+p0d/CqaQZAiC25wTtyNY4Y256jzQELh3oYnCNaKSn4I4RScRzw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "693911a6-cbc3-4491-8679-8aa122d73c95",
                            TwoFactorEnabled = false,
                            UserName = "Abed Zuhil",
                            UserStatus = 1,
                            UserType = 2
                        },
                        new
                        {
                            Id = "59f65e3a-706c-4056-a0bc-c4597e08599e",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "db3d87f0-b59f-4e2c-9cc9-e5119e4e4285",
                            DOB = new DateTime(2023, 5, 12, 18, 16, 23, 145, DateTimeKind.Local).AddTicks(9162),
                            Email = "erik@email.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "ERIK@EMAIL.COM",
                            NormalizedUserName = "ERIK LEMON",
                            Password = "123#Abc123",
                            PasswordHash = "AQAAAAEAACcQAAAAEDYh2Pj7ThXEiVCX3ugAiSswKj/xh0MySXsrS9wGlKAfvu4SSq4+UawFbSDA3VSsZg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "c0a617ac-1cca-4161-8e1c-60999ec1a0e0",
                            TwoFactorEnabled = false,
                            UserName = "Erik Lemon",
                            UserStatus = 1,
                            UserType = 2
                        },
                        new
                        {
                            Id = "41e09971-aa5d-44f2-8dd2-37ab94cb7708",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b4b35d17-9a6a-4de5-a636-8fe353f1e927",
                            DOB = new DateTime(2023, 5, 12, 18, 16, 23, 153, DateTimeKind.Local).AddTicks(2597),
                            Email = "al@email.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "AL@EMAIL.COM",
                            NormalizedUserName = "AL VISS",
                            Password = "123#Abc123",
                            PasswordHash = "AQAAAAEAACcQAAAAEM8uIGxo96wjALR7ezHx5hsVXNAnMKJ2mduXbNWdYvRs6dxycmgg3iTEafysEhHxxA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "788f8767-4193-4989-bedd-84721fd4e5f5",
                            TwoFactorEnabled = false,
                            UserName = "Al Viss",
                            UserStatus = 1,
                            UserType = 2
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

            modelBuilder.Entity("TutApp.Data.Models.Stars", b =>
                {
                    b.HasOne("TutApp.Data.Models.Article", "Article")
                        .WithMany()
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TutApp.Data.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Article");

                    b.Navigation("User");
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
