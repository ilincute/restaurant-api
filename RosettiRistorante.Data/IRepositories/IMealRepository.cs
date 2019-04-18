using System;
using System.Collections.Generic;
using System.Text;
using RosettiRistorante.Data.Models;

namespace RosettiRistorante.Data.IRepositories
{
    interface IMealRepository
    {
        List<Meal> GetMeals();
        Meal GetMealById(int mealId);
        void AddMeal(Meal meal);
        void Delete(int mealId);
        void UpdateMeal(Meal meal);
    }
}