using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CEProjectServer.Migrations
{
    /// <inheritdoc />
    public partial class upseedforInterventionType4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "EffectValue",
                table: "InterventionEffects",
                type: "decimal(28,18)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(28,6)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "EffectValue",
                table: "InterventionEffects",
                type: "decimal(28,6)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(28,18)");
        }
    }
}
