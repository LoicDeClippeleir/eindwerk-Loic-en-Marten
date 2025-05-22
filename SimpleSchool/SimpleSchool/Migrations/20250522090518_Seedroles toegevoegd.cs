using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimpleSchool.Migrations
{
    /// <inheritdoc />
    public partial class Seedrolestoegevoegd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 11,
                column: "GeboorteDatum",
                value: new DateTime(2025, 1, 3, 6, 53, 12, 142, DateTimeKind.Local).AddTicks(9031));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 12,
                column: "GeboorteDatum",
                value: new DateTime(2024, 11, 27, 19, 30, 43, 657, DateTimeKind.Local).AddTicks(1910));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 13,
                column: "GeboorteDatum",
                value: new DateTime(2025, 4, 23, 10, 48, 22, 322, DateTimeKind.Local).AddTicks(8981));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 14,
                column: "GeboorteDatum",
                value: new DateTime(2024, 12, 2, 3, 11, 3, 612, DateTimeKind.Local).AddTicks(3004));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 15,
                column: "GeboorteDatum",
                value: new DateTime(2024, 9, 24, 14, 22, 34, 533, DateTimeKind.Local).AddTicks(5250));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 16,
                column: "GeboorteDatum",
                value: new DateTime(2024, 8, 13, 18, 12, 44, 959, DateTimeKind.Local).AddTicks(938));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 17,
                column: "GeboorteDatum",
                value: new DateTime(2024, 6, 15, 2, 52, 59, 720, DateTimeKind.Local).AddTicks(51));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 18,
                column: "GeboorteDatum",
                value: new DateTime(2024, 7, 4, 14, 39, 6, 144, DateTimeKind.Local).AddTicks(1076));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 19,
                column: "GeboorteDatum",
                value: new DateTime(2024, 9, 14, 15, 44, 31, 388, DateTimeKind.Local).AddTicks(2094));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 20,
                column: "GeboorteDatum",
                value: new DateTime(2024, 8, 31, 22, 34, 52, 693, DateTimeKind.Local).AddTicks(1476));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 11,
                column: "GeboorteDatum",
                value: new DateTime(2024, 7, 25, 1, 5, 48, 34, DateTimeKind.Local).AddTicks(7321));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 12,
                column: "GeboorteDatum",
                value: new DateTime(2024, 9, 30, 0, 28, 44, 603, DateTimeKind.Local).AddTicks(5016));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 13,
                column: "GeboorteDatum",
                value: new DateTime(2024, 9, 10, 15, 16, 27, 496, DateTimeKind.Local).AddTicks(8966));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 14,
                column: "GeboorteDatum",
                value: new DateTime(2025, 3, 25, 21, 46, 43, 909, DateTimeKind.Local).AddTicks(9654));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 15,
                column: "GeboorteDatum",
                value: new DateTime(2024, 8, 31, 1, 7, 55, 734, DateTimeKind.Local).AddTicks(6242));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 16,
                column: "GeboorteDatum",
                value: new DateTime(2024, 12, 12, 20, 22, 58, 63, DateTimeKind.Local).AddTicks(2168));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 17,
                column: "GeboorteDatum",
                value: new DateTime(2025, 4, 10, 11, 41, 1, 349, DateTimeKind.Local).AddTicks(2314));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 18,
                column: "GeboorteDatum",
                value: new DateTime(2024, 9, 26, 12, 31, 40, 412, DateTimeKind.Local).AddTicks(7009));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 19,
                column: "GeboorteDatum",
                value: new DateTime(2025, 3, 6, 22, 3, 54, 465, DateTimeKind.Local).AddTicks(6054));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 20,
                column: "GeboorteDatum",
                value: new DateTime(2024, 10, 3, 13, 41, 35, 828, DateTimeKind.Local).AddTicks(3494));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 11,
                column: "GeboorteDatum",
                value: new DateTime(2025, 1, 3, 6, 37, 43, 148, DateTimeKind.Local).AddTicks(7632));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 12,
                column: "GeboorteDatum",
                value: new DateTime(2024, 11, 27, 19, 15, 14, 663, DateTimeKind.Local).AddTicks(461));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 13,
                column: "GeboorteDatum",
                value: new DateTime(2025, 4, 23, 10, 32, 53, 328, DateTimeKind.Local).AddTicks(7609));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 14,
                column: "GeboorteDatum",
                value: new DateTime(2024, 12, 2, 2, 55, 34, 618, DateTimeKind.Local).AddTicks(1649));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 15,
                column: "GeboorteDatum",
                value: new DateTime(2024, 9, 24, 14, 7, 5, 539, DateTimeKind.Local).AddTicks(3833));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 16,
                column: "GeboorteDatum",
                value: new DateTime(2024, 8, 13, 17, 57, 15, 964, DateTimeKind.Local).AddTicks(9547));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 17,
                column: "GeboorteDatum",
                value: new DateTime(2024, 6, 15, 2, 37, 30, 725, DateTimeKind.Local).AddTicks(8619));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 18,
                column: "GeboorteDatum",
                value: new DateTime(2024, 7, 4, 14, 23, 37, 149, DateTimeKind.Local).AddTicks(9721));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 19,
                column: "GeboorteDatum",
                value: new DateTime(2024, 9, 14, 15, 29, 2, 394, DateTimeKind.Local).AddTicks(757));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 20,
                column: "GeboorteDatum",
                value: new DateTime(2024, 8, 31, 22, 19, 23, 699, DateTimeKind.Local).AddTicks(111));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 11,
                column: "GeboorteDatum",
                value: new DateTime(2024, 7, 25, 0, 50, 19, 40, DateTimeKind.Local).AddTicks(5360));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 12,
                column: "GeboorteDatum",
                value: new DateTime(2024, 9, 30, 0, 13, 15, 609, DateTimeKind.Local).AddTicks(3169));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 13,
                column: "GeboorteDatum",
                value: new DateTime(2024, 9, 10, 15, 0, 58, 502, DateTimeKind.Local).AddTicks(7149));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 14,
                column: "GeboorteDatum",
                value: new DateTime(2025, 3, 25, 21, 31, 14, 915, DateTimeKind.Local).AddTicks(7772));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 15,
                column: "GeboorteDatum",
                value: new DateTime(2024, 8, 31, 0, 52, 26, 740, DateTimeKind.Local).AddTicks(4404));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 16,
                column: "GeboorteDatum",
                value: new DateTime(2024, 12, 12, 20, 7, 29, 69, DateTimeKind.Local).AddTicks(283));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 17,
                column: "GeboorteDatum",
                value: new DateTime(2025, 4, 10, 11, 25, 32, 355, DateTimeKind.Local).AddTicks(474));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 18,
                column: "GeboorteDatum",
                value: new DateTime(2024, 9, 26, 12, 16, 11, 418, DateTimeKind.Local).AddTicks(5224));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 19,
                column: "GeboorteDatum",
                value: new DateTime(2025, 3, 6, 21, 48, 25, 471, DateTimeKind.Local).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 20,
                column: "GeboorteDatum",
                value: new DateTime(2024, 10, 3, 13, 26, 6, 834, DateTimeKind.Local).AddTicks(1734));
        }
    }
}
