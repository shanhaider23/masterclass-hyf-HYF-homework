using MealsharingNET.Models;
namespace MealsharingNET;

public interface IMealRepository
{
    Task<IEnumerable<Meal>> ListOfMeals();
    Task AddMeal(Meal meal);

    Task<Meal> FindMealById(int id);
}