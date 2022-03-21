using Microsoft.AspNetCore.Mvc;

namespace MealsharingNET.Controllers;

[ApiController]
[Route("[meals]")]
public class MealController : ControllerBase
{
    private IMealRepository _repo;

    public MealController(IMealRepository repo)
    {
        _repo = repo;
    }

    [HttpGet("List")]
    public List<Meal> ListAllMeals()
    {
        return _repo.ListMeals().ToList();
    }
    [HttpPost("Add")]
    public void AddMeal([FromBody] Meal m)
    {
        _repo.Add(m);
    }

    [HttpGet("GetMeal")]
    public List<Meal> GetMeal(int id)
    {
        return _repo.GetMeal(id).ToList();
    }
}
