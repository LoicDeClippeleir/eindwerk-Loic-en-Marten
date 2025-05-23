using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimpleSchool.Migrations
{
    /// <inheritdoc />
    public partial class rollenveranderd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Noapark 5", "et", new DateTime(2024, 10, 23, 22, 32, 14, 287, DateTimeKind.Local).AddTicks(5054), "Jayden Bruin" });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Brouwersteeg 566 I", "dolorem", new DateTime(2024, 6, 13, 22, 52, 46, 117, DateTimeKind.Local).AddTicks(6597), "Johannes Vermeulen" });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Daanplantsoen 742a", "soluta", new DateTime(2024, 11, 22, 10, 33, 9, 785, DateTimeKind.Local).AddTicks(2640), "Maud Wit" });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Petersplein 394c", "voluptatem", new DateTime(2024, 11, 1, 2, 46, 50, 225, DateTimeKind.Local).AddTicks(9819), "Julian Bakker" });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Femkepassage 655a", "dolor", new DateTime(2024, 8, 26, 4, 10, 37, 408, DateTimeKind.Local).AddTicks(9085), "Amber Schouten" });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Boersloot 739a", "vel", new DateTime(2024, 8, 26, 4, 54, 52, 224, DateTimeKind.Local).AddTicks(3315), "Thijs Visser" });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Brinkweg 0", "et", new DateTime(2025, 2, 3, 11, 21, 56, 151, DateTimeKind.Local).AddTicks(6182), "Bas Broek" });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Kostergracht 749 II", "consequatur", new DateTime(2024, 10, 21, 1, 47, 12, 588, DateTimeKind.Local).AddTicks(2990), "Nick Smits" });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Grootpassage 2", "ipsam", new DateTime(2025, 4, 1, 19, 34, 16, 600, DateTimeKind.Local).AddTicks(1970), "Bas Dekker" });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Liekerijk 358b", "ducimus", new DateTime(2024, 9, 13, 9, 8, 11, 691, DateTimeKind.Local).AddTicks(4926), "Jasper Smits" });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Smitsplantsoen 223b", "facere", new DateTime(2024, 9, 25, 2, 36, 34, 334, DateTimeKind.Local).AddTicks(3000), "Tim Meer" });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Larsplantsoen 484 I", "pariatur", new DateTime(2024, 10, 7, 3, 15, 30, 643, DateTimeKind.Local).AddTicks(3794), "Sanne Graaf" });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Grootweg 950 III", "magni", new DateTime(2024, 6, 28, 11, 12, 51, 334, DateTimeKind.Local).AddTicks(6522), "Britt Hendriks" });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Bruinpark 030 I", "est", new DateTime(2025, 4, 1, 1, 56, 6, 930, DateTimeKind.Local).AddTicks(4824), "Julian Brouwer" });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Irispark 164 I", "exercitationem", new DateTime(2025, 1, 16, 19, 25, 42, 534, DateTimeKind.Local).AddTicks(4215), "Femke Ven" });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Julianmarkt 549 I", "et", new DateTime(2025, 2, 13, 1, 59, 51, 693, DateTimeKind.Local).AddTicks(6817), "Sven Meijer" });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Sanderstraat 8", "tenetur", new DateTime(2024, 10, 4, 5, 17, 11, 727, DateTimeKind.Local).AddTicks(6109), "Eva Peters" });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Meijerstraat 257", "aut", new DateTime(2025, 3, 6, 20, 41, 5, 745, DateTimeKind.Local).AddTicks(9792), "Thijs Broek" });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Mulderkade 644", "ut", new DateTime(2024, 11, 20, 22, 1, 52, 989, DateTimeKind.Local).AddTicks(5471), "Stijn Wit" });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Johannesrijk 071a", "quia", new DateTime(2024, 9, 20, 16, 10, 16, 64, DateTimeKind.Local).AddTicks(4273), "Bram Brink" });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Naam" },
                values: new object[] { 332, "Voluptatum suscipit et vel tempore ea quae cum qui dignissimos.", "Quis quisquam ratione." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 320, "Recusandae nihil aut non nihil expedita quisquam laborum qui quae.", 4, "Et saepe ut." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 384, "Ullam nobis occaecati eaque et omnis ullam est inventore a.", 4, "Nulla natus possimus." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 235, "Sed reprehenderit officiis pariatur illo hic est numquam aliquam consequatur.", 4, "Omnis beatae at." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Naam" },
                values: new object[] { 366, "Voluptas nostrum eos nam ratione rerum autem adipisci itaque quae.", "Facere est quae." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Naam" },
                values: new object[] { 230, "Culpa accusamus nobis velit non blanditiis est voluptates atque ut.", "Harum est illo." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 210, "Eum aliquam rerum incidunt fugit voluptatem itaque amet dolor tempora.", 3, "Est totam voluptatem." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 284, "Quia iste et odit nihil aut ipsa harum fugiat quis.", 4, "Maxime adipisci recusandae." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 291, "Deleniti aut nesciunt necessitatibus eius vel necessitatibus dolorem vero necessitatibus.", 4, "Sequi eum et." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 237, "Voluptatem facere odit veritatis quibusdam magni tempora nesciunt est ipsum.", 3, "Rerum nobis et." });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "totam", "Ella Peters Sr.", "Dekker, Broek and Heuvel" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "in", "Prof. Mare Janssen", "Heuvel Group" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "at", "Leon Smits Sr.", "Haan, Visser and Vries" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "pariatur", "Mevr. Dr. Medina Ven", "Meer - Vries" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "officiis", "Dhr. Bob Jansen", "Groot - Bakker" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "itaque", "Prof. Mert Dijk", "Janssen - Heuvel" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "nesciunt", "Jackson Visser IV", "Groot International" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "sit", "Dhr. Oumayra Boer", "Koning N.V." });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "animi", "Prof. Jenna Ruiter", "Janssen, Schouten and Hendriks" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "doloribus", "Britt Heuvel Jr.", "Maas - Janssen" });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal" },
                values: new object[] { 35, "repellendus", "vero" });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal", "Vaktype" },
                values: new object[] { 46, "a", "quos", 0 });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal", "Vaktype" },
                values: new object[] { 40, "quia", "aperiam", 1 });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal" },
                values: new object[] { 33, "quae", "veniam" });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal" },
                values: new object[] { 25, "minus", "repellendus" });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal", "Vaktype" },
                values: new object[] { 15, "adipisci", "est", 0 });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal" },
                values: new object[] { 26, "aut", "officia" });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal", "Vaktype" },
                values: new object[] { 23, "eveniet", "tenetur", 0 });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal", "Vaktype" },
                values: new object[] { 39, "unde", "possimus", 0 });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal" },
                values: new object[] { 49, "voluptas", "aut" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Anneplantsoen 764", "dolorem", new DateTime(2025, 1, 3, 6, 53, 12, 142, DateTimeKind.Local).AddTicks(9031), "Daan Groot" });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Lisamarkt 97", "omnis", new DateTime(2024, 11, 27, 19, 30, 43, 657, DateTimeKind.Local).AddTicks(1910), "Daan Hendriks" });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Meerrijk 00", "beatae", new DateTime(2025, 4, 23, 10, 48, 22, 322, DateTimeKind.Local).AddTicks(8981), "Amber Berg" });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Bergsteeg 862a", "nemo", new DateTime(2024, 12, 2, 3, 11, 3, 612, DateTimeKind.Local).AddTicks(3004), "Rick Koster" });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Larsplantsoen 1", "magnam", new DateTime(2024, 9, 24, 14, 22, 34, 533, DateTimeKind.Local).AddTicks(5250), "Sophie Bruin" });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Hendriksvelt 53", "tempora", new DateTime(2024, 8, 13, 18, 12, 44, 959, DateTimeKind.Local).AddTicks(938), "Lotte Heuvel" });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Rickdijk 593 II", "vitae", new DateTime(2024, 6, 15, 2, 52, 59, 720, DateTimeKind.Local).AddTicks(51), "Anouk Meer" });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Lucasvelt 050 II", "similique", new DateTime(2024, 7, 4, 14, 39, 6, 144, DateTimeKind.Local).AddTicks(1076), "Sanne Dekker" });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Ricksloot 8", "natus", new DateTime(2024, 9, 14, 15, 44, 31, 388, DateTimeKind.Local).AddTicks(2094), "Bas Koning" });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Schoutenkade 650", "dolorem", new DateTime(2024, 8, 31, 22, 34, 52, 693, DateTimeKind.Local).AddTicks(1476), "Ruben Leeuwen" });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Grootplantsoen 716b", "ut", new DateTime(2024, 7, 25, 1, 5, 48, 34, DateTimeKind.Local).AddTicks(7321), "Anne Dam" });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Bergkade 754 II", "enim", new DateTime(2024, 9, 30, 0, 28, 44, 603, DateTimeKind.Local).AddTicks(5016), "Julia Vliet" });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Jessedijk 0", "harum", new DateTime(2024, 9, 10, 15, 16, 27, 496, DateTimeKind.Local).AddTicks(8966), "Thijs Bruin" });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Maxvelt 3", "numquam", new DateTime(2025, 3, 25, 21, 46, 43, 909, DateTimeKind.Local).AddTicks(9654), "Sophie Vries" });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Dijkstrarijk 642c", "debitis", new DateTime(2024, 8, 31, 1, 7, 55, 734, DateTimeKind.Local).AddTicks(6242), "Fleur Koning" });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Haangracht 354a", "aut", new DateTime(2024, 12, 12, 20, 22, 58, 63, DateTimeKind.Local).AddTicks(2168), "Nick Jacobs" });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Veenweg 213 I", "impedit", new DateTime(2025, 4, 10, 11, 41, 1, 349, DateTimeKind.Local).AddTicks(2314), "Anne Ruiter" });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Broeksteeg 527b", "qui", new DateTime(2024, 9, 26, 12, 31, 40, 412, DateTimeKind.Local).AddTicks(7009), "Lars Veen" });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Vriesmarkt 382 III", "hic", new DateTime(2025, 3, 6, 22, 3, 54, 465, DateTimeKind.Local).AddTicks(6054), "Ruben Vos" });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Lucaskade 063", "itaque", new DateTime(2024, 10, 3, 13, 41, 35, 828, DateTimeKind.Local).AddTicks(3494), "Johannes Leeuwen" });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Naam" },
                values: new object[] { 386, "Quia sed reprehenderit officiis pariatur illo hic est numquam aliquam.", "A omnis beatae." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 353, "Eum voluptas nostrum eos nam ratione rerum autem adipisci itaque.", 3, "Consequatur facere est." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 395, "Voluptatem culpa accusamus nobis velit non blanditiis est voluptates atque.", 3, "Quae harum est." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 207, "Ab eum aliquam rerum incidunt fugit voluptatem itaque amet dolor.", 3, "Ut est totam." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Naam" },
                values: new object[] { 361, "Quam quia iste et odit nihil aut ipsa harum fugiat.", "Tempora maxime adipisci." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Naam" },
                values: new object[] { 339, "Blanditiis deleniti aut nesciunt necessitatibus eius vel necessitatibus dolorem vero.", "Quis sequi eum." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 236, "Sit voluptatem facere odit veritatis quibusdam magni tempora nesciunt est.", 4, "Necessitatibus rerum nobis." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 372, "A aut quis quos quia placeat harum aperiam quae qui.", 3, "Ipsum repellendus dolorum." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 243, "Repellendus adipisci eos qui est aut ea ad officia eveniet.", 3, "Ipsa veniam minus." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 344, "Et possimus voluptas delectus ut aut ex adipisci culpa et.", 4, "Quia magnam tenetur." });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "blanditiis", "Alexander Broek Sr.", "Visser International" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "velit", "Prof. Vince Bakker", "Vermeulen, Graaf and Groot" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "quis", "Bsc Luuk Hoek", "Dam Groep" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "ea", "Moos Jong Sr.", "Vries, Janssen and Schouten" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "ducimus", "Prof. Nikki Jansen", "Meer HRM" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "et", "Prof. Wies Ruiter", "Jong - Haan" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "saepe", "Msc Pien Jacobs", "Janssen - Meer" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "expedita", "Joas Maas I", "Vries ICT" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "sint", "Prof. Nienke Linden", "Smit - Koning" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "inventore", "Prof. Maxim Koning", "Graaf - Meijer" });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal" },
                values: new object[] { 31, "Ashley Ruiter Jr.", "parsing" });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal", "Vaktype" },
                values: new object[] { 40, "Mevr. Dr. Olivia Meijer", "Ridge", 1 });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal", "Vaktype" },
                values: new object[] { 23, "Emma Klein II", "grid-enabled", 0 });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal" },
                values: new object[] { 32, "Dhr. Evelien Dam", "Unbranded" });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal" },
                values: new object[] { 26, "Prof. Nikki Leeuwen", "monitor" });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal", "Vaktype" },
                values: new object[] { 26, "Mevr. Dr. Lizz Janssen", "Pass", 1 });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal" },
                values: new object[] { 40, "Mevr. Dr. Floor Smit", "Money Market Account" });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal", "Vaktype" },
                values: new object[] { 22, "Dhr. Vive Willems", "IB", 1 });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal", "Vaktype" },
                values: new object[] { 41, "Msc Gideon Boer", "visualize", 1 });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal" },
                values: new object[] { 26, "Hanne Brink IV", "Intelligent" });
        }
    }
}
