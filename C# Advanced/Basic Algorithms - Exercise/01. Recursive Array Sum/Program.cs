using System;
using System.Linq;

namespace _01._Recursive_Array_Sum
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            long sum = Sum(numbers, 0);
            Console.WriteLine(sum);
        }
        public static long Sum(int[] arr, int startIndex)
        {
            if (startIndex == arr.Length - 1)
            {

                return arr[startIndex];
            }
            return arr[startIndex] + Sum(arr, startIndex + 1);
        }
    }
}