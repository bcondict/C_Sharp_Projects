using System;
using System.Linq;

namespace _9_vowels_count
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the string: ");
            string str = Console.ReadLine();

            Console.WriteLine("Number of vowels is: {0}", vowels_count(str));
        }

        static int vowels_count(string str)
        {
            int count = 0;
            char[] vowels = {'a', 'e', 'i', 'o', 'u'};

            foreach (char c in str)
                // Console.WriteLine(c);
                if (vowels.Contains(c))

                    count++;
            return count; 
        }
    }
}
