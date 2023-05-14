using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TutApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class FinalMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a8a52b2-8c3d-45d2-9fe5-ff01895c5c29",
                column: "ConcurrencyStamp",
                value: "acf68246-ed00-4963-99a2-89e2d99d351c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c32f66ed-c960-4cb7-a468-90662e1fb37a",
                column: "ConcurrencyStamp",
                value: "dc76be62-03e2-4af5-8e87-bb586d951b44");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ddc1ddb9-2495-40d6-b278-633bc6ca29c6",
                column: "ConcurrencyStamp",
                value: "283cd6d1-b4b5-4248-9ddf-31c7e7b9c319");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41e09971-aa5d-44f2-8dd2-37ab94cb7708",
                columns: new[] { "ConcurrencyStamp", "DOB", "PasswordHash", "SecurityStamp" },
                values: new object[] { "153ef6c5-24ed-4a1d-8a60-f8d1610315d9", new DateTime(2023, 5, 14, 13, 17, 27, 163, DateTimeKind.Local).AddTicks(8507), "AQAAAAEAACcQAAAAECDB2crcnPJQHG5E9DCHbouHQa7GK/qIGsDI+Yat8GsEKqFiqKUiLg0w91rgLd8vyw==", "8555f50a-c415-46f1-85fd-887b7ca2e346" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "59f65e3a-706c-4056-a0bc-c4597e08599e",
                columns: new[] { "ConcurrencyStamp", "DOB", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3f6f3851-6d20-4745-ac56-b7778bbe703a", new DateTime(2023, 5, 14, 13, 17, 27, 155, DateTimeKind.Local).AddTicks(6477), "AQAAAAEAACcQAAAAEJABrDlgqNIOjgiHHWnNIxnCqoioQGNFoByBgpgH3F/RXlwUy+Faxi79deDgWQ1Rvw==", "aece2c07-23d0-4992-a01c-6ca420665183" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "DOB", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eaa2f56a-37a2-4dad-a2a2-d1e20b0e20ce", new DateTime(2023, 5, 14, 13, 17, 27, 139, DateTimeKind.Local).AddTicks(7172), "AQAAAAEAACcQAAAAECCNEGsrkgKkjaIttkdEkPpQClbN3SIqdSBH3zdT8/cHEqHK3Z3+GQGoyTqnJ/ay+w==", "72072e97-f383-4449-bccc-8e9ef8a9115d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "afa4728b-351f-4e2c-a903-3c80e77848e7",
                columns: new[] { "ConcurrencyStamp", "DOB", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fca004b9-0f65-4d3d-8c82-a2ada4978abe", new DateTime(2023, 5, 14, 13, 17, 27, 147, DateTimeKind.Local).AddTicks(8291), "AQAAAAEAACcQAAAAEHBCbFKDZ/46Cn5nvkEmmOk4EKWOkvc1rKDDNkMXtkdDrrL95tWoe7CnL/GZursfkA==", "e5cf0f51-df0b-4796-bf32-07b12a31bffe" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "Location",
                value: "https://yehonatan.moravia.co.il/tut/assets/Images/programming1.jpg");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "Location",
                value: "https://yehonatan.moravia.co.il/tut/assets/Images/programming2.jpg");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                column: "Location",
                value: "https://yehonatan.moravia.co.il/tut/assets/Images/programming3.jpg");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                column: "Location",
                value: "https://yehonatan.moravia.co.il/tut/assets/Images/programming4.jpg");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                column: "Location",
                value: "https://yehonatan.moravia.co.il/tut/assets/Images/iot1.jpg");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                column: "Location",
                value: "https://yehonatan.moravia.co.il/tut/assets/Images/iot2.jpg");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                column: "Location",
                value: "https://yehonatan.moravia.co.il/tut/assets/Images/internet1.jpg");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                column: "Location",
                value: "https://yehonatan.moravia.co.il/tut/assets/Images/internet2.jpg");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                column: "Location",
                value: "https://yehonatan.moravia.co.il/tut/assets/Images/internet3.jpg");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13,
                column: "Location",
                value: "https://yehonatan.moravia.co.il/tut/assets/Images/design1.jpg");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14,
                column: "Location",
                value: "https://yehonatan.moravia.co.il/tut/assets/Images/design2.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
