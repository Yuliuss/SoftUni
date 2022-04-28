using System;

namespace _04.TrainTheTrainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int gradeCount = 0;
            double sumOfAllGrades = 0;

            while (input != "Finish")
            {
                double gradeSum = 0;
                for (int i = 0; i < n; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    gradeSum += grade;
                    gradeCount++;
                    sumOfAllGrades += grade;
                }

                double average = gradeSum / n;
                Console.WriteLine($"{input} - {average:f2}.");
                input = Console.ReadLine();
            }
            double averageOfAllGrades = sumOfAllGrades / gradeCount;
            Console.WriteLine($"Student's final assessment is {averageOfAllGrades:f2}.");
        }
    }
}
