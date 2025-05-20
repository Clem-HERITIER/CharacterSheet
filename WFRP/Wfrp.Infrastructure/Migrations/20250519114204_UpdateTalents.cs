using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Wfrp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTalents : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MaximumLevel",
                table: "Talents",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TestType",
                table: "Talents",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaximumLevel",
                table: "Talents");

            migrationBuilder.DropColumn(
                name: "TestType",
                table: "Talents");
        }
    }
}
