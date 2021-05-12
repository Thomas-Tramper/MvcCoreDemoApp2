using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcCoreDemoApp2.Data.Migrations
{
    public partial class test3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductsModel_SupplierModel_Supplierid",
                table: "ProductsModel");

            migrationBuilder.RenameColumn(
                name: "Supplierid",
                table: "ProductsModel",
                newName: "supplierid");

            migrationBuilder.RenameIndex(
                name: "IX_ProductsModel_Supplierid",
                table: "ProductsModel",
                newName: "IX_ProductsModel_supplierid");

            migrationBuilder.AddColumn<int>(
                name: "supplierName",
                table: "ProductsModel",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsModel_SupplierModel_supplierid",
                table: "ProductsModel",
                column: "supplierid",
                principalTable: "SupplierModel",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
        }
    }
}
