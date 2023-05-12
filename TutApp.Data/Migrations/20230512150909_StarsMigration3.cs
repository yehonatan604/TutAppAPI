using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TutApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class StarsMigration3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stars_AspNetUsers_UserId1",
                table: "Stars");

            migrationBuilder.DropIndex(
                name: "IX_Stars_UserId1",
                table: "Stars");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Stars");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Stars",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.CreateIndex(
                name: "IX_Stars_UserId",
                table: "Stars",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Stars_AspNetUsers_UserId",
                table: "Stars",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stars_AspNetUsers_UserId",
                table: "Stars");

            migrationBuilder.DropIndex(
                name: "IX_Stars_UserId",
                table: "Stars");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Stars",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Stars",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a8a52b2-8c3d-45d2-9fe5-ff01895c5c29",
                column: "ConcurrencyStamp",
                value: "cb5a3600-fd57-46a1-beb3-7fe81363af29");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c32f66ed-c960-4cb7-a468-90662e1fb37a",
                column: "ConcurrencyStamp",
                value: "db261a9c-f5d9-43df-9d49-0fd15981c4a4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ddc1ddb9-2495-40d6-b278-633bc6ca29c6",
                column: "ConcurrencyStamp",
                value: "79fb4beb-0c11-4d69-86bb-b32ecf40426a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41e09971-aa5d-44f2-8dd2-37ab94cb7708",
                columns: new[] { "ConcurrencyStamp", "DOB", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c85fd20-03b7-49c1-b16a-66cfa71c7912", new DateTime(2023, 5, 12, 16, 6, 15, 317, DateTimeKind.Local).AddTicks(3572), "AQAAAAEAACcQAAAAEGYTpHN5xEvttgZ/EG/ku2eCU3vsZJmhnE/mqg41y8C48Gw9WIIv0U0BCdStW/nMIA==", "1bda6c58-8f8e-4c74-b061-38b230866d8c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "59f65e3a-706c-4056-a0bc-c4597e08599e",
                columns: new[] { "ConcurrencyStamp", "DOB", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee66084b-e68e-44dd-97e5-e61b4383f713", new DateTime(2023, 5, 12, 16, 6, 15, 309, DateTimeKind.Local).AddTicks(5889), "AQAAAAEAACcQAAAAEC3OaxvXBXkzZpberKeDIdNV9xjBZuzD3JLusnl6uUmcChPW77O85jKBFhZHb9W55g==", "25757067-95f6-42e2-9868-0247cacbf99d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "DOB", "PasswordHash", "SecurityStamp" },
                values: new object[] { "66e1a2ac-a259-47ca-9607-85b9c6e23dff", new DateTime(2023, 5, 12, 16, 6, 15, 294, DateTimeKind.Local).AddTicks(1723), "AQAAAAEAACcQAAAAEOR6fZoeK3p+G7RfPK15rRpdTkMNpY7aNXteUtolkWjT5AeBxDaRJMSL2oXWzgSXBw==", "0c3d1918-bf71-4def-8559-c93504c928c3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "afa4728b-351f-4e2c-a903-3c80e77848e7",
                columns: new[] { "ConcurrencyStamp", "DOB", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3557c878-b838-459b-95a0-1636410c16e4", new DateTime(2023, 5, 12, 16, 6, 15, 301, DateTimeKind.Local).AddTicks(8138), "AQAAAAEAACcQAAAAEOXa8cfdT9XASJ8SDsGq/4HafG4HKbrO5HCHmAyZnW/QPXJIUtLYT+v43lR+cocjBQ==", "16f1fffe-7bcf-4227-b0b2-061153530d66" });

            migrationBuilder.CreateIndex(
                name: "IX_Stars_UserId1",
                table: "Stars",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Stars_AspNetUsers_UserId1",
                table: "Stars",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
