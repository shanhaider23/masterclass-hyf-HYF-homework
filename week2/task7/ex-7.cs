// See https://aka.ms/new-console-template for more information
Console.WriteLine("Excercise-7");
var signaler = new Signaler();
signaler.AddTime(new JupiterTime(2, 00));
signaler.AddTime(new JupiterTime(4, 00));
signaler.AddTime(new JupiterTime(6, 00));
signaler.Check(new JupiterTime(1, 17));
signaler.Check(new JupiterTime(4, 21));


public class Signaler
{
    List<JupiterTime> Times = new List<JupiterTime>();
    List<JupiterTime> RemainingTimes = new List<JupiterTime>();
    public void AddTime(JupiterTime time)
    {
        Times.Add(time);
    }
    public void Check(JupiterTime time)
    {

        foreach (var i in Times)
        {
            if (time.Hours > i.Hours || (time.Hours == i.Hours && time.Minutes > i.Minutes))
            {
                RemainingTimes.Add(i);
            }
        }

        if (RemainingTimes.Count == 0) Console.WriteLine("No Timers added yet");
        else
        {
            foreach (var i in RemainingTimes)
            {
                Console.WriteLine(i);
            }
        }
    }
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
    public override string ToString()
    {
        return "Time: " + Hours + ":" + Minutes;
    }
}