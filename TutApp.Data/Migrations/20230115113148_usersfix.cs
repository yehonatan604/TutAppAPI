using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TutApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class usersfix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: "2ee7c1aa-5fbc-48b0-9829-aad8807150d5");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "UserId",
                value: "2ee7c1aa-5fbc-48b0-9829-aad8807150d5");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "UserId",
                value: "bca1aa50-df08-442d-99fd-eee79c190064");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                column: "UserId",
                value: "3e42d3b7-69e1-45a7-8ecd-acd40413b3a7");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                column: "UserId",
                value: "2ee7c1aa-5fbc-48b0-9829-aad8807150d5");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                column: "UserId",
                value: "3e42d3b7-69e1-45a7-8ecd-acd40413b3a7");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                column: "UserId",
                value: "3e42d3b7-69e1-45a7-8ecd-acd40413b3a7");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                column: "UserId",
                value: "bca1aa50-df08-442d-99fd-eee79c190064");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                column: "UserId",
                value: "bca1aa50-df08-442d-99fd-eee79c190064");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                column: "UserId",
                value: "bca1aa50-df08-442d-99fd-eee79c190064");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 11,
                column: "UserId",
                value: "3e42d3b7-69e1-45a7-8ecd-acd40413b3a7");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 12,
                column: "UserId",
                value: "2ee7c1aa-5fbc-48b0-9829-aad8807150d5");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 13,
                column: "UserId",
                value: "bca1aa50-df08-442d-99fd-eee79c190064");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 14,
                column: "UserId",
                value: "bca1aa50-df08-442d-99fd-eee79c190064");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 15,
                column: "UserId",
                value: "3e42d3b7-69e1-45a7-8ecd-acd40413b3a7");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 16,
                column: "UserId",
                value: "2ee7c1aa-5fbc-48b0-9829-aad8807150d5");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "972e854d-df2a-45d7-84f4-6571104425c1", "6ccd8416-a9b2-4d58-b9f2-7b679ddab66a", "User", "USER" },
                    { "9d839233-d374-402a-b94b-3a3ec775da92", "c378d47f-a08c-41a6-b2cf-b92a7b4e66e9", "Admin", "ADMIN" },
                    { "cc70b231-6252-4960-8288-370c956e8aac", "11d93869-2383-4310-b766-f4987f2a273b", "Creator", "CREATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AboutMe", "AccessFailedCount", "ConcurrencyStamp", "DOB", "Email", "EmailConfirmed", "FavCategoriesList", "HobbiesList", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "UserStatus", "UserType" },
                values: new object[,]
                {
                    { "0bcf01ae-167a-4241-8b46-e791b36a0119", null, 0, "e686a322-6344-44e4-834b-6879c295d549", new DateTime(2023, 1, 15, 13, 31, 48, 431, DateTimeKind.Local).AddTicks(2660), "abed@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "9f8fd556-2bde-4654-90fb-9c3fb312af1a", false, "Abed Zuhil", 1, 2 },
                    { "1edbd3f6-58f9-4647-ac13-94e69df9713a", null, 0, "d67af3b1-82d7-4291-9c58-0ab180447451", new DateTime(2023, 1, 15, 13, 31, 48, 431, DateTimeKind.Local).AddTicks(2648), "melon@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "945883ab-afe0-4b2c-ac63-d6ee595745ff", false, "Rickey Melon", 1, 1 },
                    { "55401191-8988-4d99-9fc4-3e553b00a56d", null, 0, "0fac87d8-27d2-4e45-aac3-8d4a77d6fc53", new DateTime(2023, 1, 15, 13, 31, 48, 431, DateTimeKind.Local).AddTicks(2693), "al@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "ff5c0261-0896-47f1-90ea-de511b5d9358", false, "Al Viss", 1, 2 },
                    { "774d09e5-818b-4cad-a450-0975403e81fa", null, 0, "494e0485-15dd-4e77-8346-a8745c1032cc", new DateTime(2023, 1, 15, 13, 31, 48, 431, DateTimeKind.Local).AddTicks(2595), "admin@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "8597f751-0bd2-4071-ae0c-71cdefc525c2", false, "Admin", 1, 3 },
                    { "b2142bb1-e3de-4d7f-8fa0-bdafe2ec70ee", null, 0, "7d374ac1-d0b8-4b28-b4e4-6e9f90dc72cc", new DateTime(2023, 1, 15, 13, 31, 48, 431, DateTimeKind.Local).AddTicks(2685), "chan@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "7712f0ab-8450-4807-9f4c-f5138b3cf317", false, "Chan Don Ma", 1, 1 },
                    { "b844edba-ada1-4b9a-ab12-04ecbd76e849", null, 0, "8251e6af-5543-4b5e-b815-25136599f750", new DateTime(2023, 1, 15, 13, 31, 48, 431, DateTimeKind.Local).AddTicks(2701), "donna@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "60d21aaf-5ff3-494e-b145-0fef2b626e54", false, "Donna Eyzer", 1, 1 },
                    { "b8b9f8e4-2d5b-466b-9bf0-7c10089f5155", null, 0, "3da144c6-6434-4d5b-88b9-bbbed5d72991", new DateTime(2023, 1, 15, 13, 31, 48, 431, DateTimeKind.Local).AddTicks(2675), "erik@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "6a21805d-29da-4a50-bcab-529bcb99e0ed", false, "Erik Lemon", 1, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "972e854d-df2a-45d7-84f4-6571104425c1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d839233-d374-402a-b94b-3a3ec775da92");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc70b231-6252-4960-8288-370c956e8aac");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0bcf01ae-167a-4241-8b46-e791b36a0119");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1edbd3f6-58f9-4647-ac13-94e69df9713a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55401191-8988-4d99-9fc4-3e553b00a56d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "774d09e5-818b-4cad-a450-0975403e81fa");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2142bb1-e3de-4d7f-8fa0-bdafe2ec70ee");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b844edba-ada1-4b9a-ab12-04ecbd76e849");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b8b9f8e4-2d5b-466b-9bf0-7c10089f5155");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: "24d6f228-0992-4755-8a17-670efb9d10e0");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "UserId",
                value: "24d6f228-0992-4755-8a17-670efb9d10e0");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "UserId",
                value: "917d992e-763c-4560-be77-96b1ebca3654");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                column: "UserId",
                value: "8bb44c37-2465-4d1c-ba34-85ef3c0a3d89");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                column: "UserId",
                value: "24d6f228-0992-4755-8a17-670efb9d10e0");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                column: "UserId",
                value: "8bb44c37-2465-4d1c-ba34-85ef3c0a3d89");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                column: "UserId",
                value: "8bb44c37-2465-4d1c-ba34-85ef3c0a3d89");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                column: "UserId",
                value: "917d992e-763c-4560-be77-96b1ebca3654");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                column: "UserId",
                value: "917d992e-763c-4560-be77-96b1ebca3654");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                column: "UserId",
                value: "917d992e-763c-4560-be77-96b1ebca3654");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 11,
                column: "UserId",
                value: "8bb44c37-2465-4d1c-ba34-85ef3c0a3d89");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 12,
                column: "UserId",
                value: "24d6f228-0992-4755-8a17-670efb9d10e0");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 13,
                column: "UserId",
                value: "917d992e-763c-4560-be77-96b1ebca3654");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 14,
                column: "UserId",
                value: "917d992e-763c-4560-be77-96b1ebca3654");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 15,
                column: "UserId",
                value: "8bb44c37-2465-4d1c-ba34-85ef3c0a3d89");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 16,
                column: "UserId",
                value: "24d6f228-0992-4755-8a17-670efb9d10e0");

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
    }
}
