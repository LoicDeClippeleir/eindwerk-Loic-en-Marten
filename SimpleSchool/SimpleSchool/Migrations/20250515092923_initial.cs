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
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Leerkrachten",
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
                    table.PrimaryKey("PK_Leerkrachten", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Opleidingen",
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
                    table.PrimaryKey("PK_Opleidingen", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StudentenKaarten",
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
                    table.PrimaryKey("PK_StudentenKaarten", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vakken",
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
                    table.PrimaryKey("PK_Vakken", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vakken_Leerkrachten_LeerkrachtId",
                        column: x => x.LeerkrachtId,
                        principalTable: "Leerkrachten",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Leerlingen",
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
                    table.PrimaryKey("PK_Leerlingen", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Leerlingen_Opleidingen_OpleidingId",
                        column: x => x.OpleidingId,
                        principalTable: "Opleidingen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Leerlingen_StudentenKaarten_StudentenkaartId",
                        column: x => x.StudentenkaartId,
                        principalTable: "StudentenKaarten",
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
                        name: "FK_Opleidingsvakken_Opleidingen_OpleidingenId",
                        column: x => x.OpleidingenId,
                        principalTable: "Opleidingen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Opleidingsvakken_Vakken_VakkenId",
                        column: x => x.VakkenId,
                        principalTable: "Vakken",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Leerkrachten",
                columns: new[] { "Id", "Adres", "EMail", "GeboorteDatum", "Naam" },
                values: new object[,]
                {
                    { 11, "Roosplantsoen 700 III", "debitis", new DateTime(2024, 10, 20, 18, 44, 33, 19, DateTimeKind.Local).AddTicks(6142), "Aut esse molestiae sit sed quis iste ducimus perspiciatis quam aut dicta sed reiciendis explicabo libero mollitia odit molestiae explicabo." },
                    { 12, "Walmarkt 457 I", "voluptas", new DateTime(2024, 8, 13, 18, 59, 13, 173, DateTimeKind.Local).AddTicks(9226), "Et placeat aut magnam vero recusandae fugiat omnis quibusdam ullam deserunt nihil iusto repellendus quia assumenda dicta minima rerum atque." },
                    { 13, "Brouwerpassage 1", "saepe", new DateTime(2024, 5, 18, 12, 21, 22, 457, DateTimeKind.Local).AddTicks(5481), "Eligendi commodi eum ea est repellendus fugiat excepturi voluptatem quo reprehenderit alias maxime nam unde deserunt ab qui repudiandae odio." },
                    { 14, "Isastraat 248b", "laboriosam", new DateTime(2024, 11, 13, 2, 32, 13, 622, DateTimeKind.Local).AddTicks(8386), "Provident sequi molestiae aut fugiat explicabo consequatur porro dolor harum iste pariatur sunt ut id reprehenderit consequuntur ipsum eveniet ducimus." },
                    { 15, "Maaspassage 571", "eligendi", new DateTime(2025, 4, 12, 4, 22, 29, 794, DateTimeKind.Local).AddTicks(3141), "Ducimus libero necessitatibus voluptates aut id id molestias reiciendis sed non et dolor provident est odit maiores voluptatibus molestias quae." },
                    { 16, "Maudvelt 457", "eos", new DateTime(2024, 8, 12, 12, 23, 1, 313, DateTimeKind.Local).AddTicks(9197), "Consequuntur id quo neque laudantium et fugit accusamus illo quidem et rerum sed distinctio eligendi consequatur quisquam qui sunt molestiae." },
                    { 17, "Vlietdijk 195b", "facere", new DateTime(2024, 8, 19, 8, 16, 5, 494, DateTimeKind.Local).AddTicks(47), "Sed voluptas qui similique temporibus perferendis quos at quia consequatur qui quisquam perferendis neque et et natus autem qui soluta." },
                    { 18, "Isapassage 81", "inventore", new DateTime(2024, 7, 19, 14, 50, 35, 548, DateTimeKind.Local).AddTicks(6009), "Magnam dignissimos earum qui officiis quae expedita deleniti ullam dolor at veniam voluptas est voluptas ut reprehenderit suscipit voluptas quasi." },
                    { 19, "Jaydendijk 680 II", "dolore", new DateTime(2024, 12, 8, 8, 15, 49, 789, DateTimeKind.Local).AddTicks(3800), "In sed similique ea odit aut pariatur quisquam ea itaque voluptas totam quasi totam omnis architecto quia sint commodi molestiae." },
                    { 20, "Nickweg 514 III", "veritatis", new DateTime(2024, 6, 25, 18, 24, 33, 211, DateTimeKind.Local).AddTicks(5205), "Sint est quasi ut cupiditate non deleniti voluptas mollitia qui sit iure aspernatur quidem quisquam possimus in labore officia quia." }
                });

            migrationBuilder.InsertData(
                table: "Opleidingen",
                columns: new[] { "Id", "BeschikbarePlaatsen", "Beschrijving", "Duur", "Naam" },
                values: new object[,]
                {
                    { 11, 264, "Aut qui et voluptatem nulla dolores illo occaecati porro itaque ut ab iure cum soluta consequatur ut ratione qui aut.", 3, "In veritatis nostrum dolor molestias rerum facere consequatur provident autem consequatur laboriosam et enim harum fugiat ratione deserunt iusto dolorem." },
                    { 12, 356, "Architecto sequi ut quisquam itaque sint provident sit dolorem placeat cupiditate dolore qui deserunt nobis dolorum iusto iusto facere vel.", 3, "Eaque saepe est id reprehenderit nemo quisquam deserunt ullam et aut deleniti est aperiam et maxime voluptates possimus doloribus cumque." },
                    { 13, 365, "Provident architecto vel et magnam atque iure id quo eum pariatur magnam eos neque eos quidem dignissimos corrupti dolorem dolores.", 3, "Consequuntur architecto tempora sed nobis delectus eius voluptatibus quis harum autem a a magni maxime quis quisquam aliquam cumque dignissimos." },
                    { 14, 260, "Adipisci officiis nostrum sed fuga provident repellat voluptatem eligendi numquam alias autem quas qui est quo fuga dolores tempora ea.", 3, "Quia ipsum consequatur expedita ea qui laboriosam quidem minima odit praesentium quo repellat ut ad fugiat autem ipsa rerum autem." },
                    { 15, 396, "Repudiandae dolor incidunt neque veritatis veniam recusandae quidem omnis illo accusamus qui tenetur quos at rem eos neque non natus.", 4, "Aut eveniet cum tempora dolore omnis possimus et dicta sunt est voluptatem dolorem a suscipit iste tempora esse sit officia." },
                    { 16, 392, "Voluptas ut et soluta qui laborum amet iste sed beatae at quo incidunt vero blanditiis itaque culpa ex natus est.", 3, "Culpa est enim modi error quis rerum dolores temporibus voluptatibus repellendus sapiente corrupti qui ea sint non sunt voluptatem saepe." },
                    { 17, 204, "Sapiente porro molestiae natus sunt reprehenderit eaque consectetur repellat expedita quas unde id at sit cupiditate sit tempora architecto ducimus.", 3, "Autem consequatur velit aut est laboriosam accusamus mollitia et ut et ducimus quia architecto placeat incidunt ab nobis possimus minus." },
                    { 18, 306, "Corporis voluptatibus autem saepe eaque in animi odit rerum non beatae qui commodi sint ipsa accusantium aperiam id aut in.", 3, "Laboriosam nihil dolor sapiente temporibus et saepe cumque numquam architecto illum voluptatibus ad libero corporis debitis autem ad placeat magni." },
                    { 19, 268, "Quasi eos at occaecati ex fuga commodi consequatur officiis vel distinctio voluptas est eaque inventore recusandae amet exercitationem est impedit.", 3, "Accusantium incidunt omnis fugit similique magni adipisci et voluptatum deserunt dolorem facilis occaecati optio quas veniam modi et voluptas asperiores." },
                    { 20, 358, "Accusamus ad minus aut consequatur sapiente id aut dolore rerum magnam sit enim modi minus ipsa explicabo dolores incidunt corrupti.", 4, "Voluptatem aut accusantium error et minus assumenda perspiciatis corrupti aut quis nostrum consectetur aut molestiae aut excepturi fuga velit autem." }
                });

            migrationBuilder.InsertData(
                table: "StudentenKaarten",
                columns: new[] { "Id", "Klas", "Naam", "School" },
                values: new object[,]
                {
                    { 11, "ut", "Bsc Florine Bakker", "Smit, Jansen and Peters" },
                    { 12, "dolores", "Prof. Nour Dijkstra", "Meijer - Bakker" },
                    { 13, "modi", "Msc Thijmen Bos", "Dijkstra - Groot" },
                    { 14, "vero", "Msc Youp Haan", "Bosch - Groot" },
                    { 15, "inventore", "Tymon Bruin III", "Dijkstra - Beek" },
                    { 16, "nesciunt", "Dhr. Aaron Groot", "Maas - Brink" },
                    { 17, "repellat", "Luciano Klein III", "Vermeulen, Wit and Haan" },
                    { 18, "dolore", "Mevr. Dr. Bart Koning", "Brink - Smits" },
                    { 19, "corrupti", "Bsc Nena Dijkstra", "Haan, Leeuwen and Dijk" },
                    { 20, "velit", "Cornelia Meer Jr.", "Willems NV" }
                });

            migrationBuilder.InsertData(
                table: "Vakken",
                columns: new[] { "Id", "AantalStudiePunten", "LeerkrachtId", "Naam", "Taal", "Vaktype" },
                values: new object[,]
                {
                    { 11, 30, 0, "Maes Ven I", "synergy", 1 },
                    { 12, 41, 0, "Selina Haan II", "connecting", 1 },
                    { 13, 38, 0, "Fieke Brink Jr.", "Faroe Islands", 0 },
                    { 14, 41, 0, "Mevr. Dr. Juna Stichting", "Bedfordshire", 0 },
                    { 15, 35, 0, "Jada Dekker Sr.", "Locks", 1 },
                    { 16, 27, 0, "Bsc Ryan Stichting", "productivity", 1 },
                    { 17, 28, 0, "Brian Dijkstra III", "haptic", 1 },
                    { 18, 25, 0, "Prof. Sem Wal", "convergence", 0 },
                    { 19, 33, 0, "Manuel Groot Jr.", "Internal", 1 },
                    { 20, 25, 0, "Imani Smits V", "Avon", 0 }
                });

            migrationBuilder.InsertData(
                table: "Leerlingen",
                columns: new[] { "Id", "Adres", "EMail", "GeboorteDatum", "Naam", "OpleidingId", "StudentenkaartId" },
                values: new object[,]
                {
                    { 11, "Vrieskade 035a", "eligendi", new DateTime(2024, 5, 26, 18, 22, 34, 980, DateTimeKind.Local).AddTicks(7361), "Et et autem sunt molestiae in omnis odio quia sed iste odio vel quibusdam natus aut iure inventore et et.", 11, 11 },
                    { 12, "Brinkvelt 2", "sapiente", new DateTime(2025, 2, 21, 12, 3, 19, 618, DateTimeKind.Local).AddTicks(9985), "Et deserunt ipsam et ipsum eos labore vel voluptas possimus enim nostrum incidunt consequatur aliquam eum explicabo iste ex impedit.", 12, 12 },
                    { 13, "Jongmarkt 225 I", "ad", new DateTime(2024, 10, 8, 4, 0, 35, 92, DateTimeKind.Local).AddTicks(8827), "Non reiciendis et numquam quaerat occaecati molestias provident quam impedit maxime aut a iure ad non voluptas vel animi suscipit.", 13, 13 },
                    { 14, "Smithof 295b", "autem", new DateTime(2024, 12, 2, 20, 40, 44, 801, DateTimeKind.Local).AddTicks(1010), "Est enim maxime cum omnis qui facere unde architecto voluptatem numquam earum veritatis necessitatibus molestiae laudantium nulla illum expedita quae.", 14, 14 },
                    { 15, "Boschsteeg 367 II", "quos", new DateTime(2025, 3, 15, 5, 49, 34, 952, DateTimeKind.Local).AddTicks(2288), "Minus voluptate veniam labore libero molestias alias perferendis adipisci deleniti ex qui eius doloremque consequatur praesentium nihil harum veniam quae.", 15, 15 },
                    { 16, "Finnplantsoen 792a", "quia", new DateTime(2024, 10, 26, 0, 42, 7, 228, DateTimeKind.Local).AddTicks(2116), "Sequi dolor nam aut quia cum magni dolores esse eos maiores quisquam qui enim excepturi eos aspernatur dignissimos porro consequatur.", 16, 16 },
                    { 17, "Rickpassage 57", "reiciendis", new DateTime(2024, 6, 18, 14, 21, 57, 737, DateTimeKind.Local).AddTicks(8991), "Vitae ut asperiores numquam et veritatis cumque soluta ut quidem sunt temporibus eveniet consectetur deleniti perspiciatis voluptatem facilis sint laboriosam.", 17, 17 },
                    { 18, "Visserpark 756 II", "ut", new DateTime(2025, 4, 2, 14, 8, 17, 571, DateTimeKind.Local).AddTicks(6689), "Aut sunt eos itaque eos dolor sed enim quis sunt et accusantium debitis itaque recusandae optio qui corporis minima error.", 18, 18 },
                    { 19, "Boskade 124 II", "quisquam", new DateTime(2024, 6, 19, 4, 8, 36, 538, DateTimeKind.Local).AddTicks(3576), "Dicta qui vitae et minus minima omnis consectetur non voluptatem rerum ullam ipsum delectus accusamus et ratione autem fugit voluptatem.", 19, 19 },
                    { 20, "Thomasweg 007c", "aut", new DateTime(2024, 9, 20, 6, 11, 58, 530, DateTimeKind.Local).AddTicks(5503), "Cupiditate aliquid exercitationem totam deserunt nam beatae tempore velit et est et sunt pariatur nam ut ut et error voluptas.", 20, 20 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Leerlingen_OpleidingId",
                table: "Leerlingen",
                column: "OpleidingId");

            migrationBuilder.CreateIndex(
                name: "IX_Leerlingen_StudentenkaartId",
                table: "Leerlingen",
                column: "StudentenkaartId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Opleidingsvakken_VakkenId",
                table: "Opleidingsvakken",
                column: "VakkenId");

            migrationBuilder.CreateIndex(
                name: "IX_Vakken_LeerkrachtId",
                table: "Vakken",
                column: "LeerkrachtId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Leerlingen");

            migrationBuilder.DropTable(
                name: "Opleidingsvakken");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "StudentenKaarten");

            migrationBuilder.DropTable(
                name: "Opleidingen");

            migrationBuilder.DropTable(
                name: "Vakken");

            migrationBuilder.DropTable(
                name: "Leerkrachten");
        }
    }
}
