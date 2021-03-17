using System;
using System.Linq;
using System.Collections.Generic;

namespace StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            //You will receive n pair of rows.First you will receive the student's name, 
            //after that you will receive his grade. Check if the student already exists and if not, add him. 
            //Keep track of all grades for each student.
            //When you finish reading the data, keep the students with average grade higher than or equal to 4.50.
            //Order the filtered students by average grade in descending order.
            
            Dictionary<string, List<double>> studentBook = new Dictionary<string, List<double>>();

            int rows = int.Parse(Console.ReadLine());

            for (int i = 0; i < rows; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (studentBook.ContainsKey(name))
                {
                    studentBook[name].Add(grade);
                }
                else
                {
                    studentBook.Add(name, new List<double>() {grade});
                }

            }

            Dictionary<string, List<double>> sortedBook = studentBook
                .Where(x => x.Value.Average() >= 4.5)
                .OrderByDescending(x => x.Value.Average())
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in sortedBook)
            {
                Console.WriteLine($"{item.Key} -> {item.Value.Average():F2}");
            }

        }
    }
}
