using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopAPI.Migrations
{
    public partial class AddProductToDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductCategory",
                columns: table => new
                {
                    categoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategory", x => x.categoryId);
                });

            migrationBuilder.CreateTable(
                name: "ProductSubCategory",
                columns: table => new
                {
                    subCategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSubCategory", x => x.subCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "ProductInfo",
                columns: table => new
                {
                    productId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    productBrand = table.Column<string>(nullable: true),
                    productName = table.Column<string>(nullable: true),
                    productPrice = table.Column<int>(nullable: false),
                    productDetails = table.Column<string>(nullable: true),
                    productImage = table.Column<string>(nullable: true),
                    productQuantity = table.Column<decimal>(nullable: false),
                    addedToWishList = table.Column<bool>(nullable: false),
                    productExpiryDate = table.Column<DateTime>(nullable: true),
                    categoryId = table.Column<int>(nullable: false),
                    subCategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductInfo", x => x.productId);
                    table.ForeignKey(
                        name: "FK_ProductInfo_ProductCategory_categoryId",
                        column: x => x.categoryId,
                        principalTable: "ProductCategory",
                        principalColumn: "categoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductInfo_ProductSubCategory_subCategoryId",
                        column: x => x.subCategoryId,
                        principalTable: "ProductSubCategory",
                        principalColumn: "subCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductInfo_categoryId",
                table: "ProductInfo",
                column: "categoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductInfo_subCategoryId",
                table: "ProductInfo",
                column: "subCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductInfo");

            migrationBuilder.DropTable(
                name: "ProductCategory");

            migrationBuilder.DropTable(
                name: "ProductSubCategory");
        }
    }
}
