using System;
using System.Linq;

namespace _4_largest_num
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first number: ");
            int first = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the second number: ");
            int second = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the third number: ");
            int third = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Largest number is: " + largest_num(first, second, third));
        }

        static int largest_num(int first, int second, int third)
        {
            int[] num_arr = {first, second, third};

            return num_arr.Max();
        }
    }
}
