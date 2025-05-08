using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimpleSchool.Data.Migrations
{
    /// <inheritdoc />
    public partial class Linkenenseedersenfkaerstoegevoegd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OpleidingVak_Opleiding_OpleidingenId",
                table: "OpleidingVak");

            migrationBuilder.DropForeignKey(
                name: "FK_OpleidingVak_Vak_VakkenId",
                table: "OpleidingVak");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OpleidingVak",
                table: "OpleidingVak");

            migrationBuilder.RenameTable(
                name: "OpleidingVak",
                newName: "Opleidingsvakken");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Vak",
                newName: "Vaktype");

            migrationBuilder.RenameIndex(
                name: "IX_OpleidingVak_VakkenId",
                table: "Opleidingsvakken",
                newName: "IX_Opleidingsvakken_VakkenId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Opleidingsvakken",
                table: "Opleidingsvakken",
                columns: new[] { "OpleidingenId", "VakkenId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Opleidingsvakken_Opleiding_OpleidingenId",
                table: "Opleidingsvakken",
                column: "OpleidingenId",
                principalTable: "Opleiding",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Opleidingsvakken_Vak_VakkenId",
                table: "Opleidingsvakken",
                column: "VakkenId",
                principalTable: "Vak",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Opleidingsvakken_Opleiding_OpleidingenId",
                table: "Opleidingsvakken");

            migrationBuilder.DropForeignKey(
                name: "FK_Opleidingsvakken_Vak_VakkenId",
                table: "Opleidingsvakken");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Opleidingsvakken",
                table: "Opleidingsvakken");

            migrationBuilder.RenameTable(
                name: "Opleidingsvakken",
                newName: "OpleidingVak");

            migrationBuilder.RenameColumn(
                name: "Vaktype",
                table: "Vak",
                newName: "Type");

            migrationBuilder.RenameIndex(
                name: "IX_Opleidingsvakken_VakkenId",
                table: "OpleidingVak",
                newName: "IX_OpleidingVak_VakkenId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OpleidingVak",
                table: "OpleidingVak",
                columns: new[] { "OpleidingenId", "VakkenId" });

            migrationBuilder.AddForeignKey(
                name: "FK_OpleidingVak_Opleiding_OpleidingenId",
                table: "OpleidingVak",
                column: "OpleidingenId",
                principalTable: "Opleiding",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OpleidingVak_Vak_VakkenId",
                table: "OpleidingVak",
                column: "VakkenId",
                principalTable: "Vak",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
