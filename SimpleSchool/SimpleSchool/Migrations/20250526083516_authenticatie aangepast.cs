using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimpleSchool.Migrations
{
    /// <inheritdoc />
    public partial class authenticatieaangepast : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 11,
                column: "GeboorteDatum",
                value: new DateTime(2024, 10, 26, 18, 16, 45, 120, DateTimeKind.Local).AddTicks(8845));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 12,
                column: "GeboorteDatum",
                value: new DateTime(2024, 6, 16, 18, 37, 16, 951, DateTimeKind.Local).AddTicks(348));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 13,
                column: "GeboorteDatum",
                value: new DateTime(2024, 11, 25, 6, 17, 40, 618, DateTimeKind.Local).AddTicks(6459));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 14,
                column: "GeboorteDatum",
                value: new DateTime(2024, 11, 3, 22, 31, 21, 59, DateTimeKind.Local).AddTicks(3640));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 15,
                column: "GeboorteDatum",
                value: new DateTime(2024, 8, 28, 23, 55, 8, 242, DateTimeKind.Local).AddTicks(2866));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 16,
                column: "GeboorteDatum",
                value: new DateTime(2024, 8, 29, 0, 39, 23, 57, DateTimeKind.Local).AddTicks(7145));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 17,
                column: "GeboorteDatum",
                value: new DateTime(2025, 2, 6, 7, 6, 26, 984, DateTimeKind.Local).AddTicks(9946));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 18,
                column: "GeboorteDatum",
                value: new DateTime(2024, 10, 23, 21, 31, 43, 421, DateTimeKind.Local).AddTicks(6784));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 19,
                column: "GeboorteDatum",
                value: new DateTime(2025, 4, 4, 15, 18, 47, 433, DateTimeKind.Local).AddTicks(5722));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 20,
                column: "GeboorteDatum",
                value: new DateTime(2024, 9, 16, 4, 52, 42, 524, DateTimeKind.Local).AddTicks(8644));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 11,
                column: "GeboorteDatum",
                value: new DateTime(2024, 9, 27, 22, 21, 5, 167, DateTimeKind.Local).AddTicks(6519));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 12,
                column: "GeboorteDatum",
                value: new DateTime(2024, 10, 9, 23, 0, 1, 476, DateTimeKind.Local).AddTicks(7356));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 13,
                column: "GeboorteDatum",
                value: new DateTime(2024, 7, 1, 6, 57, 22, 168, DateTimeKind.Local).AddTicks(82));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 14,
                column: "GeboorteDatum",
                value: new DateTime(2025, 4, 3, 21, 40, 37, 763, DateTimeKind.Local).AddTicks(8355));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 15,
                column: "GeboorteDatum",
                value: new DateTime(2025, 1, 19, 15, 10, 13, 367, DateTimeKind.Local).AddTicks(7798));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 16,
                column: "GeboorteDatum",
                value: new DateTime(2025, 2, 15, 21, 44, 22, 527, DateTimeKind.Local).AddTicks(360));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 17,
                column: "GeboorteDatum",
                value: new DateTime(2024, 10, 7, 1, 1, 42, 560, DateTimeKind.Local).AddTicks(9587));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 18,
                column: "GeboorteDatum",
                value: new DateTime(2025, 3, 9, 16, 25, 36, 579, DateTimeKind.Local).AddTicks(3306));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 19,
                column: "GeboorteDatum",
                value: new DateTime(2024, 11, 23, 17, 46, 23, 822, DateTimeKind.Local).AddTicks(8945));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 20,
                column: "GeboorteDatum",
                value: new DateTime(2024, 9, 23, 11, 54, 46, 897, DateTimeKind.Local).AddTicks(7855));
        }
    }
}
