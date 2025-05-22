using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimpleSchool.Migrations
{
    /// <inheritdoc />
    public partial class AddIdentitySupport : Migration
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
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
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
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
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

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Anneplantsoen 764", "dolorem", new DateTime(2025, 1, 3, 6, 37, 43, 148, DateTimeKind.Local).AddTicks(7632), "Daan Groot" });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Lisamarkt 97", "omnis", new DateTime(2024, 11, 27, 19, 15, 14, 663, DateTimeKind.Local).AddTicks(461), "Daan Hendriks" });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Meerrijk 00", "beatae", new DateTime(2025, 4, 23, 10, 32, 53, 328, DateTimeKind.Local).AddTicks(7609), "Amber Berg" });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Bergsteeg 862a", "nemo", new DateTime(2024, 12, 2, 2, 55, 34, 618, DateTimeKind.Local).AddTicks(1649), "Rick Koster" });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Larsplantsoen 1", "magnam", new DateTime(2024, 9, 24, 14, 7, 5, 539, DateTimeKind.Local).AddTicks(3833), "Sophie Bruin" });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Hendriksvelt 53", "tempora", new DateTime(2024, 8, 13, 17, 57, 15, 964, DateTimeKind.Local).AddTicks(9547), "Lotte Heuvel" });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Rickdijk 593 II", "vitae", new DateTime(2024, 6, 15, 2, 37, 30, 725, DateTimeKind.Local).AddTicks(8619), "Anouk Meer" });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Lucasvelt 050 II", "similique", new DateTime(2024, 7, 4, 14, 23, 37, 149, DateTimeKind.Local).AddTicks(9721), "Sanne Dekker" });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Ricksloot 8", "natus", new DateTime(2024, 9, 14, 15, 29, 2, 394, DateTimeKind.Local).AddTicks(757), "Bas Koning" });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Schoutenkade 650", "dolorem", new DateTime(2024, 8, 31, 22, 19, 23, 699, DateTimeKind.Local).AddTicks(111), "Ruben Leeuwen" });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Grootplantsoen 716b", "ut", new DateTime(2024, 7, 25, 0, 50, 19, 40, DateTimeKind.Local).AddTicks(5360), "Anne Dam" });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Bergkade 754 II", "enim", new DateTime(2024, 9, 30, 0, 13, 15, 609, DateTimeKind.Local).AddTicks(3169), "Julia Vliet" });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Jessedijk 0", "harum", new DateTime(2024, 9, 10, 15, 0, 58, 502, DateTimeKind.Local).AddTicks(7149), "Thijs Bruin" });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Maxvelt 3", "numquam", new DateTime(2025, 3, 25, 21, 31, 14, 915, DateTimeKind.Local).AddTicks(7772), "Sophie Vries" });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Dijkstrarijk 642c", "debitis", new DateTime(2024, 8, 31, 0, 52, 26, 740, DateTimeKind.Local).AddTicks(4404), "Fleur Koning" });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Haangracht 354a", "aut", new DateTime(2024, 12, 12, 20, 7, 29, 69, DateTimeKind.Local).AddTicks(283), "Nick Jacobs" });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Veenweg 213 I", "impedit", new DateTime(2025, 4, 10, 11, 25, 32, 355, DateTimeKind.Local).AddTicks(474), "Anne Ruiter" });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Broeksteeg 527b", "qui", new DateTime(2024, 9, 26, 12, 16, 11, 418, DateTimeKind.Local).AddTicks(5224), "Lars Veen" });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Vriesmarkt 382 III", "hic", new DateTime(2025, 3, 6, 21, 48, 25, 471, DateTimeKind.Local).AddTicks(4240), "Ruben Vos" });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Lucaskade 063", "itaque", new DateTime(2024, 10, 3, 13, 26, 6, 834, DateTimeKind.Local).AddTicks(1734), "Johannes Leeuwen" });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Naam" },
                values: new object[] { 386, "Quia sed reprehenderit officiis pariatur illo hic est numquam aliquam.", "A omnis beatae." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Naam" },
                values: new object[] { 353, "Eum voluptas nostrum eos nam ratione rerum autem adipisci itaque.", "Consequatur facere est." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 395, "Voluptatem culpa accusamus nobis velit non blanditiis est voluptates atque.", 3, "Quae harum est." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 207, "Ab eum aliquam rerum incidunt fugit voluptatem itaque amet dolor.", 3, "Ut est totam." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 361, "Quam quia iste et odit nihil aut ipsa harum fugiat.", 4, "Tempora maxime adipisci." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 339, "Blanditiis deleniti aut nesciunt necessitatibus eius vel necessitatibus dolorem vero.", 4, "Quis sequi eum." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 236, "Sit voluptatem facere odit veritatis quibusdam magni tempora nesciunt est.", 4, "Necessitatibus rerum nobis." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Naam" },
                values: new object[] { 372, "A aut quis quos quia placeat harum aperiam quae qui.", "Ipsum repellendus dolorum." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Naam" },
                values: new object[] { 243, "Repellendus adipisci eos qui est aut ea ad officia eveniet.", "Ipsa veniam minus." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 344, "Et possimus voluptas delectus ut aut ex adipisci culpa et.", 4, "Quia magnam tenetur." });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "blanditiis", "Alexander Broek Sr.", "Visser International" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "velit", "Prof. Vince Bakker", "Vermeulen, Graaf and Groot" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "quis", "Bsc Luuk Hoek", "Dam Groep" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "ea", "Moos Jong Sr.", "Vries, Janssen and Schouten" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "ducimus", "Prof. Nikki Jansen", "Meer HRM" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "et", "Prof. Wies Ruiter", "Jong - Haan" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "saepe", "Msc Pien Jacobs", "Janssen - Meer" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "expedita", "Joas Maas I", "Vries ICT" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "sint", "Prof. Nienke Linden", "Smit - Koning" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "inventore", "Prof. Maxim Koning", "Graaf - Meijer" });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal" },
                values: new object[] { 31, "Ashley Ruiter Jr.", "parsing" });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal" },
                values: new object[] { 40, "Mevr. Dr. Olivia Meijer", "Ridge" });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal" },
                values: new object[] { 23, "Emma Klein II", "grid-enabled" });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal" },
                values: new object[] { 32, "Dhr. Evelien Dam", "Unbranded" });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal", "Vaktype" },
                values: new object[] { 26, "Prof. Nikki Leeuwen", "monitor", 0 });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal" },
                values: new object[] { 26, "Mevr. Dr. Lizz Janssen", "Pass" });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal" },
                values: new object[] { 40, "Mevr. Dr. Floor Smit", "Money Market Account" });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal", "Vaktype" },
                values: new object[] { 22, "Dhr. Vive Willems", "IB", 1 });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal", "Vaktype" },
                values: new object[] { 41, "Msc Gideon Boer", "visualize", 1 });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal" },
                values: new object[] { 26, "Hanne Brink IV", "Intelligent" });

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
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Stichtinggracht 79", "maiores", new DateTime(2024, 12, 9, 17, 9, 48, 48, DateTimeKind.Local).AddTicks(4083), "Sunt at sed delectus voluptatibus reprehenderit ut suscipit nesciunt cupiditate recusandae voluptates tenetur sint repellat sed est autem autem laboriosam." });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Roosdijk 3", "suscipit", new DateTime(2024, 8, 26, 19, 46, 33, 165, DateTimeKind.Local).AddTicks(8239), "Quis explicabo ea aspernatur non itaque debitis et velit et voluptatem quia assumenda iste in quis est dolore pariatur eos." });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Graafvelt 949", "perspiciatis", new DateTime(2024, 6, 2, 4, 8, 55, 956, DateTimeKind.Local).AddTicks(9812), "Quis ipsum pariatur voluptatem voluptatum laboriosam officiis molestiae provident consequatur nihil culpa sed omnis non enim tempora numquam tempore et." });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Hendriksmarkt 9", "ut", new DateTime(2025, 2, 28, 19, 59, 57, 36, DateTimeKind.Local).AddTicks(1001), "Laboriosam nihil fugiat natus minima accusantium numquam rerum facilis molestiae soluta ratione facere debitis qui enim sit quia aut ea." });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Daanlaan 751 I", "aut", new DateTime(2025, 4, 27, 14, 44, 55, 516, DateTimeKind.Local).AddTicks(5834), "Voluptatibus qui quasi et repellat sunt totam quisquam maxime iste enim et explicabo laboriosam sunt et placeat illum temporibus tempora." });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Vosplein 97", "ut", new DateTime(2024, 6, 15, 19, 27, 5, 121, DateTimeKind.Local).AddTicks(7066), "Quia qui a dolore ut dolorem ea omnis ratione dolor velit aut cupiditate praesentium ut nemo voluptatem debitis ut et." });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Meijerweg 413 I", "consequatur", new DateTime(2024, 7, 17, 6, 50, 35, 317, DateTimeKind.Local).AddTicks(2525), "Non fugiat libero neque qui aliquid qui ut pariatur iusto maxime rerum maiores libero est vel a corrupti quia consectetur." });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Vriesgracht 853 III", "corrupti", new DateTime(2024, 6, 6, 14, 35, 49, 574, DateTimeKind.Local).AddTicks(1269), "Non rerum eum maiores eius ut maxime earum itaque aut vitae voluptas esse odio modi voluptatem itaque accusamus molestiae accusantium." });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Johanneskade 500c", "quibusdam", new DateTime(2025, 1, 31, 13, 14, 27, 44, DateTimeKind.Local).AddTicks(2808), "Nobis ea nihil molestias molestias odit et alias qui voluptatem quasi sit unde et odit architecto reprehenderit quam id harum." });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Berghof 310a", "omnis", new DateTime(2024, 8, 26, 10, 42, 5, 571, DateTimeKind.Local).AddTicks(4900), "Quis et et qui molestiae soluta laboriosam et recusandae sed occaecati recusandae quam neque a recusandae itaque earum cum eos." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Anneplantsoen 431a", "consequatur", new DateTime(2024, 8, 31, 9, 48, 51, 514, DateTimeKind.Local).AddTicks(7164), "Voluptatem velit dolorem rerum fuga perferendis dolore tempora quia qui hic sed aut hic animi reprehenderit in nisi ab optio." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Semweg 883a", "debitis", new DateTime(2024, 12, 22, 17, 20, 48, 216, DateTimeKind.Local).AddTicks(3896), "Et eius error qui sed natus sed rem quis neque perferendis excepturi vel ex tempora quia et laborum nostrum quasi." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Ricksteeg 239b", "maxime", new DateTime(2024, 10, 11, 12, 50, 44, 397, DateTimeKind.Local).AddTicks(8001), "Expedita autem debitis maiores quia qui iste a maxime eaque consectetur non aut necessitatibus nobis sed et soluta odit voluptas." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Rubenhof 628c", "eligendi", new DateTime(2024, 8, 7, 10, 50, 52, 279, DateTimeKind.Local).AddTicks(9216), "Amet quis sunt alias quas eius harum reprehenderit ratione dolores est optio et magnam aut voluptatum et aut fuga fuga." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Dampark 525c", "error", new DateTime(2024, 12, 2, 20, 21, 57, 268, DateTimeKind.Local).AddTicks(9592), "Veniam ullam rerum possimus at qui ea ut iure laudantium similique eaque provident est consectetur voluptates aut sint qui quaerat." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Hoekplein 953 I", "impedit", new DateTime(2025, 5, 7, 18, 49, 2, 495, DateTimeKind.Local).AddTicks(6748), "Deserunt aperiam qui corporis non aliquid illo odit qui veritatis sed recusandae dolores nesciunt illo maxime nesciunt sed accusamus vero." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Lucashof 194 II", "non", new DateTime(2025, 1, 16, 17, 47, 19, 669, DateTimeKind.Local).AddTicks(1527), "Dolor pariatur id autem officiis sed saepe tempora in voluptas vero est occaecati suscipit eos cupiditate quasi voluptatum quidem laudantium." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Annavelt 32", "adipisci", new DateTime(2024, 9, 24, 16, 49, 44, 147, DateTimeKind.Local).AddTicks(2956), "Soluta aut iste eaque rerum enim adipisci cumque quis occaecati pariatur non quisquam doloremque alias quaerat consectetur accusamus at vero." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Anoukmarkt 740b", "optio", new DateTime(2025, 1, 29, 23, 31, 44, 123, DateTimeKind.Local).AddTicks(7619), "Maiores impedit maxime nemo et nesciunt facere numquam atque qui et voluptas consequatur amet sed et voluptate aut est autem." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Vriesplantsoen 420 I", "voluptas", new DateTime(2024, 10, 7, 1, 48, 41, 737, DateTimeKind.Local).AddTicks(287), "Ut veritatis quo laudantium ullam consequatur odit dolorum illum accusamus dolore ipsa nihil quam maiores non minima consequatur velit totam." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Naam" },
                values: new object[] { 304, "Dolor in voluptas id aut cupiditate tenetur iure officia a minima aut dolor eos ab rerum ratione molestiae minima aut.", "Consequatur incidunt facilis odit nihil et quia perferendis quisquam unde debitis aut quia enim qui est nobis et quis minus." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Naam" },
                values: new object[] { 266, "A et minus aspernatur magni soluta rerum id ex commodi blanditiis soluta iure voluptatem et vel enim voluptatem sit maxime.", "Magni nesciunt delectus excepturi laudantium tenetur adipisci quia rerum nam sunt aut minus corrupti ab dolore omnis est rerum et." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 229, "Nemo qui expedita ab aspernatur accusantium vel sapiente esse dolorum totam ipsam eum doloremque illo similique porro iusto deserunt quo.", 4, "Quas molestiae accusamus dolorem vel eligendi sunt et ipsum blanditiis veniam deleniti repudiandae quibusdam velit quae omnis consequatur qui excepturi." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 241, "Eaque nam aut animi ut ipsum asperiores non est eum et minus culpa voluptate est soluta veniam molestias sed molestiae.", 4, "Similique ut beatae aut voluptas officia qui eum aperiam et velit illum quia ex et qui molestias voluptas deserunt veritatis." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 365, "Quaerat illum eveniet dignissimos omnis non dolores eum quae dicta vero natus minima provident dolore commodi blanditiis et facere vitae.", 3, "Molestiae molestias quam est qui rem esse repudiandae inventore reprehenderit nulla provident pariatur commodi eos esse sapiente dolorem dolorum et." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 246, "Nisi possimus tempore quis vitae sit ipsum animi impedit quia eveniet enim tempore alias ad molestias natus iste distinctio voluptatem.", 3, "Voluptatem quaerat ut reprehenderit rerum eius unde incidunt porro fugit necessitatibus omnis eaque aut dolore animi placeat cumque eligendi quia." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 223, "Ea assumenda et est et dolore voluptas et eos dolores perspiciatis sequi quia esse error commodi voluptas voluptates ab cupiditate.", 3, "Aut non adipisci nemo cupiditate quia veniam facilis laborum possimus aut unde nam sint repudiandae dolor porro mollitia dolores numquam." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Naam" },
                values: new object[] { 274, "Et libero consequatur molestias quibusdam et eius aliquid eum tempora dolorem sed consequuntur qui qui ullam beatae cum nesciunt fugiat.", "Doloribus tenetur ipsam aliquid est facere sunt quos autem delectus nihil dignissimos sed asperiores cupiditate molestiae expedita quibusdam maxime aperiam." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Naam" },
                values: new object[] { 288, "Dolores adipisci minima libero et quasi aut ex quisquam quasi debitis deleniti et odio tenetur et iste libero est vitae.", "Ducimus quia quo aspernatur hic magni necessitatibus dolores impedit ut neque perferendis non et suscipit est ut eos a deserunt." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 270, "Magnam explicabo dolores qui optio saepe eligendi odio qui nostrum voluptatibus consectetur quibusdam ad dolores quia laboriosam ex tenetur ipsum.", 3, "Facilis eos veritatis sequi voluptas molestias sed aut tenetur itaque quisquam similique error aut ipsa sint qui veniam voluptatem illum." });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "nemo", "Mevr. Dr. Noor Smit", "Klein, Vos and Vliet" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "enim", "Emilia Wit Jr.", "Wit Group" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "pariatur", "Amina Klein Jr.", "Hoek - Jong" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "ut", "Sanna Berg I", "Dam, Dijkstra and Groot" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "eos", "Dhr. Valentino Beek", "Wal, Ven and Vermeulen" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "minus", "Dhr. Pleun Groot", "Klein, Bruin and Hoek" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "ut", "Kyan Haan I", "Dijk, Vermeulen and Jacobs" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "consequatur", "Puck Wal I", "Kok B.V." });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "cupiditate", "Jaelynn Leeuwen III", "Vermeulen, Ruiter and Vermeulen" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "reprehenderit", "Skye Bakker II", "Heuvel Maatschappij" });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal" },
                values: new object[] { 47, "Prof. Lex Hendriks", "Club" });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal" },
                values: new object[] { 35, "Mehmet Stichting I", "Jewelery & Electronics" });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal" },
                values: new object[] { 25, "Bsc Maurits Hendriks", "navigate" });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal" },
                values: new object[] { 48, "Isa Vos V", "transmitter" });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal", "Vaktype" },
                values: new object[] { 22, "Mevr. Dr. Emilia Klein", "black", 1 });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal" },
                values: new object[] { 32, "Msc Isabelle Brouwer", "Unbranded Cotton Sausages" });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal" },
                values: new object[] { 25, "Marley Peters Jr.", "Cambridgeshire" });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal", "Vaktype" },
                values: new object[] { 42, "Dhr. Aisha Broek", "bus", 0 });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal", "Vaktype" },
                values: new object[] { 39, "Dhr. Maes Koster", "Persistent", 0 });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal" },
                values: new object[] { 11, "Kyano Brink Jr.", "Gorgeous" });
        }
    }
}
