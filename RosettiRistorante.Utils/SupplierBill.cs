using System;
using System.Collections.Generic;
using System.Text;

namespace RosettiRistorante.Utils
{
    public class SupplierBill
    {
        public decimal TotalPrice { get; set; }

        public int IngredientId { get; set; }

        public int Amount { get; set; }
    }
}
