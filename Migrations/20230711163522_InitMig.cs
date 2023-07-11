using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NetCoreGraphQlLearn.Migrations
{
    /// <inheritdoc />
    public partial class InitMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Leagues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    flagLink = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leagues", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeamColors = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    iconLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LeagueId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teams_Leagues_LeagueId",
                        column: x => x.LeagueId,
                        principalTable: "Leagues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    AnnualSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TeamId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Players_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Leagues",
                columns: new[] { "Id", "Name", "flagLink" },
                values: new object[,]
                {
                    { 1, "Wuckert LLC", "http://myron.com" },
                    { 2, "Brakus and Sons", "https://braxton.org" },
                    { 3, "Welch LLC", "http://reagan.biz" },
                    { 4, "Bednar - Treutel", "https://erika.net" },
                    { 5, "Langworth, Schuster and Walsh", "https://ubaldo.info" }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "LeagueId", "Name", "TeamColors", "iconLink" },
                values: new object[,]
                {
                    { 1, 2, "Hartmann and Sons", "salmon", "http://daphnee.name" },
                    { 2, 4, "Harris, Stiedemann and Lang", "grey", "http://alejandra.name" },
                    { 3, 5, "Reinger Inc", "plum", "http://eleonore.com" },
                    { 4, 2, "Leannon - Morar", "violet", "https://reva.info" },
                    { 5, 2, "Greenholt Group", "black", "https://austin.biz" },
                    { 6, 4, "Larkin LLC", "white", "http://brooks.org" },
                    { 7, 3, "Cole - Feest", "gold", "https://nat.org" },
                    { 8, 1, "Beahan Inc", "sky blue", "https://rudy.net" },
                    { 9, 5, "Crona, Ankunding and Kessler", "white", "http://libbie.biz" },
                    { 10, 3, "Haley, Jacobs and Kiehn", "tan", "https://ınes.name" }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Age", "AnnualSalary", "Name", "TeamId" },
                values: new object[,]
                {
                    { 1, 39, 135930.04m, "Lonzo Gulgowski", 4 },
                    { 2, 31, 75212.67m, "Michele Howe", 10 },
                    { 3, 22, 120418.99m, "Nola Morar", 9 },
                    { 4, 25, 445334.63m, "Eliane Romaguera", 3 },
                    { 5, 29, 36625.24m, "Lenore Torp", 8 },
                    { 6, 20, 319467.42m, "Nicolas Brekke", 3 },
                    { 7, 32, 123749.40m, "Rebecca Klocko", 10 },
                    { 8, 27, 44103.98m, "Maximus Reynolds", 3 },
                    { 9, 25, 89114.17m, "Cydney Farrell", 8 },
                    { 10, 33, 821768.78m, "Jordi Marquardt", 7 },
                    { 11, 25, 570665.10m, "Katheryn Kessler", 9 },
                    { 12, 37, 236422.66m, "Adaline Frami", 1 },
                    { 13, 25, 590969.91m, "Jedidiah Shanahan", 2 },
                    { 14, 23, 843401.59m, "Janis Gutkowski", 6 },
                    { 15, 36, 154799.62m, "Otto Hodkiewicz", 4 },
                    { 16, 23, 606353.01m, "Deven Nader", 5 },
                    { 17, 23, 350107.50m, "Milton Renner", 7 },
                    { 18, 30, 914965.73m, "Maurice Heller", 7 },
                    { 19, 36, 756228.77m, "Sylvia Kling", 6 },
                    { 20, 24, 991968.23m, "Arvilla Kris", 8 },
                    { 21, 26, 285462.05m, "Brandt Kiehn", 4 },
                    { 22, 27, 33731.33m, "Arvilla Green", 1 },
                    { 23, 31, 852796.06m, "Selina Beatty", 4 },
                    { 24, 18, 751994.95m, "Paris Wilderman", 1 },
                    { 25, 31, 649572.01m, "Elouise Quigley", 2 },
                    { 26, 34, 847645.78m, "Ezra Williamson", 7 },
                    { 27, 36, 563832.03m, "Oswald Kuphal", 5 },
                    { 28, 29, 915917.11m, "Otto Corwin", 1 },
                    { 29, 31, 673738.93m, "Althea Erdman", 10 },
                    { 30, 40, 486513.01m, "Eduardo Lind", 9 },
                    { 31, 26, 320736.81m, "Evelyn Leannon", 8 },
                    { 32, 25, 455243.05m, "Lelia Hansen", 6 },
                    { 33, 38, 536447.07m, "Golda Harris", 4 },
                    { 34, 28, 422638.54m, "Brittany Thompson", 8 },
                    { 35, 36, 452328.04m, "Kristy Kertzmann", 6 },
                    { 36, 39, 268881.80m, "Wilson Beier", 4 },
                    { 37, 19, 549301.74m, "Jessica Howell", 6 },
                    { 38, 35, 721489.28m, "Loy Kertzmann", 8 },
                    { 39, 20, 673195.69m, "Trace Klocko", 10 },
                    { 40, 25, 288553.98m, "Alvina Schaefer", 6 },
                    { 41, 28, 552871.15m, "Nona Walsh", 9 },
                    { 42, 26, 545127.39m, "Veda Will", 2 },
                    { 43, 28, 909887.82m, "Ignacio Torp", 10 },
                    { 44, 22, 730425.41m, "Katelyn Schoen", 3 },
                    { 45, 32, 888243.39m, "Elinor Goodwin", 4 },
                    { 46, 32, 600528.53m, "Esta Schowalter", 9 },
                    { 47, 27, 898016.01m, "Velda Heidenreich", 8 },
                    { 48, 22, 13075.89m, "Ahmad Harvey", 10 },
                    { 49, 30, 801742.18m, "Jimmy Pfannerstill", 4 },
                    { 50, 24, 577492.74m, "Ladarius Volkman", 2 },
                    { 51, 23, 419049.84m, "Orland Kemmer", 8 },
                    { 52, 26, 473062.53m, "Mable Quitzon", 8 },
                    { 53, 33, 21520.99m, "Ivah Friesen", 4 },
                    { 54, 34, 425507.11m, "Earlene Pouros", 4 },
                    { 55, 29, 536860.54m, "Ottilie Steuber", 3 },
                    { 56, 30, 996274.70m, "Angie Bayer", 7 },
                    { 57, 19, 446098.17m, "Theodora Kris", 5 },
                    { 58, 33, 175818.76m, "Dante Miller", 7 },
                    { 59, 18, 797863.92m, "Rupert Stark", 10 },
                    { 60, 30, 124998.65m, "Carole Wintheiser", 1 },
                    { 61, 19, 270461.46m, "Van Von", 1 },
                    { 62, 18, 269548.37m, "Bell Mayer", 9 },
                    { 63, 39, 654299.50m, "Werner Schoen", 1 },
                    { 64, 18, 642781.84m, "Alexandra Leffler", 7 },
                    { 65, 34, 365080.65m, "Maria Padberg", 5 },
                    { 66, 36, 373210.26m, "Felicia Balistreri", 10 },
                    { 67, 39, 834113.58m, "Meaghan Pfannerstill", 8 },
                    { 68, 33, 42052.76m, "Kyler Smitham", 9 },
                    { 69, 32, 809973.47m, "John Monahan", 2 },
                    { 70, 25, 401941.05m, "Garland Dach", 2 },
                    { 71, 38, 369348.22m, "Samara Jacobson", 3 },
                    { 72, 24, 826744.20m, "Timothy Bartell", 4 },
                    { 73, 30, 629824.94m, "Naomi Smith", 4 },
                    { 74, 22, 642402.45m, "Kennith Thiel", 5 },
                    { 75, 26, 112986.65m, "Glen Witting", 7 },
                    { 76, 31, 56271.44m, "Jaida Jakubowski", 5 },
                    { 77, 33, 637701.75m, "Niko Braun", 5 },
                    { 78, 33, 925060.65m, "Reginald Nienow", 3 },
                    { 79, 36, 37707.45m, "Annie Champlin", 2 },
                    { 80, 25, 172467.28m, "Greg Larson", 9 },
                    { 81, 39, 626894.63m, "Stefan Leffler", 4 },
                    { 82, 38, 783893.03m, "Krystal Miller", 1 },
                    { 83, 32, 925320.96m, "Lonie Thompson", 2 },
                    { 84, 30, 839860.18m, "Noe Lesch", 4 },
                    { 85, 39, 189779.85m, "Abdul Wunsch", 7 },
                    { 86, 34, 106924.44m, "Jaeden Jakubowski", 7 },
                    { 87, 27, 116605.57m, "Kacie West", 10 },
                    { 88, 35, 933709.58m, "Janice Baumbach", 10 },
                    { 89, 30, 603156.48m, "Kaci Morar", 2 },
                    { 90, 26, 183416.08m, "Josephine Jakubowski", 10 },
                    { 91, 25, 663244.42m, "Cristobal Pagac", 9 },
                    { 92, 36, 795143.48m, "Viola Towne", 6 },
                    { 93, 36, 519280.80m, "Merlin Hermiston", 2 },
                    { 94, 32, 509735.46m, "Shaylee Wisoky", 9 },
                    { 95, 39, 406623.97m, "Boris Jacobs", 1 },
                    { 96, 32, 67877.65m, "Jane Lind", 9 },
                    { 97, 23, 43694.09m, "Unique Ziemann", 3 },
                    { 98, 39, 86904.63m, "Monserrat Kutch", 8 },
                    { 99, 35, 720466.54m, "Lorenz Kessler", 3 },
                    { 100, 19, 347597.91m, "Chanel McCullough", 1 },
                    { 101, 32, 312506.37m, "Bethany Upton", 6 },
                    { 102, 30, 816280.84m, "Isidro Dickinson", 6 },
                    { 103, 24, 599540.20m, "Rowan Fisher", 7 },
                    { 104, 30, 173845.96m, "Elvie Goldner", 1 },
                    { 105, 40, 593461.66m, "Ashtyn Graham", 3 },
                    { 106, 39, 693060.09m, "Virginie Funk", 8 },
                    { 107, 33, 277944.69m, "Gregory Konopelski", 10 },
                    { 108, 29, 422648.94m, "Madilyn Rath", 10 },
                    { 109, 36, 708490.65m, "Kraig Hegmann", 1 },
                    { 110, 29, 588396.55m, "Connie Jaskolski", 6 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Players_TeamId",
                table: "Players",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_LeagueId",
                table: "Teams",
                column: "LeagueId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Leagues");
        }
    }
}
