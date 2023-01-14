using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TutApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class seedImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "108b667c-bd42-4bb2-9f2a-f63e237f74eb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aa35a6c0-c34c-41be-ae09-f50c87c70335");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "acbb2e0d-525b-485e-87dc-d58d9b118671");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "227a0623-220e-4cd9-9c30-dfb5d57ed8d1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4503c7ba-fb3f-491e-aa25-e7dbdca68f24");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5731af55-cde7-4765-8cfb-397a6ef1d910");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "764f9ebf-8a8b-4455-88c1-c9c3cefc6e2a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79733a7a-601e-40bd-bbea-12020e001320");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9cd96d9d-9b51-45db-8add-e266e4b954ad");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c8ed1194-fda5-47b9-b798-7c93614c9b0d");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "108b667c-bd42-4bb2-9f2a-f63e237f74eb", "7150bc7b-93c9-4da9-8f2c-a0e06582b9dc", "Admin", "ADMIN" },
                    { "aa35a6c0-c34c-41be-ae09-f50c87c70335", "122f26e7-9d94-4a51-b222-5e68a1d3334b", "Creator", "CREATOR" },
                    { "acbb2e0d-525b-485e-87dc-d58d9b118671", "c60948d8-4b37-466e-b2f4-e43749c6f2c4", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AboutMe", "AccessFailedCount", "ConcurrencyStamp", "DOB", "Email", "EmailConfirmed", "FavCategoriesList", "HobbiesList", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "UserStatus", "UserType" },
                values: new object[,]
                {
                    { "227a0623-220e-4cd9-9c30-dfb5d57ed8d1", null, 0, "dcb66a54-4642-463f-8899-8855550d3f36", new DateTime(2023, 1, 12, 17, 33, 49, 618, DateTimeKind.Local).AddTicks(3780), "al@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "6e134449-9e1b-460a-a596-835b0120805c", false, "Al Viss", 1, 2 },
                    { "4503c7ba-fb3f-491e-aa25-e7dbdca68f24", null, 0, "61be3c86-5a3c-4a04-91fb-c45d6a9ceca2", new DateTime(2023, 1, 12, 17, 33, 49, 618, DateTimeKind.Local).AddTicks(3741), "melon@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "40755fa5-4c05-444e-ac7f-61eadb21a604", false, "Rickey Melon", 1, 1 },
                    { "5731af55-cde7-4765-8cfb-397a6ef1d910", null, 0, "17dfed29-c6a6-4f47-9622-9153e2cc31bc", new DateTime(2023, 1, 12, 17, 33, 49, 618, DateTimeKind.Local).AddTicks(3674), "admin@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "fd0ddf88-8fb3-43d4-84ac-5942d614bde0", false, "Admin", 1, 3 },
                    { "764f9ebf-8a8b-4455-88c1-c9c3cefc6e2a", null, 0, "d6baefe6-f865-4dad-bb32-12fd63f003b4", new DateTime(2023, 1, 12, 17, 33, 49, 618, DateTimeKind.Local).AddTicks(3770), "chan@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "81247822-d3f6-4947-a2c6-e8acd3aa160a", false, "Chan Don Ma", 1, 1 },
                    { "79733a7a-601e-40bd-bbea-12020e001320", null, 0, "01c40e4a-5138-4e0b-af77-f30c44180018", new DateTime(2023, 1, 12, 17, 33, 49, 618, DateTimeKind.Local).AddTicks(3753), "abed@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "acdaa378-b0e0-4b99-90e4-089a8661f735", false, "Abed Zuhil", 1, 2 },
                    { "9cd96d9d-9b51-45db-8add-e266e4b954ad", null, 0, "231f3128-5e1d-4b88-95a9-122814400e54", new DateTime(2023, 1, 12, 17, 33, 49, 618, DateTimeKind.Local).AddTicks(3788), "donna@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "53560d15-3844-4647-ac7b-8ae253d25c42", false, "Donna Eyzer", 1, 1 },
                    { "c8ed1194-fda5-47b9-b798-7c93614c9b0d", null, 0, "6cc8bfd5-e87b-44ab-9fff-7c6275cd2714", new DateTime(2023, 1, 12, 17, 33, 49, 618, DateTimeKind.Local).AddTicks(3761), "erik@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "469f7d96-72ef-4a4e-b369-aef370403758", false, "Erik Lemon", 1, 2 }
                });
        }
    }
}
