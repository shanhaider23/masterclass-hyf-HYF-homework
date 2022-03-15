// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var time = new JupiterTime(2, 20);
PrintTime(time);
var timeIn1Hour = time.AddHours(1);
PrintTime(timeIn1Hour);

void PrintTime(JupiterTime time)
{
    Console.WriteLine($"{time}");
}

public class JupiterTime
{
    public int Hours;
    public int Minutes;
    public JupiterTime(int hours, int minutes)
    {
        Hours = hours;
        if (Minutes > 59)
        {
            Hours += 1;
            Minutes = minutes - 60;
        }
        else
        {
            Minutes = minutes;
        }
    }
    public JupiterTime AddHours(int hours)
    {
        Hours += hours;
        if (Hours > 23)
        {
            Hours -= 24;
        }
        if (Hours < 0)
        {
            Hours = Hours + 24;
        }
        return new JupiterTime(Hours, Minutes);
    }

}
