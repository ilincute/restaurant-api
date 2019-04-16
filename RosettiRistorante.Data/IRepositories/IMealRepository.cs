using System;
using System.Collections.Generic;
using System.Text;
using RosettiRistorante.Data.Models;

namespace RosettiRistorante.Data.IRepositories
{
    interface IMealRepository
    {
        List<Ingredient> GetIngredients();
        List<IngredientStock> GetIngredientStocks();
    }
}
