using System;
using System.Collections.Generic;
using System.Text;
using RosettiRistorante.BusinessLogic.IServices;
using RosettiRistorante.Data.IRepositories;
using RosettiRistorante.Data.Models;
using RosettiRistorante.Data.Repositories;
using RosettiRistorante.Utils;

namespace RosettiRistorante.BusinessLogic.Services
{
    public class IngredientSupplierService : IIngredientSupplierService
    {
        private readonly IIngredientSupplierRepository _ingredientSupplierRepository;

        public IngredientSupplierService(IIngredientSupplierRepository ingredientSupplierRepository)
        {
            _ingredientSupplierRepository = ingredientSupplierRepository;
        }

        public void AddIngredientSupplier(IngredientSupplier ingredientSupplier)
        {
            _ingredientSupplierRepository.AddIngredientSupplier(ingredientSupplier);
        }

        public void DeleteIngredientSupplier(int ingredientSupplierId)
        {
            _ingredientSupplierRepository.DeleteIngredientSupplier(ingredientSupplierId);
        }

        public IngredientSupplier GetIngredientSupplierById(int ingredientSupplierId)
        {
            return _ingredientSupplierRepository.GetIngredientSupplier(ingredientSupplierId);
        }

        public List<IngredientSupplier> GetIngredientSuppliersBySupplierId(int supplierId)
        {
            return _ingredientSupplierRepository.GetIngredientSuppliersBySupplierId(supplierId);
        }

        public SupplierBill OrderIngredientsFromSupplier(int supplierId, int ingredientSupplierId, int amount)
        {
            var supplierBill = new SupplierBill();

            var ingredientSupplier = _ingredientSupplierRepository.GetIngredientSupplier(ingredientSupplierId);

            if (ingredientSupplier == null)
            {
                throw new ArgumentException("Invalid ingredientSupplierId.");
            }

            if (ingredientSupplier.TotalAmount < amount)
            {
                throw new ArgumentException("The amount is too high.");
            }

            supplierBill.TotalPrice = amount * ingredientSupplier.Price;
            supplierBill.IngredientId = ingredientSupplier.IngredientId;
            supplierBill.Amount = amount;          

            ingredientSupplier.TotalAmount = ingredientSupplier.TotalAmount - amount;
            _ingredientSupplierRepository.UpdateIngredientSupplier(ingredientSupplier);

            return supplierBill;
        }

        public void UpdateIngredientSupplier(IngredientSupplier ingredientSupplier)
        {
            _ingredientSupplierRepository.UpdateIngredientSupplier(ingredientSupplier);
        }
    }
}
