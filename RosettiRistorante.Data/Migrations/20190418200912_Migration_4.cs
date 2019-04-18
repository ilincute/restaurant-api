using Microsoft.EntityFrameworkCore.Migrations;

namespace RosettiRistorante.Data.Migrations
{
    public partial class Migration_4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IngredientSuppliers_Ingredients_IngredientId",
                table: "IngredientSuppliers");

            migrationBuilder.DropForeignKey(
                name: "FK_IngredientSuppliers_Suppliers_SupplierId",
                table: "IngredientSuppliers");

            migrationBuilder.AlterColumn<int>(
                name: "SupplierId",
                table: "IngredientSuppliers",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IngredientId",
                table: "IngredientSuppliers",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_IngredientSuppliers_Ingredients_IngredientId",
                table: "IngredientSuppliers",
                column: "IngredientId",
                principalTable: "Ingredients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IngredientSuppliers_Suppliers_SupplierId",
                table: "IngredientSuppliers",
                column: "SupplierId",
                principalTable: "Suppliers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IngredientSuppliers_Ingredients_IngredientId",
                table: "IngredientSuppliers");

            migrationBuilder.DropForeignKey(
                name: "FK_IngredientSuppliers_Suppliers_SupplierId",
                table: "IngredientSuppliers");

            migrationBuilder.AlterColumn<int>(
                name: "SupplierId",
                table: "IngredientSuppliers",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "IngredientId",
                table: "IngredientSuppliers",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_IngredientSuppliers_Ingredients_IngredientId",
                table: "IngredientSuppliers",
                column: "IngredientId",
                principalTable: "Ingredients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_IngredientSuppliers_Suppliers_SupplierId",
                table: "IngredientSuppliers",
                column: "SupplierId",
                principalTable: "Suppliers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
