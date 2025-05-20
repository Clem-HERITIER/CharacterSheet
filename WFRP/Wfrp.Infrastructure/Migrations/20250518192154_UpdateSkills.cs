using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Wfrp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSkills : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsGrouped",
                table: "Skills",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ShortDescription",
                table: "Skills",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsGrouped",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "ShortDescription",
                table: "Skills");
        }
    }
}
