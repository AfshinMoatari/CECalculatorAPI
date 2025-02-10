using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CEProjectServer.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Analytics",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrganisationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrganisationType = table.Column<int>(type: "int", nullable: false),
                    Downloads = table.Column<int>(type: "int", nullable: false),
                    CreationCount = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LatestDownload = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DownloadURL = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Analytics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EconomicFactors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Factor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FactorValue = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EconomicFactors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InterventionEffects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EffectType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EffectValue = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterventionEffects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MeasurementModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MeasurementType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeasurementModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Populations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PopulationType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Populations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sectors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SectorType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sectors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stakeholders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StakeholderType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stakeholders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TotalSectorCosts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalSectorCost = table.Column<double>(type: "float", nullable: false),
                    StakeholderModelId = table.Column<int>(type: "int", nullable: false),
                    SectorModelId = table.Column<int>(type: "int", nullable: false),
                    PopulationModelId = table.Column<int>(type: "int", nullable: false),
                    MeasurementModelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TotalSectorCosts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TotalSectorCosts_MeasurementModel_MeasurementModelId",
                        column: x => x.MeasurementModelId,
                        principalTable: "MeasurementModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TotalSectorCosts_Populations_PopulationModelId",
                        column: x => x.PopulationModelId,
                        principalTable: "Populations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TotalSectorCosts_Sectors_SectorModelId",
                        column: x => x.SectorModelId,
                        principalTable: "Sectors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TotalSectorCosts_Stakeholders_StakeholderModelId",
                        column: x => x.StakeholderModelId,
                        principalTable: "Stakeholders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "EconomicFactors",
                columns: new[] { "Id", "Factor", "FactorValue" },
                values: new object[,]
                {
                    { 1, "Deadweight Factor", 19.0 },
                    { 2, "Conversion Factor", 10.0 }
                });

            migrationBuilder.InsertData(
                table: "InterventionEffects",
                columns: new[] { "Id", "EffectType", "EffectValue" },
                values: new object[,]
                {
                    { 1, "Social network", 2.6600000000000001 },
                    { 2, "Social support", 3.46 },
                    { 3, "Social and emotional skills training", 3.3700000000000001 },
                    { 4, "Psychological treatment", 4.4299999999999997 },
                    { 5, "Unspecified", 3.48 },
                    { 6, "Own specification", 0.0 }
                });

            migrationBuilder.InsertData(
                table: "MeasurementModel",
                columns: new[] { "Id", "MeasurementType" },
                values: new object[,]
                {
                    { 1, "N scale" },
                    { 2, "UCLA Loneliness Scale" }
                });

            migrationBuilder.InsertData(
                table: "Populations",
                columns: new[] { "Id", "PopulationType" },
                values: new object[,]
                {
                    { 1, "General Population" },
                    { 2, "Youth 0-15" },
                    { 3, "Working age16-64" },
                    { 4, "Population 65+" }
                });

            migrationBuilder.InsertData(
                table: "Sectors",
                columns: new[] { "Id", "SectorType" },
                values: new object[,]
                {
                    { 1, "Healthcare" },
                    { 2, "Sick days" },
                    { 3, "Unemployment" },
                    { 4, "Wellbeing" }
                });

            migrationBuilder.InsertData(
                table: "Stakeholders",
                columns: new[] { "Id", "StakeholderType" },
                values: new object[,]
                {
                    { 1, "Municipality" },
                    { 2, "Region" },
                    { 3, "Other state" },
                    { 4, "Other economic" },
                    { 5, "Monetary quality of life" },
                    { 6, "Production" }
                });

            migrationBuilder.InsertData(
                table: "TotalSectorCosts",
                columns: new[] { "Id", "MeasurementModelId", "PopulationModelId", "SectorModelId", "StakeholderModelId", "TotalSectorCost" },
                values: new object[,]
                {
                    { 1, 1, 1, 1, 1, 1.385 },
                    { 2, 1, 2, 1, 1, 0.0 },
                    { 3, 1, 3, 1, 1, 185.0 },
                    { 4, 1, 4, 1, 1, 6.2469999999999999 },
                    { 5, 1, 1, 1, 2, 8.0559999999999992 },
                    { 6, 1, 2, 1, 2, 7.6420000000000003 },
                    { 7, 1, 3, 1, 2, 7.7750000000000004 },
                    { 8, 1, 4, 1, 2, 9.2680000000000007 },
                    { 9, 1, 1, 1, 3, 0.0 },
                    { 10, 1, 2, 1, 3, 0.0 },
                    { 11, 1, 3, 1, 3, 0.0 },
                    { 12, 1, 4, 1, 3, 0.0 },
                    { 13, 1, 1, 1, 4, 0.0 },
                    { 14, 1, 2, 1, 4, 0.0 },
                    { 15, 1, 3, 1, 4, 0.0 },
                    { 16, 1, 4, 1, 4, 0.0 },
                    { 17, 1, 1, 2, 1, 979.0 },
                    { 18, 1, 2, 2, 1, 0.0 },
                    { 19, 1, 3, 2, 1, 1.5700000000000001 },
                    { 20, 1, 4, 2, 1, 0.0 },
                    { 21, 1, 1, 2, 2, 0.0 },
                    { 22, 1, 2, 2, 2, 0.0 },
                    { 23, 1, 3, 2, 2, 0.0 },
                    { 24, 1, 4, 2, 2, 0.0 },
                    { 25, 1, 1, 2, 3, 0.0 },
                    { 26, 1, 2, 2, 3, 0.0 },
                    { 27, 1, 3, 2, 3, 0.0 },
                    { 28, 1, 4, 2, 3, 0.0 },
                    { 29, 1, 1, 2, 6, 4.5220000000000002 },
                    { 30, 1, 2, 2, 6, 0.0 },
                    { 31, 1, 3, 2, 6, 7.2489999999999997 },
                    { 32, 1, 4, 2, 6, 0.0 },
                    { 33, 1, 1, 3, 1, 306.0 },
                    { 34, 1, 2, 3, 1, 0.0 },
                    { 35, 1, 3, 3, 1, 491.0 },
                    { 36, 1, 4, 3, 1, 0.0 },
                    { 37, 1, 1, 3, 2, 0.0 },
                    { 38, 1, 2, 3, 2, 0.0 },
                    { 39, 1, 3, 3, 2, 0.0 },
                    { 40, 1, 4, 3, 2, 0.0 },
                    { 41, 1, 1, 3, 3, 2.2210000000000001 },
                    { 42, 1, 2, 3, 3, 0.0 },
                    { 43, 1, 3, 3, 3, 3.5609999999999999 },
                    { 44, 1, 4, 3, 3, 0.0 },
                    { 45, 1, 1, 3, 6, 7.9729999999999999 },
                    { 46, 1, 2, 3, 6, 0.0 },
                    { 47, 1, 3, 3, 6, 12.782999999999999 },
                    { 48, 1, 4, 3, 6, 0.0 },
                    { 49, 1, 1, 4, 1, 0.0 },
                    { 50, 1, 2, 4, 1, 0.0 },
                    { 51, 1, 3, 4, 1, 0.0 },
                    { 52, 1, 4, 4, 1, 0.0 },
                    { 53, 1, 1, 4, 2, 0.0 },
                    { 54, 1, 2, 4, 2, 0.0 },
                    { 55, 1, 3, 4, 2, 0.0 },
                    { 56, 1, 4, 4, 2, 0.0 },
                    { 57, 1, 1, 4, 3, 0.0 },
                    { 58, 1, 2, 4, 3, 0.0 },
                    { 59, 1, 3, 4, 3, 0.0 },
                    { 60, 1, 4, 4, 3, 0.0 },
                    { 61, 1, 1, 4, 5, 195.63399999999999 },
                    { 62, 1, 2, 4, 5, 195.63399999999999 },
                    { 63, 1, 3, 4, 5, 195.63399999999999 },
                    { 64, 1, 4, 4, 5, 195.63399999999999 },
                    { 65, 2, 1, 1, 1, 46.0 },
                    { 66, 2, 2, 1, 1, 0.0 },
                    { 67, 2, 3, 1, 1, 6.0 },
                    { 68, 2, 4, 1, 1, 208.0 },
                    { 69, 2, 1, 1, 2, 269.0 },
                    { 70, 2, 2, 1, 2, 255.0 },
                    { 71, 2, 3, 1, 2, 259.0 },
                    { 72, 2, 4, 1, 2, 309.0 },
                    { 73, 2, 1, 1, 3, 0.0 },
                    { 74, 2, 2, 1, 3, 0.0 },
                    { 75, 2, 3, 1, 3, 0.0 },
                    { 76, 2, 4, 1, 3, 0.0 },
                    { 77, 2, 1, 1, 4, 0.0 },
                    { 78, 2, 2, 1, 4, 0.0 },
                    { 79, 2, 3, 1, 4, 0.0 },
                    { 80, 2, 4, 1, 4, 0.0 },
                    { 81, 2, 1, 2, 1, 33.0 },
                    { 82, 2, 2, 2, 1, 0.0 },
                    { 83, 2, 3, 2, 1, 52.0 },
                    { 84, 2, 4, 2, 1, 0.0 },
                    { 85, 2, 1, 2, 2, 0.0 },
                    { 86, 2, 2, 2, 2, 0.0 },
                    { 87, 2, 3, 2, 2, 0.0 },
                    { 88, 2, 4, 2, 2, 0.0 },
                    { 89, 2, 1, 2, 3, 0.0 },
                    { 90, 2, 2, 2, 3, 0.0 },
                    { 91, 2, 3, 2, 3, 0.0 },
                    { 92, 2, 4, 2, 3, 0.0 },
                    { 93, 2, 1, 2, 6, 151.0 },
                    { 94, 2, 2, 2, 6, 0.0 },
                    { 95, 2, 3, 2, 6, 242.0 },
                    { 96, 2, 4, 2, 6, 0.0 },
                    { 97, 2, 1, 3, 1, 10.0 },
                    { 98, 2, 2, 3, 1, 0.0 },
                    { 99, 2, 3, 3, 1, 16.0 },
                    { 100, 2, 4, 3, 1, 0.0 },
                    { 101, 2, 1, 3, 2, 0.0 },
                    { 102, 2, 2, 3, 2, 0.0 },
                    { 103, 2, 3, 3, 2, 0.0 },
                    { 104, 2, 4, 3, 2, 0.0 },
                    { 105, 2, 1, 3, 3, 74.0 },
                    { 106, 2, 2, 3, 3, 0.0 },
                    { 107, 2, 3, 3, 3, 119.0 },
                    { 108, 2, 4, 3, 3, 0.0 },
                    { 109, 2, 1, 3, 6, 266.0 },
                    { 110, 2, 2, 3, 6, 0.0 },
                    { 111, 2, 3, 3, 6, 426.0 },
                    { 112, 2, 4, 3, 6, 0.0 },
                    { 113, 2, 1, 4, 1, 0.0 },
                    { 114, 2, 2, 4, 1, 0.0 },
                    { 115, 2, 3, 4, 1, 0.0 },
                    { 116, 2, 4, 4, 1, 0.0 },
                    { 117, 2, 1, 4, 2, 0.0 },
                    { 118, 2, 2, 4, 2, 0.0 },
                    { 119, 2, 3, 4, 2, 0.0 },
                    { 120, 2, 4, 4, 2, 0.0 },
                    { 121, 2, 1, 4, 3, 0.0 },
                    { 122, 2, 2, 4, 3, 0.0 },
                    { 123, 2, 3, 4, 3, 0.0 },
                    { 124, 2, 4, 4, 3, 0.0 },
                    { 125, 2, 1, 4, 5, 6.5209999999999999 },
                    { 126, 2, 2, 4, 5, 6.5209999999999999 },
                    { 127, 2, 3, 4, 5, 6.5209999999999999 },
                    { 128, 2, 4, 4, 5, 6.5209999999999999 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TotalSectorCosts_MeasurementModelId",
                table: "TotalSectorCosts",
                column: "MeasurementModelId");

            migrationBuilder.CreateIndex(
                name: "IX_TotalSectorCosts_PopulationModelId",
                table: "TotalSectorCosts",
                column: "PopulationModelId");

            migrationBuilder.CreateIndex(
                name: "IX_TotalSectorCosts_SectorModelId",
                table: "TotalSectorCosts",
                column: "SectorModelId");

            migrationBuilder.CreateIndex(
                name: "IX_TotalSectorCosts_StakeholderModelId",
                table: "TotalSectorCosts",
                column: "StakeholderModelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Analytics");

            migrationBuilder.DropTable(
                name: "EconomicFactors");

            migrationBuilder.DropTable(
                name: "InterventionEffects");

            migrationBuilder.DropTable(
                name: "TotalSectorCosts");

            migrationBuilder.DropTable(
                name: "MeasurementModel");

            migrationBuilder.DropTable(
                name: "Populations");

            migrationBuilder.DropTable(
                name: "Sectors");

            migrationBuilder.DropTable(
                name: "Stakeholders");
        }
    }
}
