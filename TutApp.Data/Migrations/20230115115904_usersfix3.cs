using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TutApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class usersfix3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserEmail",
                value: "al@email.com");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "UserEmail",
                value: "al@email.com");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "UserEmail",
                value: "abed@email.com");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                column: "UserEmail",
                value: "erik@email.com");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                column: "UserEmail",
                value: "al@email.com");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                column: "UserEmail",
                value: "erik@email.com");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                column: "UserEmail",
                value: "erik@email.com");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                column: "UserEmail",
                value: "abed@email.com");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                column: "UserEmail",
                value: "abed@email.com");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                column: "UserEmail",
                value: "abed@email.com");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 11,
                column: "UserEmail",
                value: "erik@email.com");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 12,
                column: "UserEmail",
                value: "al@email.com");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 13,
                column: "UserEmail",
                value: "abed@email.com");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 14,
                column: "UserEmail",
                value: "abed@email.com");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 15,
                column: "UserEmail",
                value: "erik@email.com");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 16,
                column: "UserEmail",
                value: "al@email.com");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "112cda71-aa80-4ff7-8541-b7e8846be6cb", "dcea3556-880a-436f-8685-740f333bcbd5", "Creator", "CREATOR" },
                    { "1fbcc6dd-4d31-49bc-9320-2c80ce5874a0", "a5a52fa6-7e5e-473f-a649-7532287bbbc0", "Admin", "ADMIN" },
                    { "2ecb3bb2-4ac8-4148-a7dc-6119de036f50", "4060d8b5-1d26-4e30-a44e-7823a0053664", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AboutMe", "AccessFailedCount", "ConcurrencyStamp", "DOB", "Email", "EmailConfirmed", "FavCategoriesList", "HobbiesList", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "UserStatus", "UserType" },
                values: new object[,]
                {
                    { "177a62d7-f6d8-452c-b833-228f19542668", null, 0, "f26f1880-87fb-4212-93b0-ee27bc7845cf", new DateTime(2023, 1, 15, 13, 59, 4, 654, DateTimeKind.Local).AddTicks(6922), "al@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "f136874f-7421-4204-b14e-02e5502c9f4b", false, "Al Viss", 1, 2 },
                    { "43d3c75e-c822-454c-bb51-2135b0dc20a7", null, 0, "bce90f91-48a6-4500-aa65-fa6563a1b7bb", new DateTime(2023, 1, 15, 13, 59, 4, 654, DateTimeKind.Local).AddTicks(6892), "abed@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "b456523a-4e7e-4f25-97e1-872e80c752b2", false, "Abed Zuhil", 1, 2 },
                    { "9d4c2bad-5eb6-4936-bc8e-630808690916", null, 0, "f6c7a387-bd42-4fc0-947d-55de9604a01b", new DateTime(2023, 1, 15, 13, 59, 4, 654, DateTimeKind.Local).AddTicks(6931), "donna@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "65f2404b-acae-441d-b2c3-25913a58e476", false, "Donna Eyzer", 1, 1 },
                    { "c0e456b3-2d99-4d64-b3a7-478bfae8be8e", null, 0, "d47177e1-0e56-401f-8513-63a3ef4e32de", new DateTime(2023, 1, 15, 13, 59, 4, 654, DateTimeKind.Local).AddTicks(6911), "chan@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "7829df3b-4e80-4af6-b764-a8bc4927b75b", false, "Chan Don Ma", 1, 1 },
                    { "d2609eb2-fd8a-4874-92ac-8b94ad925e08", null, 0, "d1ee7bc4-0cc9-4921-9aa9-ababb959bd34", new DateTime(2023, 1, 15, 13, 59, 4, 654, DateTimeKind.Local).AddTicks(6877), "melon@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "75dae8d1-7cbc-4981-87b6-6a107dbb1f5b", false, "Rickey Melon", 1, 1 },
                    { "d33a52cb-eb35-40c3-9fa3-634a73042df8", null, 0, "52ef6f44-b69e-4988-b7bc-a6b729603eaa", new DateTime(2023, 1, 15, 13, 59, 4, 654, DateTimeKind.Local).AddTicks(6901), "erik@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "18a64ad1-815f-4989-bf3b-b4d980f8a49a", false, "Erik Lemon", 1, 2 },
                    { "f7f57ce4-479c-44c5-8bd5-5d1949cd9d2a", null, 0, "24ddf2fb-7022-48cb-a3cb-816f5922a521", new DateTime(2023, 1, 15, 13, 59, 4, 654, DateTimeKind.Local).AddTicks(6832), "admin@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "eb7469a9-8865-41f3-b028-da88446e9c1a", false, "Admin", 1, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "112cda71-aa80-4ff7-8541-b7e8846be6cb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1fbcc6dd-4d31-49bc-9320-2c80ce5874a0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2ecb3bb2-4ac8-4148-a7dc-6119de036f50");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "177a62d7-f6d8-452c-b833-228f19542668");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43d3c75e-c822-454c-bb51-2135b0dc20a7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9d4c2bad-5eb6-4936-bc8e-630808690916");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c0e456b3-2d99-4d64-b3a7-478bfae8be8e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d2609eb2-fd8a-4874-92ac-8b94ad925e08");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d33a52cb-eb35-40c3-9fa3-634a73042df8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f7f57ce4-479c-44c5-8bd5-5d1949cd9d2a");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserEmail",
                value: "2ee7c1aa-5fbc-48b0-9829-aad8807150d5");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "UserEmail",
                value: "2ee7c1aa-5fbc-48b0-9829-aad8807150d5");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "UserEmail",
                value: "bca1aa50-df08-442d-99fd-eee79c190064");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                column: "UserEmail",
                value: "3e42d3b7-69e1-45a7-8ecd-acd40413b3a7");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                column: "UserEmail",
                value: "2ee7c1aa-5fbc-48b0-9829-aad8807150d5");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                column: "UserEmail",
                value: "3e42d3b7-69e1-45a7-8ecd-acd40413b3a7");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                column: "UserEmail",
                value: "3e42d3b7-69e1-45a7-8ecd-acd40413b3a7");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                column: "UserEmail",
                value: "bca1aa50-df08-442d-99fd-eee79c190064");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                column: "UserEmail",
                value: "bca1aa50-df08-442d-99fd-eee79c190064");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                column: "UserEmail",
                value: "bca1aa50-df08-442d-99fd-eee79c190064");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 11,
                column: "UserEmail",
                value: "3e42d3b7-69e1-45a7-8ecd-acd40413b3a7");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 12,
                column: "UserEmail",
                value: "2ee7c1aa-5fbc-48b0-9829-aad8807150d5");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 13,
                column: "UserEmail",
                value: "bca1aa50-df08-442d-99fd-eee79c190064");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 14,
                column: "UserEmail",
                value: "bca1aa50-df08-442d-99fd-eee79c190064");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 15,
                column: "UserEmail",
                value: "3e42d3b7-69e1-45a7-8ecd-acd40413b3a7");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 16,
                column: "UserEmail",
                value: "2ee7c1aa-5fbc-48b0-9829-aad8807150d5");

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
    }
}
