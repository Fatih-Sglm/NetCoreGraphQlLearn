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
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    flagLink = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leagues", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    TeamColors = table.Column<string>(type: "TEXT", nullable: false),
                    iconLink = table.Column<string>(type: "TEXT", nullable: false),
                    LeagueId = table.Column<int>(type: "INTEGER", nullable: false)
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
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Age = table.Column<int>(type: "INTEGER", nullable: false),
                    AnnualSalary = table.Column<decimal>(type: "TEXT", nullable: false),
                    TeamId = table.Column<int>(type: "INTEGER", nullable: false)
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
                    { 1, "Kutch, Hayes and Metz", "http://jarrett.net" },
                    { 2, "Stanton and Sons", "https://helene.info" },
                    { 3, "Kovacek LLC", "http://darius.com" },
                    { 4, "Bauch Inc", "http://darron.com" },
                    { 5, "Okuneva LLC", "http://aimee.name" }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "LeagueId", "Name", "TeamColors", "iconLink" },
                values: new object[,]
                {
                    { 1, 1, "Gulgowski and Sons", "ivory", "https://raegan.org" },
                    { 2, 1, "Morissette, MacGyver and Bins", "green", "https://dave.org" },
                    { 3, 3, "Schiller, Witting and Herzog", "violet", "http://myrl.biz" },
                    { 4, 3, "Daniel Group", "white", "https://rogelio.com" },
                    { 5, 2, "Hauck - Boyer", "maroon", "https://ruthe.info" },
                    { 6, 3, "Abshire, Bernhard and Murphy", "lime", "https://jordi.info" },
                    { 7, 2, "Aufderhar - Yost", "blue", "https://cortney.info" },
                    { 8, 5, "Smith, Kerluke and Senger", "plum", "https://hilton.net" },
                    { 9, 2, "Nader - Nolan", "red", "http://ızaiah.biz" },
                    { 10, 1, "King - Collier", "yellow", "https://lew.net" }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Age", "AnnualSalary", "Name", "TeamId" },
                values: new object[,]
                {
                    { 1, 24, 73540.95m, "Sophia Cassin", 6 },
                    { 2, 28, 121965.91m, "Carlee Morissette", 2 },
                    { 3, 21, 418596.19m, "Gerardo Johns", 3 },
                    { 4, 27, 567125.12m, "Vena Luettgen", 4 },
                    { 5, 40, 270691.23m, "Hector Hahn", 7 },
                    { 6, 22, 190196.40m, "Mariano Effertz", 2 },
                    { 7, 23, 919829.73m, "Magnolia Lubowitz", 8 },
                    { 8, 30, 867166.35m, "Tiara Predovic", 3 },
                    { 9, 35, 774069.29m, "Colten Schroeder", 6 },
                    { 10, 32, 553300.94m, "Savannah Bins", 3 },
                    { 11, 28, 513907.46m, "Jeramie Marvin", 5 },
                    { 12, 19, 958723.21m, "Antonetta Johnston", 4 },
                    { 13, 32, 228698.82m, "Mekhi Cole", 2 },
                    { 14, 37, 127326.93m, "Joana Koepp", 7 },
                    { 15, 36, 628530.36m, "Gene Hermiston", 2 },
                    { 16, 20, 783258.47m, "Logan Torphy", 1 },
                    { 17, 28, 158508.92m, "Sierra Watsica", 7 },
                    { 18, 26, 58139.17m, "Rachelle Berge", 4 },
                    { 19, 35, 901115.46m, "Myrtle Ziemann", 10 },
                    { 20, 39, 251105.58m, "Eldred Keeling", 1 },
                    { 21, 25, 962691.25m, "Holden Senger", 3 },
                    { 22, 21, 95573.20m, "Garrison Yost", 2 },
                    { 23, 22, 220896.02m, "Mossie Effertz", 3 },
                    { 24, 22, 212728.58m, "Barton Wisozk", 8 },
                    { 25, 20, 198501.62m, "Murphy Pacocha", 5 },
                    { 26, 36, 522147.58m, "Wilford Kshlerin", 8 },
                    { 27, 31, 794055.84m, "Beau Sporer", 6 },
                    { 28, 33, 939589.28m, "Kamren Swaniawski", 9 },
                    { 29, 29, 118271.81m, "Brayan Welch", 7 },
                    { 30, 25, 252443.42m, "Donato Fadel", 5 },
                    { 31, 33, 156770.07m, "Ezekiel Hudson", 8 },
                    { 32, 33, 689878.64m, "Griffin Boehm", 4 },
                    { 33, 39, 800446.20m, "Jessika Ebert", 9 },
                    { 34, 30, 773643.07m, "Vivian Bode", 9 },
                    { 35, 21, 149748.99m, "Joanne Huel", 8 },
                    { 36, 26, 881432.01m, "Salma Bernier", 7 },
                    { 37, 26, 426518.02m, "Keeley Wunsch", 6 },
                    { 38, 34, 943471.32m, "Vern Marks", 4 },
                    { 39, 36, 537575.89m, "Zoey Marvin", 9 },
                    { 40, 38, 566427.62m, "Anibal Doyle", 9 },
                    { 41, 28, 306359.63m, "Billie Schulist", 10 },
                    { 42, 37, 843862.56m, "Lavinia Stroman", 10 },
                    { 43, 34, 593265.53m, "Sydni Beahan", 7 },
                    { 44, 31, 218681.29m, "Destiny Heaney", 7 },
                    { 45, 39, 451748.05m, "Erika Jenkins", 8 },
                    { 46, 30, 252901.79m, "Kathlyn Marks", 3 },
                    { 47, 24, 872700.83m, "Leone Bradtke", 6 },
                    { 48, 30, 697799.05m, "Margie Ebert", 6 },
                    { 49, 26, 812423.97m, "Horacio Daniel", 6 },
                    { 50, 37, 186511.82m, "Camryn O'Hara", 2 },
                    { 51, 18, 413730.00m, "Brionna Schulist", 4 },
                    { 52, 27, 712844.56m, "Anabel Becker", 2 },
                    { 53, 33, 653803.22m, "Taurean Jast", 3 },
                    { 54, 19, 365843.54m, "Madge Kunde", 9 },
                    { 55, 21, 13660.74m, "Heath Legros", 6 },
                    { 56, 21, 277784.26m, "Yoshiko Bartell", 5 },
                    { 57, 23, 951695.17m, "Carmelo Fadel", 5 },
                    { 58, 18, 750226.79m, "Pinkie Hane", 4 },
                    { 59, 37, 656529.38m, "Junior Erdman", 2 },
                    { 60, 38, 211102.80m, "Mara Strosin", 8 },
                    { 61, 26, 861849.91m, "Carey Harris", 2 },
                    { 62, 27, 946046.40m, "Murl Collins", 2 },
                    { 63, 18, 491822.41m, "Germaine Lang", 6 },
                    { 64, 25, 197290.73m, "Jamar Green", 3 },
                    { 65, 23, 363699.48m, "Norris Reynolds", 4 },
                    { 66, 28, 483134.69m, "Evelyn Prosacco", 9 },
                    { 67, 37, 157173.86m, "Leonard Breitenberg", 1 },
                    { 68, 20, 236565.68m, "Karson Rosenbaum", 3 },
                    { 69, 32, 557036.46m, "Golden Conroy", 10 },
                    { 70, 24, 119832.82m, "Constance Harvey", 7 },
                    { 71, 38, 920107.86m, "Kevon Hagenes", 6 },
                    { 72, 37, 83393.05m, "Madie Wilkinson", 8 },
                    { 73, 25, 144686.90m, "Cleve Kuhic", 7 },
                    { 74, 21, 951996.50m, "Heaven Runte", 1 },
                    { 75, 40, 667904.45m, "Madisyn Swaniawski", 7 },
                    { 76, 21, 184522.51m, "Jacynthe Aufderhar", 2 },
                    { 77, 23, 999162.16m, "Yvonne Berge", 3 },
                    { 78, 26, 683184.08m, "Felipa Jerde", 1 },
                    { 79, 29, 155925.26m, "Malachi Thiel", 3 },
                    { 80, 23, 258115.61m, "Ewell Schuster", 6 },
                    { 81, 26, 341101.63m, "Madison Johnson", 10 },
                    { 82, 40, 707777.42m, "Hugh Luettgen", 3 },
                    { 83, 39, 616625.31m, "Erling Toy", 4 },
                    { 84, 33, 330232.24m, "Dane Bergstrom", 8 },
                    { 85, 22, 252404.89m, "Meda Collier", 1 },
                    { 86, 38, 225436.60m, "Ford Abbott", 10 },
                    { 87, 34, 444789.55m, "Sasha Jacobs", 5 },
                    { 88, 26, 305564.93m, "Rosanna Runolfsdottir", 3 },
                    { 89, 31, 484030.70m, "Samson Jenkins", 1 },
                    { 90, 31, 756407.31m, "Hoyt Bednar", 8 },
                    { 91, 32, 470281.84m, "Krista Moore", 10 },
                    { 92, 31, 256046.71m, "Lavern Wehner", 4 },
                    { 93, 33, 736035.83m, "Abbie Treutel", 3 },
                    { 94, 18, 219433.41m, "Leonie Rath", 7 },
                    { 95, 33, 775331.98m, "Shemar Donnelly", 5 },
                    { 96, 31, 484520.25m, "Felicia Schaefer", 2 },
                    { 97, 26, 826847.42m, "Valentin Balistreri", 9 },
                    { 98, 18, 520961.80m, "Natalia Reynolds", 4 },
                    { 99, 21, 867603.73m, "Orrin Cummings", 2 },
                    { 100, 24, 343424.14m, "Otilia Kreiger", 3 },
                    { 101, 27, 806270.53m, "Bernie Gislason", 7 },
                    { 102, 29, 699645.57m, "Anabelle Stokes", 3 },
                    { 103, 24, 704946.35m, "Brennon Kihn", 2 },
                    { 104, 23, 780446.35m, "Meda Lang", 6 },
                    { 105, 32, 689817.67m, "Kylee Considine", 4 },
                    { 106, 18, 761552.66m, "Rico Cummings", 3 },
                    { 107, 36, 520730.40m, "Maria Bode", 7 },
                    { 108, 39, 48248.68m, "Rupert Lesch", 5 },
                    { 109, 33, 56549.22m, "Elinor O'Kon", 9 },
                    { 110, 36, 518248.15m, "Joseph Lynch", 2 }
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
