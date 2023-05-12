using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TutApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class StarsMigration4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Views",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Stars", "Views" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Stars", "Views" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Stars", "Views" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Stars", "Views" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Stars", "Views" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Stars", "Views" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                column: "Views",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Stars", "Views" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Stars", "Views" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Stars", "Views" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Stars", "Views" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Stars", "Views" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Stars", "Views" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Stars", "Views" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 16,
                column: "Views",
                value: 0);

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Views",
                value: 35643);

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Stars", "Views" },
                values: new object[] { 3, 324576 });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Stars", "Views" },
                values: new object[] { 4, 15643 });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Stars", "Views" },
                values: new object[] { 5, 152643 });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Stars", "Views" },
                values: new object[] { 4, 354342 });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Stars", "Views" },
                values: new object[] { 2, 3453 });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Stars", "Views" },
                values: new object[] { 1, 5685 });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                column: "Views",
                value: 124);

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Stars", "Views" },
                values: new object[] { 5, 34564536 });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Stars", "Views" },
                values: new object[] { 3, 45643 });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Stars", "Views" },
                values: new object[] { 1, 356 });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Stars", "Views" },
                values: new object[] { 2, 27643 });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Stars", "Views" },
                values: new object[] { 5, 4565468 });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Stars", "Views" },
                values: new object[] { 4, 25643 });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Stars", "Views" },
                values: new object[] { 5, 5675656 });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 16,
                column: "Views",
                value: 22643);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a8a52b2-8c3d-45d2-9fe5-ff01895c5c29",
                column: "ConcurrencyStamp",
                value: "cf442d58-88e9-4328-a61e-a3a3333f0407");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c32f66ed-c960-4cb7-a468-90662e1fb37a",
                column: "ConcurrencyStamp",
                value: "7ddf7983-3ead-4ce7-9f25-d288208596d7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ddc1ddb9-2495-40d6-b278-633bc6ca29c6",
                column: "ConcurrencyStamp",
                value: "ccf8a9e5-c24e-4cd9-b9b2-883b897e7a2b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41e09971-aa5d-44f2-8dd2-37ab94cb7708",
                columns: new[] { "ConcurrencyStamp", "DOB", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6d8c9e52-1640-4f82-80c7-0ef9bceb6382", new DateTime(2023, 5, 12, 18, 9, 9, 368, DateTimeKind.Local).AddTicks(3225), "AQAAAAEAACcQAAAAEMqXYT0VdZLLyVb+ynFOi09WRIDyr1FV3xHulFAdZ1HIF3GkRtV9WQesGLOj4mHtdg==", "d86be53c-47e9-4c3e-a712-cbb82bc6a66a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "59f65e3a-706c-4056-a0bc-c4597e08599e",
                columns: new[] { "ConcurrencyStamp", "DOB", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ec68faac-a5c6-4720-b8f1-47c9b8c275d7", new DateTime(2023, 5, 12, 18, 9, 9, 360, DateTimeKind.Local).AddTicks(4685), "AQAAAAEAACcQAAAAECb8G6aLW+cp+zVw+CHIuZRukE3Va5i4ngxfQwD9Km5LLtFjOnXFBs2tDywEsTLxtA==", "8c222496-004a-4a81-8587-ae71333099d2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "DOB", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f247b24a-4fcb-4de3-9be4-91fd9276b08c", new DateTime(2023, 5, 12, 18, 9, 9, 345, DateTimeKind.Local).AddTicks(3906), "AQAAAAEAACcQAAAAEIz3vuFImUqXtWDEIvUrncd3uYUZUWqK8di4WjiuhTCiphBqmOdCyoKaBg9wIr+IBQ==", "60deacc2-b113-44c8-a132-4c2004307d81" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "afa4728b-351f-4e2c-a903-3c80e77848e7",
                columns: new[] { "ConcurrencyStamp", "DOB", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b8330ab4-c9b7-4ca6-bef3-a76e0eaf1d0b", new DateTime(2023, 5, 12, 18, 9, 9, 352, DateTimeKind.Local).AddTicks(6791), "AQAAAAEAACcQAAAAECfjN7llarr21F36ioetx8iCqvjTQTbAE7Ok0ax2SkzIgzxalggwEl5Ukd/9XNeB3g==", "84a16ea1-ea8e-4b2d-849b-34b685638403" });
        }
    }
}
