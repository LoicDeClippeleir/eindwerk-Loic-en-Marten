using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimpleSchool.Migrations
{
    /// <inheritdoc />
    public partial class admintoegevoegd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 11,
                column: "GeboorteDatum",
                value: new DateTime(2024, 10, 23, 22, 32, 14, 287, DateTimeKind.Local).AddTicks(5054));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 12,
                column: "GeboorteDatum",
                value: new DateTime(2024, 6, 13, 22, 52, 46, 117, DateTimeKind.Local).AddTicks(6597));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 13,
                column: "GeboorteDatum",
                value: new DateTime(2024, 11, 22, 10, 33, 9, 785, DateTimeKind.Local).AddTicks(2640));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 14,
                column: "GeboorteDatum",
                value: new DateTime(2024, 11, 1, 2, 46, 50, 225, DateTimeKind.Local).AddTicks(9819));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 15,
                column: "GeboorteDatum",
                value: new DateTime(2024, 8, 26, 4, 10, 37, 408, DateTimeKind.Local).AddTicks(9085));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 16,
                column: "GeboorteDatum",
                value: new DateTime(2024, 8, 26, 4, 54, 52, 224, DateTimeKind.Local).AddTicks(3315));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 17,
                column: "GeboorteDatum",
                value: new DateTime(2025, 2, 3, 11, 21, 56, 151, DateTimeKind.Local).AddTicks(6182));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 18,
                column: "GeboorteDatum",
                value: new DateTime(2024, 10, 21, 1, 47, 12, 588, DateTimeKind.Local).AddTicks(2990));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 19,
                column: "GeboorteDatum",
                value: new DateTime(2025, 4, 1, 19, 34, 16, 600, DateTimeKind.Local).AddTicks(1970));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 20,
                column: "GeboorteDatum",
                value: new DateTime(2024, 9, 13, 9, 8, 11, 691, DateTimeKind.Local).AddTicks(4926));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 11,
                column: "GeboorteDatum",
                value: new DateTime(2024, 9, 25, 2, 36, 34, 334, DateTimeKind.Local).AddTicks(3000));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 12,
                column: "GeboorteDatum",
                value: new DateTime(2024, 10, 7, 3, 15, 30, 643, DateTimeKind.Local).AddTicks(3794));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 13,
                column: "GeboorteDatum",
                value: new DateTime(2024, 6, 28, 11, 12, 51, 334, DateTimeKind.Local).AddTicks(6522));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 14,
                column: "GeboorteDatum",
                value: new DateTime(2025, 4, 1, 1, 56, 6, 930, DateTimeKind.Local).AddTicks(4824));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 15,
                column: "GeboorteDatum",
                value: new DateTime(2025, 1, 16, 19, 25, 42, 534, DateTimeKind.Local).AddTicks(4215));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 16,
                column: "GeboorteDatum",
                value: new DateTime(2025, 2, 13, 1, 59, 51, 693, DateTimeKind.Local).AddTicks(6817));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 17,
                column: "GeboorteDatum",
                value: new DateTime(2024, 10, 4, 5, 17, 11, 727, DateTimeKind.Local).AddTicks(6109));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 18,
                column: "GeboorteDatum",
                value: new DateTime(2025, 3, 6, 20, 41, 5, 745, DateTimeKind.Local).AddTicks(9792));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 19,
                column: "GeboorteDatum",
                value: new DateTime(2024, 11, 20, 22, 1, 52, 989, DateTimeKind.Local).AddTicks(5471));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 20,
                column: "GeboorteDatum",
                value: new DateTime(2024, 9, 20, 16, 10, 16, 64, DateTimeKind.Local).AddTicks(4273));
        }
    }
}
