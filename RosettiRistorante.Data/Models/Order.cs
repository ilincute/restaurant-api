using System;
using System.Collections.Generic;
using System.Text;

namespace RosettiRistorante.Data.Models
{
    public class Order : BaseEntity
    {
        public List<OrderMeal> OrderMeal { get; set; }

        public decimal Price { get; set; }
    }
}
