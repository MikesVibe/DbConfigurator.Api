using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DbConfigurator.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddDisplayNameToApiUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DisplayName",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DisplayName",
                table: "User");
        }
    }
}
