using System;

namespace RomanNumeralGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in a roman numeral");
            string romanNumber = Console.ReadLine();
            Console.WriteLine("");    
            Console.WriteLine(GenerateRomanNumerals.ConvertRomanNumerals(romanNumber));
            Console.WriteLine("");
            Console.WriteLine("Press any key to end.");
            Console.ReadLine();
        }

    }
}
