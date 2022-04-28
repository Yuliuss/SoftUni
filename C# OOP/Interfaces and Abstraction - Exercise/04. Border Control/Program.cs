﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<IIdentifiable> identifiables = new List<IIdentifiable>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "End")
                {
                    break;
                }
                string[] parts = line.Split();

                if (parts.Length == 3)
                {
                    string name = parts[0];
                    int age = int.Parse(parts[1]);
                    string id = parts[2];

                    identifiables.Add(new Citizen(name, age, id));
                }
                else
                {
                    string model = parts[0];
                    string id = parts[1];

                    identifiables.Add(new Robot(id, model));
                }
            }
            string filterId = Console.ReadLine();
            List<IIdentifiable> filtered = identifiables.Where(i => i.Id.EndsWith(filterId)).ToList();

            foreach (var identifialbe in filtered)
            {
                Console.WriteLine(identifialbe.Id);
            }
        }
    }
}
