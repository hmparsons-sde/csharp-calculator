using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exponents or multiplication?");
            var answer = Console.ReadLine();
            Console.WriteLine("type series as 1,2,3.");
            var line = Console.ReadLine();
            switch (answer.ToLower())
            {
                case "multiply":
                    var numbers = line.Split(',');
                    Console.WriteLine(int.Parse(numbers[0]) * int.Parse(numbers[1]) * int.Parse(numbers[2]));
                    break;
                case "square":
                    var exponents = line.Split(',');
                    Console.WriteLine(int.Parse(exponents[0]) * int.Parse(exponents[0]) + "," + int.Parse(exponents[1]) * int.Parse(exponents[1]) + "," + int.Parse(exponents[2]) * int.Parse(exponents[2]));
                    break;
                default:
                    Console.WriteLine("Type 'multiply' or 'square' to run successfully.");
                    break;
            }


        }
    }
}
