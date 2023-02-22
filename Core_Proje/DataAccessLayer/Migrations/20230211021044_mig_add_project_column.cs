using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_add_project_column : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "value",
                table: "Portfolios",
                newName: "Value");

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Portfolios",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Portfolios");

            migrationBuilder.RenameColumn(
                name: "Value",
                table: "Portfolios",
                newName: "value");
        }
    }
}
