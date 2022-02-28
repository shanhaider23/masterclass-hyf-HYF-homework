// See https://aka.ms/new-console-template for more information
string input = "world";
string reversed = string.Empty;
for (int i = input.Length-1; i >=0; i--)
{
    reversed = reversed + input[i].ToString();
}

Console.WriteLine(reversed);

