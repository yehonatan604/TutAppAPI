using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TutApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
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
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserType = table.Column<int>(type: "int", nullable: false),
                    UserStatus = table.Column<int>(type: "int", nullable: false),
                    HobbiesList = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FavCategoriesList = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutMe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
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
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SenderId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ReciverId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Messages_AspNetUsers_ReciverId",
                        column: x => x.ReciverId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Messages_AspNetUsers_SenderId",
                        column: x => x.SenderId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
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
                    { "0a5cb87c-b7c2-4d61-a1a9-b11e46f33f0d", "782385d4-cb92-4204-8e59-ac97957633c8", "Creator", "CREATOR" },
                    { "83843b3a-3e36-4623-a866-38ee0aa88771", "9bc2bed4-6316-46cc-8cb2-b5c33dd0d669", "Admin", "ADMIN" },
                    { "e502c544-9d48-41b5-800b-e1815c6e3cd4", "9993dd5d-9275-41bf-adf5-3c67bb44ac1d", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AboutMe", "AccessFailedCount", "ConcurrencyStamp", "DOB", "Email", "EmailConfirmed", "FavCategoriesList", "HobbiesList", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "UserStatus", "UserType" },
                values: new object[,]
                {
                    { "119551e4-adcd-4cee-8b89-7a78417a96ad", null, 0, "1cfdd32e-0364-45c7-807d-fba9ebe53fcc", new DateTime(2023, 1, 20, 19, 31, 24, 865, DateTimeKind.Local).AddTicks(1991), "chan@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "f2e5eb5d-3cff-423b-8f14-d895b32c44a8", false, "Chan Don Ma", 1, 1 },
                    { "351dd825-4fd4-4353-ab00-1136e54b05c0", null, 0, "665a09c8-351c-407e-a264-0c0a0e2ce3d1", new DateTime(2023, 1, 20, 19, 31, 24, 865, DateTimeKind.Local).AddTicks(2009), "donna@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "9b3f8bdf-0ddc-45a9-a75a-e740ef85a5bc", false, "Donna Eyzer", 1, 1 },
                    { "79127fde-874b-4de6-9889-3bca6a200495", null, 0, "a87e427f-7a58-4141-9987-45edc8eb9bf6", new DateTime(2023, 1, 20, 19, 31, 24, 865, DateTimeKind.Local).AddTicks(1963), "melon@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "24c9da65-a6fb-4946-9acc-1f0d52b3a13a", false, "Rickey Melon", 1, 1 },
                    { "a5890a87-fb43-4e05-8c7e-4c2a6d36bfc2", null, 0, "d9271532-3ae1-4246-a46a-8af033289e11", new DateTime(2023, 1, 20, 19, 31, 24, 865, DateTimeKind.Local).AddTicks(1982), "erik@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "0e8db7d6-33fc-4809-9a59-6a5f235cd590", false, "Erik Lemon", 1, 2 },
                    { "c7ef1b9a-446f-4ca8-a8d7-f3a2a6ac22ee", null, 0, "77ab3d58-72ba-405a-959e-3c1fa66932cf", new DateTime(2023, 1, 20, 19, 31, 24, 865, DateTimeKind.Local).AddTicks(1999), "al@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "885bbf76-1248-4483-9b1a-bc5b36b6587a", false, "Al Viss", 1, 2 },
                    { "c8fa182d-6112-4a35-99b1-23abc4c22c18", null, 0, "78290a1a-6aea-49d4-bede-27acc39db748", new DateTime(2023, 1, 20, 19, 31, 24, 865, DateTimeKind.Local).AddTicks(1922), "admin@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "d06624de-78be-4b46-b686-c32e5afc784a", false, "Admin", 1, 3 },
                    { "fcd8c306-359d-4efd-a320-9fe04d2d33b8", null, 0, "491a2cb7-8132-43b0-9da7-f7a1c897dd18", new DateTime(2023, 1, 20, 19, 31, 24, 865, DateTimeKind.Local).AddTicks(1972), "abed@email.com", false, null, null, false, null, null, null, "123#Abc123", null, null, false, "d723cadb-b37f-4005-9ab1-358a54cd7ad5", false, "Abed Zuhil", 1, 2 }
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

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ReciverId",
                table: "Messages",
                column: "ReciverId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_SenderId",
                table: "Messages",
                column: "SenderId");
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
                name: "Articles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Images");
        }
    }
}
