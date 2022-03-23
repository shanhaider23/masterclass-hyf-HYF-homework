using MealsharingNET.Models;
namespace MealsharingNET;

public interface IReservationRepository
{
    IEnumerable<Reservation> ReservationList();
    void AddReservation(Reservation reservation);

    Reservation FindReservationById(int id);

    IEnumerable<Reservation> FindResrvationByMealId(int mealId);
}