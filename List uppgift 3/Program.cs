using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int> länder = new Dictionary<string, int>();
        länder["Svergie"] = 450;
        länder["Norge"] = 385;
        länder["Danmark"] = 43;
        länder["Finland"] = 338;

        Console.WriteLine("Skriv in Svergie, Norge, Danmark eller finland för att få reda på dess area");
        string input = Console.ReadLine();

        Console.WriteLine($"{input}s area är {länder[input]}-tusen kvadratkilometer");
            
    }
}