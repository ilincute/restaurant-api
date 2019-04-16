using RosettiRistorante.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RosettiRistorante.BusinessLogic.IServices
{
    public interface IIngredientService
    {
        List<Ingredient> GetIngredients();
        List<IngredientStock> GetIngredientStocks();
        List<IngredientSupplier> GetIngredientSuppliers();
    }
}
