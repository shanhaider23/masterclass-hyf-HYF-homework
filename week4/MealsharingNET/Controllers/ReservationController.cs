using Microsoft.AspNetCore.Mvc;
using MealsharingNET.Models;

namespace MealsharingNET.Controllers;

[ApiController]
[Route("Reservations")]
public class ReservationController : ControllerBase
{
    private IReservationRepository _repo;

    public ReservationController(IReservationRepository repo)
    {
        _repo = repo;
    }

    [HttpGet("List")]
    public List<Reservation> ListAllReservations()
    {
        return _repo.ListReservations().ToList();
    }
    [HttpPost("Add")]
    public void AddReservation([FromBody] Reservation r)
    {
        _repo.Add(r);
    }

    [HttpGet("GetReservation")]
    public List<Reservation> GetReservation(int id)
    {
        return _repo.GetReservation(id).ToList();
    }

    [HttpGet("GetMealReservations")]
    public List<Reservation> MealReservations(int id)
    {
        return _repo.MealReservations(id).ToList();
    }
}