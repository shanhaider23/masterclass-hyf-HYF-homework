// See https://aka.ms/new-console-template for more information
Console.WriteLine("Excercise-4!");
var time = new JupiterTime(2, 20);
time.AddMinutes(-20);
PrintTime(time);


void PrintTime(JupiterTime time)
{
    Console.WriteLine($"{time.Hours}:{time.Minutes}");
}
public class JupiterTime
{
    int _hours = 0;
    int _minutes = 0;

    public JupiterTime(int hours = 0, int minutes = 0)
    {
        if (hours > 9)
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
            if (value < 0)
            {
                throw new Exception("Invalid Value");
            }

            else if (value > 59)
            {
                _minutes = value % 60;
                _hours = _hours + value / 60;
                if (_hours > 10)
                {
                    _hours = _hours % 10;
                }
                else
                    _minutes = value;
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
}