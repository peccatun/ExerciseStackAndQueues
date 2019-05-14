using System;
using System.Collections.Generic;

namespace TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> trafficCars = new Queue<string>();
            int count = int.Parse(Console.ReadLine());
            string command = string.Empty;
            int passedCars = 0;
            while ((command = Console.ReadLine()) != "end")
            {
                if (command == "green")
                {
                    for (int i = 0; i < count; i++)
                    {
                        if (trafficCars.Count == 0)
                        {
                            break;
                        }
                        Console.WriteLine(trafficCars.Dequeue() + " passed!");
                        passedCars++;
                    }
                }
                else
                {
                    trafficCars.Enqueue(command);

                }
            }
            Console.WriteLine(passedCars + " cars passed the crossroads.");
        }
    }
}
