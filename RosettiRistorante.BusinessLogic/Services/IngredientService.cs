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

        public List<Ingredient> GetIngredients()
        {
            return _ingredientsRepository.GetIngredients();
        }

        public List<IngredientStock> GetIngredientStocks()
        {
            return _ingredientsRepository.GetIngredientStocks();
        }

        public List<IngredientSupplier> GetIngredientSuppliers()
        {
            return _ingredientsRepository.GetIngredientSuppliers();
        }
    }
}
