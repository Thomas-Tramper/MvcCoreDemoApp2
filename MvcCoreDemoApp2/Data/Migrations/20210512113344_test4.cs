using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcCoreDemoApp2.Data.Migrations
{
    public partial class test4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductsModel_SupplierModel_supplierid",
                table: "ProductsModel");

            migrationBuilder.DropColumn(
                name: "supplierName",
                table: "ProductsModel");

            migrationBuilder.RenameColumn(
                name: "supplierid",
                table: "ProductsModel",
                newName: "supplierID");

            migrationBuilder.RenameIndex(
                name: "IX_ProductsModel_supplierid",
                table: "ProductsModel",
                newName: "IX_ProductsModel_supplierID");

            migrationBuilder.AlterColumn<string>(
                name: "SupplierName",
                table: "SupplierModel",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "supplierID",
                table: "ProductsModel",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "productName",
                table: "ProductsModel",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsModel_SupplierModel_supplierID",
                table: "ProductsModel",
                column: "supplierID",
                principalTable: "SupplierModel",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductsModel_SupplierModel_supplierID",
                table: "ProductsModel");

            migrationBuilder.RenameColumn(
                name: "supplierID",
                table: "ProductsModel",
                newName: "supplierid");

            migrationBuilder.RenameIndex(
                name: "IX_ProductsModel_supplierID",
                table: "ProductsModel",
                newName: "IX_ProductsModel_supplierid");

            migrationBuilder.AlterColumn<string>(
                name: "SupplierName",
                table: "SupplierModel",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "supplierid",
                table: "ProductsModel",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "productName",
                table: "ProductsModel",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "supplierName",
                table: "ProductsModel",
                type: "int",
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
    }
}
