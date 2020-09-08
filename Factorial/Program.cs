using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, number, factorial;
            Console.WriteLine("Enter a number to see the factorial: ");
            number = int.Parse(Console.ReadLine());
            factorial = number;
            for (i = number - 1; i >= 1; i--)
            {
                factorial = factorial * i;
            }
            Console.WriteLine($"{number} factorial is: {factorial}");
            Console.ReadKey();
        }
    }
}
