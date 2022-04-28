using System;
using System.Collections.Generic;

namespace _10._Crossroads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int greenLightSeconds = int.Parse(Console.ReadLine());
            int freeWindowSeconds = int.Parse(Console.ReadLine());
            int initialGreenLightSeconds = greenLightSeconds;
            int initialFreeWindowSeconds = freeWindowSeconds;
            var queueForAllCars = new Queue<string>();
            string input = Console.ReadLine();
            int countPassedCars = 0;
            while (true)
            {
                if (input == "END")
                {
                    break;
                }

                else if (input == "green" == false)
                {
                    string car = input;
                    queueForAllCars.Enqueue(car);
                    input = Console.ReadLine();
                }

                if (input == "green")
                {
                    greenLightSeconds = initialGreenLightSeconds;
                    freeWindowSeconds = initialFreeWindowSeconds;

                    while (greenLightSeconds > 0 && queueForAllCars.Count > 0)
                    {
                        string currentCar = queueForAllCars.Peek();
                        int currentCarLength = currentCar.Length;
                        if (greenLightSeconds >= currentCarLength)
                        {
                            greenLightSeconds = TheWholeCarPassedDurringGreenLight(greenLightSeconds, queueForAllCars, currentCarLength);
                            countPassedCars++;
                        }

                        else if (greenLightSeconds < currentCarLength)
                        {
                            var queueForCurrentCar = new Queue<char>();

                            for (int i = 0; i < currentCarLength; i++)
                            {
                                queueForCurrentCar.Enqueue(currentCar[i]);
                            }

                            greenLightSeconds = SomeCarPartsPassedDuringGreenLight(greenLightSeconds, queueForCurrentCar);

                            if (freeWindowSeconds >= queueForCurrentCar.Count)
                            {
                                freeWindowSeconds = ТheRestPartAndTheWholeCarPassedDuringFreeWindow(queueForAllCars, queueForCurrentCar);
                                countPassedCars++;
                            }

                            else if (freeWindowSeconds < queueForCurrentCar.Count)
                            {
                                WhatHappendIfThereIsACrash(freeWindowSeconds, currentCar, queueForCurrentCar);
                                return;
                            }
                        }
                    }

                    input = Console.ReadLine();
                }
            }

            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{countPassedCars} total cars passed the crossroads.");
        }



        private static int TheWholeCarPassedDurringGreenLight(int greenLightSeconds, Queue<string> queue, int currentCarLength)
        {
            queue.Dequeue();
            greenLightSeconds -= currentCarLength;
            return greenLightSeconds;
        }

        private static int SomeCarPartsPassedDuringGreenLight(int greenLightSeconds, Queue<char> queueForCurrentCar)
        {
            for (int i = 0; i < greenLightSeconds; i++)
            {
                queueForCurrentCar.Dequeue();
            }

            greenLightSeconds = 0;
            return greenLightSeconds;
        }

        private static int ТheRestPartAndTheWholeCarPassedDuringFreeWindow(Queue<string> queueForAllCars, Queue<char> queueForCurrentCar)
        {
            int freeWindowSeconds;
            for (int i = 0; i < queueForCurrentCar.Count; i++)
            {
                queueForCurrentCar.Dequeue();
            }

            freeWindowSeconds = 0;
            queueForAllCars.Dequeue();
            return freeWindowSeconds;
        }

        private static void WhatHappendIfThereIsACrash(int freeWindowSeconds, string currentCar, Queue<char> queueForCurrentCar)
        {
            char crashSymbol = currentCar[0];
            for (int i = 0; i <= freeWindowSeconds; i++)
            {
                if (queueForCurrentCar.TryPeek(out char currenSymbol))
                {
                    crashSymbol = queueForCurrentCar.Dequeue();
                }
            }

            Console.WriteLine($"A crash happened!");
            Console.WriteLine($"{currentCar} was hit at {crashSymbol}.");
            return;
        }
    }
}
