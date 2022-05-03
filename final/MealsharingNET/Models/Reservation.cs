using System.Text.Json.Serialization;

namespace MealsharingNET.Models;
public class Reservation
{
    public int ID { get; set; }
    public int MealID { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public DateTime Date { get; set; }

    [JsonPropertyName("number_of_guests")]
    public int NoOfPersons { get; set; }
    public int Phone { get; set; }

}