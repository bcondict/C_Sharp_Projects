using System;

namespace _6_factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Factorial is: " + factorial(num));
        }

        static int factorial(int num)
        {
            int result = 1;

            if (num == 0)
                return 1;

            for (int i = 1; i <= num; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
