using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication6.Data.Migrations
{
    public partial class mig_rev_01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "Orders",
                newName: "ProducQuantity");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProducQuantity",
                table: "Orders",
                newName: "id");
        }
    }
}
