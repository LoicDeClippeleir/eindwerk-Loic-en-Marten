using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimpleSchool.Migrations
{
    /// <inheritdoc />
    public partial class namespaceaangepast : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 1,
                column: "GeboorteDatum",
                value: new DateTime(2024, 12, 9, 13, 42, 23, 779, DateTimeKind.Local).AddTicks(2256));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 2,
                column: "GeboorteDatum",
                value: new DateTime(2024, 8, 26, 16, 19, 8, 896, DateTimeKind.Local).AddTicks(6248));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 3,
                column: "GeboorteDatum",
                value: new DateTime(2024, 6, 2, 0, 41, 31, 687, DateTimeKind.Local).AddTicks(7789));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 4,
                column: "GeboorteDatum",
                value: new DateTime(2025, 2, 28, 16, 32, 32, 766, DateTimeKind.Local).AddTicks(8942));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 5,
                column: "GeboorteDatum",
                value: new DateTime(2025, 4, 27, 11, 17, 31, 247, DateTimeKind.Local).AddTicks(3745));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 6,
                column: "GeboorteDatum",
                value: new DateTime(2024, 6, 15, 15, 59, 40, 852, DateTimeKind.Local).AddTicks(4940));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 7,
                column: "GeboorteDatum",
                value: new DateTime(2024, 7, 17, 3, 23, 11, 48, DateTimeKind.Local).AddTicks(370));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 8,
                column: "GeboorteDatum",
                value: new DateTime(2024, 6, 6, 11, 8, 25, 304, DateTimeKind.Local).AddTicks(9080));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 9,
                column: "GeboorteDatum",
                value: new DateTime(2025, 1, 31, 9, 47, 2, 775, DateTimeKind.Local).AddTicks(590));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 10,
                column: "GeboorteDatum",
                value: new DateTime(2024, 8, 26, 7, 14, 41, 302, DateTimeKind.Local).AddTicks(2657));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 11,
                column: "GeboorteDatum",
                value: new DateTime(2024, 8, 31, 6, 21, 27, 245, DateTimeKind.Local).AddTicks(7556));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 12,
                column: "GeboorteDatum",
                value: new DateTime(2024, 12, 22, 13, 53, 23, 947, DateTimeKind.Local).AddTicks(4201));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 13,
                column: "GeboorteDatum",
                value: new DateTime(2024, 10, 11, 9, 23, 20, 128, DateTimeKind.Local).AddTicks(8260));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 14,
                column: "GeboorteDatum",
                value: new DateTime(2024, 8, 7, 7, 23, 28, 10, DateTimeKind.Local).AddTicks(9482));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 15,
                column: "GeboorteDatum",
                value: new DateTime(2024, 12, 2, 16, 54, 32, 999, DateTimeKind.Local).AddTicks(9851));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 16,
                column: "GeboorteDatum",
                value: new DateTime(2025, 5, 7, 15, 21, 38, 226, DateTimeKind.Local).AddTicks(6989));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 17,
                column: "GeboorteDatum",
                value: new DateTime(2025, 1, 16, 14, 19, 55, 400, DateTimeKind.Local).AddTicks(1698));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 18,
                column: "GeboorteDatum",
                value: new DateTime(2024, 9, 24, 13, 22, 19, 878, DateTimeKind.Local).AddTicks(3103));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 19,
                column: "GeboorteDatum",
                value: new DateTime(2025, 1, 29, 20, 4, 19, 854, DateTimeKind.Local).AddTicks(7737));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 20,
                column: "GeboorteDatum",
                value: new DateTime(2024, 10, 6, 22, 21, 17, 468, DateTimeKind.Local).AddTicks(390));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 1,
                column: "GeboorteDatum",
                value: new DateTime(2024, 12, 9, 13, 19, 42, 477, DateTimeKind.Local).AddTicks(4559));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 2,
                column: "GeboorteDatum",
                value: new DateTime(2024, 8, 26, 15, 56, 27, 594, DateTimeKind.Local).AddTicks(8552));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 3,
                column: "GeboorteDatum",
                value: new DateTime(2024, 6, 2, 0, 18, 50, 386, DateTimeKind.Local).AddTicks(132));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 4,
                column: "GeboorteDatum",
                value: new DateTime(2025, 2, 28, 16, 9, 51, 465, DateTimeKind.Local).AddTicks(1282));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 5,
                column: "GeboorteDatum",
                value: new DateTime(2025, 4, 27, 10, 54, 49, 945, DateTimeKind.Local).AddTicks(6148));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 6,
                column: "GeboorteDatum",
                value: new DateTime(2024, 6, 15, 15, 36, 59, 550, DateTimeKind.Local).AddTicks(7367));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 7,
                column: "GeboorteDatum",
                value: new DateTime(2024, 7, 17, 3, 0, 29, 746, DateTimeKind.Local).AddTicks(2794));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 8,
                column: "GeboorteDatum",
                value: new DateTime(2024, 6, 6, 10, 45, 44, 3, DateTimeKind.Local).AddTicks(1507));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 9,
                column: "GeboorteDatum",
                value: new DateTime(2025, 1, 31, 9, 24, 21, 473, DateTimeKind.Local).AddTicks(2995));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 10,
                column: "GeboorteDatum",
                value: new DateTime(2024, 8, 26, 6, 52, 0, 0, DateTimeKind.Local).AddTicks(5073));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 11,
                column: "GeboorteDatum",
                value: new DateTime(2024, 8, 31, 5, 58, 45, 943, DateTimeKind.Local).AddTicks(8453));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 12,
                column: "GeboorteDatum",
                value: new DateTime(2024, 12, 22, 13, 30, 42, 645, DateTimeKind.Local).AddTicks(5224));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 13,
                column: "GeboorteDatum",
                value: new DateTime(2024, 10, 11, 9, 0, 38, 826, DateTimeKind.Local).AddTicks(9329));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 14,
                column: "GeboorteDatum",
                value: new DateTime(2024, 8, 7, 7, 0, 46, 709, DateTimeKind.Local).AddTicks(524));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 15,
                column: "GeboorteDatum",
                value: new DateTime(2024, 12, 2, 16, 31, 51, 698, DateTimeKind.Local).AddTicks(876));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 16,
                column: "GeboorteDatum",
                value: new DateTime(2025, 5, 7, 14, 58, 56, 924, DateTimeKind.Local).AddTicks(7989));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 17,
                column: "GeboorteDatum",
                value: new DateTime(2025, 1, 16, 13, 57, 14, 98, DateTimeKind.Local).AddTicks(2751));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 18,
                column: "GeboorteDatum",
                value: new DateTime(2024, 9, 24, 12, 59, 38, 576, DateTimeKind.Local).AddTicks(4228));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 19,
                column: "GeboorteDatum",
                value: new DateTime(2025, 1, 29, 19, 41, 38, 552, DateTimeKind.Local).AddTicks(8870));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 20,
                column: "GeboorteDatum",
                value: new DateTime(2024, 10, 6, 21, 58, 36, 166, DateTimeKind.Local).AddTicks(1537));
        }
    }
}
