using System;
using System.Collections.Generic;

namespace TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int carPassOnGreen = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            Queue<string> cars = new Queue<string>();
            int countPassed = 0;

            while (command != "end")
            {
                if (command == "green")
                {
                    for (int i = 0; i < carPassOnGreen; i++)
                    {
                        if (cars.Count > 0)
                        {
                            Console.WriteLine($"{cars.Dequeue()} passed!");
                            countPassed++;
                        }
                    }
                }
                else 
                {
                    cars.Enqueue(command);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"{countPassed} cars passed the crossroads.");
        }
    }
}
