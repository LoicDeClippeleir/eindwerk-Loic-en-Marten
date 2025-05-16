using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SimpleSchool.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Leerkracht",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GeboorteDatum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leerkracht", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Opleiding",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duur = table.Column<int>(type: "int", nullable: false),
                    BeschikbarePlaatsen = table.Column<int>(type: "int", nullable: false),
                    Beschrijving = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Opleiding", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StudentenKaart",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Klas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    School = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentenKaart", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vak",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Taal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AantalStudiePunten = table.Column<int>(type: "int", nullable: false),
                    Vaktype = table.Column<int>(type: "int", nullable: false),
                    LeerkrachtId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vak", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vak_Leerkracht_LeerkrachtId",
                        column: x => x.LeerkrachtId,
                        principalTable: "Leerkracht",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Leerling",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GeboorteDatum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentenkaartId = table.Column<int>(type: "int", nullable: false),
                    OpleidingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leerling", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Leerling_Opleiding_OpleidingId",
                        column: x => x.OpleidingId,
                        principalTable: "Opleiding",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Leerling_StudentenKaart_StudentenkaartId",
                        column: x => x.StudentenkaartId,
                        principalTable: "StudentenKaart",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Opleidingsvakken",
                columns: table => new
                {
                    OpleidingenId = table.Column<int>(type: "int", nullable: false),
                    VakkenId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Opleidingsvakken", x => new { x.OpleidingenId, x.VakkenId });
                    table.ForeignKey(
                        name: "FK_Opleidingsvakken_Opleiding_OpleidingenId",
                        column: x => x.OpleidingenId,
                        principalTable: "Opleiding",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Opleidingsvakken_Vak_VakkenId",
                        column: x => x.VakkenId,
                        principalTable: "Vak",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Leerkracht",
                columns: new[] { "Id", "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[,]
                {
                    { 11, "Vensloot 5", "est", new DateTime(2025, 2, 22, 17, 46, 3, 5, DateTimeKind.Local).AddTicks(3465), "Inventore esse saepe hic qui commodi velit reprehenderit sequi consectetur et odit enim sunt veniam voluptatem dolorem cupiditate quasi totam." },
                    { 12, "Noarijk 142c", "ut", new DateTime(2024, 7, 2, 17, 18, 4, 394, DateTimeKind.Local).AddTicks(716), "Vitae distinctio perspiciatis veritatis sed tempore et sint deserunt repellat qui sit aut voluptatem rerum facere aliquam dolorem a porro." },
                    { 13, "Vlietweg 097 II", "eveniet", new DateTime(2024, 5, 30, 9, 15, 51, 398, DateTimeKind.Local).AddTicks(6709), "Corrupti natus et dicta repellendus nesciunt autem laboriosam et possimus quis fuga aspernatur facere officiis nostrum porro voluptatem debitis aliquid." },
                    { 14, "Boerrijk 505b", "sit", new DateTime(2024, 6, 24, 18, 54, 55, 347, DateTimeKind.Local).AddTicks(2178), "Nisi expedita enim error voluptas repellat qui necessitatibus rem dolorem voluptates quis vel quibusdam cupiditate laudantium omnis rem asperiores distinctio." },
                    { 15, "Bergdijk 091b", "ad", new DateTime(2024, 12, 7, 22, 17, 57, 776, DateTimeKind.Local).AddTicks(5480), "Porro facilis ut in numquam et modi sit adipisci qui non amet ut ut totam accusantium rerum ut nostrum voluptatum." },
                    { 16, "Juliagracht 273c", "est", new DateTime(2024, 7, 2, 18, 32, 46, 126, DateTimeKind.Local).AddTicks(4253), "Nihil debitis molestias vero laboriosam ea qui sint provident nulla et pariatur quos quia doloribus cum maxime veritatis aut quibusdam." },
                    { 17, "Vrieskade 81", "inventore", new DateTime(2024, 6, 25, 11, 17, 18, 251, DateTimeKind.Local).AddTicks(7207), "Velit ipsum corrupti rerum facere non ab dolorem quia ea veritatis sint vero minus nesciunt quisquam hic minima architecto rerum." },
                    { 18, "Julianpark 408", "aut", new DateTime(2025, 5, 5, 12, 30, 39, 723, DateTimeKind.Local).AddTicks(5948), "Ratione et harum aut corrupti quis pariatur vel quaerat vitae et porro maiores voluptas exercitationem animi alias odit veniam quaerat." },
                    { 19, "Noaplein 7", "repudiandae", new DateTime(2025, 2, 6, 2, 24, 46, 493, DateTimeKind.Local).AddTicks(3009), "Pariatur labore nobis itaque vero qui sint eaque voluptatibus aliquid corrupti amet est quo repellendus modi consequatur aut voluptatem hic." },
                    { 20, "Beekstraat 095b", "dolorem", new DateTime(2025, 5, 5, 7, 58, 36, 978, DateTimeKind.Local).AddTicks(154), "Totam ipsam at sint fugiat non nesciunt perferendis blanditiis quis aliquid omnis consequatur voluptatem deserunt et et velit facilis hic." }
                });

            migrationBuilder.InsertData(
                table: "Opleiding",
                columns: new[] { "Id", "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[,]
                {
                    { 11, 372, "Aut qui reiciendis delectus dignissimos laboriosam omnis animi ipsa consequatur velit dolor ad et magnam veniam voluptatum reiciendis adipisci adipisci.", 3, "Ullam aspernatur quod minima porro ullam dolores neque consectetur et qui deleniti labore quo earum sapiente in recusandae saepe necessitatibus." },
                    { 12, 204, "Minus ut recusandae ipsam fugiat molestiae laboriosam nostrum est dolores voluptatum sit illo ut et illo aperiam maxime sed ratione.", 4, "Qui et eum itaque ea excepturi sit enim non nihil nihil quod vero quisquam omnis dignissimos repellendus nam quas doloribus." },
                    { 13, 263, "Dolor et qui a libero vel sequi dolor maiores rerum et earum ea id cum molestiae totam cumque occaecati aut.", 4, "Modi ex ipsa rerum vitae ex rem nobis pariatur ea eum ratione neque aut omnis omnis vel modi delectus eum." },
                    { 14, 397, "Laboriosam deleniti pariatur rerum minima quibusdam qui non omnis quia ipsum repellendus aliquid a et inventore ad doloribus placeat suscipit.", 3, "Doloribus autem velit doloremque est doloremque voluptatem et ea labore aliquid similique qui deleniti itaque perferendis voluptas sit quidem voluptatem." },
                    { 15, 288, "Hic accusamus modi qui doloremque aut quia ab possimus iusto sit cumque non esse expedita corrupti quae est sed velit.", 3, "Nihil quidem sed fuga perferendis ut modi occaecati nihil debitis earum non est amet reiciendis minus culpa unde laudantium illo." },
                    { 16, 328, "Atque et quae ut vel nihil ea est a earum natus nihil non vel corrupti qui sapiente ut incidunt accusamus.", 3, "Dignissimos et autem ut nihil ea in voluptas quod doloribus laboriosam animi rerum fugiat repudiandae laboriosam voluptatibus tenetur est voluptas." },
                    { 17, 364, "Repellendus magnam enim et aut qui et alias nostrum necessitatibus fugiat nobis sint ratione error iste ipsa dicta architecto quaerat.", 3, "Voluptates perferendis dolore sapiente repudiandae esse unde et illum culpa consequatur excepturi neque facilis voluptatem nam porro aut consequuntur beatae." },
                    { 18, 277, "Accusantium sit et facilis possimus quas deleniti ex quo doloremque aut eius iure consequatur rerum nisi rerum quibusdam quo sunt.", 3, "Harum et sit doloremque harum temporibus nihil qui eius repellat autem quis iure atque omnis sequi et qui optio dolore." },
                    { 19, 343, "Velit consequatur et quia sit veritatis deleniti et non est dolorum quis iure harum aut earum maxime praesentium ut est.", 3, "Esse dolorem aperiam et maiores eius tenetur nemo ut et fugiat consequatur rerum officiis necessitatibus omnis nam adipisci autem nulla." },
                    { 20, 256, "Beatae molestias suscipit ipsum vitae exercitationem hic consequuntur dolores qui et aut soluta quibusdam non praesentium quae odit rerum quibusdam.", 4, "Repellendus non ducimus cumque animi numquam qui doloribus voluptates quo omnis quo ipsum quidem omnis id ut veritatis omnis dolores." }
                });

            migrationBuilder.InsertData(
                table: "StudentenKaart",
                columns: new[] { "Id", "Klas", "Naam", "School" },
                values: new object[,]
                {
                    { 11, "alias", "Siep Dijk Sr.", "Stichting, Mulder and Heuvel" },
                    { 12, "ipsum", "Dhr. Bodhi Smits", "Stichting, Smits and Maas" },
                    { 13, "laborum", "Lauren Willems Sr.", "Bruin, Hoek and Klein" },
                    { 14, "est", "Jacky Ruiter Sr.", "Bruin - Smits" },
                    { 15, "aut", "George Jacobs Jr.", "Klein N.V." },
                    { 16, "sit", "Msc Miguel Groot", "Vos IT" },
                    { 17, "nam", "Khadija Meer I", "Janssen International" },
                    { 18, "aut", "Janne Peters II", "Smit, Peters and Veen" },
                    { 19, "amet", "Nout Heuvel II", "Beek, Dekker and Graaf" },
                    { 20, "facere", "Dhr. Vieve Linden", "Veen - Vliet" }
                });

            migrationBuilder.InsertData(
                table: "Vak",
                columns: new[] { "Id", "AantalStudiePunten", "LeerkrachtId", "Naam", "Taal", "Vaktype" },
                values: new object[,]
                {
                    { 11, 16, 0, "Noud Vries III", "Dynamic", 0 },
                    { 12, 25, 0, "Prof. Samuel Vries", "Steel", 1 },
                    { 13, 45, 0, "Lex Boer II", "primary", 1 },
                    { 14, 45, 0, "Anna Brouwer I", "salmon", 0 },
                    { 15, 21, 0, "Prof. Louay Janssen", "bypassing", 1 },
                    { 16, 11, 0, "Manu Dam IV", "Health & Music", 0 },
                    { 17, 33, 0, "Natan Groot I", "CFP Franc", 0 },
                    { 18, 36, 0, "Matthijs Meijer Jr.", "5th generation", 1 },
                    { 19, 15, 0, "Ted Leeuwen I", "payment", 1 },
                    { 20, 38, 0, "Prof. Dirk Janssen", "Cape Verde", 0 }
                });

            migrationBuilder.InsertData(
                table: "Leerling",
                columns: new[] { "Id", "Adres", "EMail", "GeboorteDatum", "Naam", "OpleidingId", "StudentenkaartId" },
                values: new object[,]
                {
                    { 11, "Daanhof 833", "magnam", new DateTime(2024, 12, 9, 4, 31, 41, 184, DateTimeKind.Local).AddTicks(4157), "Corrupti eaque necessitatibus placeat doloremque mollitia vero sed cum vel itaque culpa modi id laborum aut dolores rerum cum doloribus.", 11, 11 },
                    { 12, "Beeksloot 9", "sed", new DateTime(2025, 3, 20, 18, 32, 27, 372, DateTimeKind.Local).AddTicks(464), "Qui enim nemo quia et unde eaque consequatur ea ipsam aut molestiae sit et illum placeat in eaque inventore voluptas.", 12, 12 },
                    { 13, "Lucasdijk 45", "sit", new DateTime(2025, 4, 2, 15, 50, 39, 428, DateTimeKind.Local).AddTicks(5149), "Non animi fugiat vero quas voluptatibus nulla quod culpa eos quia et aut a quia sunt velit ut magni itaque.", 13, 13 },
                    { 14, "Vriesweg 264 III", "placeat", new DateTime(2024, 12, 24, 22, 51, 12, 348, DateTimeKind.Local).AddTicks(4065), "Commodi ut temporibus omnis vitae tenetur voluptatibus perspiciatis placeat voluptatum numquam in debitis in ut ea labore deleniti cum sint.", 14, 14 },
                    { 15, "Bosrijk 978c", "exercitationem", new DateTime(2024, 6, 14, 20, 13, 10, 693, DateTimeKind.Local).AddTicks(1530), "Quia dolore molestiae iste mollitia velit quia sapiente aut quo fugiat vel magni sequi dignissimos dolorem assumenda in laudantium assumenda.", 15, 15 },
                    { 16, "Bruingracht 050 II", "ea", new DateTime(2025, 5, 16, 8, 53, 39, 698, DateTimeKind.Local).AddTicks(8917), "Et laborum et aliquam et sit et voluptas consequatur praesentium et voluptates sunt placeat magnam cum eligendi vel autem facere.", 16, 16 },
                    { 17, "Leeuwenhof 044 II", "fuga", new DateTime(2024, 12, 16, 10, 56, 48, 766, DateTimeKind.Local).AddTicks(8871), "Ipsam dicta temporibus natus similique consequuntur neque similique totam qui voluptatum fugiat sed ut omnis pariatur molestiae nihil adipisci illo.", 17, 17 },
                    { 18, "Isadijk 201a", "sunt", new DateTime(2025, 2, 16, 11, 5, 38, 889, DateTimeKind.Local).AddTicks(2140), "Sit neque odit illo eum veniam qui voluptatem eum qui quasi sunt perspiciatis quod atque omnis est repellat illo sit.", 18, 18 },
                    { 19, "Jacobsdijk 070 II", "neque", new DateTime(2024, 7, 26, 7, 2, 19, 481, DateTimeKind.Local).AddTicks(8461), "Qui eos facilis et dolores vitae tempore enim deleniti qui necessitatibus cum incidunt aut quo quam ratione qui sit quia.", 19, 19 },
                    { 20, "Evaplantsoen 774 II", "dolor", new DateTime(2024, 11, 2, 14, 22, 25, 365, DateTimeKind.Local).AddTicks(2884), "Aspernatur nihil tenetur molestias cumque nulla eum consequatur et cupiditate provident sunt at doloribus et quia ducimus accusantium quia corrupti.", 20, 20 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Leerling_OpleidingId",
                table: "Leerling",
                column: "OpleidingId");

            migrationBuilder.CreateIndex(
                name: "IX_Leerling_StudentenkaartId",
                table: "Leerling",
                column: "StudentenkaartId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Opleidingsvakken_VakkenId",
                table: "Opleidingsvakken",
                column: "VakkenId");

            migrationBuilder.CreateIndex(
                name: "IX_Vak_LeerkrachtId",
                table: "Vak",
                column: "LeerkrachtId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Leerling");

            migrationBuilder.DropTable(
                name: "Opleidingsvakken");

            migrationBuilder.DropTable(
                name: "StudentenKaart");

            migrationBuilder.DropTable(
                name: "Opleiding");

            migrationBuilder.DropTable(
                name: "Vak");

            migrationBuilder.DropTable(
                name: "Leerkracht");
        }
    }
}
