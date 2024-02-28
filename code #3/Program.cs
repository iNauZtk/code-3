class Program
{
    static void Main()
    {
        // Create an instance of SymbolGenerator
        SymbolGenerator symbolGenerator = new SymbolGenerator();

        // Generate and display a random string with symbols
        Console.Write("Enter the length of the random symbol string: ");
        if (int.TryParse(Console.ReadLine(), out int length))
        {
            string randomSymbolString = symbolGenerator.GenerateRandomString(length);
            Console.WriteLine($"Random Symbol String: {randomSymbolString}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer for the length.");
        }
    }
}