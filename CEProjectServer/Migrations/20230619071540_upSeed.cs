using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CEProjectServer.Migrations
{
    /// <inheritdoc />
    public partial class upSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "EconomicFactors",
                keyColumn: "Id",
                keyValue: 2,
                column: "Factor",
                value: "Deadweight Factor");

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 1,
                column: "TotalSectorCost",
                value: 1385m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 4,
                column: "TotalSectorCost",
                value: 6247m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 5,
                column: "TotalSectorCost",
                value: 8056m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 6,
                column: "TotalSectorCost",
                value: 7642m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 7,
                column: "TotalSectorCost",
                value: 7775m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 8,
                column: "TotalSectorCost",
                value: 9268m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 19,
                column: "TotalSectorCost",
                value: 1570m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 29,
                column: "TotalSectorCost",
                value: 4522m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 31,
                column: "TotalSectorCost",
                value: 7249m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 41,
                column: "TotalSectorCost",
                value: 2221m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 43,
                column: "TotalSectorCost",
                value: 3561m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 45,
                column: "TotalSectorCost",
                value: 7973m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 47,
                column: "TotalSectorCost",
                value: 12783m);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "EconomicFactors",
                keyColumn: "Id",
                keyValue: 2,
                column: "Factor",
                value: "Conversion Factor");

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 1,
                column: "TotalSectorCost",
                value: 1.385m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 4,
                column: "TotalSectorCost",
                value: 6.247m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 5,
                column: "TotalSectorCost",
                value: 8.056m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 6,
                column: "TotalSectorCost",
                value: 7.642m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 7,
                column: "TotalSectorCost",
                value: 7.775m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 8,
                column: "TotalSectorCost",
                value: 9.268m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 19,
                column: "TotalSectorCost",
                value: 1.570m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 29,
                column: "TotalSectorCost",
                value: 4.522m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 31,
                column: "TotalSectorCost",
                value: 7.249m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 41,
                column: "TotalSectorCost",
                value: 2.221m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 43,
                column: "TotalSectorCost",
                value: 3.561m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 45,
                column: "TotalSectorCost",
                value: 7.973m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 47,
                column: "TotalSectorCost",
                value: 12.783m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 61,
                column: "TotalSectorCost",
                value: 195.634m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 62,
                column: "TotalSectorCost",
                value: 195.634m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 63,
                column: "TotalSectorCost",
                value: 195.634m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 64,
                column: "TotalSectorCost",
                value: 195.634m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 125,
                column: "TotalSectorCost",
                value: 6.521m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 126,
                column: "TotalSectorCost",
                value: 6.521m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 127,
                column: "TotalSectorCost",
                value: 6.521m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 128,
                column: "TotalSectorCost",
                value: 6.521m);
        }
    }
}
