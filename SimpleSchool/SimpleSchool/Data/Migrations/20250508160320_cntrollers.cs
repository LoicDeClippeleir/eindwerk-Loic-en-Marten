using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimpleSchool.Data.Migrations
{
    /// <inheritdoc />
    public partial class cntrollers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Leerkracht",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GeboorteDatum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leerkracht", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Opleiding",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duur = table.Column<int>(type: "int", nullable: false),
                    BeschikbarePlaatsen = table.Column<int>(type: "int", nullable: false),
                    Beschrijving = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Opleiding", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StudentenKaart",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Klas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    School = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentenKaart", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vak",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Taal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AantalStudiePunten = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    LeerkrachtId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vak", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vak_Leerkracht_LeerkrachtId",
                        column: x => x.LeerkrachtId,
                        principalTable: "Leerkracht",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Leerling",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GeboorteDatum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentenkaartId = table.Column<int>(type: "int", nullable: false),
                    OpleidingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leerling", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Leerling_Opleiding_OpleidingId",
                        column: x => x.OpleidingId,
                        principalTable: "Opleiding",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Leerling_StudentenKaart_StudentenkaartId",
                        column: x => x.StudentenkaartId,
                        principalTable: "StudentenKaart",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OpleidingVak",
                columns: table => new
                {
                    OpleidingenId = table.Column<int>(type: "int", nullable: false),
                    VakkenId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpleidingVak", x => new { x.OpleidingenId, x.VakkenId });
                    table.ForeignKey(
                        name: "FK_OpleidingVak_Opleiding_OpleidingenId",
                        column: x => x.OpleidingenId,
                        principalTable: "Opleiding",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OpleidingVak_Vak_VakkenId",
                        column: x => x.VakkenId,
                        principalTable: "Vak",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Leerling_OpleidingId",
                table: "Leerling",
                column: "OpleidingId");

            migrationBuilder.CreateIndex(
                name: "IX_Leerling_StudentenkaartId",
                table: "Leerling",
                column: "StudentenkaartId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OpleidingVak_VakkenId",
                table: "OpleidingVak",
                column: "VakkenId");

            migrationBuilder.CreateIndex(
                name: "IX_Vak_LeerkrachtId",
                table: "Vak",
                column: "LeerkrachtId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Leerling");

            migrationBuilder.DropTable(
                name: "OpleidingVak");

            migrationBuilder.DropTable(
                name: "StudentenKaart");

            migrationBuilder.DropTable(
                name: "Opleiding");

            migrationBuilder.DropTable(
                name: "Vak");

            migrationBuilder.DropTable(
                name: "Leerkracht");
        }
    }
}
