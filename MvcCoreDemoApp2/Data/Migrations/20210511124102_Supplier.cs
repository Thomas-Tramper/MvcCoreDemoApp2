using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcCoreDemoApp2.Data.Migrations
{
    public partial class Supplier : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductsModel_SupplierModel_supplierNameid",
                table: "ProductsModel");

            migrationBuilder.DropIndex(
                name: "IX_ProductsModel_supplierNameid",
                table: "ProductsModel");

            migrationBuilder.DropColumn(
                name: "supplierNameid",
                table: "ProductsModel");

            migrationBuilder.AddColumn<int>(
                name: "ProductsModelid",
                table: "SupplierModel",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SupplierModel_ProductsModelid",
                table: "SupplierModel",
                column: "ProductsModelid");

            migrationBuilder.AddForeignKey(
                name: "FK_SupplierModel_ProductsModel_ProductsModelid",
                table: "SupplierModel",
                column: "ProductsModelid",
                principalTable: "ProductsModel",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SupplierModel_ProductsModel_ProductsModelid",
                table: "SupplierModel");

            migrationBuilder.DropIndex(
                name: "IX_SupplierModel_ProductsModelid",
                table: "SupplierModel");

            migrationBuilder.DropColumn(
                name: "ProductsModelid",
                table: "SupplierModel");

            migrationBuilder.AddColumn<int>(
                name: "supplierNameid",
                table: "ProductsModel",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductsModel_supplierNameid",
                table: "ProductsModel",
                column: "supplierNameid");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsModel_SupplierModel_supplierNameid",
                table: "ProductsModel",
                column: "supplierNameid",
                principalTable: "SupplierModel",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
