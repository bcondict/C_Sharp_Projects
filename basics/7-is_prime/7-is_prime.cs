using System;

namespace _7_is_prime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter te number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(is_prime(num) ? "{0} is a prime number" : "{0} is not a prime number", num);
        }

        static bool is_prime(int num)
        {
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }
    }
}
