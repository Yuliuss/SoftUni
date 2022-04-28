using System;

namespace _08.Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            double totalSum = 0;

            int currentGrade = 1;

            int countOfRepeatedClasses = 0;

            bool isExcluded = false;

            while (currentGrade <= 12)
            {
                if (countOfRepeatedClasses == 2)
                {
                    Console.WriteLine($"{name} has been excluded at {currentGrade} grade");
                    isExcluded = true;
                    break;
                }
                double grade = double.Parse(Console.ReadLine());

                if (grade < 4)
                {
                    countOfRepeatedClasses++;

                    continue;
                }
                totalSum += grade;

                currentGrade++;
            }
            if (!isExcluded)
            {

                double averageGrade = totalSum / 12;
                Console.WriteLine($"{name} graduated. Average grade: {averageGrade:f2}");
            }
        }
    }
}
