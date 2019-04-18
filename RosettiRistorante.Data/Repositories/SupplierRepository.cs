using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RosettiRistorante.Data.Context;
using RosettiRistorante.Data.IRepositories;
using RosettiRistorante.Data.Models;

namespace RosettiRistorante.Data.Repositories
{
    public class SupplierRepository : ISupplierRepository
    {
        private readonly DatabaseContext _databaseContext;

        public SupplierRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public void AddSupplier(Supplier supplier)
        {
            _databaseContext.Suppliers.Add(supplier);
            _databaseContext.SaveChanges();
        }

        public void DeleteSupplier(int supplierId)
        {
            var supplier = _databaseContext.Suppliers.FirstOrDefault(i => i.Id == supplierId);
            _databaseContext.Suppliers.Remove(supplier ?? throw new InvalidOperationException());
            _databaseContext.SaveChanges();
        }

        public Supplier GetSupplierById(int supplierId)
        {
            return _databaseContext.Suppliers.FirstOrDefault(i => i.Id == supplierId);
        }

        public List<Supplier> GetSuppliers()
        {
            return _databaseContext.Suppliers.ToList();
        }

        public void UpdateSupplier(Supplier supplier)
        {
            var supplierUpdate =
                _databaseContext.Suppliers.FirstOrDefault(i => i.Id == supplier.Id);
            if (supplierUpdate != null)
            {
                supplierUpdate.Name = supplier.Name;
                supplierUpdate.AvailableIngredients = supplier.AvailableIngredients;

                _databaseContext.Suppliers.Update(supplierUpdate);
            }

            _databaseContext.SaveChanges();
        }
    }
}
