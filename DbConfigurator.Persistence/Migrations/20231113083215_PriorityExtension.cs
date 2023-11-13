using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DbConfigurator.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class PriorityExtension : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Value",
                table: "Priority",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Priority",
                keyColumn: "Id",
                keyValue: 1,
                column: "Value",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Priority",
                keyColumn: "Id",
                keyValue: 2,
                column: "Value",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Priority",
                keyColumn: "Id",
                keyValue: 3,
                column: "Value",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Priority",
                keyColumn: "Id",
                keyValue: 4,
                column: "Value",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Priority",
                keyColumn: "Id",
                keyValue: 99,
                column: "Value",
                value: 99);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Value",
                table: "Priority");
        }
    }
}
