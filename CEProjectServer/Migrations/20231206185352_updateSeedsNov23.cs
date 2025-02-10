using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CEProjectServer.Migrations
{
    /// <inheritdoc />
    public partial class updateSeedsNov23 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Populations",
                keyColumn: "Id",
                keyValue: 3,
                column: "PopulationType",
                value: "Working age 16-64");

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 61,
                column: "TotalSectorCost",
                value: 89143m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 62,
                column: "TotalSectorCost",
                value: 89143m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 63,
                column: "TotalSectorCost",
                value: 89143m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 64,
                column: "TotalSectorCost",
                value: 89143m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 125,
                column: "TotalSectorCost",
                value: 2971m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 126,
                column: "TotalSectorCost",
                value: 2971m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 127,
                column: "TotalSectorCost",
                value: 2971m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 128,
                column: "TotalSectorCost",
                value: 2971m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Populations",
                keyColumn: "Id",
                keyValue: 3,
                column: "PopulationType",
                value: "Working age16-64");

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 61,
                column: "TotalSectorCost",
                value: 89221m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 62,
                column: "TotalSectorCost",
                value: 89221m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 63,
                column: "TotalSectorCost",
                value: 89221m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 64,
                column: "TotalSectorCost",
                value: 89221m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 125,
                column: "TotalSectorCost",
                value: 2974m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 126,
                column: "TotalSectorCost",
                value: 2974m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 127,
                column: "TotalSectorCost",
                value: 2974m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 128,
                column: "TotalSectorCost",
                value: 2974m);
        }
    }
}
