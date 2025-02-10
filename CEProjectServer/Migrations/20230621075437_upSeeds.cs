using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CEProjectServer.Migrations
{
    /// <inheritdoc />
    public partial class upSeeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "EconomicFactors",
                keyColumn: "Id",
                keyValue: 2,
                column: "FactorValue",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 61,
                column: "TotalSectorCost",
                value: 286000m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 62,
                column: "TotalSectorCost",
                value: 286000m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 63,
                column: "TotalSectorCost",
                value: 286000m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 64,
                column: "TotalSectorCost",
                value: 286000m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 67,
                column: "TotalSectorCost",
                value: 6m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 71,
                column: "TotalSectorCost",
                value: 259m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 125,
                column: "TotalSectorCost",
                value: 9533m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 126,
                column: "TotalSectorCost",
                value: 9533m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 127,
                column: "TotalSectorCost",
                value: 9533m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 128,
                column: "TotalSectorCost",
                value: 9533m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "EconomicFactors",
                keyColumn: "Id",
                keyValue: 2,
                column: "FactorValue",
                value: 10m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 61,
                column: "TotalSectorCost",
                value: 195634m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 62,
                column: "TotalSectorCost",
                value: 195634m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 63,
                column: "TotalSectorCost",
                value: 195634m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 64,
                column: "TotalSectorCost",
                value: 195634m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 67,
                column: "TotalSectorCost",
                value: 6.161m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 71,
                column: "TotalSectorCost",
                value: 259.178m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 125,
                column: "TotalSectorCost",
                value: 6521m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 126,
                column: "TotalSectorCost",
                value: 6521m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 127,
                column: "TotalSectorCost",
                value: 6521m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 128,
                column: "TotalSectorCost",
                value: 6521m);
        }
    }
}
