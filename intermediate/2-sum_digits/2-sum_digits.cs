using System;

namespace _2_sum_digits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the number: ");
            string str_nums = Console.ReadLine();

            Console.WriteLine("Sum of digits is: {0}", sum_digits(str_nums));
        }

        static int sum_digits(string str)
        {
            char[] char_digits = str.ToCharArray();
            int[] int_digits = Array.ConvertAll(char_digits, c => (int)Char.GetNumericValue(c));
            int result = 0;

            foreach (int num in int_digits)
                result += num;

            return result;
        }
    }
}
