using System;
using System.Linq;
using System.Collections.Generic;

namespace LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> quantityByMaterialsLegendary = new Dictionary<string, int>()
            {
                { "shards",0},
                { "fragments",0},
                { "motes",0}
            };

            SortedDictionary<string, int> quantityByMaterialsJunk = new SortedDictionary<string, int>();

            string legendaryItem = string.Empty;
            string winningItem = String.Empty;

            bool isRunning = true;

            while (isRunning)
            {
                string[] input = Console.ReadLine().ToLower()
                    .Split();

                for (int i = 0; i < input.Length; i+=2)
                {
                    int quantity = int.Parse(input[i]);
                    string item = input[i + 1];

                    if (quantityByMaterialsLegendary.ContainsKey(item))
                    {
                       
                        quantityByMaterialsLegendary[item] += quantity;

                        if (quantityByMaterialsLegendary[item] >= 250)
                        {
                           
                            quantityByMaterialsLegendary[item] -= 250;
                            winningItem = item;
                            isRunning = false;
                            break;
                        }
                    }

                    else
                    {
                        if (quantityByMaterialsJunk.ContainsKey(item))
                        {
                            quantityByMaterialsJunk[item] += quantity;
                        }
                        else
                        {
                            quantityByMaterialsJunk.Add(item,quantity);
                        }
                    }

                }

               
         
            }

            if (winningItem == "shards")
            {
                legendaryItem = "Shadowmourne";
            }

            else if (winningItem == "fragments")
            {
                legendaryItem = "Valanyr";
            }

            else if (winningItem == "motes")
            {
                legendaryItem = "Dragonwrath";
            }
           
            Console.WriteLine($"{legendaryItem} obtained!");

            Dictionary<string, int> sortedQuantityByMaterialsLegenndary = quantityByMaterialsLegendary
                .OrderByDescending(i => i.Value)
                .ThenBy(i => i.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var kpv in sortedQuantityByMaterialsLegenndary)
            {
                Console.WriteLine($"{kpv.Key}: {kpv.Value}");
            }



            foreach (var kpv in quantityByMaterialsJunk)
            {
                Console.WriteLine($"{kpv.Key}: {kpv.Value}");
            }
        }
    }
}
