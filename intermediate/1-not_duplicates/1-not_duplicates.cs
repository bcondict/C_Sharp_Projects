using System;
using System.Linq;

namespace _1_not_duplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the array: ");
            string[] str = Console.ReadLine().Split(", ");

            int[] int_nums = Array.ConvertAll(str, s => int.Parse(s));
            Console.WriteLine("Array without diplicates: {0}", String.Join(", ", array_no_duplicates(int_nums)));
        }

        static int[] array_no_duplicates(int[] nums)
        {
            int num_len = nums.Length;
            int[] new_array = new int[]{};

            foreach (int num in nums)
            {
                if (!new_array.Contains(num))
                {
                    new_array = new_array.Append(num).ToArray();
                }
            }

            return new_array;
        }
    }
}
