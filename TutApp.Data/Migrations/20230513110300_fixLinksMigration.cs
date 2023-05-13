using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TutApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class fixLinksMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a8a52b2-8c3d-45d2-9fe5-ff01895c5c29",
                column: "ConcurrencyStamp",
                value: "8b8cae8d-3c6f-4bdb-b920-feee26f3d102");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c32f66ed-c960-4cb7-a468-90662e1fb37a",
                column: "ConcurrencyStamp",
                value: "ee09dc21-0ae4-43e4-b65d-f5f8949a8074");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ddc1ddb9-2495-40d6-b278-633bc6ca29c6",
                column: "ConcurrencyStamp",
                value: "ce890806-4cbd-4f68-b8fb-a66bfed43987");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41e09971-aa5d-44f2-8dd2-37ab94cb7708",
                columns: new[] { "ConcurrencyStamp", "DOB", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b4b35d17-9a6a-4de5-a636-8fe353f1e927", new DateTime(2023, 5, 12, 18, 16, 23, 153, DateTimeKind.Local).AddTicks(2597), "AQAAAAEAACcQAAAAEM8uIGxo96wjALR7ezHx5hsVXNAnMKJ2mduXbNWdYvRs6dxycmgg3iTEafysEhHxxA==", "788f8767-4193-4989-bedd-84721fd4e5f5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "59f65e3a-706c-4056-a0bc-c4597e08599e",
                columns: new[] { "ConcurrencyStamp", "DOB", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db3d87f0-b59f-4e2c-9cc9-e5119e4e4285", new DateTime(2023, 5, 12, 18, 16, 23, 145, DateTimeKind.Local).AddTicks(9162), "AQAAAAEAACcQAAAAEDYh2Pj7ThXEiVCX3ugAiSswKj/xh0MySXsrS9wGlKAfvu4SSq4+UawFbSDA3VSsZg==", "c0a617ac-1cca-4161-8e1c-60999ec1a0e0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "DOB", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bb8b97f8-71d6-40fc-983a-48ab0c7a84ac", new DateTime(2023, 5, 12, 18, 16, 23, 130, DateTimeKind.Local).AddTicks(2177), "AQAAAAEAACcQAAAAEDwc0Wys6wynewOJi08a0WdMyy9WklrQGpDuSz/YK6REk+HWn9hNF05GB+HZt6oibQ==", "69f9bee7-94f6-4975-ac5e-5e2b28ccec3b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "afa4728b-351f-4e2c-a903-3c80e77848e7",
                columns: new[] { "ConcurrencyStamp", "DOB", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3469aa9a-7c9d-49ad-8fee-ed72254a62ad", new DateTime(2023, 5, 12, 18, 16, 23, 137, DateTimeKind.Local).AddTicks(8181), "AQAAAAEAACcQAAAAEKMGTRjaEEEXpnO+p0d/CqaQZAiC25wTtyNY4Y256jzQELh3oYnCNaKSn4I4RScRzw==", "693911a6-cbc3-4491-8679-8aa122d73c95" });

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
    }
}
