using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TutApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class fixLinksMigration3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a8a52b2-8c3d-45d2-9fe5-ff01895c5c29",
                column: "ConcurrencyStamp",
                value: "3b069a76-ab8e-4fc5-9ca2-ae42e536521d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c32f66ed-c960-4cb7-a468-90662e1fb37a",
                column: "ConcurrencyStamp",
                value: "a0d36fe2-583b-4cec-b93d-957330298924");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ddc1ddb9-2495-40d6-b278-633bc6ca29c6",
                column: "ConcurrencyStamp",
                value: "c2c2070b-13e5-4638-9945-cb426dfbf2ef");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41e09971-aa5d-44f2-8dd2-37ab94cb7708",
                columns: new[] { "ConcurrencyStamp", "DOB", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2aabd7c3-2524-43c2-81c3-a53ada09160d", new DateTime(2023, 5, 13, 14, 14, 37, 179, DateTimeKind.Local).AddTicks(9778), "AQAAAAEAACcQAAAAENJS3+lebVpLzCHI1r+Axk+UHhGg14E6KXwSqa24mdGOLa3Q8b14MF9d90vjzNz9Qw==", "cbf6b654-e9e9-4820-9225-6a801ee5e3c1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "59f65e3a-706c-4056-a0bc-c4597e08599e",
                columns: new[] { "ConcurrencyStamp", "DOB", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e45bba17-9d63-4f98-b000-54116416b775", new DateTime(2023, 5, 13, 14, 14, 37, 172, DateTimeKind.Local).AddTicks(5878), "AQAAAAEAACcQAAAAEDCCsWlX8zaoTbu4GEqmATEkv7JFz7vo+KyJDqgGJi/O7QsBNix5cbszkyHBsooibw==", "39f9b458-1eb3-493f-9067-e450e4313235" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "DOB", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f72b7632-5e35-445f-ab28-3dc4929477b9", new DateTime(2023, 5, 13, 14, 14, 37, 157, DateTimeKind.Local).AddTicks(5753), "AQAAAAEAACcQAAAAELTzqN2zhtXh8emdMTVT6lCIjve2x+BJVew/6QMdTtIEgLLkUXarmnJdFX2HtFjUZw==", "8370b567-d319-4ed2-bb41-03c25d3a5ab7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "afa4728b-351f-4e2c-a903-3c80e77848e7",
                columns: new[] { "ConcurrencyStamp", "DOB", "PasswordHash", "SecurityStamp" },
                values: new object[] { "26d1a8c3-af1f-4735-b911-b062c520be8f", new DateTime(2023, 5, 13, 14, 14, 37, 165, DateTimeKind.Local).AddTicks(1887), "AQAAAAEAACcQAAAAEPCU79CGmTPHGa1y/1oP71zYoVsrgw+uNrUhJ3vXGJH+8zfFzaB9vaK8RPQo1CcTQA==", "fe1cacc8-93f2-4e24-b14e-4219382a044e" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "Location",
                value: "/tut/assets/Images/programming1.png");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "Location",
                value: "/tut/assets/Images/programming2.png");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                column: "Location",
                value: "/tut/assets/Images/programming3.png");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                column: "Location",
                value: "/tut/assets/Images/programming4.png");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                column: "Location",
                value: "/tut/assets/Images/iot2.png");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                column: "Location",
                value: "/tut/assets/Images/internet1.png");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                column: "Location",
                value: "/tut/assets/Images/internet2.png");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                column: "Location",
                value: "/tut/assets/Images/internet3.png");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13,
                column: "Location",
                value: "/tut/assets/Images/design1.png");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14,
                column: "Location",
                value: "/tut/assets/Images/design2.png");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
