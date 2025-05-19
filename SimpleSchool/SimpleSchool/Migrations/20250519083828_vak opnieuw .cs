using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimpleSchool.Migrations
{
    /// <inheritdoc />
    public partial class vakopnieuw : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 1,
                column: "GeboorteDatum",
                value: new DateTime(2024, 12, 6, 17, 49, 34, 724, DateTimeKind.Local).AddTicks(5972));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 2,
                column: "GeboorteDatum",
                value: new DateTime(2024, 8, 23, 20, 26, 19, 841, DateTimeKind.Local).AddTicks(9946));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 3,
                column: "GeboorteDatum",
                value: new DateTime(2024, 5, 30, 4, 48, 42, 633, DateTimeKind.Local).AddTicks(1492));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 4,
                column: "GeboorteDatum",
                value: new DateTime(2025, 2, 25, 20, 39, 43, 712, DateTimeKind.Local).AddTicks(2671));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 5,
                column: "GeboorteDatum",
                value: new DateTime(2025, 4, 24, 15, 24, 42, 192, DateTimeKind.Local).AddTicks(7523));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 6,
                column: "GeboorteDatum",
                value: new DateTime(2024, 6, 12, 20, 6, 51, 797, DateTimeKind.Local).AddTicks(8738));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 7,
                column: "GeboorteDatum",
                value: new DateTime(2024, 7, 14, 7, 30, 21, 993, DateTimeKind.Local).AddTicks(4095));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 8,
                column: "GeboorteDatum",
                value: new DateTime(2024, 6, 3, 15, 15, 36, 250, DateTimeKind.Local).AddTicks(2788));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 9,
                column: "GeboorteDatum",
                value: new DateTime(2025, 1, 28, 13, 54, 13, 720, DateTimeKind.Local).AddTicks(4355));

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 10,
                column: "GeboorteDatum",
                value: new DateTime(2024, 8, 23, 11, 21, 52, 247, DateTimeKind.Local).AddTicks(6453));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 11,
                column: "GeboorteDatum",
                value: new DateTime(2024, 8, 28, 10, 28, 38, 191, DateTimeKind.Local).AddTicks(301));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 12,
                column: "GeboorteDatum",
                value: new DateTime(2024, 12, 19, 18, 0, 34, 892, DateTimeKind.Local).AddTicks(7059));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 13,
                column: "GeboorteDatum",
                value: new DateTime(2024, 10, 8, 13, 30, 31, 74, DateTimeKind.Local).AddTicks(1159));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 14,
                column: "GeboorteDatum",
                value: new DateTime(2024, 8, 4, 11, 30, 38, 956, DateTimeKind.Local).AddTicks(2314));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 15,
                column: "GeboorteDatum",
                value: new DateTime(2024, 11, 29, 21, 1, 43, 945, DateTimeKind.Local).AddTicks(2665));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 16,
                column: "GeboorteDatum",
                value: new DateTime(2025, 5, 4, 19, 28, 49, 171, DateTimeKind.Local).AddTicks(9862));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 17,
                column: "GeboorteDatum",
                value: new DateTime(2025, 1, 13, 18, 27, 6, 345, DateTimeKind.Local).AddTicks(4608));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 18,
                column: "GeboorteDatum",
                value: new DateTime(2024, 9, 21, 17, 29, 30, 823, DateTimeKind.Local).AddTicks(6058));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 19,
                column: "GeboorteDatum",
                value: new DateTime(2025, 1, 27, 0, 11, 30, 800, DateTimeKind.Local).AddTicks(707));

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 20,
                column: "GeboorteDatum",
                value: new DateTime(2024, 10, 4, 2, 28, 28, 413, DateTimeKind.Local).AddTicks(3328));
        }
    }
}
