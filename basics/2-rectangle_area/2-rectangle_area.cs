using System;

namespace _2_reactangle_area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the width: ");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the height: ");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Area is: " + calculate_area(width, height));
        }

        static int calculate_area(int width, int height)
        {
            return width * height;
        }
    }
}
