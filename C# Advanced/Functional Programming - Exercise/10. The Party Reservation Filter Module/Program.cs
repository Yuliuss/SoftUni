using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._The_Party_Reservation_Filter_Module
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>(Console.ReadLine()
                   .Split(new[] { ' ' }
                   , StringSplitOptions.RemoveEmptyEntries));
            var filters = new List<string>();
            string input = Console.ReadLine();

            while (input != "Print")
            {
                var cmd = input.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                if (cmd[0] == "Add filter")
                {
                    filters.Add(cmd[1] + " " + cmd[2]);
                }
                else if (cmd[0] == "Remove filter")
                {
                    filters.Remove(cmd[1] + " " + cmd[2]);
                }
                input = Console.ReadLine();
            }

            foreach (var filter in filters)
            {
                var cmd = filter.Split(' ');
                if (cmd[0] == "Starts")
                {
                    names = names.Where(p => !p.StartsWith(cmd[2])).ToList();
                }
                else if (cmd[0] == "Ends")
                {
                    names = names.Where(p => !p.EndsWith(cmd[2])).ToList();
                }
                else if (cmd[0] == "Length")
                {
                    names = names.Where(p => p.Length != int.Parse(cmd[1])).ToList();
                }
                else if (cmd[0] == "Contains")
                {
                    names = names.Where(p => !p.Contains(cmd[1])).ToList();
                }
            }
            if (names.Any())
            {
                Console.WriteLine(string.Join(" ", names));
            }
        }
    }
}
