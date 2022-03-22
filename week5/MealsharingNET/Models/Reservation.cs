namespace MealsharingNET.Models;

public class Reservation
{
    public int ID { get; set; }
    public int NumberOfGuests { get; set; }
    public int MealID { get; set; }
    public DateTime CreatedDate { get; set; }
    public string ContactName { get; set; }
    public string ContactEmail { get; set; }
    public int MaxReservations { get; set; }
}