using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimpleSchool.Migrations
{
    /// <inheritdoc />
    public partial class leerkrachtrol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 11,
                column: "GeboorteDatum",
                value: new DateTime(2024, 10, 23, 22, 46, 50, 227, DateTimeKind.Local).AddTicks(7472));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 12,
                column: "GeboorteDatum",
                value: new DateTime(2024, 6, 13, 23, 7, 22, 57, DateTimeKind.Local).AddTicks(9006));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 13,
                column: "GeboorteDatum",
                value: new DateTime(2024, 11, 22, 10, 47, 45, 725, DateTimeKind.Local).AddTicks(5053));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 14,
                column: "GeboorteDatum",
                value: new DateTime(2024, 11, 1, 3, 1, 26, 166, DateTimeKind.Local).AddTicks(2268));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 15,
                column: "GeboorteDatum",
                value: new DateTime(2024, 8, 26, 4, 25, 13, 349, DateTimeKind.Local).AddTicks(1494));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 16,
                column: "GeboorteDatum",
                value: new DateTime(2024, 8, 26, 5, 9, 28, 164, DateTimeKind.Local).AddTicks(5793));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 17,
                column: "GeboorteDatum",
                value: new DateTime(2025, 2, 3, 11, 36, 32, 91, DateTimeKind.Local).AddTicks(8627));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 18,
                column: "GeboorteDatum",
                value: new DateTime(2024, 10, 21, 2, 1, 48, 528, DateTimeKind.Local).AddTicks(5431));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 19,
                column: "GeboorteDatum",
                value: new DateTime(2025, 4, 1, 19, 48, 52, 540, DateTimeKind.Local).AddTicks(4399));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 20,
                column: "GeboorteDatum",
                value: new DateTime(2024, 9, 13, 9, 22, 47, 631, DateTimeKind.Local).AddTicks(7317));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 11,
                column: "GeboorteDatum",
                value: new DateTime(2024, 9, 25, 2, 51, 10, 274, DateTimeKind.Local).AddTicks(5318));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 12,
                column: "GeboorteDatum",
                value: new DateTime(2024, 10, 7, 3, 30, 6, 583, DateTimeKind.Local).AddTicks(6092));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 13,
                column: "GeboorteDatum",
                value: new DateTime(2024, 6, 28, 11, 27, 27, 274, DateTimeKind.Local).AddTicks(8840));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 14,
                column: "GeboorteDatum",
                value: new DateTime(2025, 4, 1, 2, 10, 42, 870, DateTimeKind.Local).AddTicks(7200));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 15,
                column: "GeboorteDatum",
                value: new DateTime(2025, 1, 16, 19, 40, 18, 474, DateTimeKind.Local).AddTicks(6600));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 16,
                column: "GeboorteDatum",
                value: new DateTime(2025, 2, 13, 2, 14, 27, 633, DateTimeKind.Local).AddTicks(9173));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 17,
                column: "GeboorteDatum",
                value: new DateTime(2024, 10, 4, 5, 31, 47, 667, DateTimeKind.Local).AddTicks(8396));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 18,
                column: "GeboorteDatum",
                value: new DateTime(2025, 3, 6, 20, 55, 41, 686, DateTimeKind.Local).AddTicks(2112));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 19,
                column: "GeboorteDatum",
                value: new DateTime(2024, 11, 20, 22, 16, 28, 929, DateTimeKind.Local).AddTicks(7784));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 20,
                column: "GeboorteDatum",
                value: new DateTime(2024, 9, 20, 16, 24, 52, 4, DateTimeKind.Local).AddTicks(6585));
        }
    }
}
