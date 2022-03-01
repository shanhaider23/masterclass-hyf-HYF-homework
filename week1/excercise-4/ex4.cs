// See https://aka.ms/new-console-template for more information

int Fibonacci(int n)
{
    if (n <= 1)
    {

        return n;
    }
    else
    {
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

}

int n = 6;
int nthNumber = Fibonacci(n);
Console.WriteLine($"Nth fibonacci number is {nthNumber}");


