using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SimpleSchool.Migrations
{
    /// <inheritdoc />
    public partial class leerkrachtseederaangepast : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.InsertData(
                table: "Leerkracht",
                columns: new[] { "Id", "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[,]
                {
                    { 1, "Johanneslaan 046b", "tenetur", new DateTime(2024, 9, 4, 15, 38, 7, 700, DateTimeKind.Local).AddTicks(4399), "Numquam sed est ea sit consequuntur molestiae ipsa dolorem enim necessitatibus atque consequatur et rerum reprehenderit laudantium quam saepe eos." },
                    { 2, "Brinkpassage 391 I", "quisquam", new DateTime(2024, 7, 14, 7, 59, 38, 432, DateTimeKind.Local).AddTicks(9936), "Consequuntur ratione dignissimos corrupti culpa dolorem et omnis corporis dolores blanditiis ut illum ab quibusdam provident sit accusamus amet rem." },
                    { 3, "Jonghof 958 I", "quod", new DateTime(2024, 12, 24, 12, 36, 13, 815, DateTimeKind.Local).AddTicks(1126), "Necessitatibus minus dolor assumenda qui quos quasi dolor voluptas ut incidunt saepe nihil libero quisquam sequi animi odio velit repudiandae." },
                    { 4, "Thomassteeg 103c", "incidunt", new DateTime(2024, 11, 6, 2, 43, 52, 958, DateTimeKind.Local).AddTicks(9724), "Repellendus corrupti dolores odit repellendus eos ut occaecati ad sed reiciendis excepturi vitae enim fuga iste non rerum vel modi." },
                    { 5, "Meijerpark 247 II", "sed", new DateTime(2024, 10, 17, 7, 25, 59, 514, DateTimeKind.Local).AddTicks(8335), "Facere id enim dolor laboriosam aut quaerat officiis dolor recusandae aut dolorem quia nihil molestiae consequatur neque nisi rem dolor." },
                    { 6, "Jansensloot 428a", "et", new DateTime(2024, 8, 4, 17, 38, 27, 201, DateTimeKind.Local).AddTicks(2361), "Ad sit expedita accusamus expedita debitis culpa sapiente libero deserunt explicabo perspiciatis magni quis repellat voluptas facere reiciendis unde possimus." },
                    { 7, "Basstraat 858b", "et", new DateTime(2024, 10, 30, 18, 37, 3, 723, DateTimeKind.Local).AddTicks(3911), "Officiis nisi ut modi nemo maiores et dignissimos nostrum quae quae vero rerum reiciendis voluptatum quibusdam quas aliquid laboriosam et." },
                    { 8, "Vissersteeg 895b", "amet", new DateTime(2025, 1, 30, 15, 31, 10, 174, DateTimeKind.Local).AddTicks(2810), "Molestiae vel perferendis sit qui veritatis voluptates fugit autem voluptas eum quas quis asperiores debitis quia reiciendis occaecati est sit." },
                    { 9, "Lottestraat 868a", "incidunt", new DateTime(2025, 3, 4, 13, 59, 42, 905, DateTimeKind.Local).AddTicks(8263), "Ea atque non vero dolores vero eius beatae illum pariatur laboriosam iusto laboriosam impedit ut minus ut ut praesentium excepturi." },
                    { 10, "Stijndijk 998a", "fugiat", new DateTime(2025, 3, 22, 11, 41, 32, 847, DateTimeKind.Local).AddTicks(1044), "Sed distinctio minima et cum dolorem eaque esse minus quos voluptatem perferendis alias voluptas impedit non molestias repellat porro sit." }
                });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Amberweg 167b", "aliquid", new DateTime(2025, 3, 2, 9, 43, 27, 576, DateTimeKind.Local).AddTicks(6036), "Animi sequi possimus aut fugit fugit nulla vitae praesentium sit non libero sint ipsum impedit quod facilis doloribus est et." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Leeuwenplein 63", "et", new DateTime(2025, 5, 15, 5, 3, 29, 248, DateTimeKind.Local).AddTicks(9367), "Illum beatae id magnam aut illo vel rerum et ratione ullam velit eveniet nihil ab libero quis ducimus esse nisi." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Dijkmarkt 165", "mollitia", new DateTime(2024, 6, 16, 1, 45, 24, 524, DateTimeKind.Local).AddTicks(8339), "Nihil aliquam quis vero consequatur unde eum maiores vel officia voluptas qui facilis eos eligendi velit vel minus ipsam repudiandae." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Brinkmarkt 632 III", "omnis", new DateTime(2024, 9, 22, 13, 37, 24, 35, DateTimeKind.Local).AddTicks(1054), "Maxime eligendi voluptatem omnis quae cupiditate dolor beatae rerum itaque eligendi expedita sed dignissimos fugiat dolorem consequuntur molestiae sed aspernatur." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Timkade 048", "ab", new DateTime(2025, 3, 29, 17, 6, 27, 828, DateTimeKind.Local).AddTicks(2560), "Ratione ad similique eum facilis molestiae modi saepe dicta et autem quaerat et cumque debitis aut asperiores tempore ut dolores." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Bramdijk 464a", "tempore", new DateTime(2025, 2, 24, 6, 45, 35, 322, DateTimeKind.Local).AddTicks(7412), "Similique enim incidunt voluptas sunt ab est expedita expedita eaque eum enim quidem dolore autem est iste debitis at doloremque." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Ruiterpark 27", "est", new DateTime(2024, 9, 22, 11, 28, 48, 760, DateTimeKind.Local).AddTicks(9700), "Qui minima molestiae perspiciatis dolorum aut sint animi cumque non dolor numquam accusamus eius sint eum quae omnis tenetur cum." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Meijerlaan 699 II", "et", new DateTime(2025, 4, 6, 2, 58, 49, 616, DateTimeKind.Local).AddTicks(9993), "Exercitationem reprehenderit a sapiente sit incidunt impedit molestias et voluptates tempora magnam sunt vero rerum ea officia ex recusandae eveniet." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Irislaan 54", "sit", new DateTime(2024, 12, 12, 5, 55, 17, 881, DateTimeKind.Local).AddTicks(1896), "Doloremque nihil sint dignissimos sit esse qui maiores earum doloribus quia aut culpa quam eos omnis dignissimos ipsa repellat quos." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Haangracht 549 I", "soluta", new DateTime(2024, 12, 11, 0, 11, 42, 649, DateTimeKind.Local).AddTicks(1540), "Dignissimos quo iste nihil non unde ratione aperiam iure consectetur ab placeat dolore sunt quos suscipit ut odit nostrum nihil." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 368, "Fugiat et hic sunt autem et ducimus id possimus illum quae dolores quod modi et assumenda temporibus voluptatem et ad.", 4, "Voluptas aliquam quia et omnis est nisi fugiat harum neque laudantium mollitia ad repellat molestiae veritatis illo autem iste ab." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Naam" },
                values: new object[] { 257, "Dignissimos qui voluptates ut expedita neque sed nesciunt et alias maxime ab maxime et delectus rerum totam ab exercitationem non.", "Perferendis numquam id aperiam voluptatum earum atque voluptatem velit iusto blanditiis reiciendis porro omnis ut aliquam nihil minus possimus velit." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 341, "Placeat possimus quia sapiente tenetur odio quam quo reprehenderit ut vero aut nam similique est optio error corporis voluptates ullam.", 4, "Sed et ut consequatur voluptas in id et velit officiis vel molestiae repudiandae nemo iste laboriosam ut aut neque quis." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Naam" },
                values: new object[] { 363, "Est sunt voluptatum est est alias doloribus eius impedit eum ut consequatur cumque molestiae non nostrum dignissimos temporibus voluptas et.", "Vero quas accusantium tempore vel sunt voluptas hic nisi quas impedit quia nisi temporibus velit provident et eos dolores cupiditate." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 366, "Temporibus corrupti quos perferendis ab voluptatibus qui et ad ab non nostrum voluptas et non explicabo ea totam nihil quod.", 3, "Quia optio a voluptatem inventore nisi et veritatis hic ea expedita non tempora magnam ipsa architecto accusantium atque nam numquam." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Naam" },
                values: new object[] { 231, "Repellendus laborum in doloremque enim culpa enim impedit rerum omnis ea dolorem ipsam voluptatem cumque exercitationem corporis quod reprehenderit nemo.", "Omnis in labore in odit earum omnis ipsum corrupti quas sint quis nihil officiis natus laborum doloribus est et est." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 363, "Voluptatem eum atque doloribus optio quia non ad sint dolorem labore culpa omnis est rerum aliquam similique eligendi et est.", 3, "Vel consequatur sit ullam aliquid vel rerum eum sed ut id qui consequatur rem quibusdam fugiat fugiat iste eaque animi." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 200, "Iusto ea in magnam dolores tempora ipsam cum in et at omnis ut natus quia aut expedita at esse voluptatem.", 4, "Sed sit labore et saepe nam sed voluptatem nisi quia at delectus vel rerum tempora quae asperiores qui cum earum." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Naam" },
                values: new object[] { 358, "Ex ut sequi ut ut distinctio quia cumque unde deserunt mollitia ad incidunt facere reiciendis explicabo facere porro impedit reprehenderit.", "Quia omnis minus impedit nihil vitae nulla eligendi aut optio dignissimos consequuntur quasi vel odio sunt ipsum quidem rerum aut." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 240, "Dolor alias iste totam qui et sint dolor id fugit rerum beatae consequatur quam fugiat incidunt et natus earum consequuntur.", 4, "Est aut et dignissimos praesentium ut est ea sit distinctio atque rerum dolorum sed ex aperiam quaerat voluptatibus libero eum." });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "aperiam", "Msc Lennox Bakker", "Klein, Wal and Groot" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "non", "Prof. Jorn Beek", "Beek, Visser and Graaf" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "excepturi", "Msc Martin Bosch", "Jong Bank" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "sit", "Bsc Elias Koster", "Bruin, Ven and Bosch" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "quia", "Ezra Haan I", "Klein, Bosch and Bos" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "dignissimos", "Eymen Dijkstra II", "Peters, Ven and Mulder" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "quo", "Dhr. Kayleigh Graaf", "Ven International" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "qui", "Bsc Muhammed Vries", "Vermeulen - Dijkstra" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "occaecati", "Annemijn Bosch Jr.", "Bakker - Wit" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "ut", "Julan Mulder III", "Meijer - Vries" });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal", "Vaktype" },
                values: new object[] { 43, "Mevr. Dr. Jaivey Brouwer", "transmit", 1 });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal", "Vaktype" },
                values: new object[] { 19, "Fien Beek III", "object-oriented", 0 });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal", "Vaktype" },
                values: new object[] { 19, "Dirk Haan II", "Egyptian Pound", 1 });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal" },
                values: new object[] { 14, "Msc Jesse Mulder", "Fresh" });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal" },
                values: new object[] { 34, "Prof. Meike Stichting", "synthesize" });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal", "Vaktype" },
                values: new object[] { 24, "Florence Bos Jr.", "cultivate", 0 });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal" },
                values: new object[] { 40, "Dhr. Kaylee Willems", "Gorgeous Fresh Shirt" });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal", "Vaktype" },
                values: new object[] { 38, "Nienke Ruiter Sr.", "Via", 0 });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal" },
                values: new object[] { 22, "Isra Janssen IV", "cyan" });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal" },
                values: new object[] { 36, "Isra Maas IV", "Comoros" });
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

            migrationBuilder.InsertData(
                table: "Leerkracht",
                columns: new[] { "Id", "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[,]
                {
                    { 11, "Damplein 05", "iste", new DateTime(2025, 1, 12, 15, 0, 10, 34, DateTimeKind.Local).AddTicks(5399), "Porro itaque dolorem ex quod sit vitae debitis officiis quisquam velit atque ipsa enim quia aut rerum consectetur illo officiis." },
                    { 12, "Evapassage 523c", "consectetur", new DateTime(2024, 6, 17, 10, 2, 36, 340, DateTimeKind.Local).AddTicks(8459), "Architecto nulla dolore illo nostrum ea possimus occaecati tempore quaerat possimus sit quo quo eveniet facilis placeat quia ipsum aut." },
                    { 13, "Finndijk 823", "cupiditate", new DateTime(2024, 7, 24, 7, 25, 57, 248, DateTimeKind.Local).AddTicks(8861), "Consequatur aliquam accusamus quis atque tenetur consequatur et qui fuga velit non dolor nemo temporibus vel totam exercitationem eum laudantium." },
                    { 14, "Liekehof 00", "in", new DateTime(2024, 7, 7, 21, 37, 40, 621, DateTimeKind.Local).AddTicks(853), "Cum rerum totam voluptas distinctio eveniet recusandae molestiae repellat totam dignissimos veniam dolorem eos similique aut blanditiis atque saepe commodi." },
                    { 15, "Svenplantsoen 2", "ullam", new DateTime(2024, 9, 30, 9, 17, 2, 601, DateTimeKind.Local).AddTicks(7814), "Minus quia ipsam sunt est similique quibusdam eius qui ratione ut laborum molestiae est placeat at non illum qui eum." },
                    { 16, "Evamarkt 02", "aperiam", new DateTime(2025, 2, 10, 13, 21, 11, 624, DateTimeKind.Local).AddTicks(6996), "Quia impedit sint omnis fugiat assumenda hic beatae nihil facere commodi soluta perspiciatis atque pariatur veritatis et debitis ut hic." },
                    { 17, "Bossloot 318a", "in", new DateTime(2024, 8, 13, 14, 27, 59, 169, DateTimeKind.Local).AddTicks(6475), "Fuga maxime illum dicta quibusdam nesciunt asperiores ipsam iure quasi et quas eveniet vero et inventore explicabo dolor eveniet et." },
                    { 18, "Emmarijk 12", "fugiat", new DateTime(2025, 1, 12, 22, 55, 43, 912, DateTimeKind.Local).AddTicks(8257), "Veniam repellendus quibusdam consequatur occaecati reprehenderit adipisci sunt asperiores placeat eius fugit sit et voluptate ut placeat sit iure qui." },
                    { 19, "Maxkade 252a", "voluptate", new DateTime(2025, 4, 29, 19, 33, 20, 657, DateTimeKind.Local).AddTicks(2990), "Sunt laboriosam quia adipisci minus cumque facilis delectus nostrum minus accusamus molestiae voluptas enim dolores quia quasi deleniti aspernatur culpa." },
                    { 20, "Noapark 1", "nobis", new DateTime(2024, 12, 5, 12, 35, 24, 91, DateTimeKind.Local).AddTicks(6219), "Ut eius aut suscipit qui perspiciatis aliquam aut eos rerum eum ducimus voluptatem modi porro aut corporis tempora id rem." }
                });

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
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 207, "Laudantium ipsa quo est cupiditate autem officia sint ipsam facilis pariatur itaque corrupti voluptatum voluptas amet earum optio rerum sed.", 3, "Qui nobis unde commodi aut aut est non accusantium id laudantium qui sed minima mollitia similique minima molestiae iusto voluptatem." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Naam" },
                values: new object[] { 233, "Modi quam qui consequatur assumenda quo eum voluptatem ab tenetur aut modi molestiae impedit exercitationem recusandae quas in ut nulla.", "Sit soluta quis omnis et magni ut eveniet corporis perspiciatis rerum neque deserunt molestiae iure quibusdam tenetur exercitationem officiis consequatur." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 298, "Esse saepe voluptatem accusamus repudiandae quis dolorem ducimus amet repellat est pariatur laborum et a provident deleniti suscipit omnis non.", 3, "Tenetur animi est et amet temporibus nesciunt nihil laboriosam ipsa omnis ullam qui minima expedita eum soluta similique quia facilis." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Naam" },
                values: new object[] { 346, "Quibusdam sit maxime esse porro consequuntur explicabo labore rerum accusantium aspernatur expedita consequatur pariatur quisquam totam laudantium aut id et.", "Fugiat tempora accusamus reprehenderit itaque exercitationem qui iste ullam aliquid sit rerum ut iusto dolores fugiat animi amet vero rerum." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 313, "Nesciunt sit quas ducimus quaerat quo dolorum et aperiam velit nihil est deserunt quos iusto voluptatum occaecati aut sunt sapiente.", 4, "Soluta sunt quis autem eveniet delectus doloremque id consequuntur dolores ut ut eos consequatur quam asperiores saepe qui culpa officia." });

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
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 278, "Dignissimos dicta ut vel dignissimos quaerat excepturi praesentium aut reprehenderit minus ab aliquid amet ut qui consectetur laborum nostrum repellat.", 4, "Excepturi eum necessitatibus sint ut aut voluptatem quasi dolores ut ad blanditiis tenetur ut magnam totam eveniet rerum tenetur possimus." });

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
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Naam" },
                values: new object[] { 255, "Maiores temporibus in officia rerum repellat magni harum veritatis quibusdam et quisquam illum nam dolor optio et quidem et sint.", "Quasi modi autem aut aut qui ducimus maiores quisquam voluptatibus ut illum odit autem et explicabo aut nesciunt perferendis similique." });

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
                columns: new[] { "AantalStudiePunten", "Naam", "Taal", "Vaktype" },
                values: new object[] { 38, "Tristan Stichting IV", "Advanced", 0 });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal", "Vaktype" },
                values: new object[] { 13, "Msc Sem Wit", "Dynamic", 1 });

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
                columns: new[] { "AantalStudiePunten", "Naam", "Taal" },
                values: new object[] { 49, "Thijmen Vermeulen I", "Corporate" });

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
                columns: new[] { "AantalStudiePunten", "Naam", "Taal" },
                values: new object[] { 24, "Bsc Jake Veen", "Fantastic Concrete Shirt" });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal", "Vaktype" },
                values: new object[] { 43, "Anna Peters IV", "regional", 1 });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal" },
                values: new object[] { 40, "Mevr. Dr. Filip Ven", "Cayman Islands Dollar" });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AantalStudiePunten", "Naam", "Taal" },
                values: new object[] { 45, "Rana Bosch III", "convergence" });
        }
    }
}
