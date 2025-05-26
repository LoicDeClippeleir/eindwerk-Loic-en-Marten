using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimpleSchool.Migrations
{
    /// <inheritdoc />
    public partial class apsettingsaangepast : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 11,
                column: "GeboorteDatum",
                value: new DateTime(2024, 10, 26, 18, 51, 46, 561, DateTimeKind.Local).AddTicks(4373));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 12,
                column: "GeboorteDatum",
                value: new DateTime(2024, 6, 16, 19, 12, 18, 391, DateTimeKind.Local).AddTicks(5930));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 13,
                column: "GeboorteDatum",
                value: new DateTime(2024, 11, 25, 6, 52, 42, 59, DateTimeKind.Local).AddTicks(2020));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 14,
                column: "GeboorteDatum",
                value: new DateTime(2024, 11, 3, 23, 6, 22, 499, DateTimeKind.Local).AddTicks(9166));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 15,
                column: "GeboorteDatum",
                value: new DateTime(2024, 8, 29, 0, 30, 9, 682, DateTimeKind.Local).AddTicks(8433));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 16,
                column: "GeboorteDatum",
                value: new DateTime(2024, 8, 29, 1, 14, 24, 498, DateTimeKind.Local).AddTicks(2663));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 17,
                column: "GeboorteDatum",
                value: new DateTime(2025, 2, 6, 7, 41, 28, 425, DateTimeKind.Local).AddTicks(5501));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 18,
                column: "GeboorteDatum",
                value: new DateTime(2024, 10, 23, 22, 6, 44, 862, DateTimeKind.Local).AddTicks(2336));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 19,
                column: "GeboorteDatum",
                value: new DateTime(2025, 4, 4, 15, 53, 48, 874, DateTimeKind.Local).AddTicks(1259));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 20,
                column: "GeboorteDatum",
                value: new DateTime(2024, 9, 16, 5, 27, 43, 965, DateTimeKind.Local).AddTicks(4248));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 11,
                column: "GeboorteDatum",
                value: new DateTime(2024, 9, 27, 22, 56, 6, 608, DateTimeKind.Local).AddTicks(2305));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 12,
                column: "GeboorteDatum",
                value: new DateTime(2024, 10, 9, 23, 35, 2, 917, DateTimeKind.Local).AddTicks(3147));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 13,
                column: "GeboorteDatum",
                value: new DateTime(2024, 7, 1, 7, 32, 23, 608, DateTimeKind.Local).AddTicks(5816));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 14,
                column: "GeboorteDatum",
                value: new DateTime(2025, 4, 3, 22, 15, 39, 204, DateTimeKind.Local).AddTicks(4137));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 15,
                column: "GeboorteDatum",
                value: new DateTime(2025, 1, 19, 15, 45, 14, 808, DateTimeKind.Local).AddTicks(3568));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 16,
                column: "GeboorteDatum",
                value: new DateTime(2025, 2, 15, 22, 19, 23, 967, DateTimeKind.Local).AddTicks(6102));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 17,
                column: "GeboorteDatum",
                value: new DateTime(2024, 10, 7, 1, 36, 44, 1, DateTimeKind.Local).AddTicks(5366));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 18,
                column: "GeboorteDatum",
                value: new DateTime(2025, 3, 9, 17, 0, 38, 19, DateTimeKind.Local).AddTicks(9048));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 19,
                column: "GeboorteDatum",
                value: new DateTime(2024, 11, 23, 18, 21, 25, 263, DateTimeKind.Local).AddTicks(4727));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 20,
                column: "GeboorteDatum",
                value: new DateTime(2024, 9, 23, 12, 29, 48, 338, DateTimeKind.Local).AddTicks(3562));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
