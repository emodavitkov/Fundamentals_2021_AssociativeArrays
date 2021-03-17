using System;
using System.Collections.Generic;
using System.Linq;

namespace Word_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(word => word.Length % 2 ==0)
                .ToList()
                .ForEach(word => Console.WriteLine(word));
            //first ToList and then ForEach; IEnumerable cannot be done with Foreach 
            
            
            //string[] words = Console.ReadLine()
            //    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            //approach 1
            //IEnumerable<string> filteredWords = words
            //    .Where(word => word.Length % 2 == 0);

            //approach 2
            //var filteredWords = words
            //    .Where(word => word.Length % 2 == 0);

            //approach 3
            //string[] filteredWords = words
            //    .Where(word => word.Length % 2 == 0)
            //    .ToArray();

            //approach 1 2 3 print
            //foreach (var word in filteredWords)
            //{
            //    Console.WriteLine(word);
            //}
        }
    }
}
