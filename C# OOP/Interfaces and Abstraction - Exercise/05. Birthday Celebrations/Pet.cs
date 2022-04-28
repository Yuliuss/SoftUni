using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo
{
    public class Pet : IPet
    {
        public Pet(string name, string birthday)
        {
            Name = name;
            Birthdate = birthday;
        }
        public string Name { get; private set; }

        public string Birthdate { get; private set; }
    }
}
