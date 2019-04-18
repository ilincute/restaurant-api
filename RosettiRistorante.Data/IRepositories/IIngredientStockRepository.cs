using RosettiRistorante.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RosettiRistorante.Data.IRepositories
{
    interface IIngredientStockRepository
    {
        List<IngredientStock> GetIngredientStocks();
        IngredientStock GetIngredientStock(int ingredientStockId);
        void AddIngredientStock(IngredientStock ingredientStock);
        void DeleteIngredientStock(int ingredientStockId);
        void UpdateIngredientStock(IngredientStock ingredientStock);
    }
}
