using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcTodo.Migrations
{
    public partial class IAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Priorty",
                table: "Todos",
                newName: "Priority");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Priority",
                table: "Todos",
                newName: "Priorty");
        }
    }
}
