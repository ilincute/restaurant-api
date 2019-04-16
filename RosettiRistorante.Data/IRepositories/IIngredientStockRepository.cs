using RosettiRistorante.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RosettiRistorante.Data.IRepositories
{
    interface IIngredientStockRepository
    {
        List<Ingredient> GetIngredients();
        List<IngredientStock> GetIngredientStocks();
        List<IngredientSupplier> GetIngredientSuppliers();
    }
}
