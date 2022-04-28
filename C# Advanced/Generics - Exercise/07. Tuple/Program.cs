using System;

namespace CustomTuple
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] firstTupleData = Console.ReadLine().Split(" ");
            string fullname = $"{firstTupleData[0]} {firstTupleData[1]}";
            Tuple<string, string> firstTuple =
                new Tuple<string, string>(fullname, firstTupleData[2]);

            string[] secondTupleData = Console.ReadLine().Split(" ");
            Tuple<string, int> secondTuple =
                new Tuple<string, int>(secondTupleData[0], int.Parse(secondTupleData[1]));

            string[] thirdTupleData = Console.ReadLine().Split(" ");
            Tuple<int, double> thirdTuple =
                new Tuple<int, double>(int.Parse(thirdTupleData[0]), double.Parse(thirdTupleData[1]));

            Console.WriteLine(firstTuple);
            Console.WriteLine(secondTuple);
            Console.WriteLine(thirdTuple);
        }
    }
}
