using System;
using System.Collections.Generic;
using System.Text;
using RosettiRistorante.Data.Models;

namespace RosettiRistorante.Data.IRepositories
{
    public interface IIngredientRepository
    {
        List<Ingredient> GetIngredients();
        Ingredient GetIngredientById(int ingredientId);
        void AddIngredient(Ingredient ingredient);
        void DeleteIngredient(int ingredientId);
        void UpdateIngredient(Ingredient ingredient);
    }
}
