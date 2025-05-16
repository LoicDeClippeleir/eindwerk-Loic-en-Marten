using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimpleSchool.Migrations
{
    /// <inheritdoc />
    public partial class faker : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Nielsrijk 950 I", "in", new DateTime(2025, 1, 16, 4, 24, 0, 338, DateTimeKind.Local).AddTicks(4637), "Nobis totam qui maxime animi eos harum totam laborum excepturi ut necessitatibus voluptatem dolores nam incidunt hic optio quas esse." });

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
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 390, "Incidunt consequatur ut cupiditate eius cupiditate voluptates sed suscipit officia incidunt corporis quo id neque debitis consequuntur doloremque velit magnam.", 3, "Voluptatem autem voluptatem quas non quis sunt consequatur libero et dolor aut fugit quibusdam ut in voluptas molestiae dicta praesentium." });

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
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 400, "Quidem accusantium aut amet consectetur autem sunt et et laboriosam veniam et sed doloribus quia omnis dolorem minus aut nisi.", 3, "Perferendis ratione animi rerum minima et dolores fugiat nemo perferendis ea ab rerum dolores et cum deleniti reiciendis facilis ad." });

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
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 372, "Et vel excepturi modi sunt et dolor minima non ratione a quo itaque possimus et repellendus rerum maxime ut tenetur.", 4, "Corporis quasi placeat magnam maxime eligendi velit numquam minus error ipsum quo architecto beatae hic aut fugiat quis nihil aperiam." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 368, "Tenetur unde sit veritatis corrupti qui dolorum dolor sint enim eum rerum quibusdam iusto voluptas possimus id vero molestiae itaque.", 3, "Omnis dolorem sequi fuga qui voluptatem aut laboriosam rerum aliquid soluta non animi qui a impedit laboriosam odio ullam maxime." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 261, "Quas dolor totam alias iure ullam cupiditate nesciunt quibusdam iure error sunt est sed voluptatum itaque voluptatem earum et facilis.", 4, "Ut eveniet unde eaque ratione omnis quia mollitia impedit perspiciatis vel voluptas fugit minus exercitationem alias cumque velit tenetur eligendi." });

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
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Naam" },
                values: new object[] { 331, "Omnis aliquam consectetur consequuntur fuga pariatur vero reprehenderit dolores debitis a a voluptatibus eveniet omnis eaque dolores ab doloremque beatae.", "Illum iste delectus voluptates consequatur soluta nam voluptatibus possimus totam laudantium sint dicta reprehenderit consequatur porro qui natus voluptate rerum." });

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
                columns: new[] { "AantalStudiePunten", "LeerkrachtId", "Naam", "Taal" },
                values: new object[] { 20, 11, "Prof. Safouane Vries", "Leone" });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AantalStudiePunten", "LeerkrachtId", "Naam", "Taal", "Vaktype" },
                values: new object[] { 18, 12, "Diede Mulder III", "Borders", 1 });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AantalStudiePunten", "LeerkrachtId", "Naam", "Taal" },
                values: new object[] { 22, 13, "Douwe Janssen IV", "Auto Loan Account" });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AantalStudiePunten", "LeerkrachtId", "Naam", "Taal", "Vaktype" },
                values: new object[] { 35, 14, "Isabeau Berg V", "Ergonomic", 0 });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AantalStudiePunten", "LeerkrachtId", "Naam", "Taal" },
                values: new object[] { 14, 15, "Bsc Lucy Jacobs", "Village" });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AantalStudiePunten", "LeerkrachtId", "Naam", "Taal", "Vaktype" },
                values: new object[] { 45, 16, "Jaxx Dam Sr.", "Inlet", 0 });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AantalStudiePunten", "LeerkrachtId", "Naam", "Taal" },
                values: new object[] { 49, 17, "Dhr. Idris Broek", "strategic" });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AantalStudiePunten", "LeerkrachtId", "Naam", "Taal", "Vaktype" },
                values: new object[] { 18, 18, "Bsc Kaylee Leeuwen", "Berkshire", 1 });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AantalStudiePunten", "LeerkrachtId", "Naam", "Taal", "Vaktype" },
                values: new object[] { 20, 19, "Meyra Dekker Sr.", "Open-source", 0 });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AantalStudiePunten", "LeerkrachtId", "Naam", "Taal" },
                values: new object[] { 45, 20, "Dhr. Danilo Wit", "Future" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 290, "Dolor temporibus qui autem sit error possimus corporis porro nulla est facere molestias est minus rerum dolor laudantium provident consequuntur.", 4, "Aspernatur quos perspiciatis aspernatur earum consequatur minus omnis qui similique est voluptatem ea officia nemo ut quisquam voluptatem esse sequi." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 256, "Odit doloribus sapiente quia minima laborum mollitia adipisci ab ut suscipit maiores quia aut ut laboriosam consequatur velit deserunt enim.", 4, "Qui non quibusdam reiciendis at quia porro doloremque omnis vel dolore rerum alias est et provident ea doloribus cupiditate consequatur." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 263, "Et esse et expedita earum praesentium iusto voluptatem qui cumque nisi voluptatem officiis fuga est at et animi repellat quisquam.", 3, "Magni quam aut quibusdam corrupti veritatis aut delectus nulla repellendus autem magni qui est sit iure qui et in autem." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 246, "Dolore repudiandae et cumque ut aut esse ut enim est corrupti eum debitis culpa illo maxime dolorem voluptatem illo ut.", 3, "Id porro doloribus ut quis corrupti sunt ipsum veritatis expedita exercitationem porro dolores quaerat nam suscipit optio voluptates tenetur nulla." });

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
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 249, "Quas non beatae quo accusantium omnis exercitationem non sint corrupti et officiis iure in hic in quia praesentium velit sint.", 3, "Quia veniam reiciendis reiciendis at adipisci est quidem et nostrum incidunt deserunt eos sit occaecati consectetur vero reiciendis debitis ad." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 369, "Rerum ut fuga neque alias alias dolores laudantium harum maiores ut eius harum laboriosam ipsam in cumque consectetur a natus.", 3, "Facere dolorem rerum cumque impedit adipisci unde magnam est odit voluptas architecto occaecati et molestiae porro amet odio harum quos." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Naam" },
                values: new object[] { 378, "Sed sit eum dolores autem consequuntur tempora occaecati mollitia enim architecto in illo veritatis possimus dicta similique vel qui architecto.", "Fugit magni neque qui laborum autem aut odio laboriosam et est nobis commodi accusantium voluptate illum nihil officia eos debitis." });

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
                columns: new[] { "AantalStudiePunten", "LeerkrachtId", "Naam", "Taal" },
                values: new object[] { 37, 0, "Msc Melisa Groot", "deposit" });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AantalStudiePunten", "LeerkrachtId", "Naam", "Taal", "Vaktype" },
                values: new object[] { 45, 0, "Linde Bruin V", "Savings Account", 0 });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AantalStudiePunten", "LeerkrachtId", "Naam", "Taal" },
                values: new object[] { 36, 0, "Dhr. Melody Veen", "maroon" });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AantalStudiePunten", "LeerkrachtId", "Naam", "Taal", "Vaktype" },
                values: new object[] { 15, 0, "Lina Wit III", "UIC-Franc", 1 });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AantalStudiePunten", "LeerkrachtId", "Naam", "Taal" },
                values: new object[] { 47, 0, "Mevr. Dr. Karlijn Brouwer", "Practical Frozen Chair" });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AantalStudiePunten", "LeerkrachtId", "Naam", "Taal", "Vaktype" },
                values: new object[] { 47, 0, "Mevr. Dr. Mahir Maas", "Serbian Dinar", 1 });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AantalStudiePunten", "LeerkrachtId", "Naam", "Taal" },
                values: new object[] { 35, 0, "Fayen Hendriks III", "disintermediate" });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AantalStudiePunten", "LeerkrachtId", "Naam", "Taal", "Vaktype" },
                values: new object[] { 46, 0, "Sanne Koning II", "capacitor", 0 });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AantalStudiePunten", "LeerkrachtId", "Naam", "Taal", "Vaktype" },
                values: new object[] { 21, 0, "Msc Ayden Mulder", "array", 1 });

            migrationBuilder.UpdateData(
                table: "Vak",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AantalStudiePunten", "LeerkrachtId", "Naam", "Taal" },
                values: new object[] { 26, 0, "Mevr. Dr. Ralph Kok", "Unbranded" });
        }
    }
}
