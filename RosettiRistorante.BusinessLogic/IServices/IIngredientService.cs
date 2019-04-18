using RosettiRistorante.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RosettiRistorante.BusinessLogic.IServices
{
    public interface IIngredientService
    {
        List<Ingredient> GetIngredients();
        Ingredient GetIngredientById(int ingredientId);
        void AddIngredient(Ingredient ingredient);
        void DeleteIngredient(int ingredientId);
        void UpdateIngredient(Ingredient ingredient);
    }
}
