using System;
using System.Collections.Generic;
using System.Text;
using RosettiRistorante.Data.Models;

namespace RosettiRistorante.Data.IRepositories
{
    public interface ISupplierRepository
    {
        List<Supplier> GetSuppliers();
        void UpdateSupplier(Supplier supplier);
        void DeleteSupplier(int supplierId);
        void AddSupplier(Supplier supplier);
        Supplier GetSupplierById(int supplierId);
    }
}
