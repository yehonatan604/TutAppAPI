using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TutApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class fixLinksMigration4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a8a52b2-8c3d-45d2-9fe5-ff01895c5c29",
                column: "ConcurrencyStamp",
                value: "576cb5ac-7884-4e14-bcc0-a32712ddc614");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c32f66ed-c960-4cb7-a468-90662e1fb37a",
                column: "ConcurrencyStamp",
                value: "52386236-8759-4289-9aeb-02e57cfb7eb5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ddc1ddb9-2495-40d6-b278-633bc6ca29c6",
                column: "ConcurrencyStamp",
                value: "aee05575-a394-4a61-9e40-fd604e26903d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41e09971-aa5d-44f2-8dd2-37ab94cb7708",
                columns: new[] { "ConcurrencyStamp", "DOB", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c49389b-0d12-4f5c-8d6c-97d550c5d615", new DateTime(2023, 5, 13, 14, 18, 27, 647, DateTimeKind.Local).AddTicks(6964), "AQAAAAEAACcQAAAAEM1QV/MI7tZBMPbLQTsQK/bBrzpjKpjl8bfnp9/IMcDT5he/dRipn/XYYpP89lg0iw==", "bd1f2811-f825-4862-bac2-6fe60afe3644" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "59f65e3a-706c-4056-a0bc-c4597e08599e",
                columns: new[] { "ConcurrencyStamp", "DOB", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f732fa8b-eedc-49a5-8da9-44cdb5b40a2c", new DateTime(2023, 5, 13, 14, 18, 27, 638, DateTimeKind.Local).AddTicks(4143), "AQAAAAEAACcQAAAAEPqeVh7lENJKjinR4rgywij86Pwe6D75YBBdfL+8W3s7yzyAOzIZJCd4UBtzTsNueg==", "d7d03128-84c8-4a8d-9660-8e9600f8befd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "DOB", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f7669e0b-a2ac-4e30-b390-0b8fe3d7ed36", new DateTime(2023, 5, 13, 14, 18, 27, 623, DateTimeKind.Local).AddTicks(5539), "AQAAAAEAACcQAAAAEImEnil9xnQwkKF4+a4+oxGfXpRs7gbfmtzN/6DEQ7Vs1jlnnsiP6Kl5lrLVUhKuHQ==", "7d90d6b7-0c96-43b9-abaf-1d44706034f3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "afa4728b-351f-4e2c-a903-3c80e77848e7",
                columns: new[] { "ConcurrencyStamp", "DOB", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7bc474ca-060b-4e83-a204-69c8566a492e", new DateTime(2023, 5, 13, 14, 18, 27, 630, DateTimeKind.Local).AddTicks(7713), "AQAAAAEAACcQAAAAEHlJXkxaRGCUw31NqLtvfUC1YKWUlTiiY2wqdUOvqdft7o2jixnKuS2yMEEsNS0kYw==", "ba2b532e-0fc2-4dc0-93c4-cdfc3be1d3b1" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                column: "Location",
                value: "/tut/assets/Images/iot1.png");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                keyValue: 5,
                column: "Location",
                value: "/assets/Images/iot1.png");
        }
    }
}
