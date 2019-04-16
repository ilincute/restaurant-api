using System;
using System.Collections.Generic;
using System.Text;
using RosettiRistorante.Data.Models;

namespace RosettiRistorante.Data.IRepositories
{
    public interface IIngredientRepository
    {
        List<Ingredient> GetIngredients();
        List<IngredientStock> GetIngredientStocks();
        List<IngredientSupplier> GetIngredientSuppliers();
    }
}
