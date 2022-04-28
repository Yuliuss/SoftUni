using System;

namespace _02.OldestFamilyMember
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Family family = new Family();

            int numberOfMembers = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfMembers; i++)
            {
                family.AddMember(Console.ReadLine().Split());
            }

            Person oldest = family.GetOledestMember();

            Console.WriteLine($"{oldest.Name} {oldest.Age}");
        }
    }
}
