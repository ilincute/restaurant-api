using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RosettiRistorante.API.ViewModels
{
    public class IngredientSupplierViewModel
    {
        public int IngredientId { get; set; }

        public decimal Price { get; set; }

        public int TotalAmount { get; set; }

        public int SupplierId { get; set; }
    }
}
