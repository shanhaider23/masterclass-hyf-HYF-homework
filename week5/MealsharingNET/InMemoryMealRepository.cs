using MealsharingNET.Models;
namespace MealsharingNET;
public class InMemoryMealRepository : IMealRepository
{

    private List<Meal> Meals { get; set; } = new List<Meal>(){
        new Meal(){ID = 1, Title="pizza", Description="Homemade pizza with fresh vegetable and mozzerella chese",Cost = 100, ImageUrl="", Location="Herlev",MaxReservations=30},
        new Meal(){ID = 2, Title="rice with curry", Description="rice with chicken curry",Cost = 150, ImageUrl="", Location="Hillerød",MaxReservations = 200},
        new Meal(){ID = 3, Title="pasta with prowns", Description="pasta with tomato souse and fried prowns",Cost = 110, ImageUrl="", Location="ballerup",MaxReservations = 90}
    };

    public IEnumerable<Meal> ListOfMeals()
    {

        return Meals;
    }

    public void AddMeal(Meal meal)
    {
        Meals.Add(meal);
    }

    public Meal FindMealById(int id)
    {
        return Meals.SingleOrDefault(m => m.ID == id);
    }

}