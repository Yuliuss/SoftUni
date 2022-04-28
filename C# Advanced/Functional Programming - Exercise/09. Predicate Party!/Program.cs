using System;
using System.Linq;

namespace _09._Predicate_Party_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var peopleComing = Console.ReadLine().Split().ToList();

            string cmd;
            while ((cmd = Console.ReadLine()) != "Party!")
            {
                var a = cmd.Split().ToList();
                var predicate = Predicat(a[1], a[2]);
                switch (a[0])
                {
                    case "Remove":
                        peopleComing.RemoveAll(predicate);
                        break;
                    case "Double":
                        {
                            var match = peopleComing.FindAll(predicate);
                            if (match.Count > 0)
                            {
                                var index = peopleComing.FindIndex(predicate);
                                peopleComing.InsertRange(index, match);
                            }
                            break;
                        }
                }
            }
            if (peopleComing.Count != 0)
            {
                Console.WriteLine(string.Join(", ", peopleComing) + " are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }
        private static Predicate<string> Predicat(string cmdType, string arg)
        {
            switch (cmdType)
            {
                case "StartsWith":
                    return (name) => name.StartsWith(arg);
                case "EndsWith":
                    return (name) => name.EndsWith(arg);
                case "Length":
                    return (name) => name.Length == int.Parse(arg);
                default:
                    throw new ArgumentException("Invalid command type: " + cmdType);
            }
        }
    }
}
