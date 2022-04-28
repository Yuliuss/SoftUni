using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Reverse_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<SomeClassBasic> listOfStringsBasic = new List<SomeClassBasic>();
            List<SomeClassAdvanced> listOFStringsAdvanced = new List<SomeClassAdvanced>();
            string input = null;

            while ((input = Console.ReadLine()) != "end")
            {
               
                var info = new SomeClassBasic();
                info.normalString = input;
                var reversedStringArr = input.ToArray().Reverse();
                info.reversedString = string.Join("", reversedStringArr);
                listOfStringsBasic.Add(info);

               
                var neshtoSi = new SomeClassAdvanced(input);
                listOFStringsAdvanced.Add(neshtoSi);
            }

            
            foreach (var item in listOFStringsAdvanced)
            {
                Console.WriteLine($"{item.normalString} = {item.reversedString}");
            }
        }
    }
}
