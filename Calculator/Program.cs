using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exponents or multiplication?"); // greeting command line
            var answer = Console.ReadLine(); // user input
            Console.WriteLine("type series as 1,2,3.");
            var line = Console.ReadLine(); // user input
            switch (answer.ToLower())
            {
                case "multiply":
                    var numbers = line.Split(','); // split the string by commas
                    Console.WriteLine(int.Parse(numbers[0]) * int.Parse(numbers[1]) * int.Parse(numbers[2])); // int.Parse converts strings to numbers after separation. Then the math works on those parsed numbers.
                    break;
                case "square":
                    var exponents = line.Split(',');
                    Console.WriteLine(int.Parse(exponents[0]) * int.Parse(exponents[0]) + "," + int.Parse(exponents[1]) * int.Parse(exponents[1]) + "," + int.Parse(exponents[2]) * int.Parse(exponents[2])); // same as above, except adding the addition functions to concat our line of numbers
                    break;
                default:
                    Console.WriteLine("Type 'multiply' or 'square' to run successfully."); // if other cases are not inputted to command line
                    break;
            }


        }
    }
}
