using System;
using System.Linq;
using System.Collections.Generic;

namespace CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            SortedDictionary<double, int> numbers = new SortedDictionary<double, int>();

            double[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            foreach (var key in input)
            {

                if (numbers.ContainsKey(key))
                {
                    numbers[key]++;
                    
                }
                else
                {
                    numbers.Add(key, 1);
                }
            }

            foreach (var number in numbers)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }

            //var fruits = new SortedDictionary<string, double>();
            //fruits["banana"] = 2.20;
            //fruits["apple"] = 1.40;
            //fruits["kiwi"] = 3.20;

            //fruits.Add("kiwi1", 120);
            //if (fruits.ContainsKey("kiwi"))
            //{
            //    Console.WriteLine($"kiwi key exists");
            //}

            //fruits.Remove("kiwi");

            //foreach (var item in fruits)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
