using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TutApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class seedArticles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "Content", "Created", "ImageId", "Stars", "Title", "UserId", "Views", "category" },
                values: new object[,]
                {
                    { 1, "*", new DateTime(2021, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 5, "איך להשתמש ב-Github?", "24d6f228-0992-4755-8a17-670efb9d10e0", 35643, 0 },
                    { 2, "*", new DateTime(2021, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3, "מה זה תכנות מונחה עצמים?", "24d6f228-0992-4755-8a17-670efb9d10e0", 324576, 0 },
                    { 3, "*", new DateTime(2021, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 4, "מבוא לאנגולר", "917d992e-763c-4560-be77-96b1ebca3654", 15643, 0 },
                    { 4, "*", new DateTime(2022, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 5, "תכנות אסינכרוני ב-JS", "8bb44c37-2465-4d1c-ba34-85ef3c0a3d89", 152643, 0 },
                    { 5, "*", new DateTime(2021, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 4, "10 טיפים לבית החכם", "24d6f228-0992-4755-8a17-670efb9d10e0", 354342, 2 },
                    { 6, "*", new DateTime(2022, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 2, "איך לתכנת את שואב הדייסון שלכם?", "8bb44c37-2465-4d1c-ba34-85ef3c0a3d89", 3453, 2 },
                    { 7, "*", new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 1, "התקנת מנעול חכם לבית", "8bb44c37-2465-4d1c-ba34-85ef3c0a3d89", 5685, 2 },
                    { 8, "*", new DateTime(2020, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 0, "5 מוצרים חכמים לכל בית", "917d992e-763c-4560-be77-96b1ebca3654", 124, 2 },
                    { 9, "*", new DateTime(2022, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 5, "איך להתקין חוסם פרסומות בדפדפן?", "917d992e-763c-4560-be77-96b1ebca3654", 34564536, 1 },
                    { 10, "*", new DateTime(2022, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 3, "מה זה קוד 404?", "917d992e-763c-4560-be77-96b1ebca3654", 45643, 1 },
                    { 11, "*", new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 1, "7 טיפים לגלישה בטוחה באינטרנט", "8bb44c37-2465-4d1c-ba34-85ef3c0a3d89", 356, 1 },
                    { 12, "*", new DateTime(2022, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, 2, "המדריך המלא ל-Gmail", "24d6f228-0992-4755-8a17-670efb9d10e0", 27643, 1 },
                    { 13, "*", new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, 5, "איך לעשות רקע שקוף לתמונה?", "917d992e-763c-4560-be77-96b1ebca3654", 4565468, 3 },
                    { 14, "*", new DateTime(2021, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, 4, "המדריך המלא ל-Gimp", "917d992e-763c-4560-be77-96b1ebca3654", 25643, 3 },
                    { 15, "*", new DateTime(2021, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 5, "המדריך המלא ל-PhotoShop", "8bb44c37-2465-4d1c-ba34-85ef3c0a3d89", 5675656, 3 },
                    { 16, "*", new DateTime(2020, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, 0, "איך ליצור תמונות מונפשות?", "24d6f228-0992-4755-8a17-670efb9d10e0", 22643, 3 }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0d82efc3-1a93-4f35-95ce-5fd63b2ea136", "0400306e-abd4-4369-b0dd-7489888a4611", "User", "USER" },
                    { "2c8034c5-be71-4a1f-89b9-7f9b4ea3a805", "574f2c97-e1bd-42ad-bbac-4b2bcc65ceb7", "Admin", "ADMIN" },
                    { "63e005a4-858b-4ea8-b94c-98b9f8f58623", "5b9f5aed-a463-441a-9a1e-098c742e39a8", "Creator", "CREATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AboutMe", "AccessFailedCount", "ConcurrencyStamp", "DOB", "Email", "EmailConfirmed", "FavCategoriesList", "HobbiesList", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "UserStatus", "UserType" },
                values: new object[,]
                {
                    { "0b1fbb48-33dd-43de-994c-933cf41cfa9b", null, 0, "ba8a51fc-b279-4571-93d3-e922c2dd33af", new DateTime(2023, 1, 14, 11, 51, 56, 605, DateTimeKind.Local).AddTicks(7474), "chan@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "128a97bd-dda2-461c-815f-124ed0217d24", false, "Chan Don Ma", 1, 1 },
                    { "2ee7c1aa-5fbc-48b0-9829-aad8807150d5", null, 0, "7379326f-5e26-441e-b11e-5b5e5638104d", new DateTime(2023, 1, 14, 11, 51, 56, 605, DateTimeKind.Local).AddTicks(7482), "al@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "5eb72c2f-935f-4d21-9c01-b045828d25ec", false, "Al Viss", 1, 2 },
                    { "3a03e7ae-a5c4-41c3-b7df-1b142ff3c8b0", null, 0, "af447bf7-17d9-47f0-86fe-58592d16c5a7", new DateTime(2023, 1, 14, 11, 51, 56, 605, DateTimeKind.Local).AddTicks(7489), "donna@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "5fe288ec-c5b7-41ee-b891-0cd911e108ff", false, "Donna Eyzer", 1, 1 },
                    { "3e42d3b7-69e1-45a7-8ecd-acd40413b3a7", null, 0, "77524316-309d-4305-9442-da832926b1ae", new DateTime(2023, 1, 14, 11, 51, 56, 605, DateTimeKind.Local).AddTicks(7455), "abed@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "50367052-191d-411f-9c03-87bf602b00f6", false, "Abed Zuhil", 1, 2 },
                    { "78de57a8-5a20-4608-a2d3-30acd510be78", null, 0, "ca4107a4-688a-4569-a026-2013e15ae52b", new DateTime(2023, 1, 14, 11, 51, 56, 605, DateTimeKind.Local).AddTicks(7447), "melon@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "2260aa90-a37d-4fca-9572-d84b13a6c0d6", false, "Rickey Melon", 1, 1 },
                    { "bca1aa50-df08-442d-99fd-eee79c190064", null, 0, "70e8baf4-ed06-4cfa-8321-46cd407dee22", new DateTime(2023, 1, 14, 11, 51, 56, 605, DateTimeKind.Local).AddTicks(7464), "erik@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "6b621fce-f610-41c2-bd8a-bd461fda99d4", false, "Erik Lemon", 1, 2 },
                    { "f9bdc8d4-b7b0-477b-a1e4-44e72fcfb357", null, 0, "6de79cd8-4373-4caf-9571-9dfc47104d46", new DateTime(2023, 1, 14, 11, 51, 56, 605, DateTimeKind.Local).AddTicks(7400), "admin@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "6bde944f-a01f-417f-bb85-9ecbc5a14cc0", false, "Admin", 1, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0d82efc3-1a93-4f35-95ce-5fd63b2ea136");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c8034c5-be71-4a1f-89b9-7f9b4ea3a805");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "63e005a4-858b-4ea8-b94c-98b9f8f58623");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0b1fbb48-33dd-43de-994c-933cf41cfa9b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2ee7c1aa-5fbc-48b0-9829-aad8807150d5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a03e7ae-a5c4-41c3-b7df-1b142ff3c8b0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3e42d3b7-69e1-45a7-8ecd-acd40413b3a7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78de57a8-5a20-4608-a2d3-30acd510be78");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bca1aa50-df08-442d-99fd-eee79c190064");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f9bdc8d4-b7b0-477b-a1e4-44e72fcfb357");

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
        }
    }
}
