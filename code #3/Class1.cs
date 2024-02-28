using System;

class SymbolGenerator
{
    private const string Symbols = "!@#$%^&*()_+-=[]{}|;:'\",.<>/?";

    // Constructor
    public SymbolGenerator()
    {
        Console.WriteLine("Symbol Generator - Console App");
    }

    // Generate a random string with symbols
    public string GenerateRandomString(int length)
    {
        Random random = new Random();
        char[] symbolArray = Symbols.ToCharArray();
        char[] resultArray = new char[length];

        for (int i = 0; i < length; i++)
        {
            resultArray[i] = symbolArray[random.Next(symbolArray.Length)];
        }

        return new string(resultArray);
    }
}
