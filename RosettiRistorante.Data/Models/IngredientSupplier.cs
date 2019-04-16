using System;
using System.Collections.Generic;
using System.Text;

namespace RosettiRistorante.Data.Models
{
    public class IngredientSupplier : BaseEntity
    {
        public Ingredient Ingredient { get; set; }

        public decimal Price { get; set; }

        public int TotalAmount { get; set; }
    }
}
