using System;
using System.Linq;

namespace _3._Primary_Diagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int row = int.Parse(Console.ReadLine());
            int[,] matrix = new int[row, row];
            int firstDiagonal = 0;
            int SecondDiagonal = 0;

            for (int i = 0; i < row; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int k = 0; k < row; k++)
                {
                    matrix[i, k] = input[k];
                }
            }
            for (int i = 0; i < row; i++)
            {
                firstDiagonal += matrix[i, i];
            }
            for (int i = 0; i < row; i++)
            {
                SecondDiagonal += matrix[i, row - 1 - i];
            }
            int result = Math.Abs(firstDiagonal + SecondDiagonal);
            Console.WriteLine(result);
        }
    }
}
