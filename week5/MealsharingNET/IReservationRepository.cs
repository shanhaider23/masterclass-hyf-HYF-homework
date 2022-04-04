using MealsharingNET.Models;
namespace MealsharingNET;

public interface IReservationRepository
{
    Task<IEnumerable<Reservation>> ReservationList();
    Task AddReservation(Reservation reservation);

    Task<Reservation> FindReservationById(int id);


}