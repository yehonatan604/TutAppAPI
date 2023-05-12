using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TutApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class StarsMigration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArticleId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UserId1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    StarsGiven = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stars_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Stars_AspNetUsers_UserId1",
                        column: x => x.UserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

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
                name: "IX_Stars_ArticleId",
                table: "Stars",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_Stars_UserId1",
                table: "Stars",
                column: "UserId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stars");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a8a52b2-8c3d-45d2-9fe5-ff01895c5c29",
                column: "ConcurrencyStamp",
                value: "263ec2b9-2b2a-460c-982e-654cf8dba7f1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c32f66ed-c960-4cb7-a468-90662e1fb37a",
                column: "ConcurrencyStamp",
                value: "0ae9dbf8-f67f-44f5-930a-11cffacacf75");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ddc1ddb9-2495-40d6-b278-633bc6ca29c6",
                column: "ConcurrencyStamp",
                value: "40c3cae3-882d-4dc1-ad66-fd321f0d9f05");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41e09971-aa5d-44f2-8dd2-37ab94cb7708",
                columns: new[] { "ConcurrencyStamp", "DOB", "PasswordHash", "SecurityStamp" },
                values: new object[] { "569ef362-2ee0-4f6a-9e5c-b395a7249feb", new DateTime(2023, 5, 12, 16, 4, 15, 414, DateTimeKind.Local).AddTicks(9690), "AQAAAAEAACcQAAAAEKJodWCplibYK9GyewQH1QqvS/RGTqcWLcy6KB8Vn7OWeR3d0NbKU4S7RDOVtfhm4g==", "00a992e9-c075-4203-b101-da37676ee7de" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "59f65e3a-706c-4056-a0bc-c4597e08599e",
                columns: new[] { "ConcurrencyStamp", "DOB", "PasswordHash", "SecurityStamp" },
                values: new object[] { "12a36b88-8d90-4934-9b62-f4e18bfec3a8", new DateTime(2023, 5, 12, 16, 4, 15, 407, DateTimeKind.Local).AddTicks(3922), "AQAAAAEAACcQAAAAEFRf0GuL7H/RNaUt1N66GyiMzt8auZUd9RBv5upSuqiIRhMgQ6bFGdnZrQo1/njU4w==", "52d393a1-d5d7-41a9-b107-7d99e3d9ce7c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "DOB", "PasswordHash", "SecurityStamp" },
                values: new object[] { "90726d71-4366-444f-a725-e7dcffae377f", new DateTime(2023, 5, 12, 16, 4, 15, 391, DateTimeKind.Local).AddTicks(8329), "AQAAAAEAACcQAAAAEBv8v7h8U5UojWelqMPx/wQa6zjcNnIxmipWvI+2eHBFfx11v9OlMm9jBuMDrI/6fg==", "f2e10db6-4b0a-40db-b302-227c9d6a05e5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "afa4728b-351f-4e2c-a903-3c80e77848e7",
                columns: new[] { "ConcurrencyStamp", "DOB", "PasswordHash", "SecurityStamp" },
                values: new object[] { "05c82114-6233-460d-a95f-c70e0c6e7a88", new DateTime(2023, 5, 12, 16, 4, 15, 399, DateTimeKind.Local).AddTicks(7563), "AQAAAAEAACcQAAAAEC9v8GU3kY3yhQIzKxvr+aUOJnlTyCYOvHfjp8YV/Ro6xHGwBFDytIXLT+5T4dsFwA==", "ec3cd75f-ced2-4cf0-ac3b-b31d48318a6a" });
        }
    }
}
