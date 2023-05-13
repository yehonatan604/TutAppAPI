using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TutApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class fixLinksMigration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a8a52b2-8c3d-45d2-9fe5-ff01895c5c29",
                column: "ConcurrencyStamp",
                value: "8cd8df60-60ef-4e8b-a864-b8208f67c0a2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c32f66ed-c960-4cb7-a468-90662e1fb37a",
                column: "ConcurrencyStamp",
                value: "3fdf341f-09c3-4507-967c-72333b32b3b1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ddc1ddb9-2495-40d6-b278-633bc6ca29c6",
                column: "ConcurrencyStamp",
                value: "49d68602-18d5-4b3a-bb1f-b959021408d5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41e09971-aa5d-44f2-8dd2-37ab94cb7708",
                columns: new[] { "ConcurrencyStamp", "DOB", "PasswordHash", "SecurityStamp" },
                values: new object[] { "30526d95-dd2e-4fc9-b7c9-c4c88d29a671", new DateTime(2023, 5, 13, 14, 11, 10, 549, DateTimeKind.Local).AddTicks(6309), "AQAAAAEAACcQAAAAEI6qSMY/svdlMxSJJ09detPO1z1pXekHmyYfQVIMw5AwfJdw+SjVdGmlICMooziXcA==", "0c17ccb3-fe5a-4980-ad51-8a6bd4321d52" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "59f65e3a-706c-4056-a0bc-c4597e08599e",
                columns: new[] { "ConcurrencyStamp", "DOB", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a627047-a83a-4509-b606-70bc4dc3c6e1", new DateTime(2023, 5, 13, 14, 11, 10, 538, DateTimeKind.Local).AddTicks(4120), "AQAAAAEAACcQAAAAEM4O4OQmTDAVoIGdHQmNWOfkCvbxlF5AR6V+MIq326OEI/qaqOZ71GjZuV3LopQm6w==", "4a9f88b0-c9b4-48ac-83b9-032690cebcbf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "DOB", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ab9c31d4-ae27-4c26-ada2-15bf645ceb91", new DateTime(2023, 5, 13, 14, 11, 10, 519, DateTimeKind.Local).AddTicks(6160), "AQAAAAEAACcQAAAAEABl8KINcYOWodUF+H+YeKrKLsLPwKv6DcfRC2JdP8orOvbYnhlnq2P8jSEftJgfdw==", "439cba10-62a3-4ab2-a26d-6b3b8eddedaf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "afa4728b-351f-4e2c-a903-3c80e77848e7",
                columns: new[] { "ConcurrencyStamp", "DOB", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5373e74c-025f-4053-801c-d355db5f5280", new DateTime(2023, 5, 13, 14, 11, 10, 530, DateTimeKind.Local).AddTicks(88), "AQAAAAEAACcQAAAAEE7S8EwJN18yUOaCxEs4QywwA2Xn+fxZWYcqFj1gMGh4Yy5uIdzPdolDX2JakXBnhg==", "018f4414-cdb8-492f-bc41-1dc9e15b4d24" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "Location",
                value: "/assets/Images/programming1.png");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "Location",
                value: "/assets/Images/programming2.png");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                column: "Location",
                value: "/assets/Images/programming3.png");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                column: "Location",
                value: "/assets/Images/programming4.png");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                column: "Location",
                value: "/assets/Images/iot1.png");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                column: "Location",
                value: "/assets/Images/iot2.png");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                column: "Location",
                value: "/assets/Images/internet1.png");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                column: "Location",
                value: "/assets/Images/internet2.png");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                column: "Location",
                value: "/assets/Images/internet3.png");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13,
                column: "Location",
                value: "/assets/Images/design1.png");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14,
                column: "Location",
                value: "/assets/Images/design2.png");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a8a52b2-8c3d-45d2-9fe5-ff01895c5c29",
                column: "ConcurrencyStamp",
                value: "d12aa2e4-7cf9-47f2-975f-be06fb632e3a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c32f66ed-c960-4cb7-a468-90662e1fb37a",
                column: "ConcurrencyStamp",
                value: "ee6eb27e-a07b-4463-87b0-a909fc36fb6b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ddc1ddb9-2495-40d6-b278-633bc6ca29c6",
                column: "ConcurrencyStamp",
                value: "4c93724f-325c-4039-b76e-06a1e32427f0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41e09971-aa5d-44f2-8dd2-37ab94cb7708",
                columns: new[] { "ConcurrencyStamp", "DOB", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c68faadc-d1c3-4fc0-8903-3dbf8fc78587", new DateTime(2023, 5, 13, 14, 3, 0, 169, DateTimeKind.Local).AddTicks(1100), "AQAAAAEAACcQAAAAELAdb0ByvW4ojpob2LvEa22QLBn0yJ2Ulk+RMMBNQ6JKvqs8s3d+8dYXZZQvllWb8A==", "3857cee2-339d-45a7-b37e-ca58bc22c66a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "59f65e3a-706c-4056-a0bc-c4597e08599e",
                columns: new[] { "ConcurrencyStamp", "DOB", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad9aa346-8b1f-4b47-b4db-762ed0b360b2", new DateTime(2023, 5, 13, 14, 3, 0, 162, DateTimeKind.Local).AddTicks(4733), "AQAAAAEAACcQAAAAEA55MXk68yk08sxzulBH4IbdX0ZER26b6kXG+xEmjIS4iNtrabLBQQZCSXv4rNyThg==", "a9f2c9e9-a906-44e0-a801-1c30dfa098a7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "DOB", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2843f277-febe-4e97-a64d-9dd29daed9f0", new DateTime(2023, 5, 13, 14, 3, 0, 148, DateTimeKind.Local).AddTicks(3905), "AQAAAAEAACcQAAAAEO+4UECaEQ/iuRTau9VXQnoOZy7FhX2AhIWcY7h+kJOEqyQDCoGgjpPeL5TLbQeQ3A==", "efbb238d-7285-48b0-ba2f-e219b2bf0442" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "afa4728b-351f-4e2c-a903-3c80e77848e7",
                columns: new[] { "ConcurrencyStamp", "DOB", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a35a89f6-c70a-4765-9325-d0cb6fe37c33", new DateTime(2023, 5, 13, 14, 3, 0, 155, DateTimeKind.Local).AddTicks(2047), "AQAAAAEAACcQAAAAELrLE0tVTAi7N4+kcHnIt9m0gKDKyLBKiMmkhfb2XvMdBwxL5YjxGwqtvQvKQ0IC4A==", "cc32db7f-8a86-4d32-9343-c9c6a580e99b" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "Location",
                value: "yehonatan.moravia.co.il/tut/assets/Images/programming1.png");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "Location",
                value: "yehonatan.moravia.co.il/tut/assets/Images/programming2.png");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                column: "Location",
                value: "yehonatan.moravia.co.il/tut/assets/Images/programming3.png");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                column: "Location",
                value: "yehonatan.moravia.co.il/tut/assets/Images/programming4.png");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                column: "Location",
                value: "yehonatan.moravia.co.il/tut/assets/Images/iot1.png");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                column: "Location",
                value: "yehonatan.moravia.co.il/tut/assets/Images/iot2.png");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                column: "Location",
                value: "yehonatan.moravia.co.il/tut/assets/Images/internet1.png");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                column: "Location",
                value: "yehonatan.moravia.co.il/tut/assets/Images/internet2.png");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                column: "Location",
                value: "yehonatan.moravia.co.il/tut/assets/Images/internet3.png");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13,
                column: "Location",
                value: "yehonatan.moravia.co.il/tut/assets/Images/design1.png");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14,
                column: "Location",
                value: "yehonatan.moravia.co.il/tut/assets/Images/design2.png");
        }
    }
}
