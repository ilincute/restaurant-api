using System;
using System.Collections.Generic;
using System.Text;

namespace RosettiRistorante.Data.Models
{
    public class MealIngredientsStock : BaseEntity
    {
        public int MealId { get; set; }

        public int IngredientStockId { get; set; }

        public Meal Meal { get; set; }

        public IngredientStock IngredientStock { get; set; }
    }
}
