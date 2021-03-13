using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop.Migrations
{
    public partial class NewOrders2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "orderAdress",
                table: "Order",
                newName: "orderAddress");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "orderAddress",
                table: "Order",
                newName: "orderAdress");
        }
    }
}
