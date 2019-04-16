using System;
using System.Collections.Generic;
using System.Text;

namespace RosettiRistorante.Data.Models
{
    public class Meal : BaseEntity
    {
        public string Name { get; set; }

        public List<MealIngredientsStock> MealIngredients { get; set; }

        public decimal Price { get; set; }

        public bool InStock { get; set; }
    }
}
