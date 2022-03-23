
using Microsoft.AspNetCore.Mvc;
using MealsharingNET.Models;
namespace MealsharingNET.Controllers;

[ApiController]
[Route("meals")]
public class MealsController : ControllerBase
{
    private IMealRepository _repo;
    public MealsController(IMealRepository repo)
    {
        _repo = repo;
    }
    [HttpGet("List")]
    public List<Meal> ListAllMeals()
    {
        return _repo.ListOfMeals().ToList();
    }
    [HttpPost("Add")]
    public void AddMeal([FromBody] Meal meal)
    {
        _repo.AddMeal(meal);
    }
    [HttpGet("FindMealById")]
    public Meal FindMealById(int id)
    {
        return _repo.FindMealById(id);
    }
}