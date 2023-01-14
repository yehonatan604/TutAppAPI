using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TutApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class seedRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2f2cbc04-f409-4b9c-a2dc-a9fd9c0c3fba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "64b139ca-be87-4e65-ae56-c0799fa4af64");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf5c8717-1439-4b84-a516-f9ad3144b848");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0032ec24-cb15-4ebd-9590-3628677759f1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04f3cd0a-90b0-4344-9aa5-d09f678028d9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0ae95d2e-e38c-4f7f-a209-a73050ed4980");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b9cd167-7aa7-4a7a-9de1-afec1ccf6f1f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "74369de8-1813-414d-ba1a-7087b15408b6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95180cb2-67a6-461d-9bdd-1bc1aafb9a8b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ad5ccf84-deaf-48e5-a41f-65e41936544a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "347683df-63bf-46da-aab8-02814a991932", "932abc05-8b8e-4450-868f-13cde76d2da6", "Admin", "ADMIN" },
                    { "7dd0e2f5-2e5b-411c-adce-f38b2683e431", "966ed505-5af1-46ea-b1dd-184c62e0e789", "User", "USER" },
                    { "b66fe689-545e-4e8f-8087-39c5e5d590cd", "0651f1a4-2a8b-40eb-b488-f4ddf914aa9f", "Creator", "CREATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AboutMe", "AccessFailedCount", "ConcurrencyStamp", "DOB", "Email", "EmailConfirmed", "FavCategoriesList", "HobbiesList", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "UserStatus", "UserType" },
                values: new object[,]
                {
                    { "054e8fce-b6f1-4c01-b30c-b5d4a4587adf", null, 0, "703a4016-8a31-4217-bebb-0a25cc0b5c22", new DateTime(2023, 1, 12, 17, 33, 18, 133, DateTimeKind.Local).AddTicks(9112), "chan@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "a04df066-9984-4f30-b61d-bf16b9df2450", false, "Chan Don Ma", 1, 1 },
                    { "2d99222c-2815-4f0c-9308-43f3b0541c59", null, 0, "24f557fa-b1ae-45fb-b72a-1eea62588dce", new DateTime(2023, 1, 12, 17, 33, 18, 133, DateTimeKind.Local).AddTicks(9121), "al@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "60cd8d52-6fef-495b-9445-a4f239bd7b39", false, "Al Viss", 1, 2 },
                    { "36ce988a-fd41-409a-980c-4405a8d5bd56", null, 0, "00352156-b5f1-4726-874a-b97cd008a7a2", new DateTime(2023, 1, 12, 17, 33, 18, 133, DateTimeKind.Local).AddTicks(9129), "donna@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "d7d50082-535e-4e71-be02-49c06dc738f8", false, "Donna Eyzer", 1, 1 },
                    { "3c371b4e-dfd8-4640-9d17-03f9046c0e44", null, 0, "f7e7b6d2-2bb8-4fc2-8021-bdbe36f10c72", new DateTime(2023, 1, 12, 17, 33, 18, 133, DateTimeKind.Local).AddTicks(9075), "melon@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "b7d78196-ded7-4b54-aada-0b425cb65062", false, "Rickey Melon", 1, 1 },
                    { "54106e20-e15f-4ab2-b3bb-5bf463ddef14", null, 0, "e0d604e9-feb7-4da6-bdc9-e2f3b80b5ea3", new DateTime(2023, 1, 12, 17, 33, 18, 133, DateTimeKind.Local).AddTicks(9033), "admin@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "b2ba04a9-0c9b-4b82-842c-2c6c16c4d29a", false, "Admin", 1, 3 },
                    { "621f1602-9039-4dd8-8796-befa62bce930", null, 0, "073ee739-6705-417c-bccc-377eaf75da6c", new DateTime(2023, 1, 12, 17, 33, 18, 133, DateTimeKind.Local).AddTicks(9087), "abed@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "068ac5b5-00df-4112-853e-a26f4aed9a1f", false, "Abed Zuhil", 1, 2 },
                    { "e2cc165f-d134-43c7-8adc-c9c14a8a6b42", null, 0, "30dc0511-02ff-4ce5-8624-a077872bdeb9", new DateTime(2023, 1, 12, 17, 33, 18, 133, DateTimeKind.Local).AddTicks(9101), "erik@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "672f6b22-883a-4167-94df-7df42ad91856", false, "Erik Lemon", 1, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "347683df-63bf-46da-aab8-02814a991932");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7dd0e2f5-2e5b-411c-adce-f38b2683e431");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b66fe689-545e-4e8f-8087-39c5e5d590cd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "054e8fce-b6f1-4c01-b30c-b5d4a4587adf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2d99222c-2815-4f0c-9308-43f3b0541c59");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36ce988a-fd41-409a-980c-4405a8d5bd56");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3c371b4e-dfd8-4640-9d17-03f9046c0e44");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "54106e20-e15f-4ab2-b3bb-5bf463ddef14");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "621f1602-9039-4dd8-8796-befa62bce930");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e2cc165f-d134-43c7-8adc-c9c14a8a6b42");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2f2cbc04-f409-4b9c-a2dc-a9fd9c0c3fba", "f7cf8141-b9b9-4a7e-be7c-a8f545518a0b", "Creator", "CREATOR" },
                    { "64b139ca-be87-4e65-ae56-c0799fa4af64", "b90635b3-eff5-425c-8067-b92fc4c1e0e6", "Admin", "ADMIN" },
                    { "bf5c8717-1439-4b84-a516-f9ad3144b848", "2eb4dfaa-6521-4752-a2e8-c42d8b2bdc20", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AboutMe", "AccessFailedCount", "ConcurrencyStamp", "DOB", "Email", "EmailConfirmed", "FavCategoriesList", "HobbiesList", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "UserStatus", "UserType" },
                values: new object[,]
                {
                    { "0032ec24-cb15-4ebd-9590-3628677759f1", null, 0, "5d9f23e0-aeec-4bf3-8eba-f607ff41b1fb", new DateTime(2023, 1, 12, 17, 32, 39, 88, DateTimeKind.Local).AddTicks(8261), "al@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "fcd05acb-d7fc-4455-a528-34e498c430bf", false, "Al Viss", 1, 2 },
                    { "04f3cd0a-90b0-4344-9aa5-d09f678028d9", null, 0, "35cbec61-a6db-45a9-b22f-109a16072c28", new DateTime(2023, 1, 12, 17, 32, 39, 88, DateTimeKind.Local).AddTicks(8055), "melon@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "b245d328-cab4-430d-9e96-da82639be4fe", false, "Rickey Melon", 1, 1 },
                    { "0ae95d2e-e38c-4f7f-a209-a73050ed4980", null, 0, "26753014-b064-4a6c-b6a5-b09b146d20c0", new DateTime(2023, 1, 12, 17, 32, 39, 88, DateTimeKind.Local).AddTicks(8229), "chan@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "39800db6-2db7-4b92-870c-526e36b2e91a", false, "Chan Don Ma", 1, 1 },
                    { "3b9cd167-7aa7-4a7a-9de1-afec1ccf6f1f", null, 0, "b03c9d49-53f6-433e-b638-e442ed8194d6", new DateTime(2023, 1, 12, 17, 32, 39, 88, DateTimeKind.Local).AddTicks(8006), "admin@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "b967a2ff-89cf-4ee0-a8bc-93ec690c97ad", false, "Admin", 1, 3 },
                    { "74369de8-1813-414d-ba1a-7087b15408b6", null, 0, "c8eb1a3d-28ae-41d5-97c0-f7f8fc34b49d", new DateTime(2023, 1, 12, 17, 32, 39, 88, DateTimeKind.Local).AddTicks(8066), "abed@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "574f79c4-8422-4d7c-b9bb-bb94983f0434", false, "Abed Zuhil", 1, 2 },
                    { "95180cb2-67a6-461d-9bdd-1bc1aafb9a8b", null, 0, "a93dba8a-d313-4d3f-bacf-07746aa633c2", new DateTime(2023, 1, 12, 17, 32, 39, 88, DateTimeKind.Local).AddTicks(8296), "donna@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "fb0a30b0-d84e-4e91-a332-5f69eeeb17c9", false, "Donna Eyzer", 1, 1 },
                    { "ad5ccf84-deaf-48e5-a41f-65e41936544a", null, 0, "a8ccb5b7-8fe7-443b-a2b3-8bfbfb90dd9f", new DateTime(2023, 1, 12, 17, 32, 39, 88, DateTimeKind.Local).AddTicks(8217), "erik@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "441ab71c-9b84-4e34-9961-d5ea6797dbff", false, "Erik Lemon", 1, 2 }
                });
        }
    }
}
