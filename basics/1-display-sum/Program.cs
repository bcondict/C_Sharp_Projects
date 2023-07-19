using System;

namespace _1_display_sum
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sum is " + display_sum(num1, num2));
        }

        public static int display_sum(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
