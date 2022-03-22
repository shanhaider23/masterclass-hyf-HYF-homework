using MealsharingNET.Models;

namespace MealsharingNET;

public class InMemoryReservationRepository : IReservationRepository
{
    private List<Reservation> Reservations { get; set; } = new List<Reservation>(){
        new Reservation()
        {
            ID=1,
            NumberOfGuests=10,
            MealID=2,
            CreatedDate= DateTime.Now,
                       ContactName= "shan",
            ContactEmail="shan@gmail.com"
        },
        new Reservation()
        {
            ID=2,
            NumberOfGuests=100,
            MealID=1,
            CreatedDate= DateTime.Now,
            ContactName= "haider",
            ContactEmail="haider@gmail.com"
        }
    };

    public IEnumerable<Reservation> ListReservations()
    {
        return Reservations;
    }
    public void Add(Reservation reservation)
    {
        Reservations.Add(reservation);
    }

}