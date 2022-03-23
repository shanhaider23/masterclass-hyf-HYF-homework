namespace MealsharingNET.Models;

public class Meal
{
    public int ID { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public decimal Cost { get; set; }
    public string ImageUrl { get; set; }
    public string Location { get; set; }
    public int MaxReservations { get; set; }

}