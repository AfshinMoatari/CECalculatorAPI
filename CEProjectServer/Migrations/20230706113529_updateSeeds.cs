using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CEProjectServer.Migrations
{
    /// <inheritdoc />
    public partial class updateSeeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "InterventionEffects",
                keyColumn: "Id",
                keyValue: 5,
                column: "EffectType",
                value: "Other intervention type");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "InterventionEffects",
                keyColumn: "Id",
                keyValue: 5,
                column: "EffectType",
                value: "Unspecified");

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
    }
}
