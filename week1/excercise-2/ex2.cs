// See https://aka.ms/new-console-template for more information

string input = "Intellectualization";
int GetVowelCount(string str)
{
int vowelCount = 0;
    foreach (char letter in str)
    {
        if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
        {
            vowelCount++;
        }
    }
    return vowelCount;
}

Console.WriteLine($"Number of vowels: {GetVowelCount(input)}"); 