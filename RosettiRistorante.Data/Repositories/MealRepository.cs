using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using RosettiRistorante.Data.Context;
using RosettiRistorante.Data.IRepositories;
using RosettiRistorante.Data.Models;

namespace RosettiRistorante.Data.Repositories
{
    public class MealRepository : IMealRepository
    {
        private readonly DatabaseContext _databaseContext;

        public MealRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public void AddMeal(Meal meal)
        {
            _databaseContext.Meals.Add(meal);
            _databaseContext.SaveChanges();
        }

        public void Delete(int mealId)
        {
            var meal = _databaseContext.Meals.FirstOrDefault(i => i.Id == mealId);
            _databaseContext.Meals.Remove(meal ?? throw new InvalidOperationException());
            _databaseContext.SaveChanges();
        }

        public Meal GetMealById(int mealId)
        {
            var meal = _databaseContext.Meals.FirstOrDefault(i => i.Id == mealId);
            return meal;
        }

        public List<Meal> GetMeals()
        {
            return _databaseContext.Meals.ToList();
        }

        public void UpdateMeal(Meal meal)
        {
            var mealUpdated = _databaseContext.Meals.FirstOrDefault(i => i.Id == meal.Id);

            if (mealUpdated != null)
            {
                mealUpdated.Price = meal.Price;
                mealUpdated.InStock = meal.InStock;
                mealUpdated.Name = meal.Name;
                mealUpdated.MealIngredients = meal.MealIngredients;

                _databaseContext.Meals.Update(mealUpdated);
            }

            _databaseContext.SaveChanges();

        }
    }
}
