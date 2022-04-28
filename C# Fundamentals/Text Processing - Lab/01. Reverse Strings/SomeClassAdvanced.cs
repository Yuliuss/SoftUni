using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._Reverse_Strings
{
     class SomeClassAdvanced
    {
        public SomeClassAdvanced(string input)
        {
            this.normalString = input;
        }
        public string normalString { get; set; }

        public string reversedString => string.Join("", this.normalString.ToArray().Reverse());
    }
}
