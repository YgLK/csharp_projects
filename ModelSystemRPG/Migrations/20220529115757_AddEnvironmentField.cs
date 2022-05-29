using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModelSystemRPG.Migrations
{
    public partial class AddEnvironmentField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Environment",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Environment",
                table: "Categories");
        }
    }
}
