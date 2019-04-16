using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RosettiRistorante.Data.Context;
using RosettiRistorante.Data.IRepositories;
using RosettiRistorante.Data.Models;

namespace RosettiRistorante.Data.Repositories
{
    public class IngredientStockRepository : IIngredientStockRepository
    {
        private readonly DatabaseContext _databaseContext;

        public IngredientStockRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public List<Ingredient> GetIngredients()
        {
            return _databaseContext.Ingredients.ToList();
        }

        public List<IngredientStock> GetIngredientStocks()
        {
            return _databaseContext.IngredientStocks.ToList();
        }

        public List<IngredientSupplier> GetIngredientSuppliers()
        {
            return _databaseContext.IngredientSuppliers.ToList();
        }
    }
}
