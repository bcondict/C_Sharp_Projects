using System;

namespace _3_max_occurrence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the string: ");
            string str = Console.ReadLine();

            Console.WriteLine("Max occurrence is: {0}", max_occurrence(str));
        }

        static char max_occurrence(string str)
        {
            char[] char_str = str.ToCharArray();
            int[] int_str = Array.ConvertAll(char_str, c => (int)Char.GetNumericValue(c));

            int[] int_occurrence = new int[10];

            // int max = 0;
            // int max_index = 0;

            foreach (int num in int_str)
            {
                int_occurrence[num]++;
                // try
                // {
                //     int_occurrence[num]++;
                //     Console.WriteLine(int_occurrence[num]);
                // }
                // catch (Exception)
                // {
                //     // Console.WriteLine(hola);
                //     continue;
                // }
            }

            // for (int i = 0; i < int_occurrence.Length; i++)
            // {
            //     if (int_occurrence[i] > max)
            //     {
            //         max = int_occurrence[i];
            //         max_index = i;
            //     }
            // }

            // return char_str[max_index];

            return 'a';
        }
    }
}
