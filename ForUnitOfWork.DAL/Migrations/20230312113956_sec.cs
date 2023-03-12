using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ForUnitOfWork.DAL.Migrations
{
    public partial class sec : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_ProductCategoryMatches_CategoryId",
                table: "ProductCategoryMatches",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategoryMatches_ProductId",
                table: "ProductCategoryMatches",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategoryMatches_Categories_CategoryId",
                table: "ProductCategoryMatches",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategoryMatches_Products_ProductId",
                table: "ProductCategoryMatches",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategoryMatches_Categories_CategoryId",
                table: "ProductCategoryMatches");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategoryMatches_Products_ProductId",
                table: "ProductCategoryMatches");

            migrationBuilder.DropIndex(
                name: "IX_ProductCategoryMatches_CategoryId",
                table: "ProductCategoryMatches");

            migrationBuilder.DropIndex(
                name: "IX_ProductCategoryMatches_ProductId",
                table: "ProductCategoryMatches");
        }
    }
}
