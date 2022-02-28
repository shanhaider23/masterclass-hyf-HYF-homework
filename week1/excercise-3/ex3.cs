// See https://aka.ms/new-console-template for more information

int[] arr = new[] { 271, -3, 1, 14, -100, 13, 2, 1, -8, -59, -1852, 41, 5 };
int[] resultArray = GetResult(arr);
int[] GetResult(int[] arr)
{
    int positiveNumber = 1;
    int negativeNumber = 0;
    foreach (int n in arr)
    {
        if (n > 0)
        {
            positiveNumber =positiveNumber * n;

        }
        else
        {
            negativeNumber = negativeNumber + n;
        }
    }
    return new[] { negativeNumber, positiveNumber };
}
Console.WriteLine($"Sum of negative numbers: {resultArray[0]}. Multiplication of positive numbers: {resultArray[1]}");