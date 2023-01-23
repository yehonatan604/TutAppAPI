using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TutApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class Seedmessages2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c7f8ddf-918f-4c9c-b12e-5307fc091fb3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a95a8b18-5849-40ac-b73e-bc0e24c33425");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b57800ce-0925-4108-a5c9-be860f04b336");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "03bfd94c-128f-45a2-970c-bd45c6c21b35");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "893e6d85-4a09-4943-b123-559806648d2d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1be2fc5-d3bc-4f9e-9722-8c18039d0371");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b0ca05cb-f4cd-4fea-8666-e68990d0cffc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "be140225-40d7-4fbc-9537-6ad971abd87f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c33a4267-f23c-4e1d-927f-8d855566a25e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e71b6d73-4f9c-416c-bcac-011d4798ccc8");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "600902e4-92a8-494e-9aae-757914984daa", "492f6162-8368-43cd-bdf0-8c2bf3c5edfc", "Creator", "CREATOR" },
                    { "70652ebb-0e8f-4dd1-8a81-850f6af52d91", "4c96ce0f-1c31-4c1b-b60f-a63fcbc3954b", "User", "USER" },
                    { "d386aae6-455a-4521-8364-c3d4102ea725", "dcfe83f5-7c19-4b5a-a1c1-80e4b3f16d70", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AboutMe", "AccessFailedCount", "ConcurrencyStamp", "DOB", "Email", "EmailConfirmed", "FavCategoriesList", "HobbiesList", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "UserStatus", "UserType" },
                values: new object[,]
                {
                    { "1693d3c2-5149-4134-b1cc-dce8634b7b2d", null, 0, "8124d833-d699-4f26-a897-32d8b8915e2f", new DateTime(2023, 1, 24, 1, 6, 7, 780, DateTimeKind.Local).AddTicks(6341), "erik@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "bef5380e-7a4c-4078-ad26-c7752e3595cb", false, "Erik Lemon", 1, 2 },
                    { "1e3fd766-b896-4425-9e50-c2e3a78f5c89", null, 0, "c279c256-6d64-436c-bbe1-b9d5f09dbe09", new DateTime(2023, 1, 24, 1, 6, 7, 780, DateTimeKind.Local).AddTicks(6351), "chan@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "99c8231c-97c5-4729-8aaf-9bf43a745f67", false, "Chan Don Ma", 1, 1 },
                    { "2277a003-8bca-493e-9ab5-28b2e8e902b1", null, 0, "bfa679d5-3aeb-4102-93ee-b9aa0196516e", new DateTime(2023, 1, 24, 1, 6, 7, 780, DateTimeKind.Local).AddTicks(6361), "al@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "6d2c9a76-a7a7-42c0-848b-19842c5d4329", false, "Al Viss", 1, 2 },
                    { "79237c3e-6a0a-47ab-9c2a-751457ef534c", null, 0, "4313ec19-4dbc-46de-b835-d1e8cb4b11e8", new DateTime(2023, 1, 24, 1, 6, 7, 780, DateTimeKind.Local).AddTicks(6332), "abed@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "431eabb8-f21e-4ad1-a620-e4c9c8465c85", false, "Abed Zuhil", 1, 2 },
                    { "8ec940c6-66e1-4cc9-9653-05583cd02d2b", null, 0, "db3b3d4c-a29f-42b6-b356-7c0b721a5444", new DateTime(2023, 1, 24, 1, 6, 7, 780, DateTimeKind.Local).AddTicks(6378), "donna@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "f3985664-33c3-474c-85f5-25a1c52ecc62", false, "Donna Eyzer", 1, 1 },
                    { "bd3ef79a-6036-46fb-8920-5dea82d3143d", null, 0, "b79bdc6f-a1da-47b0-ab19-3df728cbd104", new DateTime(2023, 1, 24, 1, 6, 7, 780, DateTimeKind.Local).AddTicks(6318), "melon@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "1502b863-cbf9-41ea-a365-c0915ef8203c", false, "Rickey Melon", 1, 1 },
                    { "dee5c3de-3b48-49ff-8e49-f25375ca2841", null, 0, "04027ea8-1bdf-4290-bbe7-8e1aa8115ddb", new DateTime(2023, 1, 24, 1, 6, 7, 780, DateTimeKind.Local).AddTicks(6266), "admin@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "a9204989-0936-4b4a-8ead-bf44eca9b9f1", false, "Admin", 1, 3 }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Content", "Created", "ReciverEmail", "SenderEmail", "Status", "Title" },
                values: new object[,]
                {
                    { 1, "ברוכים הבאים לתות!\nשימוש מהנה באתר", new DateTime(2023, 1, 24, 1, 6, 7, 780, DateTimeKind.Local).AddTicks(6603), "abed@email.com", "admin@email.com", 1, "Welcome" },
                    { 2, "ברוכים הבאים לתות!\nשימוש מהנה באתר", new DateTime(2023, 1, 24, 1, 6, 7, 780, DateTimeKind.Local).AddTicks(6608), "melon@email.com", "admin@email.com", 1, "Welcome" },
                    { 3, "ברוכים הבאים לתות!\nשימוש מהנה באתר", new DateTime(2023, 1, 24, 1, 6, 7, 780, DateTimeKind.Local).AddTicks(6610), "erik@email.com", "admin@email.com", 1, "Welcome" },
                    { 4, "ברוכים הבאים לתות!\nשימוש מהנה באתר", new DateTime(2023, 1, 24, 1, 6, 7, 780, DateTimeKind.Local).AddTicks(6613), "chan@email.com", "admin@email.com", 1, "Welcome" },
                    { 5, "ברוכים הבאים לתות!\nשימוש מהנה באתר", new DateTime(2023, 1, 24, 1, 6, 7, 780, DateTimeKind.Local).AddTicks(6616), "al@email.com", "admin@email.com", 1, "Welcome" },
                    { 6, "ברוכים הבאים לתות!\nשימוש מהנה באתר", new DateTime(2023, 1, 24, 1, 6, 7, 780, DateTimeKind.Local).AddTicks(6618), "donna@email.com", "admin@email.com", 1, "Welcome" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "600902e4-92a8-494e-9aae-757914984daa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "70652ebb-0e8f-4dd1-8a81-850f6af52d91");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d386aae6-455a-4521-8364-c3d4102ea725");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1693d3c2-5149-4134-b1cc-dce8634b7b2d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1e3fd766-b896-4425-9e50-c2e3a78f5c89");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2277a003-8bca-493e-9ab5-28b2e8e902b1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79237c3e-6a0a-47ab-9c2a-751457ef534c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8ec940c6-66e1-4cc9-9653-05583cd02d2b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd3ef79a-6036-46fb-8920-5dea82d3143d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dee5c3de-3b48-49ff-8e49-f25375ca2841");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1c7f8ddf-918f-4c9c-b12e-5307fc091fb3", "d11ef265-58aa-445e-a56f-8ca4f1837055", "Admin", "ADMIN" },
                    { "a95a8b18-5849-40ac-b73e-bc0e24c33425", "246c85cf-3dd9-4c23-b576-a2789b0002b8", "User", "USER" },
                    { "b57800ce-0925-4108-a5c9-be860f04b336", "116ccc8c-0b30-4ba8-adf3-716756b7a516", "Creator", "CREATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AboutMe", "AccessFailedCount", "ConcurrencyStamp", "DOB", "Email", "EmailConfirmed", "FavCategoriesList", "HobbiesList", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "UserStatus", "UserType" },
                values: new object[,]
                {
                    { "03bfd94c-128f-45a2-970c-bd45c6c21b35", null, 0, "d63d0710-bfc9-42c7-8d59-cc49cd9060aa", new DateTime(2023, 1, 24, 0, 31, 4, 546, DateTimeKind.Local).AddTicks(2713), "donna@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "90dec7e6-fe44-4ba1-b86f-b97c1607849a", false, "Donna Eyzer", 1, 1 },
                    { "893e6d85-4a09-4943-b123-559806648d2d", null, 0, "dec11f7a-6008-4b75-9d52-75dc4e8dc5b0", new DateTime(2023, 1, 24, 0, 31, 4, 546, DateTimeKind.Local).AddTicks(2669), "melon@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "84f214c0-2545-45e3-812c-ce6214d4e52d", false, "Rickey Melon", 1, 1 },
                    { "a1be2fc5-d3bc-4f9e-9722-8c18039d0371", null, 0, "a15e4ce3-370e-4666-af62-bfdb2221d40c", new DateTime(2023, 1, 24, 0, 31, 4, 546, DateTimeKind.Local).AddTicks(2630), "admin@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "cbcf4c93-ca96-466d-aa9c-19071db83017", false, "Admin", 1, 3 },
                    { "b0ca05cb-f4cd-4fea-8666-e68990d0cffc", null, 0, "805cd4a7-5aa6-49c8-a1ad-a5bae7fc9daa", new DateTime(2023, 1, 24, 0, 31, 4, 546, DateTimeKind.Local).AddTicks(2695), "chan@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "22933f07-e62a-4af2-af97-7e40aed26e24", false, "Chan Don Ma", 1, 1 },
                    { "be140225-40d7-4fbc-9537-6ad971abd87f", null, 0, "d78371f5-7888-4264-91d8-71be320e4b35", new DateTime(2023, 1, 24, 0, 31, 4, 546, DateTimeKind.Local).AddTicks(2702), "al@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "caaa2d26-5ad6-43b0-b8fd-47522ad53ac7", false, "Al Viss", 1, 2 },
                    { "c33a4267-f23c-4e1d-927f-8d855566a25e", null, 0, "50435a03-e987-4ca5-9e68-eec0547a0930", new DateTime(2023, 1, 24, 0, 31, 4, 546, DateTimeKind.Local).AddTicks(2677), "abed@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "44e77767-e75a-4788-83aa-812037416873", false, "Abed Zuhil", 1, 2 },
                    { "e71b6d73-4f9c-416c-bcac-011d4798ccc8", null, 0, "f11eeee7-c358-459b-85c3-6a28b4d635d9", new DateTime(2023, 1, 24, 0, 31, 4, 546, DateTimeKind.Local).AddTicks(2687), "erik@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "11c6e79d-ccb4-4afb-9372-1d757c290f10", false, "Erik Lemon", 1, 2 }
                });
        }
    }
}
