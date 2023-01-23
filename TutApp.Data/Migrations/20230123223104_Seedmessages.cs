using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TutApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class Seedmessages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "ReciverEmail",
                table: "Messages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "ReciverEmail",
                table: "Messages");

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
    }
}
