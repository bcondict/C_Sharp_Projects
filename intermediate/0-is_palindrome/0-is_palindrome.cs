using System;

namespace _0_is_palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the string: ");
            string str = Console.ReadLine();

            Console.WriteLine("{0} is {1}palindrome", str, is_palindrome(str) ? "" : "not ");
        }

        static bool is_palindrome(string str)
        {
            char[] str_arr = str.ToCharArray();
            int char_len = str_arr.Length;
            char[] reverse_str = new char[char_len];

            Array.Copy(str_arr, reverse_str, char_len);
            Array.Reverse(reverse_str);

            for (int i = 0; i < char_len; i++)
            {
                if (str_arr[i] != reverse_str[i])
                    return false;
            }
            return true;
        }
    }
}
