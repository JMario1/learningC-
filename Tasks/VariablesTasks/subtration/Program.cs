using System;

namespace subtration
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 0;
            int secondNumber = 0;
            int reusult = 0;

            Console.Write("Please enter your first number: ");
            firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Please enter your second number: ");
            secondNumber = int.Parse(Console.ReadLine());
            
            Console.Write("Please enter your third number: ");
            reusult = firstNumber - secondNumber;

            Console.WriteLine("The answer is: " + reusult);
        }
    }
}
