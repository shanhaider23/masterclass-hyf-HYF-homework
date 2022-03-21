// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var time = new JupiterTime(7, 40);
var newTime = new JupiterTime(14, 88);

PrintTime(newTime);

void PrintTime(JupiterTime time)
{
    Console.WriteLine($"{time.Hours}:{time.Minutes}");
}
public class JupiterTime
{
    public int Hours { get; set; }
    public int Minutes { get; set; }
    public JupiterTime(int hours, int minutes)
    {
        Hours = hours;
        Minutes = minutes;

        if (Minutes > 59)
        {
            Hours += minutes / 60;
            Minutes = minutes % 60;

        }
    }
}