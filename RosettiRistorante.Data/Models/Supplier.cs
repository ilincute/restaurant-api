using System;
using System.Collections.Generic;
using System.Text;

namespace RosettiRistorante.Data.Models
{
    public class Supplier : BaseEntity
    {

        public string Name { get; set; }

        public List<IngredientSupplier> AvailableIngredients { get; set; }
    }
}
