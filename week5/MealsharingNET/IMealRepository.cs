using MealsharingNET.Models;
namespace MealsharingNET;

public interface IMealRepository
{
    IEnumerable<Meal> ListOfMeals();
    void AddMeal(Meal meal);

    Meal FindMealById(int id);
}