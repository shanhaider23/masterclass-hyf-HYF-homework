using MealsharingNET.Models;
namespace MealsharingNET;

public class InMemoryReservationRepository : IReservationRepository
{
    private List<Reservation> Reservations { get; set; } = new List<Reservation>(){
        new Reservation(){ ID = 1, MealID = 2, Name = "Anne", Email = "anne@gmail.com", Date = "12/5/2022", NoOfPersons = 5},
        new Reservation(){ID = 2, MealID = 1, Name = "Sofie", Email = "sofie@gmail.com", Date = "15/4/2022", NoOfPersons = 20},
        new Reservation(){ ID = 3, MealID = 3, Name = "Eva", Email = "eva@gmail.com", Date = "25/6/2022", NoOfPersons = 10},
     };

    public IEnumerable<Reservation> ReservationList()
    {
        return Reservations;
    }

    public void AddReservation(Reservation resrvstion)
    {
        Reservations.Add(resrvstion);
    }

    public Reservation FindReservationById(int id)
    {
        return Reservations.SingleOrDefault(r => r.ID == id);
    }

    public IEnumerable<Reservation> FindResrvationByMealId(int mealId)
    {
        return Reservations.Where(r => r.MealID == mealId);
    }


}