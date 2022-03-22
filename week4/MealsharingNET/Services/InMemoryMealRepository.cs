using MealsharingNET.Models;

namespace MealsharingNET;
public class InMemoryMealRepository : IMealRepository
{
    private List<Meal> Meals { get; set; } = new List<Meal>(){
        new Meal()
        {
            ID=1,
            Title="butter chicken",
            Description="butter and chicken with spieses ",
            Price= 199,
            Location="Copenhagen",
            When= DateTime.Now,

        },
        new Meal()
        {
            ID=2,
            Title="Grill",
            Description="Indian grill",
            Price= 130,
            Location="Brondby",
            When= DateTime.Now,

        }

    };

    public void Add(Meal meal)
    {
        Meals.Add(meal);
    }
    public IEnumerable<Meal> MealList()
    {
        return Meals;
    }

    public void Delete(int ID)
    {
        Meals.RemoveAll(meal => meal.ID == ID);
    }

}