using MealsharingNET.Models;
namespace MealsharingNET;
using Dapper;
using MySql.Data.MySqlClient;

public class MealRepository : IMealRepository
{
    public async Task<Meal> FindMealById(int id)
    {

        await using var connection = new MySqlConnection(Shared.ConnectionString);
        var meal = await connection.QueryFirstAsync<Meal>("SELECT * FROM meals WHERE ID=Id");
        return meal;
    }

    public async Task<IEnumerable<Meal>> ListOfMeals()
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        var meals = await connection.QueryAsync<Meal>("SELECT id, title, discription as Description, location, `when`, max_reservations as MaxReservations, price as cost, createdDate FROM meals");
        return meals;
    }

    public async Task AddMeal(Meal meal)
    {
        await using var connection = new MySqlConnection(Shared.ConnectionString);
        var meals = await connection.ExecuteAsync("INSERT INTO meals (title, discription, location, max_reservations, price, createdDate) VALUES ( @Title , @Description, @Location,@MaxReservations ,   @Cost, now() ) ", meal);
    }


}