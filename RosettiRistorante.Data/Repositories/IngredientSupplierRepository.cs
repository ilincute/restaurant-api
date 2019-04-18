using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using RosettiRistorante.Data.Context;
using RosettiRistorante.Data.IRepositories;
using RosettiRistorante.Data.Models;

namespace RosettiRistorante.Data.Repositories
{
    public class IngredientSupplierRepository : IIngredientSupplierRepository
    {
        private readonly DatabaseContext _databaseContext;

        public IngredientSupplierRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public void AddIngredientSupplier(IngredientSupplier ingredientSupplier)
        {
            _databaseContext.IngredientSuppliers.Add(ingredientSupplier);
            _databaseContext.SaveChanges();
        }

        public void DeleteIngredientSupplier(int ingredientSupplierId)
        {
            var ingredientSupplier = _databaseContext.IngredientSuppliers.FirstOrDefault(i => i.Id == ingredientSupplierId);
            _databaseContext.IngredientSuppliers.Remove(ingredientSupplier ?? throw new InvalidOperationException());
            _databaseContext.SaveChanges();
        }

        public IngredientSupplier GetIngredientSupplier(int ingredientSupplierId)
        {
            var ingredientSupplier = _databaseContext.IngredientSuppliers
                .Include(i => i.Ingredient)
                .FirstOrDefault(i => i.Id == ingredientSupplierId);
            return ingredientSupplier;
        }

        public List<IngredientSupplier> GetIngredientSuppliers()
        {
            return _databaseContext.IngredientSuppliers.ToList();
        }

        public List<IngredientSupplier> GetIngredientSuppliersBySupplierId(int supplierId)
        {
            return _databaseContext.IngredientSuppliers
                .Include(i => i.Ingredient)
                .Where(i => i.SupplierId == supplierId).ToList();
        }

        public void UpdateIngredientSupplier(IngredientSupplier ingredientSupplier)
        {
            var ingredientSupplierUpdate =
                _databaseContext.IngredientSuppliers.FirstOrDefault(i => i.Id == ingredientSupplier.Id);
            if (ingredientSupplierUpdate != null)
            {
                ingredientSupplierUpdate.TotalAmount = ingredientSupplier.TotalAmount;
                ingredientSupplierUpdate.Price = ingredientSupplier.Price;
                ingredientSupplierUpdate.IngredientId = ingredientSupplier.IngredientId;
                _databaseContext.IngredientSuppliers.Update(ingredientSupplierUpdate);
            }

            _databaseContext.SaveChanges();
        }
    }
}
