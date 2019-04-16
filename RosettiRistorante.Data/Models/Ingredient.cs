using System;
using System.Collections.Generic;
using System.Text;

namespace RosettiRistorante.Data.Models
{
    public class Ingredient : BaseEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
