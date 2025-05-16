using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimpleSchool.Migrations
{
    /// <inheritdoc />
    public partial class fktoegeveogd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Damplein 05", "iste", new DateTime(2025, 1, 12, 15, 0, 10, 34, DateTimeKind.Local).AddTicks(5399), "Porro itaque dolorem ex quod sit vitae debitis officiis quisquam velit atque ipsa enim quia aut rerum consectetur illo officiis." });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Evapassage 523c", "consectetur", new DateTime(2024, 6, 17, 10, 2, 36, 340, DateTimeKind.Local).AddTicks(8459), "Architecto nulla dolore illo nostrum ea possimus occaecati tempore quaerat possimus sit quo quo eveniet facilis placeat quia ipsum aut." });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Finndijk 823", "cupiditate", new DateTime(2024, 7, 24, 7, 25, 57, 248, DateTimeKind.Local).AddTicks(8861), "Consequatur aliquam accusamus quis atque tenetur consequatur et qui fuga velit non dolor nemo temporibus vel totam exercitationem eum laudantium." });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Adres", "GeboorteDatum", "Naam" },
                values: new object[] { "Liekehof 00", new DateTime(2024, 7, 7, 21, 37, 40, 621, DateTimeKind.Local).AddTicks(853), "Cum rerum totam voluptas distinctio eveniet recusandae molestiae repellat totam dignissimos veniam dolorem eos similique aut blanditiis atque saepe commodi." });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Svenplantsoen 2", "ullam", new DateTime(2024, 9, 30, 9, 17, 2, 601, DateTimeKind.Local).AddTicks(7814), "Minus quia ipsam sunt est similique quibusdam eius qui ratione ut laborum molestiae est placeat at non illum qui eum." });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Evamarkt 02", "aperiam", new DateTime(2025, 2, 10, 13, 21, 11, 624, DateTimeKind.Local).AddTicks(6996), "Quia impedit sint omnis fugiat assumenda hic beatae nihil facere commodi soluta perspiciatis atque pariatur veritatis et debitis ut hic." });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Bossloot 318a", "in", new DateTime(2024, 8, 13, 14, 27, 59, 169, DateTimeKind.Local).AddTicks(6475), "Fuga maxime illum dicta quibusdam nesciunt asperiores ipsam iure quasi et quas eveniet vero et inventore explicabo dolor eveniet et." });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Emmarijk 12", "fugiat", new DateTime(2025, 1, 12, 22, 55, 43, 912, DateTimeKind.Local).AddTicks(8257), "Veniam repellendus quibusdam consequatur occaecati reprehenderit adipisci sunt asperiores placeat eius fugit sit et voluptate ut placeat sit iure qui." });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Maxkade 252a", "voluptate", new DateTime(2025, 4, 29, 19, 33, 20, 657, DateTimeKind.Local).AddTicks(2990), "Sunt laboriosam quia adipisci minus cumque facilis delectus nostrum minus accusamus molestiae voluptas enim dolores quia quasi deleniti aspernatur culpa." });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Noapark 1", "nobis", new DateTime(2024, 12, 5, 12, 35, 24, 91, DateTimeKind.Local).AddTicks(6219), "Ut eius aut suscipit qui perspiciatis aliquam aut eos rerum eum ducimus voluptatem modi porro aut corporis tempora id rem." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Maudsteeg 53", "delectus", new DateTime(2024, 6, 10, 5, 44, 59, 650, DateTimeKind.Local).AddTicks(9291), "Impedit eaque ipsum odit amet eligendi laudantium ut delectus et sapiente laborum enim eius mollitia quasi ratione est dignissimos ullam." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Dijkstrastraat 9", "quaerat", new DateTime(2025, 3, 16, 3, 22, 2, 814, DateTimeKind.Local).AddTicks(1354), "Ut nesciunt possimus eveniet dolor deserunt quas ut aut quaerat sunt ipsa eum ut aut excepturi quisquam quod sed totam." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Nielskade 440 III", "est", new DateTime(2025, 1, 31, 14, 44, 47, 764, DateTimeKind.Local).AddTicks(8742), "Et numquam quisquam maxime culpa consequatur dolorem sunt ipsum odit quis neque incidunt in adipisci mollitia molestiae nisi vel omnis." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Isapassage 26", "et", new DateTime(2024, 10, 28, 16, 25, 18, 450, DateTimeKind.Local).AddTicks(5580), "Molestiae nobis laudantium consequatur ducimus aut dicta sunt aut facere cum quos fugit commodi beatae quis aut voluptatem aut vero." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Jaydenplein 395 III", "incidunt", new DateTime(2024, 10, 30, 14, 15, 1, 907, DateTimeKind.Local).AddTicks(8898), "Illum qui omnis ducimus tempora consectetur pariatur qui aut id molestiae et maiores aspernatur maxime illum nihil vel ea accusamus." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Juliasteeg 381", "dolores", new DateTime(2025, 2, 25, 2, 9, 3, 834, DateTimeKind.Local).AddTicks(2697), "Voluptates aliquam nemo itaque beatae laboriosam aliquid architecto sed voluptas quae soluta in ducimus qui fugit corrupti sed et officiis." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Johanneskade 500c", "distinctio", new DateTime(2024, 11, 25, 18, 41, 7, 610, DateTimeKind.Local).AddTicks(9016), "Harum fuga ea mollitia labore et ut saepe velit quia laudantium et nulla qui consectetur culpa quae eum et commodi." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Rubenstraat 764c", "nisi", new DateTime(2024, 8, 29, 23, 25, 28, 671, DateTimeKind.Local).AddTicks(1628), "Minima dolorem expedita dolorem nobis iure pariatur non quia distinctio quis dolorem natus quisquam aliquam fugit et praesentium libero deserunt." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Brouwersteeg 420 III", "qui", new DateTime(2024, 9, 10, 22, 43, 51, 436, DateTimeKind.Local).AddTicks(8008), "Perspiciatis veniam et ut consequatur molestiae rerum non enim ut est fuga natus fugit unde atque voluptas accusantium asperiores occaecati." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Maassteeg 706 II", "illo", new DateTime(2025, 5, 2, 0, 48, 41, 932, DateTimeKind.Local).AddTicks(6935), "Et commodi vel ea fugiat iure laboriosam illum minus et voluptas dolore vel assumenda sapiente id excepturi sed nobis dolores." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Naam" },
                values: new object[] { 207, "Laudantium ipsa quo est cupiditate autem officia sint ipsam facilis pariatur itaque corrupti voluptatum voluptas amet earum optio rerum sed.", "Qui nobis unde commodi aut aut est non accusantium id laudantium qui sed minima mollitia similique minima molestiae iusto voluptatem." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 233, "Modi quam qui consequatur assumenda quo eum voluptatem ab tenetur aut modi molestiae impedit exercitationem recusandae quas in ut nulla.", 4, "Sit soluta quis omnis et magni ut eveniet corporis perspiciatis rerum neque deserunt molestiae iure quibusdam tenetur exercitationem officiis consequatur." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Naam" },
                values: new object[] { 298, "Esse saepe voluptatem accusamus repudiandae quis dolorem ducimus amet repellat est pariatur laborum et a provident deleniti suscipit omnis non.", "Tenetur animi est et amet temporibus nesciunt nihil laboriosam ipsa omnis ullam qui minima expedita eum soluta similique quia facilis." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 346, "Quibusdam sit maxime esse porro consequuntur explicabo labore rerum accusantium aspernatur expedita consequatur pariatur quisquam totam laudantium aut id et.", 3, "Fugiat tempora accusamus reprehenderit itaque exercitationem qui iste ullam aliquid sit rerum ut iusto dolores fugiat animi amet vero rerum." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Naam" },
                values: new object[] { 313, "Nesciunt sit quas ducimus quaerat quo dolorum et aperiam velit nihil est deserunt quos iusto voluptatum occaecati aut sunt sapiente.", "Soluta sunt quis autem eveniet delectus doloremque id consequuntur dolores ut ut eos consequatur quam asperiores saepe qui culpa officia." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Naam" },
                values: new object[] { 220, "Quaerat nesciunt cumque assumenda ipsum magni quas ducimus veniam velit numquam autem modi vel error reiciendis id laboriosam debitis enim.", "Doloribus ea quidem quia sint aut tempora voluptatem nihil sit consequatur saepe quia minus adipisci omnis quia maiores quis mollitia." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Naam" },
                values: new object[] { 278, "Dignissimos dicta ut vel dignissimos quaerat excepturi praesentium aut reprehenderit minus ab aliquid amet ut qui consectetur laborum nostrum repellat.", "Excepturi eum necessitatibus sint ut aut voluptatem quasi dolores ut ad blanditiis tenetur ut magnam totam eveniet rerum tenetur possimus." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 315, "Modi dolores est id vero beatae alias omnis cupiditate facilis doloremque exercitationem ipsam non quia rerum quaerat adipisci reprehenderit excepturi.", 3, "Fuga velit neque aperiam minus voluptas pariatur quaerat nulla quasi repellendus et similique qui excepturi quisquam esse non consectetur rem." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 255, "Maiores temporibus in officia rerum repellat magni harum veritatis quibusdam et quisquam illum nam dolor optio et quidem et sint.", 3, "Quasi modi autem aut aut qui ducimus maiores quisquam voluptatibus ut illum odit autem et explicabo aut nesciunt perferendis similique." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 207, "Nisi enim vero omnis qui necessitatibus quisquam rerum quos nemo delectus minus ipsum molestias nihil voluptatem eum dolorum sit et.", 3, "Et quae pariatur voluptas excepturi et vero voluptatem quos ut modi dicta nesciunt quibusdam amet blanditiis rem qui reiciendis rem." });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "sit", "Yarah Hoek II", "Berg - Boer" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "et", "Tessa Vermeulen II", "Dijkstra, Linden and Beek" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "commodi", "Ilse Linden III", "Schouten B.V." });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "et", "Prof. Nikki Meer", "Peters V.O.F." });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "autem", "Lexi Hoek Jr.", "Beek IT" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "et", "Josh Peters Sr.", "Graaf - Haan" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "dolores", "Mevr. Dr. Bente Schouten", "Willems - Berg" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "consectetur", "Yasin Kok III", "Willems, Bosch and Willems" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "autem", "Matthew Stichting I", "Jong, Koning and Dijk" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "cum", "Dhr. Joes Bakker", "Vermeulen BV" });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal" },
                values: new object[] { 38, "Tristan Stichting IV", "Advanced" });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal" },
                values: new object[] { 13, "Msc Sem Wit", "Dynamic" });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal", "Vaktype" },
                values: new object[] { 47, "Prof. Riff Ruiter", "synergy", 0 });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal" },
                values: new object[] { 12, "Shane Beek Jr.", "Way" });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal", "Vaktype" },
                values: new object[] { 49, "Thijmen Vermeulen I", "Corporate", 0 });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal", "Vaktype" },
                values: new object[] { 28, "Juna Ruiter III", "withdrawal", 1 });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal", "Vaktype" },
                values: new object[] { 24, "Bsc Jake Veen", "Fantastic Concrete Shirt", 1 });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal" },
                values: new object[] { 43, "Anna Peters IV", "regional" });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal", "Vaktype" },
                values: new object[] { 40, "Mevr. Dr. Filip Ven", "Cayman Islands Dollar", 1 });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Naam", "Taal" },
                values: new object[] { "Rana Bosch III", "convergence" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Maasplein 743a", "ut", new DateTime(2025, 2, 17, 11, 23, 17, 48, DateTimeKind.Local).AddTicks(8983), "A et quibusdam id iure maiores id vitae sint omnis cupiditate sunt ut distinctio ipsam sunt aut modi est omnis." });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Maudsteeg 234a", "et", new DateTime(2024, 8, 4, 10, 7, 43, 860, DateTimeKind.Local).AddTicks(2359), "Nam quo labore officiis rerum minima ipsam praesentium voluptatibus non omnis voluptates iste dolores harum qui eius est quas est." });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Brammarkt 320c", "molestiae", new DateTime(2024, 11, 7, 19, 54, 1, 105, DateTimeKind.Local).AddTicks(4104), "Exercitationem est fugit at harum dolorem qui dolorem et officia ipsam facere et magnam doloribus laboriosam molestiae dolorum laboriosam voluptas." });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Adres", "GeboorteDatum", "Naam" },
                values: new object[] { "Nielsrijk 950 I", new DateTime(2025, 1, 16, 4, 24, 0, 338, DateTimeKind.Local).AddTicks(4637), "Nobis totam qui maxime animi eos harum totam laborum excepturi ut necessitatibus voluptatem dolores nam incidunt hic optio quas esse." });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Jessemarkt 309c", "eos", new DateTime(2024, 7, 14, 9, 6, 9, 862, DateTimeKind.Local).AddTicks(176), "Sit consequatur et aut sunt aut praesentium blanditiis voluptas voluptatum earum enim labore aut amet autem corrupti et id dicta." });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Liekeplein 698b", "magni", new DateTime(2025, 2, 6, 23, 48, 43, 955, DateTimeKind.Local).AddTicks(5846), "Atque ut voluptatem voluptatem hic autem et sed sed a ducimus est qui doloribus aperiam nihil quae autem corrupti non." });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Smitsdijk 9", "laudantium", new DateTime(2024, 9, 23, 19, 52, 39, 616, DateTimeKind.Local).AddTicks(2307), "Non voluptas labore voluptates omnis nemo id est sed velit sit ipsam explicabo quia asperiores qui porro voluptatum doloribus consequatur." });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Boschmarkt 436c", "in", new DateTime(2024, 12, 24, 9, 22, 52, 968, DateTimeKind.Local).AddTicks(90), "Quia occaecati odit quod culpa reiciendis dolorem unde soluta voluptas voluptas deleniti voluptatem ea beatae ut harum est praesentium nesciunt." });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Schoutenpark 550 II", "non", new DateTime(2024, 12, 27, 5, 33, 26, 472, DateTimeKind.Local).AddTicks(6347), "Possimus non adipisci molestiae iusto repellendus impedit sit eveniet omnis voluptatem voluptatum praesentium impedit iure itaque sunt maiores tenetur recusandae." });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Hoekplein 760b", "sint", new DateTime(2025, 4, 17, 10, 52, 20, 325, DateTimeKind.Local).AddTicks(7863), "Error veniam voluptatem quis sed laborum laudantium veritatis commodi fugit facere maxime quae temporibus consectetur voluptatem ducimus officiis eum sapiente." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Vlietkade 78", "quis", new DateTime(2024, 12, 29, 3, 30, 49, 351, DateTimeKind.Local).AddTicks(2293), "Et id animi odit voluptates et sunt occaecati adipisci libero voluptas voluptatem enim asperiores ab voluptates quos quaerat earum quam." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Meijerhof 193a", "dolorem", new DateTime(2024, 10, 4, 4, 54, 41, 471, DateTimeKind.Local).AddTicks(8339), "Et nostrum et corrupti in distinctio impedit iste laborum voluptatum aliquid aperiam ut necessitatibus cupiditate molestias expedita aspernatur molestiae cupiditate." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Lotterijk 048a", "aut", new DateTime(2024, 8, 27, 13, 37, 44, 292, DateTimeKind.Local).AddTicks(6017), "Et voluptates officiis nihil quaerat consectetur non rerum fugit voluptatem nisi et soluta at atque ab eum et odio eos." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Lucaslaan 452a", "commodi", new DateTime(2024, 6, 29, 20, 40, 19, 383, DateTimeKind.Local).AddTicks(10), "Culpa cumque non provident eum quas cumque quasi ut repellendus architecto eum est commodi autem ut omnis quia quis hic." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Haanplein 413 II", "enim", new DateTime(2024, 11, 27, 13, 47, 56, 771, DateTimeKind.Local).AddTicks(1252), "Fugit deleniti laborum accusamus voluptatem molestiae eligendi qui omnis debitis blanditiis sunt consequatur ullam quae corrupti dolore sed illo est." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Luukplein 889c", "et", new DateTime(2024, 6, 25, 11, 44, 50, 37, DateTimeKind.Local).AddTicks(6410), "Ipsum aut ipsa maiores eos impedit nemo fugit sit dolores dicta libero qui a voluptas eum neque assumenda quae consequatur." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Lottedijk 624 I", "optio", new DateTime(2025, 5, 3, 23, 56, 13, 188, DateTimeKind.Local).AddTicks(559), "At possimus adipisci ipsam ut rerum possimus quod et impedit dolores est et et ab fugiat et quisquam consequatur et." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Rubensloot 669c", "pariatur", new DateTime(2024, 10, 16, 19, 6, 13, 901, DateTimeKind.Local).AddTicks(4271), "Ab aut laboriosam non blanditiis vero voluptas eum laborum rerum dolor nam ipsa autem dicta inventore in recusandae voluptates voluptatem." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Annaplein 585 III", "maxime", new DateTime(2024, 11, 9, 20, 13, 9, 472, DateTimeKind.Local).AddTicks(4575), "Non modi occaecati mollitia aspernatur quibusdam pariatur totam sit ipsam in alias qui ea dolorem qui et alias est voluptatum." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Britthof 257 I", "labore", new DateTime(2024, 11, 9, 14, 47, 30, 485, DateTimeKind.Local).AddTicks(1654), "Dolor nulla aut eos quia sapiente nulla at et possimus aspernatur necessitatibus et aspernatur eos qui amet sed inventore necessitatibus." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Naam" },
                values: new object[] { 390, "Incidunt consequatur ut cupiditate eius cupiditate voluptates sed suscipit officia incidunt corporis quo id neque debitis consequuntur doloremque velit magnam.", "Voluptatem autem voluptatem quas non quis sunt consequatur libero et dolor aut fugit quibusdam ut in voluptas molestiae dicta praesentium." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 359, "Repudiandae fugiat molestias porro molestiae iure ratione consequatur itaque ratione laboriosam perferendis et et eaque repellat et pariatur tenetur dicta.", 3, "Assumenda quo dolores sint voluptate magnam porro et delectus enim porro quis facilis quia ut ut quo reprehenderit voluptas molestias." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Naam" },
                values: new object[] { 400, "Quidem accusantium aut amet consectetur autem sunt et et laboriosam veniam et sed doloribus quia omnis dolorem minus aut nisi.", "Perferendis ratione animi rerum minima et dolores fugiat nemo perferendis ea ab rerum dolores et cum deleniti reiciendis facilis ad." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 377, "Ut qui similique distinctio sed et consectetur nesciunt animi quia neque consequatur labore ipsa autem reiciendis et et rerum ut.", 4, "Sed enim recusandae rerum quis reprehenderit facere aut possimus hic similique numquam autem ea provident repellendus alias et non nisi." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Naam" },
                values: new object[] { 372, "Et vel excepturi modi sunt et dolor minima non ratione a quo itaque possimus et repellendus rerum maxime ut tenetur.", "Corporis quasi placeat magnam maxime eligendi velit numquam minus error ipsum quo architecto beatae hic aut fugiat quis nihil aperiam." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Naam" },
                values: new object[] { 368, "Tenetur unde sit veritatis corrupti qui dolorum dolor sint enim eum rerum quibusdam iusto voluptas possimus id vero molestiae itaque.", "Omnis dolorem sequi fuga qui voluptatem aut laboriosam rerum aliquid soluta non animi qui a impedit laboriosam odio ullam maxime." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Naam" },
                values: new object[] { 261, "Quas dolor totam alias iure ullam cupiditate nesciunt quibusdam iure error sunt est sed voluptatum itaque voluptatem earum et facilis.", "Ut eveniet unde eaque ratione omnis quia mollitia impedit perspiciatis vel voluptas fugit minus exercitationem alias cumque velit tenetur eligendi." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 266, "Doloremque rerum rerum voluptatem laudantium eos vero quidem possimus pariatur delectus enim officia tempora quasi enim quibusdam accusantium impedit culpa.", 4, "Aliquid molestiae magnam facilis quam rerum amet quae distinctio quia vitae doloremque tenetur eius illum officiis recusandae ut praesentium inventore." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 331, "Omnis aliquam consectetur consequuntur fuga pariatur vero reprehenderit dolores debitis a a voluptatibus eveniet omnis eaque dolores ab doloremque beatae.", 4, "Illum iste delectus voluptates consequatur soluta nam voluptatibus possimus totam laudantium sint dicta reprehenderit consequatur porro qui natus voluptate rerum." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 244, "Esse repellat est delectus quaerat id voluptas velit vero enim eius nemo debitis doloremque aut voluptatem voluptas eveniet dolor voluptatem.", 4, "Nemo est iure enim soluta omnis excepturi similique molestiae ratione consequuntur et suscipit odit aperiam in quia libero excepturi fugiat." });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "ad", "Msc Maurits Beek", "Ruiter - Beek" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "doloribus", "Dhr. Linn Heuvel", "Smit ICT" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "alias", "Msc Collin Maas", "Bosch, Smits and Veen" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "dolorum", "Hugo Wit V", "Koning - Vliet" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "aut", "Elisa Bakker Sr.", "Willems - Jacobs" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "sit", "Vera Beek I", "Smits, Visser and Janssen" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "omnis", "Mevr. Dr. Lucie Ruiter", "Hendriks - Smit" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "doloremque", "Ayman Stichting Jr.", "Visser - Haan" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "nobis", "Mevr. Dr. Revi Dam", "Jansen, Veen and Vos" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "incidunt", "Prof. Féline Graaf", "Jansen B.V." });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal" },
                values: new object[] { 20, "Prof. Safouane Vries", "Leone" });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal" },
                values: new object[] { 18, "Diede Mulder III", "Borders" });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal", "Vaktype" },
                values: new object[] { 22, "Douwe Janssen IV", "Auto Loan Account", 1 });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal" },
                values: new object[] { 35, "Isabeau Berg V", "Ergonomic" });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal", "Vaktype" },
                values: new object[] { 14, "Bsc Lucy Jacobs", "Village", 1 });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal", "Vaktype" },
                values: new object[] { 45, "Jaxx Dam Sr.", "Inlet", 0 });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal", "Vaktype" },
                values: new object[] { 49, "Dhr. Idris Broek", "strategic", 0 });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal" },
                values: new object[] { 18, "Bsc Kaylee Leeuwen", "Berkshire" });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal", "Vaktype" },
                values: new object[] { 20, "Meyra Dekker Sr.", "Open-source", 0 });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Naam", "Taal" },
                values: new object[] { "Dhr. Danilo Wit", "Future" });
        }
    }
}
