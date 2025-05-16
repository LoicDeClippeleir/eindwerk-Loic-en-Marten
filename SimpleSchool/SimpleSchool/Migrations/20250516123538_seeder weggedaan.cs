using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SimpleSchool.Migrations
{
    /// <inheritdoc />
    public partial class seederweggedaan : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Smitsdijk 367a", "accusamus", new DateTime(2025, 1, 11, 7, 24, 40, 600, DateTimeKind.Local).AddTicks(3958), "Animi aspernatur veritatis minus eius voluptas ullam laborum praesentium saepe non facilis molestiae tenetur est deserunt non debitis assumenda occaecati." });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Brouwerhof 5", "voluptas", new DateTime(2025, 5, 5, 19, 49, 26, 81, DateTimeKind.Local).AddTicks(9745), "Necessitatibus necessitatibus porro ut velit ipsum facere et hic et natus et aut libero voluptatem labore aut aperiam dolores tempora." });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Anoukhof 164a", "dicta", new DateTime(2024, 12, 25, 10, 5, 50, 1, DateTimeKind.Local).AddTicks(6502), "Nobis occaecati eaque numquam ut illo aut autem et ut totam qui qui excepturi dolorem aspernatur commodi repellat amet laboriosam." });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Annakade 585a", "id", new DateTime(2024, 10, 20, 1, 34, 22, 248, DateTimeKind.Local).AddTicks(2091), "Labore harum et libero earum impedit culpa eum dignissimos quia in ut pariatur ut officiis tempora enim velit et et." });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Jonghof 693 III", "et", new DateTime(2024, 6, 13, 17, 33, 38, 832, DateTimeKind.Local).AddTicks(8783), "Nobis minima qui fuga et nostrum adipisci quod quia ut eius sunt eum quibusdam quam pariatur consequatur dicta molestias iure." });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Kostersloot 98", "eos", new DateTime(2024, 6, 29, 13, 13, 23, 217, DateTimeKind.Local).AddTicks(8792), "Nemo ex et ut molestias eos quia asperiores et voluptate ipsum rerum doloribus assumenda sed eaque suscipit aut quisquam maiores." });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Juliavelt 127c", "ullam", new DateTime(2025, 1, 13, 15, 36, 29, 463, DateTimeKind.Local).AddTicks(8045), "Quis necessitatibus vero delectus et voluptas rerum et molestias alias voluptates autem accusantium quos distinctio voluptatibus repellendus iusto nisi inventore." });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Jansenhof 505a", "ducimus", new DateTime(2024, 9, 13, 22, 43, 5, 385, DateTimeKind.Local).AddTicks(7691), "Vero ad quia est consequatur omnis incidunt modi blanditiis et et eos distinctio eum omnis dolores veniam adipisci soluta possimus." });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Janssenplein 46", "id", new DateTime(2025, 2, 26, 12, 12, 48, 529, DateTimeKind.Local).AddTicks(3847), "Error neque illo velit quo ipsam rerum aut explicabo natus dignissimos maxime non laboriosam hic ratione ut rem est ut." });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Vensloot 008a", "quia", new DateTime(2024, 10, 31, 0, 14, 39, 197, DateTimeKind.Local).AddTicks(531), "Incidunt ut autem voluptas libero amet quod modi ut non quis totam quo ea consequatur labore delectus illo et ut." });

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
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Maxplantsoen 498a", "quam", new DateTime(2024, 7, 13, 2, 46, 20, 429, DateTimeKind.Local).AddTicks(2091), "Officiis sed quae cum expedita accusantium in non perspiciatis dicta dolorem dolorum repellat quisquam quis et tempore dolores ut dignissimos." });

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
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 220, "Facere voluptas impedit quis nemo nihil voluptates in et magni nihil dolore et cum blanditiis eum fugiat et harum et.", 3, "Quasi deleniti neque et ducimus cum eligendi officia quam ut aut et dolores odit nemo pariatur officia quod officia quis." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 327, "Reprehenderit voluptatibus voluptatem ipsum blanditiis quisquam reiciendis placeat dolor quo est ullam temporibus debitis suscipit autem dolorem vel cumque ab.", 3, "Quisquam accusamus ut quia assumenda error recusandae error tempore laboriosam porro maxime deserunt et vitae ut sit molestias aut voluptatem." });

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
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 269, "Quisquam reiciendis temporibus animi magni quis ut voluptas odio maiores accusamus qui accusamus quis quia a ab quos voluptatum voluptates.", 4, "Eaque sit eos soluta cum eos magnam molestias est vitae praesentium vero voluptas cupiditate nihil voluptas cupiditate voluptas culpa expedita." });

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
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 388, "Sunt est velit rerum beatae totam illum eaque esse ipsum adipisci corrupti debitis aperiam voluptas voluptas debitis nam adipisci officia.", 3, "Eaque et atque temporibus repellendus doloribus assumenda eius tempora deleniti voluptatem ut deserunt ducimus tempore odit omnis eum et reiciendis." });

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
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Naam" },
                values: new object[] { 318, "Deserunt et voluptatem consequatur et porro itaque a assumenda quia totam eum non numquam qui ut eos dolore eum est.", "Dolorum nihil ullam cupiditate quibusdam dolor voluptatem est magnam saepe totam voluptas ducimus rerum voluptas repudiandae vel eum itaque sit." });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Johanneslaan 046b", "tenetur", new DateTime(2024, 9, 4, 15, 38, 7, 700, DateTimeKind.Local).AddTicks(4399), "Numquam sed est ea sit consequuntur molestiae ipsa dolorem enim necessitatibus atque consequatur et rerum reprehenderit laudantium quam saepe eos." });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Brinkpassage 391 I", "quisquam", new DateTime(2024, 7, 14, 7, 59, 38, 432, DateTimeKind.Local).AddTicks(9936), "Consequuntur ratione dignissimos corrupti culpa dolorem et omnis corporis dolores blanditiis ut illum ab quibusdam provident sit accusamus amet rem." });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Jonghof 958 I", "quod", new DateTime(2024, 12, 24, 12, 36, 13, 815, DateTimeKind.Local).AddTicks(1126), "Necessitatibus minus dolor assumenda qui quos quasi dolor voluptas ut incidunt saepe nihil libero quisquam sequi animi odio velit repudiandae." });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Thomassteeg 103c", "incidunt", new DateTime(2024, 11, 6, 2, 43, 52, 958, DateTimeKind.Local).AddTicks(9724), "Repellendus corrupti dolores odit repellendus eos ut occaecati ad sed reiciendis excepturi vitae enim fuga iste non rerum vel modi." });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Meijerpark 247 II", "sed", new DateTime(2024, 10, 17, 7, 25, 59, 514, DateTimeKind.Local).AddTicks(8335), "Facere id enim dolor laboriosam aut quaerat officiis dolor recusandae aut dolorem quia nihil molestiae consequatur neque nisi rem dolor." });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Jansensloot 428a", "et", new DateTime(2024, 8, 4, 17, 38, 27, 201, DateTimeKind.Local).AddTicks(2361), "Ad sit expedita accusamus expedita debitis culpa sapiente libero deserunt explicabo perspiciatis magni quis repellat voluptas facere reiciendis unde possimus." });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Basstraat 858b", "et", new DateTime(2024, 10, 30, 18, 37, 3, 723, DateTimeKind.Local).AddTicks(3911), "Officiis nisi ut modi nemo maiores et dignissimos nostrum quae quae vero rerum reiciendis voluptatum quibusdam quas aliquid laboriosam et." });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Vissersteeg 895b", "amet", new DateTime(2025, 1, 30, 15, 31, 10, 174, DateTimeKind.Local).AddTicks(2810), "Molestiae vel perferendis sit qui veritatis voluptates fugit autem voluptas eum quas quis asperiores debitis quia reiciendis occaecati est sit." });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Lottestraat 868a", "incidunt", new DateTime(2025, 3, 4, 13, 59, 42, 905, DateTimeKind.Local).AddTicks(8263), "Ea atque non vero dolores vero eius beatae illum pariatur laboriosam iusto laboriosam impedit ut minus ut ut praesentium excepturi." });

            migrationBuilder.UpdateData(
                table: "Leerkracht",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[] { "Stijndijk 998a", "fugiat", new DateTime(2025, 3, 22, 11, 41, 32, 847, DateTimeKind.Local).AddTicks(1044), "Sed distinctio minima et cum dolorem eaque esse minus quos voluptatem perferendis alias voluptas impedit non molestias repellat porro sit." });

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
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Naam" },
                values: new object[] { 368, "Fugiat et hic sunt autem et ducimus id possimus illum quae dolores quod modi et assumenda temporibus voluptatem et ad.", "Voluptas aliquam quia et omnis est nisi fugiat harum neque laudantium mollitia ad repellat molestiae veritatis illo autem iste ab." });

            migrationBuilder.UpdateData(
                table: "Opleiding",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[] { 257, "Dignissimos qui voluptates ut expedita neque sed nesciunt et alias maxime ab maxime et delectus rerum totam ab exercitationem non.", 4, "Perferendis numquam id aperiam voluptatum earum atque voluptatem velit iusto blanditiis reiciendis porro omnis ut aliquam nihil minus possimus velit." });

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
                columns: new[] { "BeschikbarePlaatsen", "Beschrijving", "Naam" },
                values: new object[] { 240, "Dolor alias iste totam qui et sint dolor id fugit rerum beatae consequatur quam fugiat incidunt et natus earum consequuntur.", "Est aut et dignissimos praesentium ut est ea sit distinctio atque rerum dolorum sed ex aperiam quaerat voluptatibus libero eum." });

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

            migrationBuilder.InsertData(
                table: "Vak",
                columns: new[] { "Id", "AantalStudiePunten", "LeerkrachtId", "Naam", "Taal", "Vaktype" },
                values: new object[,]
                {
                    { 11, 43, 11, "Mevr. Dr. Jaivey Brouwer", "transmit", 1 },
                    { 12, 19, 12, "Fien Beek III", "object-oriented", 0 },
                    { 13, 19, 13, "Dirk Haan II", "Egyptian Pound", 1 },
                    { 14, 14, 14, "Msc Jesse Mulder", "Fresh", 0 },
                    { 15, 34, 15, "Prof. Meike Stichting", "synthesize", 0 },
                    { 16, 24, 16, "Florence Bos Jr.", "cultivate", 0 },
                    { 17, 40, 17, "Dhr. Kaylee Willems", "Gorgeous Fresh Shirt", 1 },
                    { 18, 38, 18, "Nienke Ruiter Sr.", "Via", 0 },
                    { 19, 22, 19, "Isra Janssen IV", "cyan", 1 },
                    { 20, 36, 20, "Isra Maas IV", "Comoros", 1 }
                });
        }
    }
}
