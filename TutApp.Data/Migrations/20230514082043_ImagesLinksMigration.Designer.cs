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
    [Migration("20230514082043_ImagesLinksMigration")]
    partial class ImagesLinksMigration
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
                            ConcurrencyStamp = "5dabb985-04f0-4ed2-b0e9-695171901f1d",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "ddc1ddb9-2495-40d6-b278-633bc6ca29c6",
                            ConcurrencyStamp = "7791e761-f759-43fb-94a6-f3365f9ec2cb",
                            Name = "Creator",
                            NormalizedName = "CREATOR"
                        },
                        new
                        {
                            Id = "4a8a52b2-8c3d-45d2-9fe5-ff01895c5c29",
                            ConcurrencyStamp = "31de0832-3595-4c11-a718-47edc36770fe",
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
                            Location = "https://yehonatan.moravia.co.il/tut/assets/Images/programming1.png",
                            Title = "Programming1"
                        },
                        new
                        {
                            Id = 2,
                            Location = "https://yehonatan.moravia.co.il/tut/assets/Images/programming2.png",
                            Title = "Programming2"
                        },
                        new
                        {
                            Id = 3,
                            Location = "https://yehonatan.moravia.co.il/tut/assets/Images/programming3.png",
                            Title = "Programming3"
                        },
                        new
                        {
                            Id = 4,
                            Location = "https://yehonatan.moravia.co.il/tut/assets/Images/programming4.png",
                            Title = "Programming4"
                        },
                        new
                        {
                            Id = 5,
                            Location = "https://yehonatan.moravia.co.il/tut/assets/Images/iot1.png",
                            Title = "Iot1"
                        },
                        new
                        {
                            Id = 6,
                            Location = "https://yehonatan.moravia.co.il/tut/assets/Images/iot2.png",
                            Title = "Iot2"
                        },
                        new
                        {
                            Id = 9,
                            Location = "https://yehonatan.moravia.co.il/tut/assets/Images/internet1.png",
                            Title = "Internet1"
                        },
                        new
                        {
                            Id = 10,
                            Location = "https://yehonatan.moravia.co.il/tut/assets/Images/internet2.png",
                            Title = "Internet2"
                        },
                        new
                        {
                            Id = 11,
                            Location = "https://yehonatan.moravia.co.il/tut/assets/Images/internet3.png",
                            Title = "Internet3"
                        },
                        new
                        {
                            Id = 13,
                            Location = "https://yehonatan.moravia.co.il/tut/assets/Images/design1.png",
                            Title = "Design1"
                        },
                        new
                        {
                            Id = 14,
                            Location = "https://yehonatan.moravia.co.il/tut/assets/Images/design2.png",
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
                            ConcurrencyStamp = "ad691a50-d5a9-4999-a8c6-819e5df7577f",
                            DOB = new DateTime(2023, 5, 14, 11, 20, 43, 264, DateTimeKind.Local).AddTicks(4219),
                            Email = "admin@email.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@EMAIL.COM",
                            NormalizedUserName = "ADMIN",
                            Password = "123#Abc123",
                            PasswordHash = "AQAAAAEAACcQAAAAEAyAEQQaF1hPpYsxItPUlewXgZkr5uqJcRPBGLV7fnrrh0a9Mb0ZdT0HP20x4gtFYg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "b3597f14-2c2d-4d86-ac4d-92d74ec4e7da",
                            TwoFactorEnabled = false,
                            UserName = "Admin",
                            UserStatus = 1,
                            UserType = 3
                        },
                        new
                        {
                            Id = "afa4728b-351f-4e2c-a903-3c80e77848e7",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "90751bdc-83dc-4ab6-a57d-909a867f0220",
                            DOB = new DateTime(2023, 5, 14, 11, 20, 43, 271, DateTimeKind.Local).AddTicks(1217),
                            Email = "abed@email.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "ABED@EMAIL.COM",
                            NormalizedUserName = "ABED ZUHIL",
                            Password = "123#Abc123",
                            PasswordHash = "AQAAAAEAACcQAAAAELmI+U1sc1dJbk5uk1ijVWIE84mgQ2oJoO8j1in+K0i2iKTCfuoNNQ+GZXdBWkVcRQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "475f5e12-3dd7-4925-b207-d96c5babc223",
                            TwoFactorEnabled = false,
                            UserName = "Abed Zuhil",
                            UserStatus = 1,
                            UserType = 2
                        },
                        new
                        {
                            Id = "59f65e3a-706c-4056-a0bc-c4597e08599e",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c9a6b466-a8f0-4452-8620-b59ec1ba1e3a",
                            DOB = new DateTime(2023, 5, 14, 11, 20, 43, 278, DateTimeKind.Local).AddTicks(570),
                            Email = "erik@email.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "ERIK@EMAIL.COM",
                            NormalizedUserName = "ERIK LEMON",
                            Password = "123#Abc123",
                            PasswordHash = "AQAAAAEAACcQAAAAEOUK33fjxAWJWBH9Z68HX7RfnnIC+XcUhU8uVo281s2x4YjduNG5ACP+zYX9j5Mx4Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "8208afd8-db3c-46e4-a306-2f478d466482",
                            TwoFactorEnabled = false,
                            UserName = "Erik Lemon",
                            UserStatus = 1,
                            UserType = 2
                        },
                        new
                        {
                            Id = "41e09971-aa5d-44f2-8dd2-37ab94cb7708",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "f0a194b1-3cf3-4a5f-b508-9841bef51c03",
                            DOB = new DateTime(2023, 5, 14, 11, 20, 43, 284, DateTimeKind.Local).AddTicks(8965),
                            Email = "al@email.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "AL@EMAIL.COM",
                            NormalizedUserName = "AL VISS",
                            Password = "123#Abc123",
                            PasswordHash = "AQAAAAEAACcQAAAAEC6dU2RwMieP9+UnMqv0L0mB5KhJpRkAw8QnP66i575PHlnIFw32uQK1pk/e5PCFCw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "fa181fd4-0025-4b0e-8adc-830c8928120b",
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
