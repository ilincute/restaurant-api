using System;
using System.Collections.Generic;
using System.Text;
using RosettiRistorante.BusinessLogic.IServices;
using RosettiRistorante.Data.IRepositories;
using RosettiRistorante.Data.Models;

namespace RosettiRistorante.BusinessLogic.Services
{
    public class IngredientService : IIngredientService
    {
        private readonly IIngredientRepository _ingredientsRepository;

        public IngredientService(IIngredientRepository ingredientsRepository)
        {
            _ingredientsRepository = ingredientsRepository;
        }

        public void AddIngredient(Ingredient ingredient)
        {
            _ingredientsRepository.AddIngredient(ingredient);
        }

        public void DeleteIngredient(int ingredientId)
        {
            _ingredientsRepository.DeleteIngredient(ingredientId);
        }

        public Ingredient GetIngredientById(int ingredientId)
        {
            var ingredient = _ingredientsRepository.GetIngredientById(ingredientId);
            return ingredient;
        }

        public List<Ingredient> GetIngredients()
        {
            var ingredients = _ingredientsRepository.GetIngredients();
            return ingredients;
        }

        public void UpdateIngredient(Ingredient ingredient)
        {
            _ingredientsRepository.UpdateIngredient(ingredient);
        }
    }
}
