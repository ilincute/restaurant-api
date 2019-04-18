using System;
using System.Collections.Generic;
using System.Text;
using RosettiRistorante.Data.Models;
using RosettiRistorante.Utils;

namespace RosettiRistorante.BusinessLogic.IServices
{
    public interface IIngredientSupplierService
    {
        List<IngredientSupplier> GetIngredientSuppliersBySupplierId(int supplierId);
        IngredientSupplier GetIngredientSupplierById(int ingredientSupplierId);
        void AddIngredientSupplier(IngredientSupplier ingredientSupplier);
        void DeleteIngredientSupplier(int ingredientSupplierId);
        void UpdateIngredientSupplier(IngredientSupplier ingredientSupplier);
        SupplierBill OrderIngredientsFromSupplier(int supplierId, int ingredientSupplierId, int amount);
    }
}
