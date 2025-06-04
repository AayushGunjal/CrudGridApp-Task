using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CrudGridApp.Migrations
{
    /// <inheritdoc />
    public partial class AddQuantityAndRateToEmployee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Rate",
                table: "Employees",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Rate",
                table: "Employees");
        }
    }
}
