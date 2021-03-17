using System;
using System.Linq;
using System.Collections.Generic;

namespace A_MinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> metals = new Dictionary<string, int>();

            

            while (true)
            {
                string input = Console.ReadLine();

                if (input=="stop")
                {
                    break;
                }

                int quantity = int.Parse(Console.ReadLine());
                if (metals.ContainsKey(input))
                {
                    metals[input]+=quantity;
                }

                else
                {
                    metals.Add(input, quantity);
                }
                

                
            }

            foreach (var item in metals)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
