// See https://aka.ms/new-console-template for more information
Console.WriteLine("Excercise-9");
var time = new JupiterTime(20, 40);
Console.WriteLine(time);

public abstract class AlienTime
{
    public int Hour;
    public int Minutes;
    private int _hoursInDay;

    public AlienTime(int hour, int minutes, int hoursInDay)
    {
        _hoursInDay = hoursInDay;

        Hour = hour % hoursInDay + minutes / 60;
        Minutes = minutes % 60;

    }

    public override string ToString()
    {
        return $"{Hour:000}:{Minutes:00}";
    }


}

public class JupiterTime : AlienTime
{
    public JupiterTime(int hours, int minutes)
        : base(hours, minutes, 10)
    { }

    public override string ToString()
    {
        return $"{Hour:00}:{Minutes:00}";
    }
}

public class TitanTime : AlienTime
{
    public TitanTime(int hours, int minutes)
        : base(hours, minutes, 900)
    { }


}

public class GanymedeTime : AlienTime
{
    public GanymedeTime(int hours, int minutes)
        : base(hours, minutes, 171)
    { }

}