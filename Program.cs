using System;

namespace VariablesCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C#");

            var numberOfCupsOfCoffee = "1";
            var fullName = "Nathan Pham";
            var today = DateTime.Now;


            Console.WriteLine(numberOfCupsOfCoffee + fullName + today);


            Console.Write("What is your name? ");
            var username = Console.ReadLine();
            Console.WriteLine("What is up " + username);


            Console.Write("How old are you? ");
            var firstNumberAsString = Console.ReadLine();
            Console.Write("How many pets do you own? ");
            var secondNumberAsString = Console.ReadLine();


            var firstOperand = double.Parse(firstNumberAsString);
            var secondOperand = double.Parse(secondNumberAsString);


            var sum = (firstOperand + secondOperand);
            var difference = (firstOperand - secondOperand);
            var product = (firstOperand * secondOperand);
            var quotient = (firstOperand / secondOperand);
            var remainder = (firstOperand % secondOperand);

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Difference: " + difference);
            Console.WriteLine("Product: " + product);
            Console.WriteLine("Quotient: " + quotient);
            Console.WriteLine("Remainder: " + remainder);









        }
    }
}
