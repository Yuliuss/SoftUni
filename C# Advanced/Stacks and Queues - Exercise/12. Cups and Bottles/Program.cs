using System;
using System.Collections.Generic;
using System.Linq;

namespace _12._Cups_and_Bottles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cupsCapacity = new Queue<int>(Console.ReadLine()
                   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                   .Select(int.Parse));
            var bottlesFill = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));
            int wastedWater = 0;

            while (true)
            {
                int currBottle = bottlesFill.Pop();
                if (currBottle < cupsCapacity.Peek())
                {
                    int currCup = cupsCapacity.Dequeue();
                    currCup -= currBottle;
                    while (true)
                    {
                        int nowBottle = bottlesFill.Pop();
                        if (nowBottle < currCup)
                        {
                            currCup -= nowBottle;
                        }
                        else
                        {
                            wastedWater += nowBottle - currCup;
                            break;
                        }

                        if (bottlesFill.Count == 0)
                        {
                            Console.WriteLine($"Cups: {currCup + " " + string.Join(" ", cupsCapacity)}");
                            Console.WriteLine("Wasted litters of water: " + wastedWater);
                            return;
                        }
                    }
                }
                else if (currBottle >= cupsCapacity.Peek())
                {
                    wastedWater += currBottle - cupsCapacity.Peek();
                    cupsCapacity.Dequeue();
                }

                if (cupsCapacity.Count == 0)
                {
                    Console.WriteLine($"Bottles: {string.Join(" ", bottlesFill)}");
                    Console.WriteLine("Wasted litters of water: " + wastedWater);
                    return;
                }
                else if (bottlesFill.Count == 0)
                {
                    Console.WriteLine($"Cups: {string.Join(" ", cupsCapacity)}");
                    Console.WriteLine("Wasted litters of water: " + wastedWater);
                    return;
                }
            }
        }
    }
}
