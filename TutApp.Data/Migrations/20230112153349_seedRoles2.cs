using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TutApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class seedRoles2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
