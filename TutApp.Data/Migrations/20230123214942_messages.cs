using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TutApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class messages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_AspNetUsers_ReciverId",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_AspNetUsers_SenderId",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_ReciverId",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_SenderId",
                table: "Messages");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0a5cb87c-b7c2-4d61-a1a9-b11e46f33f0d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "83843b3a-3e36-4623-a866-38ee0aa88771");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e502c544-9d48-41b5-800b-e1815c6e3cd4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "119551e4-adcd-4cee-8b89-7a78417a96ad");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "351dd825-4fd4-4353-ab00-1136e54b05c0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79127fde-874b-4de6-9889-3bca6a200495");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a5890a87-fb43-4e05-8c7e-4c2a6d36bfc2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c7ef1b9a-446f-4ca8-a8d7-f3a2a6ac22ee");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c8fa182d-6112-4a35-99b1-23abc4c22c18");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fcd8c306-359d-4efd-a320-9fe04d2d33b8");

            migrationBuilder.DropColumn(
                name: "ReciverId",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "SenderId",
                table: "Messages");

            migrationBuilder.AddColumn<string>(
                name: "SenderEmail",
                table: "Messages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0f3cf3f9-f0db-44ad-9e66-759543f7496a", "f735918f-5385-4b32-b99f-b99f85b780f2", "User", "USER" },
                    { "5a56877e-d40f-4c22-832d-5693d2bdc70d", "6978e4f0-7b53-430c-86bf-d01a3682b18a", "Admin", "ADMIN" },
                    { "be331dbe-d5ca-4d25-80b5-48dfeec66f42", "85b86910-103a-4129-9462-6769f4483f8b", "Creator", "CREATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AboutMe", "AccessFailedCount", "ConcurrencyStamp", "DOB", "Email", "EmailConfirmed", "FavCategoriesList", "HobbiesList", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "UserStatus", "UserType" },
                values: new object[,]
                {
                    { "0553cc31-b470-4dee-b0fa-e47605e0c0cb", null, 0, "9c65fab8-01c4-4eb0-a59f-095fc0484d17", new DateTime(2023, 1, 23, 23, 49, 42, 128, DateTimeKind.Local).AddTicks(594), "melon@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "4b8567fb-09f3-40e5-bb4e-35bde91cabc8", false, "Rickey Melon", 1, 1 },
                    { "0da38234-027a-4d31-9a43-242c18a54336", null, 0, "ddc56fec-409f-4fd6-93c8-24485eaf3a04", new DateTime(2023, 1, 23, 23, 49, 42, 128, DateTimeKind.Local).AddTicks(622), "chan@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "e2792b08-73d4-444e-8d64-a4dd1259a065", false, "Chan Don Ma", 1, 1 },
                    { "11f91332-b4da-4651-a666-2da99e7b637d", null, 0, "9384b574-60fc-4eb3-bf0f-a80d6c9b8cd6", new DateTime(2023, 1, 23, 23, 49, 42, 128, DateTimeKind.Local).AddTicks(606), "abed@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "350a1e64-1779-440a-9865-3fd3f5c69f6b", false, "Abed Zuhil", 1, 2 },
                    { "3bc6b132-d07b-4804-9592-dc63c3543503", null, 0, "9e22779e-34e1-40b7-b159-c722d33d427c", new DateTime(2023, 1, 23, 23, 49, 42, 128, DateTimeKind.Local).AddTicks(640), "donna@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "92995d60-d219-436f-9b01-dc2be653270b", false, "Donna Eyzer", 1, 1 },
                    { "974a5337-fb32-42d6-838e-52ca9f3c7242", null, 0, "da8783e5-41cb-434d-808e-aa7a604010fb", new DateTime(2023, 1, 23, 23, 49, 42, 128, DateTimeKind.Local).AddTicks(633), "al@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "470911a0-1f55-4f91-9620-72306392caec", false, "Al Viss", 1, 2 },
                    { "a21ec2cf-0cc6-4151-a3ff-16ff7b64ab3e", null, 0, "b5d9071e-4ab4-417b-bf45-0b04e342b4a6", new DateTime(2023, 1, 23, 23, 49, 42, 128, DateTimeKind.Local).AddTicks(549), "admin@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "001fa9a9-e989-461c-96b5-e4f64627d980", false, "Admin", 1, 3 },
                    { "ef488416-689e-4954-9973-65bb5cef505a", null, 0, "267f6fd3-5f19-43a8-abb8-fc881fb0e6ef", new DateTime(2023, 1, 23, 23, 49, 42, 128, DateTimeKind.Local).AddTicks(614), "erik@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "db447902-ac53-4a75-8545-c6efa902bc5b", false, "Erik Lemon", 1, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f3cf3f9-f0db-44ad-9e66-759543f7496a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5a56877e-d40f-4c22-832d-5693d2bdc70d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "be331dbe-d5ca-4d25-80b5-48dfeec66f42");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0553cc31-b470-4dee-b0fa-e47605e0c0cb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0da38234-027a-4d31-9a43-242c18a54336");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11f91332-b4da-4651-a666-2da99e7b637d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3bc6b132-d07b-4804-9592-dc63c3543503");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "974a5337-fb32-42d6-838e-52ca9f3c7242");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a21ec2cf-0cc6-4151-a3ff-16ff7b64ab3e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ef488416-689e-4954-9973-65bb5cef505a");

            migrationBuilder.DropColumn(
                name: "SenderEmail",
                table: "Messages");

            migrationBuilder.AddColumn<string>(
                name: "ReciverId",
                table: "Messages",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SenderId",
                table: "Messages",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0a5cb87c-b7c2-4d61-a1a9-b11e46f33f0d", "782385d4-cb92-4204-8e59-ac97957633c8", "Creator", "CREATOR" },
                    { "83843b3a-3e36-4623-a866-38ee0aa88771", "9bc2bed4-6316-46cc-8cb2-b5c33dd0d669", "Admin", "ADMIN" },
                    { "e502c544-9d48-41b5-800b-e1815c6e3cd4", "9993dd5d-9275-41bf-adf5-3c67bb44ac1d", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AboutMe", "AccessFailedCount", "ConcurrencyStamp", "DOB", "Email", "EmailConfirmed", "FavCategoriesList", "HobbiesList", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "UserStatus", "UserType" },
                values: new object[,]
                {
                    { "119551e4-adcd-4cee-8b89-7a78417a96ad", null, 0, "1cfdd32e-0364-45c7-807d-fba9ebe53fcc", new DateTime(2023, 1, 20, 19, 31, 24, 865, DateTimeKind.Local).AddTicks(1991), "chan@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "f2e5eb5d-3cff-423b-8f14-d895b32c44a8", false, "Chan Don Ma", 1, 1 },
                    { "351dd825-4fd4-4353-ab00-1136e54b05c0", null, 0, "665a09c8-351c-407e-a264-0c0a0e2ce3d1", new DateTime(2023, 1, 20, 19, 31, 24, 865, DateTimeKind.Local).AddTicks(2009), "donna@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "9b3f8bdf-0ddc-45a9-a75a-e740ef85a5bc", false, "Donna Eyzer", 1, 1 },
                    { "79127fde-874b-4de6-9889-3bca6a200495", null, 0, "a87e427f-7a58-4141-9987-45edc8eb9bf6", new DateTime(2023, 1, 20, 19, 31, 24, 865, DateTimeKind.Local).AddTicks(1963), "melon@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "24c9da65-a6fb-4946-9acc-1f0d52b3a13a", false, "Rickey Melon", 1, 1 },
                    { "a5890a87-fb43-4e05-8c7e-4c2a6d36bfc2", null, 0, "d9271532-3ae1-4246-a46a-8af033289e11", new DateTime(2023, 1, 20, 19, 31, 24, 865, DateTimeKind.Local).AddTicks(1982), "erik@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "0e8db7d6-33fc-4809-9a59-6a5f235cd590", false, "Erik Lemon", 1, 2 },
                    { "c7ef1b9a-446f-4ca8-a8d7-f3a2a6ac22ee", null, 0, "77ab3d58-72ba-405a-959e-3c1fa66932cf", new DateTime(2023, 1, 20, 19, 31, 24, 865, DateTimeKind.Local).AddTicks(1999), "al@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "885bbf76-1248-4483-9b1a-bc5b36b6587a", false, "Al Viss", 1, 2 },
                    { "c8fa182d-6112-4a35-99b1-23abc4c22c18", null, 0, "78290a1a-6aea-49d4-bede-27acc39db748", new DateTime(2023, 1, 20, 19, 31, 24, 865, DateTimeKind.Local).AddTicks(1922), "admin@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "d06624de-78be-4b46-b686-c32e5afc784a", false, "Admin", 1, 3 },
                    { "fcd8c306-359d-4efd-a320-9fe04d2d33b8", null, 0, "491a2cb7-8132-43b0-9da7-f7a1c897dd18", new DateTime(2023, 1, 20, 19, 31, 24, 865, DateTimeKind.Local).AddTicks(1972), "abed@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "d723cadb-b37f-4005-9ab1-358a54cd7ad5", false, "Abed Zuhil", 1, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ReciverId",
                table: "Messages",
                column: "ReciverId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_SenderId",
                table: "Messages",
                column: "SenderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_AspNetUsers_ReciverId",
                table: "Messages",
                column: "ReciverId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_AspNetUsers_SenderId",
                table: "Messages",
                column: "SenderId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
