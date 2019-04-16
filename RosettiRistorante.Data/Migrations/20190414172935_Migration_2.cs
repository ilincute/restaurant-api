using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RosettiRistorante.Data.Migrations
{
    public partial class Migration_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IngredientStocks_Meals_MealId",
                table: "IngredientStocks");

            migrationBuilder.DropIndex(
                name: "IX_IngredientStocks_MealId",
                table: "IngredientStocks");

            migrationBuilder.DropColumn(
                name: "MealId",
                table: "IngredientStocks");

            migrationBuilder.CreateTable(
                name: "MealIngredientsStock",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MealId = table.Column<int>(nullable: false),
                    IngredientStockId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MealIngredientsStock", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MealIngredientsStock_IngredientStocks_IngredientStockId",
                        column: x => x.IngredientStockId,
                        principalTable: "IngredientStocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MealIngredientsStock_Meals_MealId",
                        column: x => x.MealId,
                        principalTable: "Meals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MealIngredientsStock_IngredientStockId",
                table: "MealIngredientsStock",
                column: "IngredientStockId");

            migrationBuilder.CreateIndex(
                name: "IX_MealIngredientsStock_MealId",
                table: "MealIngredientsStock",
                column: "MealId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MealIngredientsStock");

            migrationBuilder.AddColumn<int>(
                name: "MealId",
                table: "IngredientStocks",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_IngredientStocks_MealId",
                table: "IngredientStocks",
                column: "MealId");

            migrationBuilder.AddForeignKey(
                name: "FK_IngredientStocks_Meals_MealId",
                table: "IngredientStocks",
                column: "MealId",
                principalTable: "Meals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
