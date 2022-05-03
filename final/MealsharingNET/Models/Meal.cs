using System.Text.Json.Serialization;

namespace MealsharingNET.Models;

public class Meal
{
    public int ID { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    [JsonPropertyName("price")]
    public decimal Cost { get; set; }

    public string Location { get; set; }
    public int MaxReservations { get; set; }

}