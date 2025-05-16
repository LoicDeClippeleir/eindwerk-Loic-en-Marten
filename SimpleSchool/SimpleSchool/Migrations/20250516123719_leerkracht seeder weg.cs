using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SimpleSchool.Migrations
{
    /// <inheritdoc />
    public partial class leerkrachtseederweg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "Adres", "GeboorteDatum", "Naam" },
                values: new object[] { "Dekkersloot 799c", new DateTime(2024, 6, 7, 22, 23, 52, 773, DateTimeKind.Local).AddTicks(1), "Nostrum vitae sit rerum assumenda delectus id qui ipsum dolorem saepe qui vitae blanditiis velit quas eaque qui et minus." });

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
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Naam" },
                values: new object[] { 330, "Quae qui nesciunt nostrum est consectetur temporibus vel voluptate corrupti iste qui voluptatem quasi ipsa error eligendi fuga aut recusandae.", "Ut expedita repellat et recusandae numquam vitae facilis alias quaerat nostrum quaerat molestias maxime excepturi in et et architecto magni." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Naam" },
                values: new object[] { 262, "Hic quaerat modi sint aut eos quia esse eaque veniam unde in unde ex qui porro incidunt libero et enim.", "Dolorum quis totam voluptatem qui rem iusto expedita eveniet vitae ab qui assumenda possimus et beatae facilis mollitia ipsam consectetur." });

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
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Naam" },
                values: new object[] { 365, "Voluptatibus qui reprehenderit reiciendis eius consectetur dolorem exercitationem assumenda eos sit maxime nobis rerum itaque voluptas velit minus recusandae non.", "Iusto nemo dolore suscipit consectetur sit autem nemo corporis deleniti blanditiis doloremque sunt quo deserunt eaque assumenda facere quae non." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Naam" },
                values: new object[] { 366, "Assumenda ducimus atque et architecto dolorem fuga officiis laboriosam dolorem mollitia facere corporis non accusamus nam laborum accusamus consequuntur quia.", "Illo et ipsum deserunt a cumque laudantium in sed libero molestias fugiat blanditiis et pariatur doloremque unde aliquam libero corporis." });

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
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 280, "Nobis velit dolores ex aliquid aliquid et occaecati in labore dignissimos ipsa at ut explicabo dolorem hic laboriosam quia corporis.", 3, "Qui in ullam nulla sunt ea laborum et illum voluptate earum qui quis possimus sapiente iste quia sit voluptatem magni." });

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
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Naam" },
                values: new object[] { 300, "Eos recusandae culpa unde inventore dolorem dolor ut molestiae minima est dolore ut rem rerum qui nisi enim aliquam modi.", "Voluptas et voluptatem atque voluptatum iste ut facere qui consequatur ea doloremque nobis commodi molestiae nulla error voluptas qui fugiat." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 374, "Et fugiat dolore et reiciendis officiis est adipisci temporibus molestiae totam corrupti vel itaque ipsam rerum odio et non ea.", 3, "Maiores aut excepturi aspernatur fuga placeat qui ipsa eaque voluptate sed laboriosam qui quidem laborum non hic dolorum eius eos." });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Leerkracht",
                columns: new[] { "Id", "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[,]
                {
                    { 1, "Smitsdijk 367a", "accusamus", new DateTime(2025, 1, 11, 7, 24, 40, 600, DateTimeKind.Local).AddTicks(3958), "Animi aspernatur veritatis minus eius voluptas ullam laborum praesentium saepe non facilis molestiae tenetur est deserunt non debitis assumenda occaecati." },
                    { 2, "Brouwerhof 5", "voluptas", new DateTime(2025, 5, 5, 19, 49, 26, 81, DateTimeKind.Local).AddTicks(9745), "Necessitatibus necessitatibus porro ut velit ipsum facere et hic et natus et aut libero voluptatem labore aut aperiam dolores tempora." },
                    { 3, "Anoukhof 164a", "dicta", new DateTime(2024, 12, 25, 10, 5, 50, 1, DateTimeKind.Local).AddTicks(6502), "Nobis occaecati eaque numquam ut illo aut autem et ut totam qui qui excepturi dolorem aspernatur commodi repellat amet laboriosam." },
                    { 4, "Annakade 585a", "id", new DateTime(2024, 10, 20, 1, 34, 22, 248, DateTimeKind.Local).AddTicks(2091), "Labore harum et libero earum impedit culpa eum dignissimos quia in ut pariatur ut officiis tempora enim velit et et." },
                    { 5, "Jonghof 693 III", "et", new DateTime(2024, 6, 13, 17, 33, 38, 832, DateTimeKind.Local).AddTicks(8783), "Nobis minima qui fuga et nostrum adipisci quod quia ut eius sunt eum quibusdam quam pariatur consequatur dicta molestias iure." },
                    { 6, "Kostersloot 98", "eos", new DateTime(2024, 6, 29, 13, 13, 23, 217, DateTimeKind.Local).AddTicks(8792), "Nemo ex et ut molestias eos quia asperiores et voluptate ipsum rerum doloribus assumenda sed eaque suscipit aut quisquam maiores." },
                    { 7, "Juliavelt 127c", "ullam", new DateTime(2025, 1, 13, 15, 36, 29, 463, DateTimeKind.Local).AddTicks(8045), "Quis necessitatibus vero delectus et voluptas rerum et molestias alias voluptates autem accusantium quos distinctio voluptatibus repellendus iusto nisi inventore." },
                    { 8, "Jansenhof 505a", "ducimus", new DateTime(2024, 9, 13, 22, 43, 5, 385, DateTimeKind.Local).AddTicks(7691), "Vero ad quia est consequatur omnis incidunt modi blanditiis et et eos distinctio eum omnis dolores veniam adipisci soluta possimus." },
                    { 9, "Janssenplein 46", "id", new DateTime(2025, 2, 26, 12, 12, 48, 529, DateTimeKind.Local).AddTicks(3847), "Error neque illo velit quo ipsam rerum aut explicabo natus dignissimos maxime non laboriosam hic ratione ut rem est ut." },
                    { 10, "Vensloot 008a", "quia", new DateTime(2024, 10, 31, 0, 14, 39, 197, DateTimeKind.Local).AddTicks(531), "Incidunt ut autem voluptas libero amet quod modi ut non quis totam quo ea consequatur labore delectus illo et ut." }
                });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Rubenweg 065 I", "libero", new DateTime(2025, 5, 15, 22, 57, 40, 778, DateTimeKind.Local).AddTicks(5671), "Molestiae facere aut ut quidem eligendi ratione qui eum consequatur qui et in at ducimus numquam cupiditate quas illum consequatur." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Tomplantsoen 206c", "reiciendis", new DateTime(2024, 7, 18, 2, 46, 26, 854, DateTimeKind.Local).AddTicks(4981), "Est quia a excepturi molestiae neque occaecati in ea nesciunt et nihil eos ut sint et voluptas atque doloribus amet." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Evavelt 439 III", "temporibus", new DateTime(2024, 7, 15, 5, 41, 47, 259, DateTimeKind.Local).AddTicks(5686), "Praesentium sint enim facilis ipsum consectetur quos fugiat dolor hic qui est nobis delectus rerum id id eius consequatur quaerat." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Adres", "GeboorteDatum", "Naam" },
                values: new object[] { "Maxplantsoen 498a", new DateTime(2024, 7, 13, 2, 46, 20, 429, DateTimeKind.Local).AddTicks(2091), "Officiis sed quae cum expedita accusantium in non perspiciatis dicta dolorem dolorum repellat quisquam quis et tempore dolores ut dignissimos." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Smitplein 64", "quia", new DateTime(2025, 4, 2, 6, 18, 42, 590, DateTimeKind.Local).AddTicks(6821), "Autem beatae aliquid tenetur veniam ipsum maiores labore debitis provident sit aut id ipsum voluptatem optio vero corrupti voluptates repudiandae." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Veenplein 487 III", "doloremque", new DateTime(2025, 3, 28, 16, 12, 32, 358, DateTimeKind.Local).AddTicks(7439), "Pariatur officiis inventore rem eum voluptate ducimus aperiam voluptas hic explicabo qui est dignissimos pariatur ullam adipisci vero esse similique." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Bruinpassage 1", "accusamus", new DateTime(2024, 7, 30, 16, 16, 49, 435, DateTimeKind.Local).AddTicks(6638), "Quis nobis qui maxime molestiae dicta ea reprehenderit ab molestias voluptates quidem voluptatem nemo unde expedita debitis sed quia tenetur." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Heuvelpassage 38", "impedit", new DateTime(2024, 7, 8, 2, 39, 31, 410, DateTimeKind.Local).AddTicks(8171), "Tempora nemo doloremque explicabo eius sequi fugit nesciunt vel vel blanditiis maxime suscipit voluptatum neque quo voluptatem explicabo et repudiandae." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Rickplein 888 II", "dolores", new DateTime(2025, 1, 22, 16, 26, 17, 828, DateTimeKind.Local).AddTicks(4201), "Doloremque eum et ut quas et magni omnis repellat eius voluptatem fugit quia error sed eligendi modi natus quam ratione." });

            migrationBuilder.UpdateData(
                table: "Leerling",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Bruinhof 034", "ex", new DateTime(2024, 11, 6, 10, 10, 54, 229, DateTimeKind.Local).AddTicks(9360), "Dignissimos voluptatum neque non quibusdam voluptatem nostrum consectetur aliquid aut ut consequuntur esse aut autem veritatis iste ratione inventore voluptas." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Naam" },
                values: new object[] { 219, "Et qui nihil sed incidunt quia ipsum est distinctio alias ab fuga sed sit voluptas doloribus et eius tempora blanditiis.", "Facere ut facere fuga id accusamus est libero ducimus dignissimos vitae pariatur asperiores ducimus est laudantium nihil iusto sunt quia." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Naam" },
                values: new object[] { 220, "Facere voluptas impedit quis nemo nihil voluptates in et magni nihil dolore et cum blanditiis eum fugiat et harum et.", "Quasi deleniti neque et ducimus cum eligendi officia quam ut aut et dolores odit nemo pariatur officia quod officia quis." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Naam" },
                values: new object[] { 327, "Reprehenderit voluptatibus voluptatem ipsum blanditiis quisquam reiciendis placeat dolor quo est ullam temporibus debitis suscipit autem dolorem vel cumque ab.", "Quisquam accusamus ut quia assumenda error recusandae error tempore laboriosam porro maxime deserunt et vitae ut sit molestias aut voluptatem." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Naam" },
                values: new object[] { 281, "Animi laudantium qui autem veritatis dolor ut ut excepturi magni aut quae autem exercitationem sunt ex quia fugit quo deleniti.", "Omnis voluptates vel harum impedit aut quae voluptatibus consequatur ut quia ipsa libero ut repudiandae odit commodi error sint quam." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Naam" },
                values: new object[] { 269, "Quisquam reiciendis temporibus animi magni quis ut voluptas odio maiores accusamus qui accusamus quis quia a ab quos voluptatum voluptates.", "Eaque sit eos soluta cum eos magnam molestias est vitae praesentium vero voluptas cupiditate nihil voluptas cupiditate voluptas culpa expedita." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Naam" },
                values: new object[] { 305, "Nemo atque est accusantium et quasi alias deserunt harum et cupiditate quidem consectetur quibusdam hic omnis repellat quia aut exercitationem.", "At debitis laudantium laborum vitae porro voluptatem nobis aut adipisci rerum distinctio velit eos tempora temporibus omnis iste voluptates sunt." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 330, "Modi non animi qui facere hic quam iste provident officiis consectetur inventore porro est voluptatum minus consectetur ad delectus animi.", 4, "Qui commodi ut ratione debitis rerum molestiae amet ea temporibus praesentium corporis architecto quam nihil hic aliquid quaerat blanditiis porro." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Naam" },
                values: new object[] { 388, "Sunt est velit rerum beatae totam illum eaque esse ipsum adipisci corrupti debitis aperiam voluptas voluptas debitis nam adipisci officia.", "Eaque et atque temporibus repellendus doloribus assumenda eius tempora deleniti voluptatem ut deserunt ducimus tempore odit omnis eum et reiciendis." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Naam" },
                values: new object[] { 327, "Porro cum iste aut dicta ex asperiores accusamus deserunt possimus nostrum aut culpa eos placeat ut explicabo distinctio et optio.", "Blanditiis aperiam dignissimos nostrum quis totam quis porro voluptate illo ab minus dignissimos aut nam nulla sed libero voluptatum ut." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 318, "Deserunt et voluptatem consequatur et porro itaque a assumenda quia totam eum non numquam qui ut eos dolore eum est.", 4, "Dolorum nihil ullam cupiditate quibusdam dolor voluptatem est magnam saepe totam voluptas ducimus rerum voluptas repudiandae vel eum itaque sit." });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "ullam", "Elin Veen V", "Berg - Boer" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "dolores", "Bsc Juda Stichting", "Jong, Brink and Bakker" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "voluptatum", "Prof. Mara Boer", "Ven - Hoek" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "veritatis", "Chloe Vliet Jr.", "Groot International" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "minus", "Nino Schouten II", "Dekker - Jacobs" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "doloremque", "Senna Bos II", "Brink IT" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "perspiciatis", "Josefien Wit II", "Meer - Janssen" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "maiores", "Arthur Brouwer IV", "Brink - Peters" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "vero", "Prof. Moos Linden", "Berg - Bos" });

            migrationBuilder.UpdateData(
                table: "StudentenKaart",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Klas", "Naam", "School" },
                values: new object[] { "velit", "Msc Jesper Dijkstra", "Jacobs BV" });
        }
    }
}
