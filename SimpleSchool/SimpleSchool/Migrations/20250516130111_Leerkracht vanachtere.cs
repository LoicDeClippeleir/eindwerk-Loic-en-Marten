using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SimpleSchool.Migrations
{
    /// <inheritdoc />
    public partial class Leerkrachtvanachtere : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Leerkracht",
                columns: new[] { "Id", "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[,]
                {
                    { 1, "Stijnhof 992 III", "cumque", new DateTime(2025, 4, 18, 5, 36, 2, 377, DateTimeKind.Local).AddTicks(9991), "In eum qui explicabo quod optio harum nesciunt ipsa quo occaecati deserunt nam quo in aut est sunt a omnis." },
                    { 2, "Hendriksstraat 271 I", "quasi", new DateTime(2024, 12, 3, 9, 57, 41, 24, DateTimeKind.Local).AddTicks(8467), "Sapiente deserunt amet fugit placeat voluptates perferendis consequatur quis iusto sint nihil eligendi labore voluptatem enim provident at minima consectetur." },
                    { 3, "Maasplein 5", "necessitatibus", new DateTime(2024, 6, 10, 19, 37, 45, 459, DateTimeKind.Local).AddTicks(2279), "Necessitatibus qui vel officia at sint provident voluptas ipsum architecto tenetur totam sunt at doloribus fuga dolorum laudantium incidunt deserunt." },
                    { 4, "Hoekstraat 98", "et", new DateTime(2025, 5, 1, 19, 26, 44, 106, DateTimeKind.Local).AddTicks(4104), "Voluptas magni inventore voluptatibus dolor recusandae deleniti voluptas dolor non non aliquid et temporibus non nisi assumenda quibusdam in labore." },
                    { 5, "Milansteeg 65", "commodi", new DateTime(2025, 2, 26, 7, 54, 29, 680, DateTimeKind.Local).AddTicks(2271), "Omnis voluptatem qui necessitatibus et et at alias asperiores exercitationem quia nobis sit enim autem ut aliquid dolorem omnis repellat." },
                    { 6, "Nicksteeg 266", "cum", new DateTime(2024, 5, 29, 20, 44, 49, 157, DateTimeKind.Local).AddTicks(1356), "Accusamus fugiat magnam in perspiciatis qui eos dolore est earum dolores adipisci occaecati qui fuga eum odio libero eos qui." },
                    { 7, "Sanderhof 495a", "ipsa", new DateTime(2024, 6, 21, 13, 53, 11, 185, DateTimeKind.Local).AddTicks(1117), "Porro rerum neque vel alias doloribus voluptas suscipit enim voluptas quas praesentium labore eum omnis et reiciendis voluptatem tempore esse." },
                    { 8, "Nielsplantsoen 7", "porro", new DateTime(2025, 1, 29, 13, 55, 20, 231, DateTimeKind.Local).AddTicks(3238), "Esse voluptatem provident cum autem nemo asperiores est atque id quis aliquam illum libero sed et tempore sint quis est." },
                    { 9, "Meijerstraat 71", "fugit", new DateTime(2024, 9, 9, 3, 58, 54, 893, DateTimeKind.Local).AddTicks(283), "Aliquam nihil qui soluta natus doloremque ex earum quia voluptatem ipsa accusamus ipsum tempore rerum eum ut qui aperiam maxime." },
                    { 10, "Stichtingmarkt 259a", "qui", new DateTime(2024, 9, 2, 16, 26, 22, 340, DateTimeKind.Local).AddTicks(3075), "Eveniet delectus ea dolores ea quae similique nesciunt quae voluptatem eos esse autem aperiam non occaecati repudiandae et eos quia." }
                });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Wallaan 900", "sed", new DateTime(2024, 9, 13, 16, 1, 42, 454, DateTimeKind.Local).AddTicks(1678), "Consequatur quas qui ut nostrum maxime dolorum sequi non eaque laudantium non perferendis aspernatur et nam a explicabo excepturi officia." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Boschplantsoen 9", "consequatur", new DateTime(2024, 6, 26, 0, 33, 54, 249, DateTimeKind.Local).AddTicks(7799), "Laborum non saepe consequatur qui accusamus quia optio hic facilis at modi reprehenderit facilis maxime error perspiciatis est magnam dicta." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Jesseplein 122", "voluptas", new DateTime(2025, 1, 13, 8, 9, 8, 220, DateTimeKind.Local).AddTicks(9653), "Et quo assumenda placeat fugit labore non nobis fuga dolores fuga beatae aut ut dolorum nemo aut id soluta omnis." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Lisaplein 202 I", "odio", new DateTime(2024, 8, 4, 22, 49, 45, 853, DateTimeKind.Local).AddTicks(5398), "Est quo cumque ut at modi autem vero et inventore aut voluptas impedit id et dolor esse eos culpa delectus." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Vengracht 888a", "earum", new DateTime(2024, 9, 26, 18, 25, 48, 937, DateTimeKind.Local).AddTicks(7907), "Nisi beatae exercitationem neque maiores pariatur optio quia soluta in sunt delectus qui harum corporis sint voluptas ducimus asperiores beatae." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Koksteeg 976 I", "molestias", new DateTime(2025, 3, 12, 22, 41, 31, 446, DateTimeKind.Local).AddTicks(7422), "Eum sed qui ut suscipit minus dolores provident cum unde aut architecto blanditiis rerum dicta rem aut similique architecto qui." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Amberkade 440 III", "debitis", new DateTime(2024, 5, 27, 23, 0, 3, 997, DateTimeKind.Local).AddTicks(6598), "Voluptates officiis voluptas voluptas accusamus a voluptate rerum voluptatum quis quasi quo expedita perspiciatis et quis quas itaque magni fuga." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Boschrijk 2", "placeat", new DateTime(2025, 4, 1, 12, 26, 19, 248, DateTimeKind.Local).AddTicks(1313), "Vel autem omnis consequatur iusto reprehenderit eos praesentium sit deleniti expedita neque veritatis ut voluptatem quia eum quis maiores voluptate." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Emmasloot 42", "culpa", new DateTime(2025, 4, 11, 20, 6, 18, 290, DateTimeKind.Local).AddTicks(6046), "Odio commodi eos dolorem a laboriosam dolorem aspernatur sint dolores mollitia qui inventore ea et eos alias repellat natus accusamus." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Witpassage 870 I", "ut", new DateTime(2024, 6, 7, 18, 19, 47, 227, DateTimeKind.Local).AddTicks(5111), "Accusamus impedit temporibus ipsa a debitis optio et et accusamus molestias possimus unde iusto ut et explicabo quae saepe nulla." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 368, "Rerum ab odio eligendi est qui ut nesciunt dolorem hic iure et natus maiores repudiandae porro ullam pariatur qui earum.", 3, "Id optio in rerum unde qui dolore culpa esse aut ad sed esse voluptatem laborum voluptates commodi voluptatum esse ut." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 247, "Ipsam et tenetur magni consequatur temporibus ut architecto blanditiis culpa nemo iure nisi veritatis quaerat consequatur numquam quos sed fugiat.", 4, "Deleniti reprehenderit eos incidunt molestiae voluptatum fugit hic aut quisquam odio nulla cumque vitae dolorem velit labore vitae blanditiis cupiditate." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Naam" },
                values: new object[] { 272, "Nesciunt libero et itaque quasi saepe blanditiis pariatur nihil possimus vel nihil amet totam aut consequatur aut dolores totam et.", "Dignissimos voluptatem voluptas numquam aut corporis est perferendis ut dolores officiis itaque et numquam minus rem aut saepe provident est." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 370, "Repellendus vel sunt nisi nemo voluptatem quod quam nesciunt vel soluta in eos sunt omnis cum in adipisci amet dolor.", 4, "Delectus natus eum facere aspernatur voluptates veritatis qui repudiandae quia minus dolor et ducimus sit harum impedit accusantium ex possimus." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 247, "Sint et vel assumenda quos voluptas aut minus nostrum et molestias qui repudiandae ut fugiat error omnis dolorum temporibus voluptates.", 3, "Itaque quidem nihil itaque quia ipsum similique impedit in quae sed vero impedit consequatur vel vel et exercitationem omnis expedita." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Naam" },
                values: new object[] { 324, "Nihil magnam cumque accusantium est ipsum quam tempora error expedita aliquid est odit voluptatum iste qui omnis et omnis dolore.", "Aut placeat nihil magni aliquid soluta nisi repudiandae autem eius voluptatem enim iste enim omnis voluptatem est ut aut quae." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Naam" },
                values: new object[] { 395, "Explicabo voluptatem excepturi nisi rem quos necessitatibus laborum asperiores neque dicta consequuntur optio animi est facere natus maxime qui vitae.", "Error quod asperiores rerum placeat tempore in omnis rerum ut temporibus sint id deleniti tempora totam voluptas magnam doloremque dolor." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Naam" },
                values: new object[] { 398, "Et quibusdam ea quibusdam rerum cum illum qui suscipit hic aperiam aut inventore atque repudiandae consequatur qui non earum delectus.", "Officiis labore commodi et et cumque sit ad nihil similique quis eum ut dolore id exercitationem eos nostrum repudiandae sit." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 336, "Dolores quod corrupti ut non possimus quidem sequi reiciendis omnis nam cupiditate iure sint quis enim quidem et debitis voluptatem.", 4, "Voluptatum dolorem modi sed nobis consectetur quas officiis voluptas officiis fugiat reiciendis quos beatae et tenetur voluptatum distinctio nemo ab." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Naam" },
                values: new object[] { 372, "Cupiditate alias voluptas minima aut quidem rerum qui ut facilis velit aliquid iusto est deserunt totam laudantium et quas natus.", "Assumenda est qui officia rem veritatis reiciendis consequatur est iusto illum repellat est deserunt debitis ratione cum voluptatem velit rerum." });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "a", "Msc Davina Berg", "Dekker, Vries and Brouwer" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "excepturi", "Fleur Bos Sr.", "Boer, Jong and Wal" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "iste", "Bsc Jane Hendriks", "Kok - Hendriks" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "qui", "Dhr. Jara Dijk", "Dekker - Stichting" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "expedita", "Dion Jansen IV", "Vos - Vos" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "quam", "Prof. Rico Dijk", "Haan, Janssen and Jansen" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "aut", "Mevr. Dr. Neeltje Heuvel", "Jong - Kok" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "eveniet", "Faas Hendriks Sr.", "Klein, Bakker and Beek" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "quos", "Mevr. Dr. Siem Beek", "Linden Bank" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "praesentium", "Marly Jong III", "Groot - Visser" });

            migrationBuilder.InsertData(
                table: "Vak",
                columns: new[] { "Id", "AantalStudiePunten", "LeerkrachtId", "Naam", "Taal", "Vaktype" },
                values: new object[,]
                {
                    { 11, 21, 11, "Mevr. Dr. Aylin Jansen", "Grocery & Toys", 1 },
                    { 12, 30, 12, "Kyara Linden II", "Utah", 1 },
                    { 13, 21, 13, "Mevr. Dr. Ninthe Bruin", "forecast", 1 },
                    { 14, 25, 14, "Oliwier Bosch Jr.", "Refined", 1 },
                    { 15, 26, 15, "Scottie Bos Jr.", "invoice", 0 },
                    { 16, 36, 16, "Dhr. Nikodem Jong", "payment", 0 },
                    { 17, 48, 17, "Romy Meijer Sr.", "Aruban Guilder", 1 },
                    { 18, 41, 18, "Prof. Dies Schouten", "Mobility", 1 },
                    { 19, 42, 19, "Christian Leeuwen IV", "bypass", 1 },
                    { 20, 26, 20, "Yves Leeuwen Jr.", "Harbor", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Maasmarkt 903c", "laudantium", new DateTime(2025, 3, 4, 15, 43, 22, 864, DateTimeKind.Local).AddTicks(9159), "Optio velit nesciunt aut suscipit a qui nihil ratione nostrum aut sunt quasi corporis labore et quaerat labore velit quo." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Jongplein 824a", "delectus", new DateTime(2024, 8, 20, 17, 46, 25, 692, DateTimeKind.Local).AddTicks(2056), "Temporibus ratione quibusdam fugit corrupti et odio quas excepturi adipisci laudantium eos officiis qui et et fuga inventore voluptatem rerum." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Roospark 980c", "veritatis", new DateTime(2024, 8, 5, 9, 22, 53, 694, DateTimeKind.Local).AddTicks(7830), "Quasi cum praesentium voluptates id ab explicabo eos voluptatem non dolor quaerat veniam facilis esse consequuntur dignissimos porro nam voluptatibus." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Dekkersloot 799c", "quam", new DateTime(2024, 6, 7, 22, 23, 52, 773, DateTimeKind.Local).AddTicks(1), "Nostrum vitae sit rerum assumenda delectus id qui ipsum dolorem saepe qui vitae blanditiis velit quas eaque qui et minus." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Roosstraat 844", "sint", new DateTime(2025, 3, 15, 13, 49, 13, 173, DateTimeKind.Local).AddTicks(9971), "Blanditiis repellat et facere nihil cupiditate enim odit perferendis totam repellendus repudiandae accusantium ut quod aliquid eos autem numquam modi." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Kevinpassage 00", "aut", new DateTime(2024, 9, 26, 21, 54, 39, 311, DateTimeKind.Local).AddTicks(5140), "Temporibus perspiciatis voluptatem facilis dignissimos expedita recusandae molestiae ducimus eius atque ut tempore eius sit eum enim et ut rem." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Hendriksgracht 297a", "dolores", new DateTime(2024, 6, 29, 12, 55, 26, 867, DateTimeKind.Local).AddTicks(856), "Voluptatem blanditiis quas aut atque maxime vitae quidem ea ullam hic iste et ipsam omnis eum explicabo enim mollitia sed." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Graafsloot 216b", "libero", new DateTime(2024, 10, 22, 2, 56, 51, 28, DateTimeKind.Local).AddTicks(6021), "Ut enim aut iusto repudiandae iusto explicabo in est facilis maiores doloribus eum ipsa quia aut eveniet sit sunt aliquam." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Nielspassage 262a", "quam", new DateTime(2025, 4, 21, 2, 40, 21, 82, DateTimeKind.Local).AddTicks(9204), "Totam qui odio voluptas voluptatem dolores perferendis est maxime enim dolores explicabo aut quam ullam quia voluptas voluptatem accusantium sit." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Nicksloot 413 III", "est", new DateTime(2025, 5, 1, 1, 23, 39, 161, DateTimeKind.Local).AddTicks(6320), "Omnis est inventore ipsum sed enim molestiae eum architecto mollitia perspiciatis at doloremque et minus totam rem ab voluptatum qui." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 330, "Quae qui nesciunt nostrum est consectetur temporibus vel voluptate corrupti iste qui voluptatem quasi ipsa error eligendi fuga aut recusandae.", 4, "Ut expedita repellat et recusandae numquam vitae facilis alias quaerat nostrum quaerat molestias maxime excepturi in et et architecto magni." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 262, "Hic quaerat modi sint aut eos quia esse eaque veniam unde in unde ex qui porro incidunt libero et enim.", 3, "Dolorum quis totam voluptatem qui rem iusto expedita eveniet vitae ab qui assumenda possimus et beatae facilis mollitia ipsam consectetur." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Naam" },
                values: new object[] { 341, "Id debitis quia cum a fugit velit labore laborum non voluptatem nisi debitis autem officia fugiat veniam necessitatibus hic neque.", "Sed et veniam ab exercitationem aut unde harum in nesciunt maxime dolores recusandae dolorem eius in est nobis molestiae sit." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 365, "Voluptatibus qui reprehenderit reiciendis eius consectetur dolorem exercitationem assumenda eos sit maxime nobis rerum itaque voluptas velit minus recusandae non.", 3, "Iusto nemo dolore suscipit consectetur sit autem nemo corporis deleniti blanditiis doloremque sunt quo deserunt eaque assumenda facere quae non." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 366, "Assumenda ducimus atque et architecto dolorem fuga officiis laboriosam dolorem mollitia facere corporis non accusamus nam laborum accusamus consequuntur quia.", 4, "Illo et ipsum deserunt a cumque laudantium in sed libero molestias fugiat blanditiis et pariatur doloremque unde aliquam libero corporis." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Naam" },
                values: new object[] { 336, "Nobis et sed autem sit quos qui natus consectetur quasi error explicabo aut minima ab aut ea non modi sed.", "Omnis voluptas aut necessitatibus ullam totam atque natus autem rerum ut minima nihil repudiandae error et sapiente eos perferendis maxime." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Naam" },
                values: new object[] { 280, "Nobis velit dolores ex aliquid aliquid et occaecati in labore dignissimos ipsa at ut explicabo dolorem hic laboriosam quia corporis.", "Qui in ullam nulla sunt ea laborum et illum voluptate earum qui quis possimus sapiente iste quia sit voluptatem magni." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Naam" },
                values: new object[] { 342, "Ipsam et quibusdam in nemo et libero enim sunt sit aut tempora rerum accusamus et natus quo accusamus deserunt ut.", "Temporibus et omnis ea dolores aut corporis aut et officia ex illo magnam est atque assumenda culpa molestias nostrum tempora." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 300, "Eos recusandae culpa unde inventore dolorem dolor ut molestiae minima est dolore ut rem rerum qui nisi enim aliquam modi.", 3, "Voluptas et voluptatem atque voluptatum iste ut facere qui consequatur ea doloremque nobis commodi molestiae nulla error voluptas qui fugiat." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Naam" },
                values: new object[] { 374, "Et fugiat dolore et reiciendis officiis est adipisci temporibus molestiae totam corrupti vel itaque ipsam rerum odio et non ea.", "Maiores aut excepturi aspernatur fuga placeat qui ipsa eaque voluptate sed laboriosam qui quidem laborum non hic dolorum eius eos." });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "incidunt", "Faye Dam I", "Brink - Ruiter" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "a", "Thiago Kok III", "Boer Groep" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "et", "Dhr. Diede Dijkstra", "Janssen - Vries" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "natus", "Valentijn Meer V", "Graaf - Koster" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "dolores", "Noëlla Haan II", "Jacobs - Janssen" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "mollitia", "Liselotte Klein I", "Brink, Vries and Kok" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "laudantium", "Lux Bruin V", "Brouwer, Bakker and Stichting" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "architecto", "Msc Isa Janssen", "Hendriks - Brink" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "nesciunt", "Mevr. Dr. Benyamin Dijkstra", "Dekker Group" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "et", "Marrit Stichting Jr.", "Vliet, Dijkstra and Vermeulen" });
        }
    }
}
