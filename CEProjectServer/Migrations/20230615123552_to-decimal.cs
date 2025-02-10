using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CEProjectServer.Migrations
{
    /// <inheritdoc />
    public partial class todecimal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "TotalSectorCost",
                table: "TotalSectorCosts",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<decimal>(
                name: "EffectValue",
                table: "InterventionEffects",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<decimal>(
                name: "FactorValue",
                table: "EconomicFactors",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.UpdateData(
                table: "EconomicFactors",
                keyColumn: "Id",
                keyValue: 1,
                column: "FactorValue",
                value: 19m);

            migrationBuilder.UpdateData(
                table: "EconomicFactors",
                keyColumn: "Id",
                keyValue: 2,
                column: "FactorValue",
                value: 10m);

            migrationBuilder.UpdateData(
                table: "InterventionEffects",
                keyColumn: "Id",
                keyValue: 1,
                column: "EffectValue",
                value: 2.66m);

            migrationBuilder.UpdateData(
                table: "InterventionEffects",
                keyColumn: "Id",
                keyValue: 2,
                column: "EffectValue",
                value: 3.46m);

            migrationBuilder.UpdateData(
                table: "InterventionEffects",
                keyColumn: "Id",
                keyValue: 3,
                column: "EffectValue",
                value: 3.37m);

            migrationBuilder.UpdateData(
                table: "InterventionEffects",
                keyColumn: "Id",
                keyValue: 4,
                column: "EffectValue",
                value: 4.43m);

            migrationBuilder.UpdateData(
                table: "InterventionEffects",
                keyColumn: "Id",
                keyValue: 5,
                column: "EffectValue",
                value: 3.48m);

            migrationBuilder.UpdateData(
                table: "InterventionEffects",
                keyColumn: "Id",
                keyValue: 6,
                column: "EffectValue",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 1,
                column: "TotalSectorCost",
                value: 1.385m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 2,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 3,
                column: "TotalSectorCost",
                value: 185m);

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
                keyValue: 9,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 10,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 11,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 12,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 13,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 14,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 15,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 16,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 17,
                column: "TotalSectorCost",
                value: 979m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 18,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 19,
                column: "TotalSectorCost",
                value: 1.570m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 20,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 21,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 22,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 23,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 24,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 25,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 26,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 27,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 28,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 29,
                column: "TotalSectorCost",
                value: 4.522m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 30,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 31,
                column: "TotalSectorCost",
                value: 7.249m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 32,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 33,
                column: "TotalSectorCost",
                value: 306m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 34,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 35,
                column: "TotalSectorCost",
                value: 491m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 36,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 37,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 38,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 39,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 40,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 41,
                column: "TotalSectorCost",
                value: 2.221m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 42,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 43,
                column: "TotalSectorCost",
                value: 3.561m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 44,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 45,
                column: "TotalSectorCost",
                value: 7.973m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 46,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 47,
                column: "TotalSectorCost",
                value: 12.783m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 48,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 49,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 50,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 51,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 52,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 53,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 54,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 55,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 56,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 57,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 58,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 59,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 60,
                column: "TotalSectorCost",
                value: 0m);

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
                keyValue: 65,
                column: "TotalSectorCost",
                value: 46m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 66,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 67,
                column: "TotalSectorCost",
                value: 6.161m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 68,
                column: "TotalSectorCost",
                value: 208m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 69,
                column: "TotalSectorCost",
                value: 269m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 70,
                column: "TotalSectorCost",
                value: 255m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 71,
                column: "TotalSectorCost",
                value: 259.178m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 72,
                column: "TotalSectorCost",
                value: 309m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 73,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 74,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 75,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 76,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 77,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 78,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 79,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 80,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 81,
                column: "TotalSectorCost",
                value: 33m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 82,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 83,
                column: "TotalSectorCost",
                value: 52m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 84,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 85,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 86,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 87,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 88,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 89,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 90,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 91,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 92,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 93,
                column: "TotalSectorCost",
                value: 151m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 94,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 95,
                column: "TotalSectorCost",
                value: 242m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 96,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 97,
                column: "TotalSectorCost",
                value: 10m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 98,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 99,
                column: "TotalSectorCost",
                value: 16m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 100,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 101,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 102,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 103,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 104,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 105,
                column: "TotalSectorCost",
                value: 74m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 106,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 107,
                column: "TotalSectorCost",
                value: 119m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 108,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 109,
                column: "TotalSectorCost",
                value: 266m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 110,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 111,
                column: "TotalSectorCost",
                value: 426m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 112,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 113,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 114,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 115,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 116,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 117,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 118,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 119,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 120,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 121,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 122,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 123,
                column: "TotalSectorCost",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 124,
                column: "TotalSectorCost",
                value: 0m);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "TotalSectorCost",
                table: "TotalSectorCosts",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<double>(
                name: "EffectValue",
                table: "InterventionEffects",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<double>(
                name: "FactorValue",
                table: "EconomicFactors",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "EconomicFactors",
                keyColumn: "Id",
                keyValue: 1,
                column: "FactorValue",
                value: 19.0);

            migrationBuilder.UpdateData(
                table: "EconomicFactors",
                keyColumn: "Id",
                keyValue: 2,
                column: "FactorValue",
                value: 10.0);

            migrationBuilder.UpdateData(
                table: "InterventionEffects",
                keyColumn: "Id",
                keyValue: 1,
                column: "EffectValue",
                value: 2.6600000000000001);

            migrationBuilder.UpdateData(
                table: "InterventionEffects",
                keyColumn: "Id",
                keyValue: 2,
                column: "EffectValue",
                value: 3.46);

            migrationBuilder.UpdateData(
                table: "InterventionEffects",
                keyColumn: "Id",
                keyValue: 3,
                column: "EffectValue",
                value: 3.3700000000000001);

            migrationBuilder.UpdateData(
                table: "InterventionEffects",
                keyColumn: "Id",
                keyValue: 4,
                column: "EffectValue",
                value: 4.4299999999999997);

            migrationBuilder.UpdateData(
                table: "InterventionEffects",
                keyColumn: "Id",
                keyValue: 5,
                column: "EffectValue",
                value: 3.48);

            migrationBuilder.UpdateData(
                table: "InterventionEffects",
                keyColumn: "Id",
                keyValue: 6,
                column: "EffectValue",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 1,
                column: "TotalSectorCost",
                value: 1.385);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 2,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 3,
                column: "TotalSectorCost",
                value: 185.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 4,
                column: "TotalSectorCost",
                value: 6.2469999999999999);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 5,
                column: "TotalSectorCost",
                value: 8.0559999999999992);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 6,
                column: "TotalSectorCost",
                value: 7.6420000000000003);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 7,
                column: "TotalSectorCost",
                value: 7.7750000000000004);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 8,
                column: "TotalSectorCost",
                value: 9.2680000000000007);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 9,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 10,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 11,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 12,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 13,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 14,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 15,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 16,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 17,
                column: "TotalSectorCost",
                value: 979.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 18,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 19,
                column: "TotalSectorCost",
                value: 1.5700000000000001);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 20,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 21,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 22,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 23,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 24,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 25,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 26,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 27,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 28,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 29,
                column: "TotalSectorCost",
                value: 4.5220000000000002);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 30,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 31,
                column: "TotalSectorCost",
                value: 7.2489999999999997);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 32,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 33,
                column: "TotalSectorCost",
                value: 306.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 34,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 35,
                column: "TotalSectorCost",
                value: 491.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 36,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 37,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 38,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 39,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 40,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 41,
                column: "TotalSectorCost",
                value: 2.2210000000000001);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 42,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 43,
                column: "TotalSectorCost",
                value: 3.5609999999999999);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 44,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 45,
                column: "TotalSectorCost",
                value: 7.9729999999999999);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 46,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 47,
                column: "TotalSectorCost",
                value: 12.782999999999999);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 48,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 49,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 50,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 51,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 52,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 53,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 54,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 55,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 56,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 57,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 58,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 59,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 60,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 61,
                column: "TotalSectorCost",
                value: 195.63399999999999);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 62,
                column: "TotalSectorCost",
                value: 195.63399999999999);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 63,
                column: "TotalSectorCost",
                value: 195.63399999999999);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 64,
                column: "TotalSectorCost",
                value: 195.63399999999999);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 65,
                column: "TotalSectorCost",
                value: 46.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 66,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 67,
                column: "TotalSectorCost",
                value: 6.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 68,
                column: "TotalSectorCost",
                value: 208.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 69,
                column: "TotalSectorCost",
                value: 269.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 70,
                column: "TotalSectorCost",
                value: 255.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 71,
                column: "TotalSectorCost",
                value: 259.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 72,
                column: "TotalSectorCost",
                value: 309.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 73,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 74,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 75,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 76,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 77,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 78,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 79,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 80,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 81,
                column: "TotalSectorCost",
                value: 33.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 82,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 83,
                column: "TotalSectorCost",
                value: 52.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 84,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 85,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 86,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 87,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 88,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 89,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 90,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 91,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 92,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 93,
                column: "TotalSectorCost",
                value: 151.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 94,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 95,
                column: "TotalSectorCost",
                value: 242.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 96,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 97,
                column: "TotalSectorCost",
                value: 10.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 98,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 99,
                column: "TotalSectorCost",
                value: 16.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 100,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 101,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 102,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 103,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 104,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 105,
                column: "TotalSectorCost",
                value: 74.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 106,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 107,
                column: "TotalSectorCost",
                value: 119.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 108,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 109,
                column: "TotalSectorCost",
                value: 266.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 110,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 111,
                column: "TotalSectorCost",
                value: 426.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 112,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 113,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 114,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 115,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 116,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 117,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 118,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 119,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 120,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 121,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 122,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 123,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 124,
                column: "TotalSectorCost",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 125,
                column: "TotalSectorCost",
                value: 6.5209999999999999);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 126,
                column: "TotalSectorCost",
                value: 6.5209999999999999);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 127,
                column: "TotalSectorCost",
                value: 6.5209999999999999);

            migrationBuilder.UpdateData(
                table: "TotalSectorCosts",
                keyColumn: "Id",
                keyValue: 128,
                column: "TotalSectorCost",
                value: 6.5209999999999999);
        }
    }
}
