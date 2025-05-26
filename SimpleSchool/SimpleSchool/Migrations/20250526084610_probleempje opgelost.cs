using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimpleSchool.Migrations
{
    /// <inheritdoc />
    public partial class probleempjeopgelost : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 11,
                column: "GeboorteDatum",
                value: new DateTime(2024, 10, 26, 18, 35, 42, 8, DateTimeKind.Local).AddTicks(2602));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 12,
                column: "GeboorteDatum",
                value: new DateTime(2024, 6, 16, 18, 56, 13, 838, DateTimeKind.Local).AddTicks(4192));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 13,
                column: "GeboorteDatum",
                value: new DateTime(2024, 11, 25, 6, 36, 37, 506, DateTimeKind.Local).AddTicks(286));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 14,
                column: "GeboorteDatum",
                value: new DateTime(2024, 11, 3, 22, 50, 17, 946, DateTimeKind.Local).AddTicks(7445));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 15,
                column: "GeboorteDatum",
                value: new DateTime(2024, 8, 29, 0, 14, 5, 129, DateTimeKind.Local).AddTicks(6734));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 16,
                column: "GeboorteDatum",
                value: new DateTime(2024, 8, 29, 0, 58, 19, 945, DateTimeKind.Local).AddTicks(971));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 17,
                column: "GeboorteDatum",
                value: new DateTime(2025, 2, 6, 7, 25, 23, 872, DateTimeKind.Local).AddTicks(3836));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 18,
                column: "GeboorteDatum",
                value: new DateTime(2024, 10, 23, 21, 50, 40, 309, DateTimeKind.Local).AddTicks(688));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 19,
                column: "GeboorteDatum",
                value: new DateTime(2025, 4, 4, 15, 37, 44, 320, DateTimeKind.Local).AddTicks(9614));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 20,
                column: "GeboorteDatum",
                value: new DateTime(2024, 9, 16, 5, 11, 39, 412, DateTimeKind.Local).AddTicks(2583));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 11,
                column: "GeboorteDatum",
                value: new DateTime(2024, 9, 27, 22, 40, 2, 55, DateTimeKind.Local).AddTicks(254));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 12,
                column: "GeboorteDatum",
                value: new DateTime(2024, 10, 9, 23, 18, 58, 364, DateTimeKind.Local).AddTicks(1080));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 13,
                column: "GeboorteDatum",
                value: new DateTime(2024, 7, 1, 7, 16, 19, 55, DateTimeKind.Local).AddTicks(3769));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 14,
                column: "GeboorteDatum",
                value: new DateTime(2025, 4, 3, 21, 59, 34, 651, DateTimeKind.Local).AddTicks(2137));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 15,
                column: "GeboorteDatum",
                value: new DateTime(2025, 1, 19, 15, 29, 10, 255, DateTimeKind.Local).AddTicks(1597));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 16,
                column: "GeboorteDatum",
                value: new DateTime(2025, 2, 15, 22, 3, 19, 414, DateTimeKind.Local).AddTicks(4142));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 17,
                column: "GeboorteDatum",
                value: new DateTime(2024, 10, 7, 1, 20, 39, 448, DateTimeKind.Local).AddTicks(3417));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 18,
                column: "GeboorteDatum",
                value: new DateTime(2025, 3, 9, 16, 44, 33, 466, DateTimeKind.Local).AddTicks(7106));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 19,
                column: "GeboorteDatum",
                value: new DateTime(2024, 11, 23, 18, 5, 20, 710, DateTimeKind.Local).AddTicks(2793));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 20,
                column: "GeboorteDatum",
                value: new DateTime(2024, 9, 23, 12, 13, 43, 785, DateTimeKind.Local).AddTicks(1643));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 11,
                column: "GeboorteDatum",
                value: new DateTime(2024, 10, 26, 18, 24, 47, 926, DateTimeKind.Local).AddTicks(1696));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 12,
                column: "GeboorteDatum",
                value: new DateTime(2024, 6, 16, 18, 45, 19, 756, DateTimeKind.Local).AddTicks(3257));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 13,
                column: "GeboorteDatum",
                value: new DateTime(2024, 11, 25, 6, 25, 43, 423, DateTimeKind.Local).AddTicks(9347));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 14,
                column: "GeboorteDatum",
                value: new DateTime(2024, 11, 3, 22, 39, 23, 864, DateTimeKind.Local).AddTicks(6490));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 15,
                column: "GeboorteDatum",
                value: new DateTime(2024, 8, 29, 0, 3, 11, 47, DateTimeKind.Local).AddTicks(5759));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 16,
                column: "GeboorteDatum",
                value: new DateTime(2024, 8, 29, 0, 47, 25, 862, DateTimeKind.Local).AddTicks(9984));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 17,
                column: "GeboorteDatum",
                value: new DateTime(2025, 2, 6, 7, 14, 29, 790, DateTimeKind.Local).AddTicks(2810));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 18,
                column: "GeboorteDatum",
                value: new DateTime(2024, 10, 23, 21, 39, 46, 226, DateTimeKind.Local).AddTicks(9697));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 19,
                column: "GeboorteDatum",
                value: new DateTime(2025, 4, 4, 15, 26, 50, 238, DateTimeKind.Local).AddTicks(8618));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 20,
                column: "GeboorteDatum",
                value: new DateTime(2024, 9, 16, 5, 0, 45, 330, DateTimeKind.Local).AddTicks(1599));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 11,
                column: "GeboorteDatum",
                value: new DateTime(2024, 9, 27, 22, 29, 7, 972, DateTimeKind.Local).AddTicks(9374));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 12,
                column: "GeboorteDatum",
                value: new DateTime(2024, 10, 9, 23, 8, 4, 282, DateTimeKind.Local).AddTicks(234));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 13,
                column: "GeboorteDatum",
                value: new DateTime(2024, 7, 1, 7, 5, 24, 973, DateTimeKind.Local).AddTicks(2896));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 14,
                column: "GeboorteDatum",
                value: new DateTime(2025, 4, 3, 21, 48, 40, 569, DateTimeKind.Local).AddTicks(1205));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 15,
                column: "GeboorteDatum",
                value: new DateTime(2025, 1, 19, 15, 18, 16, 173, DateTimeKind.Local).AddTicks(679));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 16,
                column: "GeboorteDatum",
                value: new DateTime(2025, 2, 15, 21, 52, 25, 332, DateTimeKind.Local).AddTicks(3218));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 17,
                column: "GeboorteDatum",
                value: new DateTime(2024, 10, 7, 1, 9, 45, 366, DateTimeKind.Local).AddTicks(2509));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 18,
                column: "GeboorteDatum",
                value: new DateTime(2025, 3, 9, 16, 33, 39, 384, DateTimeKind.Local).AddTicks(6192));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 19,
                column: "GeboorteDatum",
                value: new DateTime(2024, 11, 23, 17, 54, 26, 628, DateTimeKind.Local).AddTicks(1876));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 20,
                column: "GeboorteDatum",
                value: new DateTime(2024, 9, 23, 12, 2, 49, 703, DateTimeKind.Local).AddTicks(720));
        }
    }
}
