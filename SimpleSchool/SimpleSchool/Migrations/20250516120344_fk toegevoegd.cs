using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimpleSchool.Migrations
{
    /// <inheritdoc />
    public partial class fktoegevoegd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Kevinhof 13", "laboriosam", new DateTime(2024, 9, 13, 8, 39, 35, 705, DateTimeKind.Local).AddTicks(942), "Blanditiis nobis blanditiis nemo commodi quis a fugiat quis assumenda aperiam minus hic nihil eos sint voluptatum sint quia id." });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Mikerijk 035b", "laboriosam", new DateTime(2025, 2, 8, 18, 45, 25, 616, DateTimeKind.Local).AddTicks(1203), "Commodi delectus odio labore voluptatem aut soluta aliquam labore dolor deserunt omnis cum eius quis similique quia provident architecto dolorem." });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Thijspassage 7", "sed", new DateTime(2024, 7, 30, 17, 2, 38, 936, DateTimeKind.Local).AddTicks(2955), "Non possimus delectus voluptas soluta esse omnis vel suscipit aut reiciendis unde itaque totam eius et consectetur magni labore pariatur." });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Lisaplantsoen 495b", "deserunt", new DateTime(2025, 2, 16, 2, 53, 23, 988, DateTimeKind.Local).AddTicks(4615), "Qui ratione vero autem est in quos et dolore aut libero et omnis excepturi quo eos facere architecto laborum aut." });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Thomasvelt 072", "quaerat", new DateTime(2024, 8, 18, 20, 42, 28, 498, DateTimeKind.Local).AddTicks(7461), "Ut ut tempora incidunt assumenda tempore explicabo nostrum quaerat reprehenderit at aut magni assumenda aut sit vitae nihil quibusdam id." });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Beekrijk 571b", "quas", new DateTime(2024, 6, 29, 10, 36, 1, 45, DateTimeKind.Local).AddTicks(7621), "Aut sint veritatis ad molestiae enim tenetur voluptatem ea nisi et nihil autem harum quos inventore ut est fugit quasi." });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Boslaan 243b", "repellendus", new DateTime(2025, 4, 13, 6, 0, 41, 350, DateTimeKind.Local).AddTicks(3224), "Ex nulla eaque et atque sed dolore vel possimus consequuntur nobis error quam quia eaque et consequatur beatae quisquam vel." });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Svenrijk 067 I", "et", new DateTime(2024, 11, 11, 23, 8, 47, 854, DateTimeKind.Local).AddTicks(9648), "Ex totam vero et at veritatis nulla sint deleniti fugiat porro velit culpa id a aut similique quidem qui mollitia." });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Brittsteeg 1", "iure", new DateTime(2025, 2, 25, 17, 39, 5, 715, DateTimeKind.Local).AddTicks(178), "Praesentium adipisci est illum velit explicabo consequatur consequatur cum nulla enim illum nihil quos aut dolor modi eum dolor accusamus." });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Janlaan 862 III", "ut", new DateTime(2024, 10, 27, 8, 34, 27, 842, DateTimeKind.Local).AddTicks(8175), "Accusantium sunt natus quos voluptas inventore temporibus eum voluptatem necessitatibus facilis vitae dignissimos nam harum porro vel quia sunt est." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Stijnkade 244 I", "cumque", new DateTime(2024, 6, 25, 21, 27, 54, 764, DateTimeKind.Local).AddTicks(7218), "Occaecati est quis et ipsum quo delectus assumenda eos debitis laudantium natus odit sed facilis sit minima et non ex." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Leeuwenrijk 032 III", "ea", new DateTime(2025, 4, 28, 16, 41, 9, 31, DateTimeKind.Local).AddTicks(3063), "Est deserunt rerum fuga reiciendis blanditiis est incidunt minima tenetur eveniet culpa autem a officiis aut cumque dolores est eos." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Nickrijk 169c", "enim", new DateTime(2025, 3, 16, 18, 11, 42, 246, DateTimeKind.Local).AddTicks(416), "Aliquid et beatae id aut quia consequatur et possimus alias rerum et nostrum excepturi nisi cum illo voluptas perferendis qui." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Visserplantsoen 401 I", "est", new DateTime(2025, 1, 14, 7, 36, 25, 460, DateTimeKind.Local).AddTicks(7802), "Accusantium omnis suscipit dolore quaerat commodi qui quibusdam dolor eligendi dolorem vitae placeat recusandae omnis cum accusamus quis voluptatem debitis." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Finnsloot 528 II", "officia", new DateTime(2024, 10, 26, 8, 45, 36, 342, DateTimeKind.Local).AddTicks(4441), "Unde quia delectus tenetur nostrum id inventore perferendis animi fugiat rerum sit qui sint facere qui fugit explicabo ducimus modi." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Noaplein 012a", "dolorum", new DateTime(2024, 8, 20, 5, 12, 10, 565, DateTimeKind.Local).AddTicks(5882), "Sit in non ipsum dolore quae cumque distinctio similique sed occaecati dolor id accusamus quas quia neque accusamus necessitatibus ullam." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Brittstraat 89", "error", new DateTime(2024, 8, 24, 20, 1, 33, 622, DateTimeKind.Local).AddTicks(8637), "Eveniet doloremque culpa dolorem id iure a nulla et placeat ea necessitatibus id amet reiciendis doloribus dolore temporibus amet ipsum." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Milanrijk 779 II", "voluptatem", new DateTime(2024, 8, 6, 21, 28, 59, 141, DateTimeKind.Local).AddTicks(5190), "Ut molestias adipisci delectus quas harum exercitationem eligendi qui recusandae dolorum quod et rerum aut quidem in omnis voluptatum et." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Mulderplantsoen 791c", "est", new DateTime(2024, 10, 24, 17, 55, 7, 999, DateTimeKind.Local).AddTicks(1486), "Minus aut ipsa aliquid magni et itaque adipisci deleniti eum id non excepturi quia voluptatem eveniet et excepturi eligendi ut." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Maudkade 579 III", "non", new DateTime(2024, 8, 23, 23, 11, 54, 801, DateTimeKind.Local).AddTicks(159), "Aut vel nihil inventore delectus accusantium animi et nemo ut illum ad similique voluptatem possimus et voluptatem sed atque dolore." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 248, "Possimus cumque ducimus qui ad ad et et unde aut quasi nobis doloribus quis sunt et porro alias omnis quisquam.", 4, "Facere at voluptas eveniet perspiciatis earum amet nihil quam voluptas aperiam autem repellendus consequatur enim quia sint nam ex quia." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Naam" },
                values: new object[] { 290, "Dolor temporibus qui autem sit error possimus corporis porro nulla est facere molestias est minus rerum dolor laudantium provident consequuntur.", "Aspernatur quos perspiciatis aspernatur earum consequatur minus omnis qui similique est voluptatem ea officia nemo ut quisquam voluptatem esse sequi." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Naam" },
                values: new object[] { 256, "Odit doloribus sapiente quia minima laborum mollitia adipisci ab ut suscipit maiores quia aut ut laboriosam consequatur velit deserunt enim.", "Qui non quibusdam reiciendis at quia porro doloremque omnis vel dolore rerum alias est et provident ea doloribus cupiditate consequatur." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Naam" },
                values: new object[] { 263, "Et esse et expedita earum praesentium iusto voluptatem qui cumque nisi voluptatem officiis fuga est at et animi repellat quisquam.", "Magni quam aut quibusdam corrupti veritatis aut delectus nulla repellendus autem magni qui est sit iure qui et in autem." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Naam" },
                values: new object[] { 246, "Dolore repudiandae et cumque ut aut esse ut enim est corrupti eum debitis culpa illo maxime dolorem voluptatem illo ut.", "Id porro doloribus ut quis corrupti sunt ipsum veritatis expedita exercitationem porro dolores quaerat nam suscipit optio voluptates tenetur nulla." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 351, "Fugiat rerum consequatur et officiis quia non nisi iusto eum ut nemo dicta accusamus nemo quidem expedita alias quaerat occaecati.", 4, "Eveniet consequatur voluptate iure rem sed ad et asperiores non repellendus neque vitae cum numquam corporis hic earum ducimus quia." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Naam" },
                values: new object[] { 249, "Quas non beatae quo accusantium omnis exercitationem non sint corrupti et officiis iure in hic in quia praesentium velit sint.", "Quia veniam reiciendis reiciendis at adipisci est quidem et nostrum incidunt deserunt eos sit occaecati consectetur vero reiciendis debitis ad." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Naam" },
                values: new object[] { 369, "Rerum ut fuga neque alias alias dolores laudantium harum maiores ut eius harum laboriosam ipsam in cumque consectetur a natus.", "Facere dolorem rerum cumque impedit adipisci unde magnam est odit voluptas architecto occaecati et molestiae porro amet odio harum quos." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 378, "Sed sit eum dolores autem consequuntur tempora occaecati mollitia enim architecto in illo veritatis possimus dicta similique vel qui architecto.", 4, "Fugit magni neque qui laborum autem aut odio laboriosam et est nobis commodi accusantium voluptate illum nihil officia eos debitis." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 285, "Accusantium et laboriosam occaecati eveniet tempore libero quia modi debitis provident doloribus aut distinctio corrupti est asperiores nihil alias beatae.", 3, "Quas ut sequi reiciendis sed atque numquam et eos aut ullam architecto tenetur ex consequatur ipsum similique est ut ratione." });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "quos", "Harvey Dijkstra V", "Meer, Smits and Vries" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "quis", "Mevr. Dr. Rayen Jansen", "Maas - Veen" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "explicabo", "Prof. Guusje Brink", "Koning, Wal and Leeuwen" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "dolor", "Mozes Smits II", "Dijk - Dekker" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "voluptatibus", "Bsc Jana Meijer", "Janssen, Wit and Ven" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "voluptatum", "Prof. Isabel Brouwer", "Dijk en Zonen" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "neque", "Oliver Wal II", "Vliet - Willems" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "consequatur", "Davi Leeuwen IV", "Groot - Linden" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "cum", "Nico Beek IV", "Leeuwen - Vos" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "illo", "Bsc Maes Hendriks", "Vries, Jong and Mulder" });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal" },
                values: new object[] { 37, "Msc Melisa Groot", "deposit" });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal", "Vaktype" },
                values: new object[] { 45, "Linde Bruin V", "Savings Account", 0 });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal" },
                values: new object[] { 36, "Dhr. Melody Veen", "maroon" });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal", "Vaktype" },
                values: new object[] { 15, "Lina Wit III", "UIC-Franc", 1 });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal" },
                values: new object[] { 47, "Mevr. Dr. Karlijn Brouwer", "Practical Frozen Chair" });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal", "Vaktype" },
                values: new object[] { 47, "Mevr. Dr. Mahir Maas", "Serbian Dinar", 1 });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal" },
                values: new object[] { 35, "Fayen Hendriks III", "disintermediate" });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal", "Vaktype" },
                values: new object[] { 46, "Sanne Koning II", "capacitor", 0 });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal" },
                values: new object[] { 21, "Msc Ayden Mulder", "array" });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal", "Vaktype" },
                values: new object[] { 26, "Mevr. Dr. Ralph Kok", "Unbranded", 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Vensloot 5", "est", new DateTime(2025, 2, 22, 17, 46, 3, 5, DateTimeKind.Local).AddTicks(3465), "Inventore esse saepe hic qui commodi velit reprehenderit sequi consectetur et odit enim sunt veniam voluptatem dolorem cupiditate quasi totam." });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Noarijk 142c", "ut", new DateTime(2024, 7, 2, 17, 18, 4, 394, DateTimeKind.Local).AddTicks(716), "Vitae distinctio perspiciatis veritatis sed tempore et sint deserunt repellat qui sit aut voluptatem rerum facere aliquam dolorem a porro." });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Vlietweg 097 II", "eveniet", new DateTime(2024, 5, 30, 9, 15, 51, 398, DateTimeKind.Local).AddTicks(6709), "Corrupti natus et dicta repellendus nesciunt autem laboriosam et possimus quis fuga aspernatur facere officiis nostrum porro voluptatem debitis aliquid." });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Boerrijk 505b", "sit", new DateTime(2024, 6, 24, 18, 54, 55, 347, DateTimeKind.Local).AddTicks(2178), "Nisi expedita enim error voluptas repellat qui necessitatibus rem dolorem voluptates quis vel quibusdam cupiditate laudantium omnis rem asperiores distinctio." });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Bergdijk 091b", "ad", new DateTime(2024, 12, 7, 22, 17, 57, 776, DateTimeKind.Local).AddTicks(5480), "Porro facilis ut in numquam et modi sit adipisci qui non amet ut ut totam accusantium rerum ut nostrum voluptatum." });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Juliagracht 273c", "est", new DateTime(2024, 7, 2, 18, 32, 46, 126, DateTimeKind.Local).AddTicks(4253), "Nihil debitis molestias vero laboriosam ea qui sint provident nulla et pariatur quos quia doloribus cum maxime veritatis aut quibusdam." });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Vrieskade 81", "inventore", new DateTime(2024, 6, 25, 11, 17, 18, 251, DateTimeKind.Local).AddTicks(7207), "Velit ipsum corrupti rerum facere non ab dolorem quia ea veritatis sint vero minus nesciunt quisquam hic minima architecto rerum." });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Julianpark 408", "aut", new DateTime(2025, 5, 5, 12, 30, 39, 723, DateTimeKind.Local).AddTicks(5948), "Ratione et harum aut corrupti quis pariatur vel quaerat vitae et porro maiores voluptas exercitationem animi alias odit veniam quaerat." });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Noaplein 7", "repudiandae", new DateTime(2025, 2, 6, 2, 24, 46, 493, DateTimeKind.Local).AddTicks(3009), "Pariatur labore nobis itaque vero qui sint eaque voluptatibus aliquid corrupti amet est quo repellendus modi consequatur aut voluptatem hic." });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Beekstraat 095b", "dolorem", new DateTime(2025, 5, 5, 7, 58, 36, 978, DateTimeKind.Local).AddTicks(154), "Totam ipsam at sint fugiat non nesciunt perferendis blanditiis quis aliquid omnis consequatur voluptatem deserunt et et velit facilis hic." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Daanhof 833", "magnam", new DateTime(2024, 12, 9, 4, 31, 41, 184, DateTimeKind.Local).AddTicks(4157), "Corrupti eaque necessitatibus placeat doloremque mollitia vero sed cum vel itaque culpa modi id laborum aut dolores rerum cum doloribus." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Beeksloot 9", "sed", new DateTime(2025, 3, 20, 18, 32, 27, 372, DateTimeKind.Local).AddTicks(464), "Qui enim nemo quia et unde eaque consequatur ea ipsam aut molestiae sit et illum placeat in eaque inventore voluptas." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Lucasdijk 45", "sit", new DateTime(2025, 4, 2, 15, 50, 39, 428, DateTimeKind.Local).AddTicks(5149), "Non animi fugiat vero quas voluptatibus nulla quod culpa eos quia et aut a quia sunt velit ut magni itaque." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Vriesweg 264 III", "placeat", new DateTime(2024, 12, 24, 22, 51, 12, 348, DateTimeKind.Local).AddTicks(4065), "Commodi ut temporibus omnis vitae tenetur voluptatibus perspiciatis placeat voluptatum numquam in debitis in ut ea labore deleniti cum sint." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Bosrijk 978c", "exercitationem", new DateTime(2024, 6, 14, 20, 13, 10, 693, DateTimeKind.Local).AddTicks(1530), "Quia dolore molestiae iste mollitia velit quia sapiente aut quo fugiat vel magni sequi dignissimos dolorem assumenda in laudantium assumenda." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Bruingracht 050 II", "ea", new DateTime(2025, 5, 16, 8, 53, 39, 698, DateTimeKind.Local).AddTicks(8917), "Et laborum et aliquam et sit et voluptas consequatur praesentium et voluptates sunt placeat magnam cum eligendi vel autem facere." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Leeuwenhof 044 II", "fuga", new DateTime(2024, 12, 16, 10, 56, 48, 766, DateTimeKind.Local).AddTicks(8871), "Ipsam dicta temporibus natus similique consequuntur neque similique totam qui voluptatum fugiat sed ut omnis pariatur molestiae nihil adipisci illo." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Isadijk 201a", "sunt", new DateTime(2025, 2, 16, 11, 5, 38, 889, DateTimeKind.Local).AddTicks(2140), "Sit neque odit illo eum veniam qui voluptatem eum qui quasi sunt perspiciatis quod atque omnis est repellat illo sit." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Jacobsdijk 070 II", "neque", new DateTime(2024, 7, 26, 7, 2, 19, 481, DateTimeKind.Local).AddTicks(8461), "Qui eos facilis et dolores vitae tempore enim deleniti qui necessitatibus cum incidunt aut quo quam ratione qui sit quia." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Evaplantsoen 774 II", "dolor", new DateTime(2024, 11, 2, 14, 22, 25, 365, DateTimeKind.Local).AddTicks(2884), "Aspernatur nihil tenetur molestias cumque nulla eum consequatur et cupiditate provident sunt at doloribus et quia ducimus accusantium quia corrupti." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 372, "Aut qui reiciendis delectus dignissimos laboriosam omnis animi ipsa consequatur velit dolor ad et magnam veniam voluptatum reiciendis adipisci adipisci.", 3, "Ullam aspernatur quod minima porro ullam dolores neque consectetur et qui deleniti labore quo earum sapiente in recusandae saepe necessitatibus." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Naam" },
                values: new object[] { 204, "Minus ut recusandae ipsam fugiat molestiae laboriosam nostrum est dolores voluptatum sit illo ut et illo aperiam maxime sed ratione.", "Qui et eum itaque ea excepturi sit enim non nihil nihil quod vero quisquam omnis dignissimos repellendus nam quas doloribus." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Naam" },
                values: new object[] { 263, "Dolor et qui a libero vel sequi dolor maiores rerum et earum ea id cum molestiae totam cumque occaecati aut.", "Modi ex ipsa rerum vitae ex rem nobis pariatur ea eum ratione neque aut omnis omnis vel modi delectus eum." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Naam" },
                values: new object[] { 397, "Laboriosam deleniti pariatur rerum minima quibusdam qui non omnis quia ipsum repellendus aliquid a et inventore ad doloribus placeat suscipit.", "Doloribus autem velit doloremque est doloremque voluptatem et ea labore aliquid similique qui deleniti itaque perferendis voluptas sit quidem voluptatem." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Naam" },
                values: new object[] { 288, "Hic accusamus modi qui doloremque aut quia ab possimus iusto sit cumque non esse expedita corrupti quae est sed velit.", "Nihil quidem sed fuga perferendis ut modi occaecati nihil debitis earum non est amet reiciendis minus culpa unde laudantium illo." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 328, "Atque et quae ut vel nihil ea est a earum natus nihil non vel corrupti qui sapiente ut incidunt accusamus.", 3, "Dignissimos et autem ut nihil ea in voluptas quod doloribus laboriosam animi rerum fugiat repudiandae laboriosam voluptatibus tenetur est voluptas." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Naam" },
                values: new object[] { 364, "Repellendus magnam enim et aut qui et alias nostrum necessitatibus fugiat nobis sint ratione error iste ipsa dicta architecto quaerat.", "Voluptates perferendis dolore sapiente repudiandae esse unde et illum culpa consequatur excepturi neque facilis voluptatem nam porro aut consequuntur beatae." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Naam" },
                values: new object[] { 277, "Accusantium sit et facilis possimus quas deleniti ex quo doloremque aut eius iure consequatur rerum nisi rerum quibusdam quo sunt.", "Harum et sit doloremque harum temporibus nihil qui eius repellat autem quis iure atque omnis sequi et qui optio dolore." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 343, "Velit consequatur et quia sit veritatis deleniti et non est dolorum quis iure harum aut earum maxime praesentium ut est.", 3, "Esse dolorem aperiam et maiores eius tenetur nemo ut et fugiat consequatur rerum officiis necessitatibus omnis nam adipisci autem nulla." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 256, "Beatae molestias suscipit ipsum vitae exercitationem hic consequuntur dolores qui et aut soluta quibusdam non praesentium quae odit rerum quibusdam.", 4, "Repellendus non ducimus cumque animi numquam qui doloribus voluptates quo omnis quo ipsum quidem omnis id ut veritatis omnis dolores." });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "alias", "Siep Dijk Sr.", "Stichting, Mulder and Heuvel" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "ipsum", "Dhr. Bodhi Smits", "Stichting, Smits and Maas" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "laborum", "Lauren Willems Sr.", "Bruin, Hoek and Klein" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "est", "Jacky Ruiter Sr.", "Bruin - Smits" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "aut", "George Jacobs Jr.", "Klein N.V." });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "sit", "Msc Miguel Groot", "Vos IT" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "nam", "Khadija Meer I", "Janssen International" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "aut", "Janne Peters II", "Smit, Peters and Veen" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "amet", "Nout Heuvel II", "Beek, Dekker and Graaf" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "facere", "Dhr. Vieve Linden", "Veen - Vliet" });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal" },
                values: new object[] { 16, "Noud Vries III", "Dynamic" });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal", "Vaktype" },
                values: new object[] { 25, "Prof. Samuel Vries", "Steel", 1 });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal" },
                values: new object[] { 45, "Lex Boer II", "primary" });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal", "Vaktype" },
                values: new object[] { 45, "Anna Brouwer I", "salmon", 0 });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal" },
                values: new object[] { 21, "Prof. Louay Janssen", "bypassing" });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal", "Vaktype" },
                values: new object[] { 11, "Manu Dam IV", "Health & Music", 0 });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal" },
                values: new object[] { 33, "Natan Groot I", "CFP Franc" });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal", "Vaktype" },
                values: new object[] { 36, "Matthijs Meijer Jr.", "5th generation", 1 });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal" },
                values: new object[] { 15, "Ted Leeuwen I", "payment" });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal", "Vaktype" },
                values: new object[] { 38, "Prof. Dirk Janssen", "Cape Verde", 0 });
        }
    }
}
