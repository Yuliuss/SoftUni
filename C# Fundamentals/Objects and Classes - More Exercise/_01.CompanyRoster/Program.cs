using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CompanyRoster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Department> departments = new List<Department>();

            int numberOfEmployees = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfEmployees; i++)
            {
                string[] inputArr = Console.ReadLine().Split();

                if (!departments.Any(d => d.DepartmentName == inputArr[2]))
                {
                    departments.Add(new Department(inputArr[2]));
                }

                departments.Find(d => d.DepartmentName == inputArr[2]).AddNewEmployee(inputArr[0], decimal.Parse(inputArr[1]));

            }

            Department bestDepartment = departments.OrderByDescending(d => d.TotalSalaries / d.Employees.Count()).First();

            Console.WriteLine($"Highest Average Salary: {bestDepartment.DepartmentName}");

            foreach (var employee in bestDepartment.Employees.OrderByDescending(e => e.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:F2}");
            }
        }
    }
}
