using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SimpleSchool.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
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
                    { 11, "Stichtinggracht 79", "maiores", new DateTime(2024, 12, 9, 17, 9, 48, 48, DateTimeKind.Local).AddTicks(4083), "Sunt at sed delectus voluptatibus reprehenderit ut suscipit nesciunt cupiditate recusandae voluptates tenetur sint repellat sed est autem autem laboriosam." },
                    { 12, "Roosdijk 3", "suscipit", new DateTime(2024, 8, 26, 19, 46, 33, 165, DateTimeKind.Local).AddTicks(8239), "Quis explicabo ea aspernatur non itaque debitis et velit et voluptatem quia assumenda iste in quis est dolore pariatur eos." },
                    { 13, "Graafvelt 949", "perspiciatis", new DateTime(2024, 6, 2, 4, 8, 55, 956, DateTimeKind.Local).AddTicks(9812), "Quis ipsum pariatur voluptatem voluptatum laboriosam officiis molestiae provident consequatur nihil culpa sed omnis non enim tempora numquam tempore et." },
                    { 14, "Hendriksmarkt 9", "ut", new DateTime(2025, 2, 28, 19, 59, 57, 36, DateTimeKind.Local).AddTicks(1001), "Laboriosam nihil fugiat natus minima accusantium numquam rerum facilis molestiae soluta ratione facere debitis qui enim sit quia aut ea." },
                    { 15, "Daanlaan 751 I", "aut", new DateTime(2025, 4, 27, 14, 44, 55, 516, DateTimeKind.Local).AddTicks(5834), "Voluptatibus qui quasi et repellat sunt totam quisquam maxime iste enim et explicabo laboriosam sunt et placeat illum temporibus tempora." },
                    { 16, "Vosplein 97", "ut", new DateTime(2024, 6, 15, 19, 27, 5, 121, DateTimeKind.Local).AddTicks(7066), "Quia qui a dolore ut dolorem ea omnis ratione dolor velit aut cupiditate praesentium ut nemo voluptatem debitis ut et." },
                    { 17, "Meijerweg 413 I", "consequatur", new DateTime(2024, 7, 17, 6, 50, 35, 317, DateTimeKind.Local).AddTicks(2525), "Non fugiat libero neque qui aliquid qui ut pariatur iusto maxime rerum maiores libero est vel a corrupti quia consectetur." },
                    { 18, "Vriesgracht 853 III", "corrupti", new DateTime(2024, 6, 6, 14, 35, 49, 574, DateTimeKind.Local).AddTicks(1269), "Non rerum eum maiores eius ut maxime earum itaque aut vitae voluptas esse odio modi voluptatem itaque accusamus molestiae accusantium." },
                    { 19, "Johanneskade 500c", "quibusdam", new DateTime(2025, 1, 31, 13, 14, 27, 44, DateTimeKind.Local).AddTicks(2808), "Nobis ea nihil molestias molestias odit et alias qui voluptatem quasi sit unde et odit architecto reprehenderit quam id harum." },
                    { 20, "Berghof 310a", "omnis", new DateTime(2024, 8, 26, 10, 42, 5, 571, DateTimeKind.Local).AddTicks(4900), "Quis et et qui molestiae soluta laboriosam et recusandae sed occaecati recusandae quam neque a recusandae itaque earum cum eos." }
                });

            migrationBuilder.InsertData(
                table: "Opleiding",
                columns: new[] { "Id", "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[,]
                {
                    { 11, 304, "Dolor in voluptas id aut cupiditate tenetur iure officia a minima aut dolor eos ab rerum ratione molestiae minima aut.", 4, "Consequatur incidunt facilis odit nihil et quia perferendis quisquam unde debitis aut quia enim qui est nobis et quis minus." },
                    { 12, 266, "A et minus aspernatur magni soluta rerum id ex commodi blanditiis soluta iure voluptatem et vel enim voluptatem sit maxime.", 3, "Magni nesciunt delectus excepturi laudantium tenetur adipisci quia rerum nam sunt aut minus corrupti ab dolore omnis est rerum et." },
                    { 13, 229, "Nemo qui expedita ab aspernatur accusantium vel sapiente esse dolorum totam ipsam eum doloremque illo similique porro iusto deserunt quo.", 4, "Quas molestiae accusamus dolorem vel eligendi sunt et ipsum blanditiis veniam deleniti repudiandae quibusdam velit quae omnis consequatur qui excepturi." },
                    { 14, 241, "Eaque nam aut animi ut ipsum asperiores non est eum et minus culpa voluptate est soluta veniam molestias sed molestiae.", 4, "Similique ut beatae aut voluptas officia qui eum aperiam et velit illum quia ex et qui molestias voluptas deserunt veritatis." },
                    { 15, 365, "Quaerat illum eveniet dignissimos omnis non dolores eum quae dicta vero natus minima provident dolore commodi blanditiis et facere vitae.", 3, "Molestiae molestias quam est qui rem esse repudiandae inventore reprehenderit nulla provident pariatur commodi eos esse sapiente dolorem dolorum et." },
                    { 16, 246, "Nisi possimus tempore quis vitae sit ipsum animi impedit quia eveniet enim tempore alias ad molestias natus iste distinctio voluptatem.", 3, "Voluptatem quaerat ut reprehenderit rerum eius unde incidunt porro fugit necessitatibus omnis eaque aut dolore animi placeat cumque eligendi quia." },
                    { 17, 223, "Ea assumenda et est et dolore voluptas et eos dolores perspiciatis sequi quia esse error commodi voluptas voluptates ab cupiditate.", 3, "Aut non adipisci nemo cupiditate quia veniam facilis laborum possimus aut unde nam sint repudiandae dolor porro mollitia dolores numquam." },
                    { 18, 274, "Et libero consequatur molestias quibusdam et eius aliquid eum tempora dolorem sed consequuntur qui qui ullam beatae cum nesciunt fugiat.", 3, "Doloribus tenetur ipsam aliquid est facere sunt quos autem delectus nihil dignissimos sed asperiores cupiditate molestiae expedita quibusdam maxime aperiam." },
                    { 19, 288, "Dolores adipisci minima libero et quasi aut ex quisquam quasi debitis deleniti et odio tenetur et iste libero est vitae.", 3, "Ducimus quia quo aspernatur hic magni necessitatibus dolores impedit ut neque perferendis non et suscipit est ut eos a deserunt." },
                    { 20, 270, "Magnam explicabo dolores qui optio saepe eligendi odio qui nostrum voluptatibus consectetur quibusdam ad dolores quia laboriosam ex tenetur ipsum.", 3, "Facilis eos veritatis sequi voluptas molestias sed aut tenetur itaque quisquam similique error aut ipsa sint qui veniam voluptatem illum." }
                });

            migrationBuilder.InsertData(
                table: "StudentenKaart",
                columns: new[] { "Id", "Klas", "Naam", "School" },
                values: new object[,]
                {
                    { 11, "nemo", "Mevr. Dr. Noor Smit", "Klein, Vos and Vliet" },
                    { 12, "enim", "Emilia Wit Jr.", "Wit Group" },
                    { 13, "pariatur", "Amina Klein Jr.", "Hoek - Jong" },
                    { 14, "ut", "Sanna Berg I", "Dam, Dijkstra and Groot" },
                    { 15, "eos", "Dhr. Valentino Beek", "Wal, Ven and Vermeulen" },
                    { 16, "minus", "Dhr. Pleun Groot", "Klein, Bruin and Hoek" },
                    { 17, "ut", "Kyan Haan I", "Dijk, Vermeulen and Jacobs" },
                    { 18, "consequatur", "Puck Wal I", "Kok B.V." },
                    { 19, "cupiditate", "Jaelynn Leeuwen III", "Vermeulen, Ruiter and Vermeulen" },
                    { 20, "reprehenderit", "Skye Bakker II", "Heuvel Maatschappij" }
                });

            migrationBuilder.InsertData(
                table: "Leerling",
                columns: new[] { "Id", "Adres", "EMail", "GeboorteDatum", "Naam", "OpleidingId", "StudentenkaartId" },
                values: new object[,]
                {
                    { 11, "Anneplantsoen 431a", "consequatur", new DateTime(2024, 8, 31, 9, 48, 51, 514, DateTimeKind.Local).AddTicks(7164), "Voluptatem velit dolorem rerum fuga perferendis dolore tempora quia qui hic sed aut hic animi reprehenderit in nisi ab optio.", 11, 11 },
                    { 12, "Semweg 883a", "debitis", new DateTime(2024, 12, 22, 17, 20, 48, 216, DateTimeKind.Local).AddTicks(3896), "Et eius error qui sed natus sed rem quis neque perferendis excepturi vel ex tempora quia et laborum nostrum quasi.", 12, 12 },
                    { 13, "Ricksteeg 239b", "maxime", new DateTime(2024, 10, 11, 12, 50, 44, 397, DateTimeKind.Local).AddTicks(8001), "Expedita autem debitis maiores quia qui iste a maxime eaque consectetur non aut necessitatibus nobis sed et soluta odit voluptas.", 13, 13 },
                    { 14, "Rubenhof 628c", "eligendi", new DateTime(2024, 8, 7, 10, 50, 52, 279, DateTimeKind.Local).AddTicks(9216), "Amet quis sunt alias quas eius harum reprehenderit ratione dolores est optio et magnam aut voluptatum et aut fuga fuga.", 14, 14 },
                    { 15, "Dampark 525c", "error", new DateTime(2024, 12, 2, 20, 21, 57, 268, DateTimeKind.Local).AddTicks(9592), "Veniam ullam rerum possimus at qui ea ut iure laudantium similique eaque provident est consectetur voluptates aut sint qui quaerat.", 15, 15 },
                    { 16, "Hoekplein 953 I", "impedit", new DateTime(2025, 5, 7, 18, 49, 2, 495, DateTimeKind.Local).AddTicks(6748), "Deserunt aperiam qui corporis non aliquid illo odit qui veritatis sed recusandae dolores nesciunt illo maxime nesciunt sed accusamus vero.", 16, 16 },
                    { 17, "Lucashof 194 II", "non", new DateTime(2025, 1, 16, 17, 47, 19, 669, DateTimeKind.Local).AddTicks(1527), "Dolor pariatur id autem officiis sed saepe tempora in voluptas vero est occaecati suscipit eos cupiditate quasi voluptatum quidem laudantium.", 17, 17 },
                    { 18, "Annavelt 32", "adipisci", new DateTime(2024, 9, 24, 16, 49, 44, 147, DateTimeKind.Local).AddTicks(2956), "Soluta aut iste eaque rerum enim adipisci cumque quis occaecati pariatur non quisquam doloremque alias quaerat consectetur accusamus at vero.", 18, 18 },
                    { 19, "Anoukmarkt 740b", "optio", new DateTime(2025, 1, 29, 23, 31, 44, 123, DateTimeKind.Local).AddTicks(7619), "Maiores impedit maxime nemo et nesciunt facere numquam atque qui et voluptas consequatur amet sed et voluptate aut est autem.", 19, 19 },
                    { 20, "Vriesplantsoen 420 I", "voluptas", new DateTime(2024, 10, 7, 1, 48, 41, 737, DateTimeKind.Local).AddTicks(287), "Ut veritatis quo laudantium ullam consequatur odit dolorum illum accusamus dolore ipsa nihil quam maiores non minima consequatur velit totam.", 20, 20 }
                });

            migrationBuilder.InsertData(
                table: "Vak",
                columns: new[] { "Id", "AantalStudiePunten", "LeerkrachtId", "Naam", "Taal", "Vaktype" },
                values: new object[,]
                {
                    { 11, 47, 11, "Prof. Lex Hendriks", "Club", 0 },
                    { 12, 35, 12, "Mehmet Stichting I", "Jewelery & Electronics", 1 },
                    { 13, 25, 13, "Bsc Maurits Hendriks", "navigate", 0 },
                    { 14, 48, 14, "Isa Vos V", "transmitter", 0 },
                    { 15, 22, 15, "Mevr. Dr. Emilia Klein", "black", 1 },
                    { 16, 32, 16, "Msc Isabelle Brouwer", "Unbranded Cotton Sausages", 1 },
                    { 17, 25, 17, "Marley Peters Jr.", "Cambridgeshire", 0 },
                    { 18, 42, 18, "Dhr. Aisha Broek", "bus", 0 },
                    { 19, 39, 19, "Dhr. Maes Koster", "Persistent", 0 },
                    { 20, 11, 20, "Kyano Brink Jr.", "Gorgeous", 1 }
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
