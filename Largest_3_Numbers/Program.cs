using System;
using System.Linq;
using System.Collections.Generic;

namespace Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .OrderByDescending(n => n)
                .ToArray();

            int count = numbers.Length >= 3 ? 3 : numbers.Length;

            
            for (int i = 0; i < count; i++)
            {
                Console.Write($"{numbers[i]} ");
            }


        }
    }
}
