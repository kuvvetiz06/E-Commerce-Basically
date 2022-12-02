using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class Mg_02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductID",
                table: "Baskets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "Baskets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Baskets_ProductID",
                table: "Baskets",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Baskets_UserID",
                table: "Baskets",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Baskets_Products_ProductID",
                table: "Baskets",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Baskets_Users_UserID",
                table: "Baskets",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Baskets_Products_ProductID",
                table: "Baskets");

            migrationBuilder.DropForeignKey(
                name: "FK_Baskets_Users_UserID",
                table: "Baskets");

            migrationBuilder.DropIndex(
                name: "IX_Baskets_ProductID",
                table: "Baskets");

            migrationBuilder.DropIndex(
                name: "IX_Baskets_UserID",
                table: "Baskets");

            migrationBuilder.DropColumn(
                name: "ProductID",
                table: "Baskets");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Baskets");
        }
    }
}
