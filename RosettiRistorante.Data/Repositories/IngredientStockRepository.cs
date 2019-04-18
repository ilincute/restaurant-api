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

        public void AddIngredientStock(IngredientStock ingredientStock)
        {
            _databaseContext.IngredientStocks.Add(ingredientStock);
            _databaseContext.SaveChanges();
        }

        public void DeleteIngredientStock(int ingredientStockId)
        {
            var ingredientStock = _databaseContext.IngredientStocks.FirstOrDefault(i => i.Id == ingredientStockId);
            _databaseContext.IngredientStocks.Remove(ingredientStock ?? throw new InvalidOperationException());
            _databaseContext.SaveChanges();
        }

        public IngredientStock GetIngredientStock(int ingredientStockId)
        {
            var ingredientStock = _databaseContext.IngredientStocks.FirstOrDefault(i => i.Id == ingredientStockId);
            return ingredientStock;
        }

        public List<IngredientStock> GetIngredientStocks()
        {
            return _databaseContext.IngredientStocks.ToList();
        }

        public void UpdateIngredientStock(IngredientStock ingredientStock)
        {
            var ingredientStockUpdate =
                _databaseContext.IngredientStocks.FirstOrDefault(i => i.Id == ingredientStock.Id);
            if (ingredientStockUpdate != null)
            {
                ingredientStockUpdate.TotalAmount = ingredientStock.TotalAmount;
                ingredientStockUpdate.Price = ingredientStock.Price;
                ingredientStockUpdate.IngredientId = ingredientStock.IngredientId;
                _databaseContext.IngredientStocks.Update(ingredientStockUpdate);
            }

            _databaseContext.SaveChanges();
        }
    }
}