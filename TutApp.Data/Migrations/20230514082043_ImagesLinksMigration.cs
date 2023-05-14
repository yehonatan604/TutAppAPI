using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TutApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class ImagesLinksMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a8a52b2-8c3d-45d2-9fe5-ff01895c5c29",
                column: "ConcurrencyStamp",
                value: "31de0832-3595-4c11-a718-47edc36770fe");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c32f66ed-c960-4cb7-a468-90662e1fb37a",
                column: "ConcurrencyStamp",
                value: "5dabb985-04f0-4ed2-b0e9-695171901f1d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ddc1ddb9-2495-40d6-b278-633bc6ca29c6",
                column: "ConcurrencyStamp",
                value: "7791e761-f759-43fb-94a6-f3365f9ec2cb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41e09971-aa5d-44f2-8dd2-37ab94cb7708",
                columns: new[] { "ConcurrencyStamp", "DOB", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f0a194b1-3cf3-4a5f-b508-9841bef51c03", new DateTime(2023, 5, 14, 11, 20, 43, 284, DateTimeKind.Local).AddTicks(8965), "AQAAAAEAACcQAAAAEC6dU2RwMieP9+UnMqv0L0mB5KhJpRkAw8QnP66i575PHlnIFw32uQK1pk/e5PCFCw==", "fa181fd4-0025-4b0e-8adc-830c8928120b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "59f65e3a-706c-4056-a0bc-c4597e08599e",
                columns: new[] { "ConcurrencyStamp", "DOB", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c9a6b466-a8f0-4452-8620-b59ec1ba1e3a", new DateTime(2023, 5, 14, 11, 20, 43, 278, DateTimeKind.Local).AddTicks(570), "AQAAAAEAACcQAAAAEOUK33fjxAWJWBH9Z68HX7RfnnIC+XcUhU8uVo281s2x4YjduNG5ACP+zYX9j5Mx4Q==", "8208afd8-db3c-46e4-a306-2f478d466482" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "DOB", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad691a50-d5a9-4999-a8c6-819e5df7577f", new DateTime(2023, 5, 14, 11, 20, 43, 264, DateTimeKind.Local).AddTicks(4219), "AQAAAAEAACcQAAAAEAyAEQQaF1hPpYsxItPUlewXgZkr5uqJcRPBGLV7fnrrh0a9Mb0ZdT0HP20x4gtFYg==", "b3597f14-2c2d-4d86-ac4d-92d74ec4e7da" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "afa4728b-351f-4e2c-a903-3c80e77848e7",
                columns: new[] { "ConcurrencyStamp", "DOB", "PasswordHash", "SecurityStamp" },
                values: new object[] { "90751bdc-83dc-4ab6-a57d-909a867f0220", new DateTime(2023, 5, 14, 11, 20, 43, 271, DateTimeKind.Local).AddTicks(1217), "AQAAAAEAACcQAAAAELmI+U1sc1dJbk5uk1ijVWIE84mgQ2oJoO8j1in+K0i2iKTCfuoNNQ+GZXdBWkVcRQ==", "475f5e12-3dd7-4925-b207-d96c5babc223" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "Location",
                value: "https://yehonatan.moravia.co.il/tut/assets/Images/programming1.png");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "Location",
                value: "https://yehonatan.moravia.co.il/tut/assets/Images/programming2.png");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                column: "Location",
                value: "https://yehonatan.moravia.co.il/tut/assets/Images/programming3.png");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                column: "Location",
                value: "https://yehonatan.moravia.co.il/tut/assets/Images/programming4.png");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                column: "Location",
                value: "https://yehonatan.moravia.co.il/tut/assets/Images/iot1.png");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                column: "Location",
                value: "https://yehonatan.moravia.co.il/tut/assets/Images/iot2.png");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                column: "Location",
                value: "https://yehonatan.moravia.co.il/tut/assets/Images/internet1.png");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                column: "Location",
                value: "https://yehonatan.moravia.co.il/tut/assets/Images/internet2.png");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                column: "Location",
                value: "https://yehonatan.moravia.co.il/tut/assets/Images/internet3.png");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13,
                column: "Location",
                value: "https://yehonatan.moravia.co.il/tut/assets/Images/design1.png");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14,
                column: "Location",
                value: "https://yehonatan.moravia.co.il/tut/assets/Images/design2.png");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                keyValue: 5,
                column: "Location",
                value: "/tut/assets/Images/iot1.png");

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
    }
}
