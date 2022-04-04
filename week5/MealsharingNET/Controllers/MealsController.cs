
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
    public async Task<IEnumerable<Meal>> ListAllMeals()
    {
        return await _repo.ListOfMeals();
    }
    [HttpPost("Add")]
    public async Task AddMeal([FromBody] Meal meal)
    {
        await _repo.AddMeal(meal);
    }
    [HttpGet("FindMealById")]
    public async Task<Meal> FindMealById(int id)
    {
        return await _repo.FindMealById(id);
    }
}