using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TutApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class mig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserType = table.Column<int>(type: "int", nullable: false),
                    UserStatus = table.Column<int>(type: "int", nullable: false),
                    HobbiesList = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FavCategoriesList = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutMe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SenderEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReciverEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageId = table.Column<int>(type: "int", nullable: false),
                    category = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Stars = table.Column<int>(type: "int", nullable: false),
                    Views = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Articles_Images_ImageId",
                        column: x => x.ImageId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArticleId = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CommentStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4a8a52b2-8c3d-45d2-9fe5-ff01895c5c29", "169a328e-dc27-4523-a2b9-d882ab345bb7", "User", "USER" },
                    { "c32f66ed-c960-4cb7-a468-90662e1fb37a", "086f69c4-aaac-4466-a526-f5425fe63f0d", "Admin", "ADMIN" },
                    { "ddc1ddb9-2495-40d6-b278-633bc6ca29c6", "92312111-981e-4dd1-808f-9f37e3feb602", "Creator", "CREATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AboutMe", "AccessFailedCount", "ConcurrencyStamp", "DOB", "Email", "EmailConfirmed", "FavCategoriesList", "HobbiesList", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "UserStatus", "UserType" },
                values: new object[,]
                {
                    { "41e09971-aa5d-44f2-8dd2-37ab94cb7708", null, 0, "954ce12d-f7f5-4d4c-bcad-11391338c97d", new DateTime(2023, 5, 7, 18, 3, 43, 441, DateTimeKind.Local).AddTicks(4305), "al@email.com", false, null, null, false, null, "AL@EMAIL.COM", "AL VISS", "123#Abc123", "AQAAAAEAACcQAAAAEPq8i2KyZ3O27RYCMTvcEZXyhDJhlmTP80uPfRJj6VrW4OCFkEOzhuDU0Xo9Te51GQ==", null, false, "d1668b87-59fd-42cf-bc4d-44b3e354d5a4", false, "Al Viss", 1, 2 },
                    { "59f65e3a-706c-4056-a0bc-c4597e08599e", null, 0, "eb2db691-8781-4d43-b3b9-22bbf0287c74", new DateTime(2023, 5, 7, 18, 3, 43, 434, DateTimeKind.Local).AddTicks(4252), "erik@email.com", false, null, null, false, null, "ERIK@EMAIL.COM", "ERIK LEMON", "123#Abc123", "AQAAAAEAACcQAAAAEJ/BsrwJsxjkumrHWLJ6gihXYdjnXyIgU4Ny42KXMquuI1eRz9diMiAFyKFSCxrr2g==", null, false, "60b544eb-8602-4331-9ff4-f2ae01970946", false, "Erik Lemon", 1, 2 },
                    { "8e445865-a24d-4543-a6c6-9443d048cdb9", null, 0, "a4543ac5-892b-4530-ae03-4db5ac3e9871", new DateTime(2023, 5, 7, 18, 3, 43, 420, DateTimeKind.Local).AddTicks(8878), "admin@email.com", true, null, null, false, null, "ADMIN@EMAIL.COM", "ADMIN", "123#Abc123", "AQAAAAEAACcQAAAAELs3uyeqhKbTN80lhbmK8vJK4bIp8UqNacVtxkCB9qYJnSChYRYD3wQnDZkRWEx+Wg==", null, false, "50bfffb7-fd6b-4d6f-aac4-9f0bf5f4196f", false, "Admin", 1, 3 },
                    { "afa4728b-351f-4e2c-a903-3c80e77848e7", null, 0, "a1fd6875-d625-4894-b4f7-4b164f416ead", new DateTime(2023, 5, 7, 18, 3, 43, 427, DateTimeKind.Local).AddTicks(7370), "abed@email.com", false, null, null, false, null, "ABED@EMAIL.COM", "ABED ZUHIL", "123#Abc123", "AQAAAAEAACcQAAAAEFRTcjS6gUbNSIoMKNOObu1m2pf3TzXmBwmwfCP6O/zi2SVbdNEOcNEfd/DoBCYCfg==", null, false, "e7acb15b-b9ce-4b18-93bd-9458106af30c", false, "Abed Zuhil", 1, 2 }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Location", "Title" },
                values: new object[,]
                {
                    { 1, "/assets/Images/programming1.png", "Programming1" },
                    { 2, "/assets/Images/programming2.png", "Programming2" },
                    { 3, "/assets/Images/programming3.png", "Programming3" },
                    { 4, "/assets/Images/programming4.png", "Programming4" },
                    { 5, "/assets/Images/iot1.png", "Iot1" },
                    { 6, "/assets/Images/iot2.png", "Iot2" },
                    { 9, "/assets/Images/internet1.png", "Internet1" },
                    { 10, "/assets/Images/internet2.png", "Internet2" },
                    { 11, "/assets/Images/internet3.png", "Internet3" },
                    { 13, "/assets/Images/design1.png", "Design1" },
                    { 14, "/assets/Images/design2.png", "Design2" }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "Content", "Created", "ImageId", "Stars", "Title", "UserEmail", "Views", "category" },
                values: new object[,]
                {
                    { 1, "*", new DateTime(2021, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 5, "איך להשתמש ב-Github?", "al@email.com", 35643, 0 },
                    { 2, "*", new DateTime(2021, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3, "מה זה תכנות מונחה עצמים?", "al@email.com", 324576, 0 },
                    { 3, "*", new DateTime(2021, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 4, "מבוא לאנגולר", "abed@email.com", 15643, 0 },
                    { 4, "*", new DateTime(2022, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 5, "תכנות אסינכרוני ב-JS", "erik@email.com", 152643, 0 },
                    { 5, "*", new DateTime(2021, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 4, "10 טיפים לבית החכם", "al@email.com", 354342, 2 },
                    { 6, "*", new DateTime(2022, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 2, "איך לתכנת את שואב הדייסון שלכם?", "erik@email.com", 3453, 2 },
                    { 7, "*", new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 1, "התקנת מנעול חכם לבית", "erik@email.com", 5685, 2 },
                    { 8, "*", new DateTime(2020, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 0, "5 מוצרים חכמים לכל בית", "abed@email.com", 124, 2 },
                    { 9, "*", new DateTime(2022, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 5, "איך להתקין חוסם פרסומות בדפדפן?", "abed@email.com", 34564536, 1 },
                    { 10, "*", new DateTime(2022, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 3, "מה זה קוד 404?", "abed@email.com", 45643, 1 },
                    { 11, "*", new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 1, "7 טיפים לגלישה בטוחה באינטרנט", "erik@email.com", 356, 1 },
                    { 12, "*", new DateTime(2022, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 2, "המדריך המלא ל-Gmail", "al@email.com", 27643, 1 },
                    { 13, "*", new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, 5, "איך לעשות רקע שקוף לתמונה?", "abed@email.com", 4565468, 3 },
                    { 14, "*", new DateTime(2021, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, 4, "המדריך המלא ל-Gimp", "abed@email.com", 25643, 3 },
                    { 15, "*", new DateTime(2021, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, 5, "המדריך המלא ל-PhotoShop", "erik@email.com", 5675656, 3 },
                    { 16, "*", new DateTime(2020, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, 0, "איך ליצור תמונות מונפשות?", "al@email.com", 22643, 3 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "ddc1ddb9-2495-40d6-b278-633bc6ca29c6", "41e09971-aa5d-44f2-8dd2-37ab94cb7708" },
                    { "ddc1ddb9-2495-40d6-b278-633bc6ca29c6", "59f65e3a-706c-4056-a0bc-c4597e08599e" },
                    { "c32f66ed-c960-4cb7-a468-90662e1fb37a", "8e445865-a24d-4543-a6c6-9443d048cdb9" },
                    { "ddc1ddb9-2495-40d6-b278-633bc6ca29c6", "afa4728b-351f-4e2c-a903-3c80e77848e7" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_ImageId",
                table: "Articles",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ArticleId",
                table: "Comments",
                column: "ArticleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "Images");
        }
    }
}
