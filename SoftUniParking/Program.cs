using System;
using System.Linq;
using System.Collections.Generic;

namespace SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> carRegistrar = new Dictionary<string, string>();

            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string[] singleRegistration = Console.ReadLine()
                    .Split();

                string registerUnregister = singleRegistration[0];
                string name = singleRegistration[1];
                

                switch (registerUnregister)
                {
                    case "register":
                        string carPlate = singleRegistration[2];
                        if (carRegistrar.ContainsKey(name))
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {carPlate}");
                        }

                        else
                        {
                            carRegistrar.Add(name,carPlate);
                            Console.WriteLine($"{name} registered {carPlate} successfully");
                        }
                        break;

                    case "unregister":
                        if (carRegistrar.ContainsKey(name))
                        {
                            carRegistrar.Remove(name);
                            Console.WriteLine($"{name} unregistered successfully");
                        }

                        else
                        {
                            Console.WriteLine($"ERROR: user {name} not found");
                        }
                        break;

                    default:
                        break;
                }

            }

            foreach (var item in carRegistrar)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
