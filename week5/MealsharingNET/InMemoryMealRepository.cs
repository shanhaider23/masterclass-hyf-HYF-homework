// using MealsharingNET.Models;
// namespace MealsharingNET;
// public class InMemoryMealRepository : IMealRepository
// {

//     private List<Meal> Meals { get; set; } = new List<Meal>(){
//         new Meal(){ID = 1, Title="Butter Chicken", Description="Homemade butter chiken",Cost = 100,  Location="Copenhagen",MaxReservations=30},
//         new Meal(){ID = 2, Title="rice with curry", Description="rice with curry",Cost = 150,  Location="Brondby",MaxReservations = 100},
//         new Meal(){ID = 3, Title="pasta with prowns", Description="pasta with tomato souse and fried prowns",Cost = 110,  Location="ballerup",MaxReservations = 90}
//     };

//     public IEnumerable<Meal> ListOfMeals()
//     {

//         return Meals;
//     }

//     public void AddMeal(Meal meal)
//     {
//         Meals.Add(meal);
//     }

//     public Meal FindMealById(int id)
//     {
//         return Meals.SingleOrDefault(m => m.ID == id);
//     }

// }