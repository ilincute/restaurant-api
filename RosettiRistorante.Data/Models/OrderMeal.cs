using System;
using System.Collections.Generic;
using System.Text;

namespace RosettiRistorante.Data.Models
{
    public class OrderMeal : BaseEntity
    {
        public int OrderId { get; set; }

        public int MealId { get; set; }

        public Meal Meal { get; set; }

        public Order Order { get; set; }
    }
}
