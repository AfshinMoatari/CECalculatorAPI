using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CEProjectServer.Migrations
{
    /// <inheritdoc />
    public partial class upseedforInterventionType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "InterventionEffects",
                keyColumn: "Id",
                keyValue: 1,
                column: "EffectValue",
                value: 2.65923970302888m);

            migrationBuilder.UpdateData(
                table: "InterventionEffects",
                keyColumn: "Id",
                keyValue: 2,
                column: "EffectValue",
                value: 3.45701161393755m);

            migrationBuilder.UpdateData(
                table: "InterventionEffects",
                keyColumn: "Id",
                keyValue: 3,
                column: "EffectValue",
                value: 3.36837029050325m);

            migrationBuilder.UpdateData(
                table: "InterventionEffects",
                keyColumn: "Id",
                keyValue: 4,
                column: "EffectValue",
                value: 4.4320661717148m);

            migrationBuilder.UpdateData(
                table: "InterventionEffects",
                keyColumn: "Id",
                keyValue: 5,
                column: "EffectValue",
                value: 3.47917194479612m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
