using System;
using System.Collections.Generic;
using System.Text;
using RosettiRistorante.Data.Models;

namespace RosettiRistorante.Data.IRepositories
{
    public interface IIngredientSupplierRepository
    {
        List<IngredientSupplier> GetIngredientSuppliers();
        IngredientSupplier GetIngredientSupplier(int ingredientSupplierId);
        void AddIngredientSupplier(IngredientSupplier ingredientSupplier);
        void DeleteIngredientSupplier(int ingredientSupplierId);
        void UpdateIngredientSupplier(IngredientSupplier ingredientSupplier);
        List<IngredientSupplier> GetIngredientSuppliersBySupplierId(int supplierId);
    }
}
