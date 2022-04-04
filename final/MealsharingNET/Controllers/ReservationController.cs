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
    [HttpGet("AllReservations")]
    public async Task<IEnumerable<Reservation>> ListAllReservations()
    {
        return await _repo.ReservationList();
    }
    [HttpPost("AddReservation")]
    public async Task AddReservation([FromBody] Reservation reservation)
    {
        await _repo.AddReservation(reservation);
    }
    [HttpGet("FindReservationById")]
    public async Task<Reservation> FindReservationById(int id)
    {
        return await _repo.FindReservationById(id);

    }


}