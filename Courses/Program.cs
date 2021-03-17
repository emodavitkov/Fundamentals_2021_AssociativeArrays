using System;
using System.Linq;
using System.Collections.Generic;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] currCommand = command.Split(" : ");

                string courseName = currCommand[0];

                string studentName = currCommand[1];

                if (courses.ContainsKey(courseName))
                {
                    courses[courseName].Add(studentName);
                }
                else
                {
                    courses.Add(courseName, new List<string>() {studentName});
                }

                command = Console.ReadLine();
            }

            foreach (var course in courses.OrderByDescending(c => c.Value.Count))
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                foreach (var student in course.Value.OrderBy(n => n))
                {
                    //Console.WriteLine(string.Join(Environment.NewLine, $"-- {student}"));
                    Console.WriteLine($"-- {student}");
                }

                //Dictionary<string, List<string>> coursesCatalogue = new Dictionary<string, List<string>>();
                //Dictionary<string, int> coursesCatalogueByStudents = new Dictionary<string, int>();

                //while (true)
                //{
                //    string input = Console.ReadLine();

                //    if (input == "end")
                //    {
                //        break;
                //    }

                //    string[] course = input
                //        .Split(" : ", StringSplitOptions.RemoveEmptyEntries);

                //    string courseName = course[0];
                //    string courseStudent = course[1];

                //    if (coursesCatalogue.ContainsKey(courseName))
                //    {

                //        coursesCatalogue[courseName].Add(courseStudent);
                //        coursesCatalogueByStudents[courseName]++;
                //    }

                //    else
                //    {
                //        coursesCatalogue.Add(courseName, new List<string>());
                //        coursesCatalogue[courseName].Add(courseStudent);
                //        coursesCatalogueByStudents.Add(courseName,1);
                //    }


                //}

                //Dictionary<string, List<string>> sortedOrder = coursesCatalogue
                //   .OrderByDescending(x=> x.Value.Count)
                //   .ToDictionary(x => x.Key, x => x.Value);



                //foreach (var item in sortedOrder)
                //{
                //    string courseNameOutput = item.Key;
                //    int numberStudents = coursesCatalogueByStudents[courseNameOutput];
                //    //Console.WriteLine($"{item.Key}: {numberStudents} -- {string.Join(Environment.NewLine, item.Value)}");

                //    Console.WriteLine($"{item.Key}: {numberStudents}");
                //    //Console.WriteLine($"-- {string.Join(Environment.NewLine, string.Join(" ",item.Value))}");

                //    foreach (var student in item.Value.OrderBy(n => n))
                //    {
                //        Console.WriteLine($"-- {student}");
                //    }
                //}
            }


        }
    }
}
