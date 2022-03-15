// See https://aka.ms/new-console-template for more information
Console.WriteLine("Excercise 6");
var signaler = new Signaler();
signaler.AddTime(new JupiterTime(1, 20));
signaler.AddTime(new JupiterTime(2, 20));
signaler.AddTime(new JupiterTime(3, 20));
signaler.Inform();

public class Signaler
{
    List<JupiterTime> Times = new List<JupiterTime>();
    public void AddTime(JupiterTime time)
    {
        Times.Add(time);
    }

    public void Inform()
    {
        if (Times == null) Console.WriteLine("No timers added yet.");
        else
        {
            foreach (var Time in Times)
            {
                Console.WriteLine(Time);
            }
        }
    }
}
public class JupiterTime
{
    private int Hours { get; set; }
    private int Minutes { get; set; }
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
    public override string ToString()
    {
        return "Time: " + Hours + ":" + Minutes;
    }
}