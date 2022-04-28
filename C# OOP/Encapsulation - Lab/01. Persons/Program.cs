using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonsInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());
            var persons = new List<Person>();
            for (int i = 0; i < lines; i++)
            {
                var cmdArgs = Console.ReadLine().Split();
                var person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]));
                persons.Add(person);
            }

            persons.OrderBy(p => p.FirstName)
                   .ThenBy(p => p.Age)
                   .ToList()
                   .ForEach(p => Console.WriteLine(p.ToString()));

            //int n = int.Parse(Console.ReadLine());
            //List<Person> people = new List<Person>();

            //for (int i = 0; i < n; i++)
            //{
            //    var input = Console.ReadLine().Split();
            //    people.Add(new Person(input[0], input[1], int.Parse(input[2])));
            //}
            //people.OrderBy(p => p.FirstName).ThenBy(p => p.Age).ToList();

            //foreach (var person in people)
            //{
            //    Console.WriteLine(person);
            //}
        }
    }
}
