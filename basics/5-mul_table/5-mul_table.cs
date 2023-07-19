using System;

namespace _5_mul_table
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            mul_table(num);
        }

        static void mul_table(int num)
        {
            int i = 0;
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} X {1} = {2}", num, i, num*i);
            }
        }
    }
}
