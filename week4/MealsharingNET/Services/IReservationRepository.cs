using MealsharingNET.Models;
namespace MealsharingNET
{
    using System.Collections.Generic;
    public interface IReservationRepository
    {
        void CreateReservation(Reservation reservation);
        IEnumerable<Reservation> ReservationList();
        List<Reservation> GetReservations(int MealID);
    }
}