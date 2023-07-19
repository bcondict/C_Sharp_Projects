using System;

namespace _3_cel_to_fah
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the temperature in Celsius: ");
            double temperature = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Temperature in Fahrenheith is: " + cels_to_fah(temperature));
        }

        static double cels_to_fah(double temp)
        {
            return temp * 1.8 + 32;
        }
    }
}
