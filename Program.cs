using System;
using System.Collections.Generic;

namespace TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int countCarsAllowedToPass = int.Parse(Console.ReadLine());

            Queue<string> cars = new Queue<string>();

            int countPassed = 0;
            int count = 0;

            while (true)
            {                
                string line = Console.ReadLine();

                if (line == "end")
                {
                    Console.WriteLine($"{countPassed} cars passed the crossroads.");
                    //ToDo
                    break;
                }

                if (line == "green")
                {
                    if (count <= countCarsAllowedToPass)
                    {      
                        for (int i = 0; i < count; i++)
                        {
                            string car = cars.Dequeue();
                            Console.WriteLine($"{car} passed!");                            
                        }

                        countPassed += count;
                        count -= count;

                    }
                    else // if count > countCarsAllowedToPass
                    {
                        countPassed += countCarsAllowedToPass;

                        for (int i = 0; i < countCarsAllowedToPass; i++)
                        {
                            string car = cars.Dequeue();
                            Console.WriteLine($"{car} passed!");                            
                        }

                        count -= countCarsAllowedToPass;
                    }
                }
                else // line = some car to enter
                {
                    cars.Enqueue(line);
                    count++;
                }
            }
        }
    }
}
