using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TutApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class StarsMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Stars",
                value: 0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Stars",
                value: 5);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a8a52b2-8c3d-45d2-9fe5-ff01895c5c29",
                column: "ConcurrencyStamp",
                value: "169a328e-dc27-4523-a2b9-d882ab345bb7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c32f66ed-c960-4cb7-a468-90662e1fb37a",
                column: "ConcurrencyStamp",
                value: "086f69c4-aaac-4466-a526-f5425fe63f0d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ddc1ddb9-2495-40d6-b278-633bc6ca29c6",
                column: "ConcurrencyStamp",
                value: "92312111-981e-4dd1-808f-9f37e3feb602");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41e09971-aa5d-44f2-8dd2-37ab94cb7708",
                columns: new[] { "ConcurrencyStamp", "DOB", "PasswordHash", "SecurityStamp" },
                values: new object[] { "954ce12d-f7f5-4d4c-bcad-11391338c97d", new DateTime(2023, 5, 7, 18, 3, 43, 441, DateTimeKind.Local).AddTicks(4305), "AQAAAAEAACcQAAAAEPq8i2KyZ3O27RYCMTvcEZXyhDJhlmTP80uPfRJj6VrW4OCFkEOzhuDU0Xo9Te51GQ==", "d1668b87-59fd-42cf-bc4d-44b3e354d5a4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "59f65e3a-706c-4056-a0bc-c4597e08599e",
                columns: new[] { "ConcurrencyStamp", "DOB", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb2db691-8781-4d43-b3b9-22bbf0287c74", new DateTime(2023, 5, 7, 18, 3, 43, 434, DateTimeKind.Local).AddTicks(4252), "AQAAAAEAACcQAAAAEJ/BsrwJsxjkumrHWLJ6gihXYdjnXyIgU4Ny42KXMquuI1eRz9diMiAFyKFSCxrr2g==", "60b544eb-8602-4331-9ff4-f2ae01970946" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "DOB", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4543ac5-892b-4530-ae03-4db5ac3e9871", new DateTime(2023, 5, 7, 18, 3, 43, 420, DateTimeKind.Local).AddTicks(8878), "AQAAAAEAACcQAAAAELs3uyeqhKbTN80lhbmK8vJK4bIp8UqNacVtxkCB9qYJnSChYRYD3wQnDZkRWEx+Wg==", "50bfffb7-fd6b-4d6f-aac4-9f0bf5f4196f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "afa4728b-351f-4e2c-a903-3c80e77848e7",
                columns: new[] { "ConcurrencyStamp", "DOB", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a1fd6875-d625-4894-b4f7-4b164f416ead", new DateTime(2023, 5, 7, 18, 3, 43, 427, DateTimeKind.Local).AddTicks(7370), "AQAAAAEAACcQAAAAEFRTcjS6gUbNSIoMKNOObu1m2pf3TzXmBwmwfCP6O/zi2SVbdNEOcNEfd/DoBCYCfg==", "e7acb15b-b9ce-4b18-93bd-9458106af30c" });
        }
    }
}
