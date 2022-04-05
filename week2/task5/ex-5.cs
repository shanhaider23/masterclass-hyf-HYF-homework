// See https://aka.ms/new-console-template for more information
Console.WriteLine("Excercise-5");

var time = new JupiterTime(2, 20);
time.AddMinutes(20);

Console.WriteLine(time);

public class JupiterTime
{
    int _hours = 0;
    int _minutes = 0;
    public JupiterTime(int hours = 0, int minutes = 0)
    {
        if (hours > 0)
        {
            _hours = hours % 10;
        }
        else _hours = hours;
        if (minutes > 59)
        {
            _hours += minutes / 60;
            _minutes = minutes % 60;
        }
        else _minutes = minutes;
    }
    public int Hours
    {
        get
        {
            return _hours;
        }
        set
        {
            _hours += value;
            if (_hours > 9) _hours = _hours % 10;
        }
    }
    public int Minutes
    {
        get
        {
            return _minutes;
        }
        set
        {
            _minutes += value;
            if (_minutes > 59)
            {
                _hours += _minutes / 60;
                _minutes = _minutes % 60;
            }

        }
    }
    public int AddHours(int hours)
    {
        _hours += hours;


        if (_hours < 0) _hours += System.Math.Abs(_hours - (_hours % 10) - 10);
        if (_hours > 9) _hours = _hours % 10;

        return _hours;
    }
    public int AddMinutes(int minutes)
    {
        _minutes += minutes;


        if (_minutes < 0)
        {
            _hours -= System.Math.Abs(minutes) / 60 + 1;
            _minutes += System.Math.Abs(_minutes - (_minutes % 60) - 60);
        }

        if (_minutes > 59)
        {
            _hours += _minutes / 60;
            _minutes = _minutes % 60;
        }
        return _minutes;
    }
    public override string ToString()
    {
        string f = "00.##";
        return $"{_hours.ToString(f)}:{_minutes.ToString(f)}";
    }
}