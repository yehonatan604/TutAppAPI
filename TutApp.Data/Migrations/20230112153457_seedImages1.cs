using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TutApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class seedImages1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e376740-71bb-4297-b7c0-33698e9dd943");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "416d4d7e-12fa-4b1e-a276-a0ebb8b62de9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7aa133a2-8d04-432f-906d-367451a6aac2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0cd0b067-2d6d-46f0-8533-9dafdd7c2fc8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4e7c472f-aea9-4f9e-8512-c1071cca6841");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "60c51d5a-a577-495c-9135-b0fcde572972");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f367a89-34cb-487e-96e7-e48de2cd92ee");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c274fe9f-3024-4162-a716-f6f00aea8acf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e0b4e406-5423-4b63-9306-b9c646890780");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eab52220-beff-42f4-8ea7-aa093102b3c7");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "061a53c4-aaa9-4d50-9878-42b0d6bb18cc", "b814bef3-53b3-4df0-a9a9-5a52f91b0638", "User", "USER" },
                    { "3974ba4b-a39d-4388-8815-7bb48aca61f8", "665d76fd-3237-4847-ba35-842383bb9e03", "Admin", "ADMIN" },
                    { "aaf22504-aa33-434d-a192-66dbcc93d2e8", "9e1a2d2f-1de6-4b27-9580-db488ee341d7", "Creator", "CREATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AboutMe", "AccessFailedCount", "ConcurrencyStamp", "DOB", "Email", "EmailConfirmed", "FavCategoriesList", "HobbiesList", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "UserStatus", "UserType" },
                values: new object[,]
                {
                    { "07eabd23-ed6a-41ba-b1ad-61517f4a8ff4", null, 0, "1bc93f30-470d-4532-a693-b2334228db92", new DateTime(2023, 1, 12, 17, 34, 56, 999, DateTimeKind.Local).AddTicks(3288), "admin@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "aa197c45-bac1-4e2b-8205-67d6900af61c", false, "Admin", 1, 3 },
                    { "24d6f228-0992-4755-8a17-670efb9d10e0", null, 0, "81d544b9-6786-40cd-8632-d5c4fee30a4e", new DateTime(2023, 1, 12, 17, 34, 56, 999, DateTimeKind.Local).AddTicks(3375), "al@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "6f54b4c8-83d1-4891-8265-68b03551a0df", false, "Al Viss", 1, 2 },
                    { "881b739d-391d-4107-a23c-b9a1d5d74f9b", null, 0, "ce42bcb3-35e1-4fcc-a176-319c628250b7", new DateTime(2023, 1, 12, 17, 34, 56, 999, DateTimeKind.Local).AddTicks(3365), "chan@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "37359201-76fa-49b8-8a4b-6e683ae09341", false, "Chan Don Ma", 1, 1 },
                    { "8bb44c37-2465-4d1c-ba34-85ef3c0a3d89", null, 0, "5a0a2b4b-4c2c-4c47-9529-057966f5bc8a", new DateTime(2023, 1, 12, 17, 34, 56, 999, DateTimeKind.Local).AddTicks(3357), "erik@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "fc2689d5-5192-4189-95a2-d0f73894f88a", false, "Erik Lemon", 1, 2 },
                    { "917d992e-763c-4560-be77-96b1ebca3654", null, 0, "bbf5c42d-0499-4ab9-976a-d00a4897cff8", new DateTime(2023, 1, 12, 17, 34, 56, 999, DateTimeKind.Local).AddTicks(3349), "abed@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "a65b7fb3-4cd2-454f-87e1-d544f3a345c0", false, "Abed Zuhil", 1, 2 },
                    { "b13923fd-2607-461e-88d4-726cc0e98850", null, 0, "72234175-9410-4ed7-b547-e218dea480cb", new DateTime(2023, 1, 12, 17, 34, 56, 999, DateTimeKind.Local).AddTicks(3402), "donna@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "65b1c4bd-f88a-4ebe-8269-f10c961b3b4f", false, "Donna Eyzer", 1, 1 },
                    { "c77c9d5a-dcac-4f6a-ba45-74636a134f2c", null, 0, "ea7a4f33-2314-4d4f-baf6-aa3190f3b8cb", new DateTime(2023, 1, 12, 17, 34, 56, 999, DateTimeKind.Local).AddTicks(3337), "melon@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "156ba1bc-20c6-4abe-98d4-b15b5e0c4342", false, "Rickey Melon", 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Location", "Title" },
                values: new object[,]
                {
                    { 1, "/assets/Images/programming1.png", "Programming1" },
                    { 2, "/assets/Images/programming2.png", "Programming2" },
                    { 3, "/assets/Images/programming3.png", "Programming3" },
                    { 4, "/assets/Images/programming4.png", "Programming4" },
                    { 5, "/assets/Images/iot1.png", "Iot1" },
                    { 6, "/assets/Images/iot2.png", "Iot2" },
                    { 7, "/assets/Images/iot3.png", "Iot3" },
                    { 8, "/assets/Images/iot4.png", "Iot4" },
                    { 9, "/assets/Images/internet1.png", "Internet1" },
                    { 10, "/assets/Images/internet2.png", "Internet2" },
                    { 11, "/assets/Images/internet3.png", "Internet3" },
                    { 12, "/assets/Images/internet4.png", "Internet4" },
                    { 13, "/assets/Images/design1.png", "Design1" },
                    { 14, "/assets/Images/design2.png", "Design2" },
                    { 15, "/assets/Images/design3.png", "Design3" },
                    { 16, "/assets/Images/design4.png", "Design4" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "061a53c4-aaa9-4d50-9878-42b0d6bb18cc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3974ba4b-a39d-4388-8815-7bb48aca61f8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aaf22504-aa33-434d-a192-66dbcc93d2e8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "07eabd23-ed6a-41ba-b1ad-61517f4a8ff4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24d6f228-0992-4755-8a17-670efb9d10e0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "881b739d-391d-4107-a23c-b9a1d5d74f9b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8bb44c37-2465-4d1c-ba34-85ef3c0a3d89");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "917d992e-763c-4560-be77-96b1ebca3654");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b13923fd-2607-461e-88d4-726cc0e98850");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c77c9d5a-dcac-4f6a-ba45-74636a134f2c");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2e376740-71bb-4297-b7c0-33698e9dd943", "e03603d9-4b36-4c92-9659-5b424be5aa4a", "User", "USER" },
                    { "416d4d7e-12fa-4b1e-a276-a0ebb8b62de9", "f0e8493e-c430-4042-b5e4-45d5ed86a80a", "Admin", "ADMIN" },
                    { "7aa133a2-8d04-432f-906d-367451a6aac2", "3dbabc90-2635-43bf-af11-1da27aa94c65", "Creator", "CREATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AboutMe", "AccessFailedCount", "ConcurrencyStamp", "DOB", "Email", "EmailConfirmed", "FavCategoriesList", "HobbiesList", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "UserStatus", "UserType" },
                values: new object[,]
                {
                    { "0cd0b067-2d6d-46f0-8533-9dafdd7c2fc8", null, 0, "e7ac415f-124a-41e5-a318-0da4c4fb448a", new DateTime(2023, 1, 12, 17, 34, 36, 492, DateTimeKind.Local).AddTicks(3153), "al@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "eba0da6e-bcdf-40c7-9728-5a1bc8ae294e", false, "Al Viss", 1, 2 },
                    { "4e7c472f-aea9-4f9e-8512-c1071cca6841", null, 0, "a5054b23-2d34-4296-ac70-038769cf5048", new DateTime(2023, 1, 12, 17, 34, 36, 492, DateTimeKind.Local).AddTicks(3114), "melon@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "6289f1b9-a0bb-4b10-94af-f18bacb39ae1", false, "Rickey Melon", 1, 1 },
                    { "60c51d5a-a577-495c-9135-b0fcde572972", null, 0, "706f76c5-ad4a-46b6-8071-6a1dd14a0656", new DateTime(2023, 1, 12, 17, 34, 36, 492, DateTimeKind.Local).AddTicks(3123), "abed@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "c5f673a7-bbcd-4609-889d-44af255c4fd8", false, "Abed Zuhil", 1, 2 },
                    { "6f367a89-34cb-487e-96e7-e48de2cd92ee", null, 0, "d64e702d-2ed8-4714-b7f8-e12f4b9693d1", new DateTime(2023, 1, 12, 17, 34, 36, 492, DateTimeKind.Local).AddTicks(3074), "admin@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "09929833-e8fa-43c8-9c43-2a5564aec4b2", false, "Admin", 1, 3 },
                    { "c274fe9f-3024-4162-a716-f6f00aea8acf", null, 0, "fffb7ae2-8a0e-4371-aec7-11636ce2d900", new DateTime(2023, 1, 12, 17, 34, 36, 492, DateTimeKind.Local).AddTicks(3162), "donna@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "865588be-92bc-4c7f-9e12-2f42db355f1b", false, "Donna Eyzer", 1, 1 },
                    { "e0b4e406-5423-4b63-9306-b9c646890780", null, 0, "6c92ac02-fb28-4f8f-8769-911f4e46ec3b", new DateTime(2023, 1, 12, 17, 34, 36, 492, DateTimeKind.Local).AddTicks(3143), "chan@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "7809191c-9dd4-4325-bb3d-f0d3b4261be1", false, "Chan Don Ma", 1, 1 },
                    { "eab52220-beff-42f4-8ea7-aa093102b3c7", null, 0, "72a5c348-24b2-4ecd-a161-8d6d67ad0f56", new DateTime(2023, 1, 12, 17, 34, 36, 492, DateTimeKind.Local).AddTicks(3135), "erik@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "ad96f59f-f4f0-42aa-a6f7-415108dee138", false, "Erik Lemon", 1, 2 }
                });
        }
    }
}
