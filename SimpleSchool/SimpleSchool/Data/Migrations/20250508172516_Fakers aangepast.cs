using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SimpleSchool.Data.Migrations
{
    /// <inheritdoc />
    public partial class Fakersaangepast : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Leerkracht",
                columns: new[] { "Id", "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[,]
                {
                    { 11, "32810 Darrick Crest", "officiis", new DateTime(2025, 4, 4, 2, 27, 27, 747, DateTimeKind.Local).AddTicks(7420), "Ipsam possimus sunt natus voluptas officiis ex temporibus eos voluptas voluptas voluptas cum rerum aut similique totam quas aut autem." },
                    { 12, "525 Wintheiser River", "incidunt", new DateTime(2025, 3, 6, 8, 3, 6, 615, DateTimeKind.Local).AddTicks(4082), "Est perspiciatis dignissimos minus est dignissimos quasi ut nobis repellendus excepturi iure consequatur tempora natus amet in omnis itaque cum." },
                    { 13, "7608 Valentine Road", "sunt", new DateTime(2024, 11, 5, 19, 38, 54, 370, DateTimeKind.Local).AddTicks(3781), "Est et distinctio nostrum enim aut non molestiae perferendis repellat aliquid voluptas iure blanditiis enim voluptatibus illum odit non voluptatum." },
                    { 14, "5933 Oceane Viaduct", "qui", new DateTime(2025, 3, 7, 2, 28, 29, 154, DateTimeKind.Local).AddTicks(2407), "Voluptatem minus et placeat sapiente est qui ut molestias possimus illum placeat quia maiores repellendus et corrupti eligendi incidunt est." },
                    { 15, "9894 Erik Trafficway", "id", new DateTime(2024, 12, 23, 2, 11, 41, 693, DateTimeKind.Local).AddTicks(5558), "Saepe itaque quas aspernatur possimus non voluptatem perspiciatis sint amet architecto rerum fugiat sed est est impedit provident dolorum ducimus." },
                    { 16, "2565 Zemlak Plaza", "enim", new DateTime(2025, 2, 14, 16, 18, 54, 98, DateTimeKind.Local).AddTicks(9338), "Totam sunt ut consequuntur voluptas numquam omnis id eos sit facere ipsum sunt est mollitia et amet dolore aspernatur et." },
                    { 17, "3557 Arno Brooks", "et", new DateTime(2024, 12, 23, 9, 2, 8, 385, DateTimeKind.Local).AddTicks(8771), "Autem illum non exercitationem asperiores est repellat cupiditate mollitia est rem facilis est exercitationem cupiditate quasi sit sunt itaque et." },
                    { 18, "7741 Franecki Parkway", "expedita", new DateTime(2024, 5, 27, 23, 2, 4, 610, DateTimeKind.Local).AddTicks(522), "Iste sed accusamus qui quae et molestiae illo illum beatae eos fugit voluptate mollitia est dolorem autem vel at unde." },
                    { 19, "5509 Gleason Expressway", "ipsa", new DateTime(2025, 3, 17, 15, 16, 21, 865, DateTimeKind.Local).AddTicks(1667), "Exercitationem qui quaerat minima repellendus voluptate quos ut modi consequatur et est iure et facilis reiciendis ex sit ipsum nostrum." },
                    { 20, "882 Maxwell Plain", "ut", new DateTime(2024, 9, 27, 11, 55, 13, 906, DateTimeKind.Local).AddTicks(7466), "Sit ab nihil voluptate saepe nobis omnis vel sunt est similique et amet aut repudiandae libero rerum quia distinctio ut." }
                });

            migrationBuilder.InsertData(
                table: "Opleiding",
                columns: new[] { "Id", "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[,]
                {
                    { 11, 249, "Distinctio fugiat consequatur vero ut sunt aut voluptatem et magni perferendis voluptatem in tempora sapiente qui consequatur corporis aut hic.", 3, "Sed nihil ut amet qui ut aliquam aut unde quas aperiam sint dolorum quasi asperiores neque provident reprehenderit ad nesciunt." },
                    { 12, 324, "Quia est mollitia voluptatem deleniti delectus aut unde est perferendis eos consequatur dolor eum vero ex laudantium iusto aliquid atque.", 4, "Ut impedit ipsum velit nemo sint dolor molestiae aliquid explicabo quos hic aut quasi aliquam ipsa placeat esse fuga et." },
                    { 13, 245, "Sapiente cum consectetur odit eos ipsam et quo enim vel sunt recusandae expedita id et omnis distinctio blanditiis ea molestiae.", 3, "Iure voluptatem placeat dolores corrupti dolorum velit illo occaecati aut aliquam perferendis quidem adipisci tempore quod dolorum asperiores esse porro." },
                    { 14, 389, "Consequuntur voluptas iste voluptas eveniet labore sequi officiis cupiditate vel repellat placeat error vitae provident voluptatum aut eveniet ut totam.", 4, "Id provident eius delectus explicabo esse in nihil autem aliquid nostrum et quibusdam neque tempora molestiae vitae in voluptas dolore." },
                    { 15, 279, "Ipsa quibusdam aspernatur illo in inventore rem nobis qui voluptas ratione explicabo ipsam laudantium laudantium ea doloremque perferendis magni corporis.", 3, "Ipsa eos et iusto quasi quia ipsum placeat aut sed dolor est enim et eius quo rerum dolor aut et." },
                    { 16, 355, "Consequatur praesentium reprehenderit et debitis minima cum quis maxime ut harum voluptatem adipisci facilis earum quia tempore rem non dolore.", 4, "Quidem cupiditate labore voluptas deserunt assumenda quaerat sunt voluptatibus sint quaerat assumenda vero ut ut quia aliquid praesentium eveniet illo." },
                    { 17, 295, "Qui iusto dolorem dolores consectetur rerum qui expedita cupiditate tempora sit inventore illum quae consequuntur dolorem perferendis debitis alias ex.", 4, "Sequi ea asperiores dolor aut aspernatur temporibus ea odio dolore facere fuga cumque ullam provident culpa et expedita minima exercitationem." },
                    { 18, 274, "Rem possimus ut provident et fuga laborum recusandae molestiae quaerat officia est iusto et quibusdam laboriosam qui modi omnis quia.", 4, "Officiis voluptatem minus minima eos maiores ut sed est quibusdam sint aspernatur rerum sit voluptatem qui rem dolores quia iste." },
                    { 19, 289, "Ut aliquam neque aliquam ut sit ad inventore et veritatis omnis a vel quis fugit optio sed ut quae rerum.", 3, "Velit est ducimus sint dolorum laudantium est aut consequatur quia minus nesciunt inventore explicabo expedita non placeat ea quam fuga." },
                    { 20, 221, "Ducimus ut saepe dolor reiciendis tempore quo molestiae et voluptatum rerum aut repellat sit optio consequatur totam officia nihil ratione.", 4, "Rerum molestias rerum fuga voluptas natus eius dolor hic commodi dolor nulla minima odit expedita quia atque deserunt quos sit." }
                });

            migrationBuilder.InsertData(
                table: "StudentenKaart",
                columns: new[] { "Id", "Klas", "Naam", "School" },
                values: new object[,]
                {
                    { 11, "consequatur", "Marion Price IV", "Hirthe - Vandervort" },
                    { 12, "asperiores", "Mr. Raquel Jones", "Paucek - Fritsch" },
                    { 13, "velit", "Lora Collins MD", "Price - Lynch" },
                    { 14, "cupiditate", "Miss Wendell Hoppe", "Mills, Hyatt and Bahringer" },
                    { 15, "quas", "Mrs. Emanuel Ortiz", "Fadel Group" },
                    { 16, "ducimus", "Ms. Kay Jaskolski", "Conn LLC" },
                    { 17, "recusandae", "George Kshlerin PhD", "Block Inc" },
                    { 18, "nam", "Mr. Marianne Altenwerth", "Herzog and Sons" },
                    { 19, "similique", "Mr. Frank Haley", "O'Kon Inc" },
                    { 20, "voluptas", "Howard Bednar DVM", "Hessel - Reichel" }
                });

            migrationBuilder.InsertData(
                table: "Vak",
                columns: new[] { "Id", "AantalStudiePunten", "LeerkrachtId", "Naam", "Taal", "Vaktype" },
                values: new object[,]
                {
                    { 11, 48, 0, "Miss Kenneth Cassin", "microchip", 0 },
                    { 12, 27, 0, "Ms. Craig O'Connell", "Sharable", 1 },
                    { 13, 49, 0, "Mrs. Violet Will", "Sleek", 1 },
                    { 14, 34, 0, "Jana Heaney IV", "Licensed", 0 },
                    { 15, 19, 0, "Crystal Moore IV", "USB", 0 },
                    { 16, 39, 0, "Miss Juana Simonis", "Profit-focused", 1 },
                    { 17, 30, 0, "Mrs. Bernard Hodkiewicz", "sensor", 1 },
                    { 18, 23, 0, "Mrs. Edward Powlowski", "Bermudian Dollar (customarily known as Bermuda Dollar)", 0 },
                    { 19, 46, 0, "Traci McLaughlin MD", "implement", 0 },
                    { 20, 38, 0, "Ms. Dennis Hyatt", "Metal", 0 }
                });

            migrationBuilder.InsertData(
                table: "Leerling",
                columns: new[] { "Id", "Adres", "EMail", "GeboorteDatum", "Naam", "OpleidingId", "StudentenkaartId" },
                values: new object[,]
                {
                    { 11, "107 Metz Summit", "sunt", new DateTime(2024, 8, 7, 7, 40, 7, 967, DateTimeKind.Local).AddTicks(4419), "Dolores quidem vel voluptas sed odit aut voluptatem ab voluptatem neque deserunt est omnis ut quas doloremque aspernatur adipisci repudiandae.", 11, 11 },
                    { 12, "970 Ashtyn Lodge", "fugit", new DateTime(2025, 4, 12, 17, 35, 30, 992, DateTimeKind.Local).AddTicks(8806), "Consequuntur praesentium amet accusamus ipsam molestias facilis ut vel et consequatur adipisci nihil consequuntur veritatis et eum repellendus ipsa iusto.", 12, 12 },
                    { 13, "71299 Carter Road", "praesentium", new DateTime(2024, 8, 22, 20, 47, 51, 819, DateTimeKind.Local).AddTicks(5522), "Vero aut tenetur velit dolor quidem est eligendi ducimus sunt minus rerum et velit nisi aut est commodi accusantium molestiae.", 13, 13 },
                    { 14, "242 Brenda Points", "eligendi", new DateTime(2025, 4, 12, 0, 0, 58, 534, DateTimeKind.Local).AddTicks(8012), "Eaque et accusantium dicta sint iste explicabo aut tempora voluptatem placeat ut nobis dolores ut dolores quia eius tempore voluptatum.", 14, 14 },
                    { 15, "5432 Zita Ville", "et", new DateTime(2024, 12, 29, 6, 3, 53, 534, DateTimeKind.Local).AddTicks(5931), "Minus dolorem voluptate ullam dolor amet soluta est aliquam sed et voluptatibus ut eveniet omnis eos sit neque qui a.", 15, 15 },
                    { 16, "09007 Leann Curve", "aliquam", new DateTime(2024, 6, 6, 23, 53, 21, 375, DateTimeKind.Local).AddTicks(4755), "Neque autem dignissimos dolore dolores iure voluptatem id sequi voluptas quibusdam et consequatur ad autem nulla doloremque beatae repudiandae quasi.", 16, 16 },
                    { 17, "586 Baron Street", "omnis", new DateTime(2024, 10, 7, 23, 57, 3, 732, DateTimeKind.Local).AddTicks(860), "Natus aut omnis nobis est ex officiis enim est fugiat non atque ipsum quidem non eveniet enim sit magni aut.", 17, 17 },
                    { 18, "15199 Wisoky Lane", "nihil", new DateTime(2025, 3, 19, 13, 2, 20, 651, DateTimeKind.Local).AddTicks(8589), "Autem eos inventore provident quos quaerat laboriosam magni rerum aspernatur et quibusdam non id quidem soluta iste repudiandae explicabo minima.", 18, 18 },
                    { 19, "02109 Cale Fork", "autem", new DateTime(2024, 10, 16, 3, 32, 7, 166, DateTimeKind.Local).AddTicks(7896), "Nulla suscipit minus aliquid libero incidunt quidem dolorem quam esse et aliquam ut vel commodi et alias nesciunt cumque aut.", 19, 19 },
                    { 20, "001 Brigitte Course", "itaque", new DateTime(2025, 1, 28, 1, 32, 22, 191, DateTimeKind.Local).AddTicks(8184), "Cupiditate vel ipsum quasi non libero autem modi cumque veniam quos quibusdam sit fuga non suscipit excepturi assumenda quasi beatae.", 20, 20 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 20);

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

            migrationBuilder.DeleteData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 20);
        }
    }
}
