using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TutApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class mg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "486dc9f4-c287-4677-8125-24d589f89972", "f829a78d-53e4-412c-b57c-738951724e8c", "Admin", "ADMIN" },
                    { "4a8a52b2-8c3d-45d2-9fe5-ff01895c5c29", "05006565-d257-406a-a3d2-6d535b09f33f", "User", "USER" },
                    { "ddc1ddb9-2495-40d6-b278-633bc6ca29c6", "3cfb4820-5598-4a89-93cf-c004d2152fe2", "Creator", "CREATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AboutMe", "AccessFailedCount", "ConcurrencyStamp", "DOB", "Email", "EmailConfirmed", "FavCategoriesList", "HobbiesList", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "UserStatus", "UserType" },
                values: new object[,]
                {
                    { "10a4159a-172c-467c-9c97-1a21115e3743", null, 0, "ab44c147-e81c-4b51-be1d-769ece233641", new DateTime(2023, 4, 4, 13, 48, 47, 417, DateTimeKind.Local).AddTicks(4830), "donna@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "3be07e27-f0ab-4b97-b7a4-0a5e352e22e5", false, "Donna Eyzer", 1, 1 },
                    { "41e09971-aa5d-44f2-8dd2-37ab94cb7708", null, 0, "320e5515-495f-4c47-bdbb-3772e30f3ed5", new DateTime(2023, 4, 4, 13, 48, 47, 417, DateTimeKind.Local).AddTicks(4823), "al@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "56e69533-782d-4047-8248-7463f4ef340e", false, "Al Viss", 1, 2 },
                    { "59f65e3a-706c-4056-a0bc-c4597e08599e", null, 0, "3e2a55ca-c7e6-4ef9-9a3a-38eb32fad9be", new DateTime(2023, 4, 4, 13, 48, 47, 417, DateTimeKind.Local).AddTicks(4806), "erik@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "31f3627f-1790-4577-87e0-c690985b651e", false, "Erik Lemon", 1, 2 },
                    { "afa4728b-351f-4e2c-a903-3c80e77848e7", null, 0, "d5df8847-3e62-44bc-8790-cc690ad0265c", new DateTime(2023, 4, 4, 13, 48, 47, 417, DateTimeKind.Local).AddTicks(4795), "abed@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "ffdfeb3c-84ea-4e72-aa0a-f663c2e59da3", false, "Abed Zuhil", 1, 2 },
                    { "c32f66ed-c960-4cb7-a468-90662e1fb37a", null, 0, "ca8ef2cc-5735-4b76-beee-bc695477d407", new DateTime(2023, 4, 4, 13, 48, 47, 417, DateTimeKind.Local).AddTicks(4746), "admin@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "45ee5dcf-61c3-4d75-9cb8-36e8b183ef65", false, "Admin", 1, 3 },
                    { "dc2b70cb-f433-4bc7-9492-34c3c41404b6", null, 0, "f077ee9c-044a-4394-9876-0eaddc6e42a5", new DateTime(2023, 4, 4, 13, 48, 47, 417, DateTimeKind.Local).AddTicks(4787), "melon@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "f135a561-fdb6-4e0d-ad92-fc5a39b077f9", false, "Rickey Melon", 1, 1 },
                    { "ec346d77-93e6-4e7b-bff7-5e8b21acbce0", null, 0, "b1b4a27a-cec7-4740-8a73-99367f519b73", new DateTime(2023, 4, 4, 13, 48, 47, 417, DateTimeKind.Local).AddTicks(4813), "chan@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "5a73d3dd-3d52-4721-a131-1faa23c47289", false, "Chan Don Ma", 1, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 4, 4, 13, 48, 47, 417, DateTimeKind.Local).AddTicks(5069));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 4, 4, 13, 48, 47, 417, DateTimeKind.Local).AddTicks(5077));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2023, 4, 4, 13, 48, 47, 417, DateTimeKind.Local).AddTicks(5079));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2023, 4, 4, 13, 48, 47, 417, DateTimeKind.Local).AddTicks(5081));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2023, 4, 4, 13, 48, 47, 417, DateTimeKind.Local).AddTicks(5083));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2023, 4, 4, 13, 48, 47, 417, DateTimeKind.Local).AddTicks(5085));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "486dc9f4-c287-4677-8125-24d589f89972");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a8a52b2-8c3d-45d2-9fe5-ff01895c5c29");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ddc1ddb9-2495-40d6-b278-633bc6ca29c6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10a4159a-172c-467c-9c97-1a21115e3743");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41e09971-aa5d-44f2-8dd2-37ab94cb7708");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "59f65e3a-706c-4056-a0bc-c4597e08599e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "afa4728b-351f-4e2c-a903-3c80e77848e7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c32f66ed-c960-4cb7-a468-90662e1fb37a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dc2b70cb-f433-4bc7-9492-34c3c41404b6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ec346d77-93e6-4e7b-bff7-5e8b21acbce0");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

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

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 1, 24, 1, 6, 7, 780, DateTimeKind.Local).AddTicks(6603));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 1, 24, 1, 6, 7, 780, DateTimeKind.Local).AddTicks(6608));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2023, 1, 24, 1, 6, 7, 780, DateTimeKind.Local).AddTicks(6610));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2023, 1, 24, 1, 6, 7, 780, DateTimeKind.Local).AddTicks(6613));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2023, 1, 24, 1, 6, 7, 780, DateTimeKind.Local).AddTicks(6616));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2023, 1, 24, 1, 6, 7, 780, DateTimeKind.Local).AddTicks(6618));
        }
    }
}
