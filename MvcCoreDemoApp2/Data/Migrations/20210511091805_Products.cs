using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcCoreDemoApp2.Data.Migrations
{
    public partial class Products : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductsModel",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    productName = table.Column<string>(nullable: true),
                    supplierNameid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsModel", x => x.id);
                    table.ForeignKey(
                        name: "FK_ProductsModel_SupplierModel_supplierNameid",
                        column: x => x.supplierNameid,
                        principalTable: "SupplierModel",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductsModel_supplierNameid",
                table: "ProductsModel",
                column: "supplierNameid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductsModel");
        }
    }
}
