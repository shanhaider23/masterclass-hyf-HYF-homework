using MealsharingNET.Models;

namespace MealsharingNET;

public interface IMealRepository
{
    void AddMeal(Meal m);
    IEnumerable<Meal> ListMeals();
    Meal GetMealByID(int ID);
}