using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UnitConvertMMS.Migrations
{
    /// <inheritdoc />
    public partial class SeedingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Formula",
                table: "UnitRates",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "UnitCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Temperature" },
                    { 2, "Length" },
                    { 3, "Mass" }
                });

            migrationBuilder.InsertData(
                table: "UnitRates",
                columns: new[] { "Id", "CategoryId", "Formula", "ImperialUnitName", "MetricUnitName", "RateMetricToImperial" },
                values: new object[,]
                {
                    { 1, 1, "(X*9/5)+32", "f", "c", 0.0 },
                    { 2, 2, null, "in", "mm", 0.039370000000000002 },
                    { 3, 2, null, "in", "cm", 0.39369999999999999 },
                    { 4, 2, null, "yd", "m", 1.0935999999999999 },
                    { 5, 2, null, "mile", "km", 0.62139999999999995 },
                    { 6, 3, null, "grain", "mg", 0.0154 },
                    { 7, 3, null, "oz", "g", 0.035299999999999998 },
                    { 8, 3, null, "lb", "kg", 2.2046000000000001 },
                    { 9, 3, null, "ton", "kg", 0.98419999999999996 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UnitRates",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UnitRates",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UnitRates",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UnitRates",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "UnitRates",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "UnitRates",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "UnitRates",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "UnitRates",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "UnitRates",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "UnitCategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UnitCategories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UnitCategories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "Formula",
                table: "UnitRates");
        }
    }
}
