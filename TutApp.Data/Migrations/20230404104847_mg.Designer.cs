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
    [Migration("20230404104847_mg")]
    partial class mg
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
                            Id = "486dc9f4-c287-4677-8125-24d589f89972",
                            ConcurrencyStamp = "f829a78d-53e4-412c-b57c-738951724e8c",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "ddc1ddb9-2495-40d6-b278-633bc6ca29c6",
                            ConcurrencyStamp = "3cfb4820-5598-4a89-93cf-c004d2152fe2",
                            Name = "Creator",
                            NormalizedName = "CREATOR"
                        },
                        new
                        {
                            Id = "4a8a52b2-8c3d-45d2-9fe5-ff01895c5c29",
                            ConcurrencyStamp = "05006565-d257-406a-a3d2-6d535b09f33f",
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
                            Stars = 5,
                            Title = "איך להשתמש ב-Github?",
                            UserEmail = "al@email.com",
                            Views = 35643,
                            category = 0
                        },
                        new
                        {
                            Id = 2,
                            Content = "*",
                            Created = new DateTime(2021, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageId = 2,
                            Stars = 3,
                            Title = "מה זה תכנות מונחה עצמים?",
                            UserEmail = "al@email.com",
                            Views = 324576,
                            category = 0
                        },
                        new
                        {
                            Id = 3,
                            Content = "*",
                            Created = new DateTime(2021, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageId = 3,
                            Stars = 4,
                            Title = "מבוא לאנגולר",
                            UserEmail = "abed@email.com",
                            Views = 15643,
                            category = 0
                        },
                        new
                        {
                            Id = 4,
                            Content = "*",
                            Created = new DateTime(2022, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageId = 4,
                            Stars = 5,
                            Title = "תכנות אסינכרוני ב-JS",
                            UserEmail = "erik@email.com",
                            Views = 152643,
                            category = 0
                        },
                        new
                        {
                            Id = 5,
                            Content = "*",
                            Created = new DateTime(2021, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageId = 5,
                            Stars = 4,
                            Title = "10 טיפים לבית החכם",
                            UserEmail = "al@email.com",
                            Views = 354342,
                            category = 2
                        },
                        new
                        {
                            Id = 6,
                            Content = "*",
                            Created = new DateTime(2022, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageId = 6,
                            Stars = 2,
                            Title = "איך לתכנת את שואב הדייסון שלכם?",
                            UserEmail = "erik@email.com",
                            Views = 3453,
                            category = 2
                        },
                        new
                        {
                            Id = 7,
                            Content = "*",
                            Created = new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageId = 5,
                            Stars = 1,
                            Title = "התקנת מנעול חכם לבית",
                            UserEmail = "erik@email.com",
                            Views = 5685,
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
                            Views = 124,
                            category = 2
                        },
                        new
                        {
                            Id = 9,
                            Content = "*",
                            Created = new DateTime(2022, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageId = 9,
                            Stars = 5,
                            Title = "איך להתקין חוסם פרסומות בדפדפן?",
                            UserEmail = "abed@email.com",
                            Views = 34564536,
                            category = 1
                        },
                        new
                        {
                            Id = 10,
                            Content = "*",
                            Created = new DateTime(2022, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageId = 10,
                            Stars = 3,
                            Title = "מה זה קוד 404?",
                            UserEmail = "abed@email.com",
                            Views = 45643,
                            category = 1
                        },
                        new
                        {
                            Id = 11,
                            Content = "*",
                            Created = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageId = 11,
                            Stars = 1,
                            Title = "7 טיפים לגלישה בטוחה באינטרנט",
                            UserEmail = "erik@email.com",
                            Views = 356,
                            category = 1
                        },
                        new
                        {
                            Id = 12,
                            Content = "*",
                            Created = new DateTime(2022, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageId = 10,
                            Stars = 2,
                            Title = "המדריך המלא ל-Gmail",
                            UserEmail = "al@email.com",
                            Views = 27643,
                            category = 1
                        },
                        new
                        {
                            Id = 13,
                            Content = "*",
                            Created = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageId = 13,
                            Stars = 5,
                            Title = "איך לעשות רקע שקוף לתמונה?",
                            UserEmail = "abed@email.com",
                            Views = 4565468,
                            category = 3
                        },
                        new
                        {
                            Id = 14,
                            Content = "*",
                            Created = new DateTime(2021, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageId = 14,
                            Stars = 4,
                            Title = "המדריך המלא ל-Gimp",
                            UserEmail = "abed@email.com",
                            Views = 25643,
                            category = 3
                        },
                        new
                        {
                            Id = 15,
                            Content = "*",
                            Created = new DateTime(2021, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageId = 13,
                            Stars = 5,
                            Title = "המדריך המלא ל-PhotoShop",
                            UserEmail = "erik@email.com",
                            Views = 5675656,
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
                            Views = 22643,
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "ברוכים הבאים לתות!\nשימוש מהנה באתר",
                            Created = new DateTime(2023, 4, 4, 13, 48, 47, 417, DateTimeKind.Local).AddTicks(5069),
                            ReciverEmail = "abed@email.com",
                            SenderEmail = "admin@email.com",
                            Status = 1,
                            Title = "Welcome"
                        },
                        new
                        {
                            Id = 2,
                            Content = "ברוכים הבאים לתות!\nשימוש מהנה באתר",
                            Created = new DateTime(2023, 4, 4, 13, 48, 47, 417, DateTimeKind.Local).AddTicks(5077),
                            ReciverEmail = "melon@email.com",
                            SenderEmail = "admin@email.com",
                            Status = 1,
                            Title = "Welcome"
                        },
                        new
                        {
                            Id = 3,
                            Content = "ברוכים הבאים לתות!\nשימוש מהנה באתר",
                            Created = new DateTime(2023, 4, 4, 13, 48, 47, 417, DateTimeKind.Local).AddTicks(5079),
                            ReciverEmail = "erik@email.com",
                            SenderEmail = "admin@email.com",
                            Status = 1,
                            Title = "Welcome"
                        },
                        new
                        {
                            Id = 4,
                            Content = "ברוכים הבאים לתות!\nשימוש מהנה באתר",
                            Created = new DateTime(2023, 4, 4, 13, 48, 47, 417, DateTimeKind.Local).AddTicks(5081),
                            ReciverEmail = "chan@email.com",
                            SenderEmail = "admin@email.com",
                            Status = 1,
                            Title = "Welcome"
                        },
                        new
                        {
                            Id = 5,
                            Content = "ברוכים הבאים לתות!\nשימוש מהנה באתר",
                            Created = new DateTime(2023, 4, 4, 13, 48, 47, 417, DateTimeKind.Local).AddTicks(5083),
                            ReciverEmail = "al@email.com",
                            SenderEmail = "admin@email.com",
                            Status = 1,
                            Title = "Welcome"
                        },
                        new
                        {
                            Id = 6,
                            Content = "ברוכים הבאים לתות!\nשימוש מהנה באתר",
                            Created = new DateTime(2023, 4, 4, 13, 48, 47, 417, DateTimeKind.Local).AddTicks(5085),
                            ReciverEmail = "donna@email.com",
                            SenderEmail = "admin@email.com",
                            Status = 1,
                            Title = "Welcome"
                        });
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
                            Id = "c32f66ed-c960-4cb7-a468-90662e1fb37a",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ca8ef2cc-5735-4b76-beee-bc695477d407",
                            DOB = new DateTime(2023, 4, 4, 13, 48, 47, 417, DateTimeKind.Local).AddTicks(4746),
                            Email = "admin@email.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Password = "123#Abc123",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "45ee5dcf-61c3-4d75-9cb8-36e8b183ef65",
                            TwoFactorEnabled = false,
                            UserName = "Admin",
                            UserStatus = 1,
                            UserType = 3
                        },
                        new
                        {
                            Id = "dc2b70cb-f433-4bc7-9492-34c3c41404b6",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "f077ee9c-044a-4394-9876-0eaddc6e42a5",
                            DOB = new DateTime(2023, 4, 4, 13, 48, 47, 417, DateTimeKind.Local).AddTicks(4787),
                            Email = "melon@email.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Password = "123#Abc123",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "f135a561-fdb6-4e0d-ad92-fc5a39b077f9",
                            TwoFactorEnabled = false,
                            UserName = "Rickey Melon",
                            UserStatus = 1,
                            UserType = 1
                        },
                        new
                        {
                            Id = "afa4728b-351f-4e2c-a903-3c80e77848e7",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d5df8847-3e62-44bc-8790-cc690ad0265c",
                            DOB = new DateTime(2023, 4, 4, 13, 48, 47, 417, DateTimeKind.Local).AddTicks(4795),
                            Email = "abed@email.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Password = "123#Abc123",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "ffdfeb3c-84ea-4e72-aa0a-f663c2e59da3",
                            TwoFactorEnabled = false,
                            UserName = "Abed Zuhil",
                            UserStatus = 1,
                            UserType = 2
                        },
                        new
                        {
                            Id = "59f65e3a-706c-4056-a0bc-c4597e08599e",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "3e2a55ca-c7e6-4ef9-9a3a-38eb32fad9be",
                            DOB = new DateTime(2023, 4, 4, 13, 48, 47, 417, DateTimeKind.Local).AddTicks(4806),
                            Email = "erik@email.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Password = "123#Abc123",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "31f3627f-1790-4577-87e0-c690985b651e",
                            TwoFactorEnabled = false,
                            UserName = "Erik Lemon",
                            UserStatus = 1,
                            UserType = 2
                        },
                        new
                        {
                            Id = "ec346d77-93e6-4e7b-bff7-5e8b21acbce0",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b1b4a27a-cec7-4740-8a73-99367f519b73",
                            DOB = new DateTime(2023, 4, 4, 13, 48, 47, 417, DateTimeKind.Local).AddTicks(4813),
                            Email = "chan@email.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Password = "123#Abc123",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "5a73d3dd-3d52-4721-a131-1faa23c47289",
                            TwoFactorEnabled = false,
                            UserName = "Chan Don Ma",
                            UserStatus = 1,
                            UserType = 1
                        },
                        new
                        {
                            Id = "41e09971-aa5d-44f2-8dd2-37ab94cb7708",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "320e5515-495f-4c47-bdbb-3772e30f3ed5",
                            DOB = new DateTime(2023, 4, 4, 13, 48, 47, 417, DateTimeKind.Local).AddTicks(4823),
                            Email = "al@email.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Password = "123#Abc123",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "56e69533-782d-4047-8248-7463f4ef340e",
                            TwoFactorEnabled = false,
                            UserName = "Al Viss",
                            UserStatus = 1,
                            UserType = 2
                        },
                        new
                        {
                            Id = "10a4159a-172c-467c-9c97-1a21115e3743",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ab44c147-e81c-4b51-be1d-769ece233641",
                            DOB = new DateTime(2023, 4, 4, 13, 48, 47, 417, DateTimeKind.Local).AddTicks(4830),
                            Email = "donna@email.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Password = "123#Abc123",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "3be07e27-f0ab-4b97-b7a4-0a5e352e22e5",
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