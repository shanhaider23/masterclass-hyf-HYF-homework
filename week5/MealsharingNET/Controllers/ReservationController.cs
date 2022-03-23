using Microsoft.AspNetCore.Mvc;
using MealsharingNET.Models;
namespace MealsharingNET.Controllers;

[ApiController]
[Route("reservations")]
public class ReservationController : ControllerBase
{
    private IReservationRepository _repo;
    public ReservationController(IReservationRepository repo)
    {
        _repo = repo;
    }
    [HttpGet("ListAllReservations")]
    public List<Reservation> ListAllReservations()
    {
        return _repo.ReservationList().ToList();
    }
    [HttpPost("AddReservation")]
    public void AddReservation([FromBody] Reservation reservation)
    {
        _repo.AddReservation(reservation);
    }
    [HttpGet("FindReservationById")]
    public Reservation FindReservationById(int id)
    {
        return _repo.FindReservationById(id);
    }
    [HttpGet("FindResrvationByMealId")]

    public List<Reservation> FindResrvationByMealId(int mealId)
    {
        return _repo.FindResrvationByMealId(mealId).ToList();
    }

}