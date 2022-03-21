namespace MealsharingNET.Models;

public class Meal
{
    public int ID { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Location { get; set; }
    public DateTime When { get; set; }
    public int Price { get; set; }

    public DateTime CreatedDate { get; set; }

    //    public string ImageUrl { get; set; }


}