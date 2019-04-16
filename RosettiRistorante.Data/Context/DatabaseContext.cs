using System;
using System.Collections.Generic;
using System.Text;
using RosettiRistorante.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace RosettiRistorante.Data.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Balance> Balances { get; set; }

        public DbSet<Ingredient> Ingredients { get; set; }

        public DbSet<IngredientStock> IngredientStocks { get; set; }

        public DbSet<IngredientSupplier> IngredientSuppliers { get; set; }

        public DbSet<Meal> Meals { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Supplier> Suppliers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
