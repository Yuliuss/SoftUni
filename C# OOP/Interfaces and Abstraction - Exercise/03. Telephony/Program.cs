using System;

namespace Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();
            string[] urls = Console.ReadLine().Split();

            Smartphone smartPhone = new Smartphone();
            StationaryPhone stationary = new StationaryPhone();

            foreach (var number in numbers) 
            {
                try
                {
                    string result = number.Length == 10 ? smartPhone.Call(number) : stationary.Call(number);
                    Console.WriteLine(result);
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            foreach (var url in urls)
            {
                try
                {
                    string result = smartPhone.Browse(url);
                    Console.WriteLine(result);
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
