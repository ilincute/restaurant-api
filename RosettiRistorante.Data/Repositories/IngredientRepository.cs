using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RosettiRistorante.Data.Context;
using RosettiRistorante.Data.IRepositories;
using RosettiRistorante.Data.Models;

namespace RosettiRistorante.Data.Repositories
{
    public class IngredientRepository : IIngredientRepository
    {
        private readonly DatabaseContext _databaseContext;

        public IngredientRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public void AddIngredient(Ingredient ingredient)
        {
            _databaseContext.Ingredients.Add(ingredient);
            _databaseContext.SaveChanges();
        }

        public void DeleteIngredient(int ingredientId)
        {
            var ingredient = _databaseContext.Ingredients.FirstOrDefault(i => i.Id == ingredientId);
            _databaseContext.Ingredients.Remove(ingredient ?? throw new InvalidOperationException());
            _databaseContext.SaveChanges();
        }

        public Ingredient GetIngredientById(int ingredientId)
        {
            var ingredient = _databaseContext.Ingredients.FirstOrDefault(i => i.Id == ingredientId);
            return ingredient;
        }

        public List<Ingredient> GetIngredients()
        {
            return _databaseContext.Ingredients.ToList();
        }

        public void UpdateIngredient(Ingredient ingredient)
        {
            var ingredientUpdate =
                _databaseContext.Ingredients.FirstOrDefault(i => i.Id == ingredient.Id);
            if (ingredientUpdate != null)
            {
                ingredientUpdate.Name = ingredient.Name;
                ingredientUpdate.Description = ingredient.Description;
                

                _databaseContext.Ingredients.Update(ingredientUpdate);
            }

            _databaseContext.SaveChanges();
        }
    }
}