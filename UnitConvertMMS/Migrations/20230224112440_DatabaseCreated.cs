using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UnitConvertMMS.Migrations
{
    /// <inheritdoc />
    public partial class DatabaseCreated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UnitCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UnitRates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    MetricUnitName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImperialUnitName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RateMetricToImperial = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitRates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UnitRates_UnitCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "UnitCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UnitRates_CategoryId",
                table: "UnitRates",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UnitRates");

            migrationBuilder.DropTable(
                name: "UnitCategories");
        }
    }
}
