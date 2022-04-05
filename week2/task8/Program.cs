// See https://aka.ms/new-console-template for more information
Console.WriteLine("Excercise-8");

var time = new TitanTime(1000, 40);
Console.WriteLine(time.ToString());
public class TitanTime
{
    public int Hour;
    public int Minutes;
    public TitanTime(int hour, int minutes)
    {

        Hour = hour % 900 + minutes / 60;
        Minutes = minutes % 60;
    }



    public override string ToString()
    {
        return $"{Hour:000}:{Minutes:00}";
    }

}