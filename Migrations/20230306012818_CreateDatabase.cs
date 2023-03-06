using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Northwind_2.Migrations
{
    public partial class CreateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "ProductId",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuantityPerUnit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    UnitsInStock = table.Column<short>(type: "smallint", nullable: false),
                    UnitsOnOrder = table.Column<short>(type: "smallint", nullable: false),
                    ReorderLevel = table.Column<short>(type: "smallint", nullable: false),
                    Discontinued = table.Column<bool>(type: "bit", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductId", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_ProductId_Product_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Product",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductId_CategoryId",
                table: "ProductId",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductId");

            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
