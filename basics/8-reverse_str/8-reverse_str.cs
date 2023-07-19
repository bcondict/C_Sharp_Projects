using System;

namespace _8_reverse_str
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the string: ");
            string str = Console.ReadLine();

            Console.WriteLine("Reverse string is: {0}", reverse_str(str));
        }

        static string reverse_str(string str)
        {
            char[] str_arr = str.ToCharArray();
            Array.Reverse(str_arr);
            string new_arr = new string(str_arr);
            return new_arr;
        }
    }
}
