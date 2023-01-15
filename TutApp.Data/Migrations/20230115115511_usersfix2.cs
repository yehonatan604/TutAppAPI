using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TutApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class usersfix2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Articles",
                newName: "UserEmail");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5280d787-d868-43b2-ae9c-1f6423b473d0", "97ada959-007a-40ca-bbc5-edcffe2e2bcc", "Creator", "CREATOR" },
                    { "5df7e5a7-ec8c-42cd-ade6-9349097fe72c", "2eb56020-1530-40f5-b41f-e8cb955c2fb1", "Admin", "ADMIN" },
                    { "fdbd1219-6302-4312-8d55-7a52624f8976", "502cffe0-880c-4deb-a7b1-e2df210a151a", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AboutMe", "AccessFailedCount", "ConcurrencyStamp", "DOB", "Email", "EmailConfirmed", "FavCategoriesList", "HobbiesList", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "UserStatus", "UserType" },
                values: new object[,]
                {
                    { "15c56a90-d6cb-4098-a196-6ae9593d3bf4", null, 0, "d1a5dbca-041c-4ec3-89c8-ec92798b4fcc", new DateTime(2023, 1, 15, 13, 55, 11, 152, DateTimeKind.Local).AddTicks(5061), "erik@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "050d3359-542e-4e7f-9f78-45cedc11bb12", false, "Erik Lemon", 1, 2 },
                    { "8413d0fa-3806-45fa-8156-4e2fbdb43ebb", null, 0, "0dff1403-498c-4ed5-b1f4-a1f3b56b2c5f", new DateTime(2023, 1, 15, 13, 55, 11, 152, DateTimeKind.Local).AddTicks(5078), "al@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "14080270-fb19-4cf2-a61b-abcec000e948", false, "Al Viss", 1, 2 },
                    { "a86be999-129f-4ae7-be89-975eb7eb7c40", null, 0, "07b17498-c1ed-4754-811d-f58843ac1d9f", new DateTime(2023, 1, 15, 13, 55, 11, 152, DateTimeKind.Local).AddTicks(5086), "donna@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "ddef9a92-e1b7-4fdb-b2dd-1d92333f5adc", false, "Donna Eyzer", 1, 1 },
                    { "ab03ce0a-abcd-4508-8ac5-50514026e713", null, 0, "49e71c7c-48b7-46e2-9227-8fb2eb4fdecd", new DateTime(2023, 1, 15, 13, 55, 11, 152, DateTimeKind.Local).AddTicks(5000), "admin@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "928732f5-04a6-45bd-9fd4-1b06a11f6b67", false, "Admin", 1, 3 },
                    { "ac8bc95b-5689-4920-b81c-b9191ac8381d", null, 0, "5ea974d9-c456-47a9-b721-426310a7588f", new DateTime(2023, 1, 15, 13, 55, 11, 152, DateTimeKind.Local).AddTicks(5050), "abed@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "01cdcff4-f9cc-4530-8a42-012fcc456eb2", false, "Abed Zuhil", 1, 2 },
                    { "af9653d8-6d0e-4773-88a8-a75ca2282b82", null, 0, "f30c062e-c275-40e1-b80f-4431c842555b", new DateTime(2023, 1, 15, 13, 55, 11, 152, DateTimeKind.Local).AddTicks(5042), "melon@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "d98ea5a5-65b7-4b42-8ec0-b3ec61f6b37c", false, "Rickey Melon", 1, 1 },
                    { "f6b7f62b-bcd2-4244-b6c3-6135073f38ea", null, 0, "8047ea7e-7320-4c95-9488-22f11b388ff1", new DateTime(2023, 1, 15, 13, 55, 11, 152, DateTimeKind.Local).AddTicks(5068), "chan@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "237a5440-98ae-4b10-980f-14669b243377", false, "Chan Don Ma", 1, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5280d787-d868-43b2-ae9c-1f6423b473d0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5df7e5a7-ec8c-42cd-ade6-9349097fe72c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fdbd1219-6302-4312-8d55-7a52624f8976");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15c56a90-d6cb-4098-a196-6ae9593d3bf4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8413d0fa-3806-45fa-8156-4e2fbdb43ebb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a86be999-129f-4ae7-be89-975eb7eb7c40");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ab03ce0a-abcd-4508-8ac5-50514026e713");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ac8bc95b-5689-4920-b81c-b9191ac8381d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "af9653d8-6d0e-4773-88a8-a75ca2282b82");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6b7f62b-bcd2-4244-b6c3-6135073f38ea");

            migrationBuilder.RenameColumn(
                name: "UserEmail",
                table: "Articles",
                newName: "UserId");

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
    }
}
