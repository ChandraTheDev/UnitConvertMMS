using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UnitConvertMMS.Migrations
{
    /// <inheritdoc />
    public partial class SeedingData3updated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "UnitRates",
                keyColumn: "Id",
                keyValue: 9,
                column: "RateMetricToImperial",
                value: 0.001);

            migrationBuilder.UpdateData(
                table: "UnitRates",
                keyColumn: "Id",
                keyValue: 18,
                column: "RateMetricToImperial",
                value: 1000.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "UnitRates",
                keyColumn: "Id",
                keyValue: 9,
                column: "RateMetricToImperial",
                value: 0.98419999999999996);

            migrationBuilder.UpdateData(
                table: "UnitRates",
                keyColumn: "Id",
                keyValue: 18,
                column: "RateMetricToImperial",
                value: 907.18499999999995);
        }
    }
}
