using System;
using System.Linq;
using System.Collections.Generic;

namespace CountCharsInString
{
    class Program
    {
        static void Main(string[] args)
        {

            //Write a program that counts all characters in a string except for space(' ').
            //Print all the occurrences in the following format:
            //{ char} -> { occurrences}

            Dictionary<char, int> chars = new Dictionary<char, int>();

            string input = Console.ReadLine().Replace(" ", "");

            foreach (var letter in input)
            {

                //if Replace is not used use below approach: 
                //if (letter == ' ')
                //{
                //    continue;
                //}

                if (chars.ContainsKey(letter))
                {
                    chars[letter]++;
                }
                else
                {
                    chars.Add(letter,1);
                }
            }

            foreach (var item in chars)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
