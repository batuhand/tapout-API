using Microsoft.EntityFrameworkCore.Migrations;

namespace tapoutAPI.Migrations
{
    public partial class taskUpdate4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "taskUser",
                table: "Task",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "taskUser",
                table: "Task");
        }
    }
}
