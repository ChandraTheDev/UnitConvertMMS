using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UnitConvertMMS.Migrations
{
    /// <inheritdoc />
    public partial class SeedingData2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "UnitRates",
                columns: new[] { "Id", "CategoryId", "Formula", "ImperialUnitName", "MetricUnitName", "RateMetricToImperial" },
                values: new object[,]
                {
                    { 10, 1, "(X-32)*5/9", "c", "f", 0.0 },
                    { 11, 2, null, "mm", "in", 25.399999999999999 },
                    { 12, 2, null, "cm", "in", 2.54 },
                    { 13, 2, null, "m", "yd", 0.91439999999999999 },
                    { 14, 2, null, "km", "mile", 1.6093 },
                    { 15, 3, null, "mg", "grain", 64.798900000000003 },
                    { 16, 3, null, "g", "oz", 28.349499999999999 },
                    { 17, 3, null, "kg", "lb", 0.453592 },
                    { 18, 3, null, "kg", "ton", 907.18499999999995 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UnitRates",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "UnitRates",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "UnitRates",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "UnitRates",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "UnitRates",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "UnitRates",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "UnitRates",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "UnitRates",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "UnitRates",
                keyColumn: "Id",
                keyValue: 18);
        }
    }
}
