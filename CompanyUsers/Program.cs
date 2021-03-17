using System;
using System.Linq;
using System.Collections.Generic;

namespace CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that keeps information about companies and their employees.
            //You will be receiving a company name and an employee's id, until you receive the command "End" command.
            //Add each employee to the given company. Keep in mind that a company cannot have two employees with the same id.
            //When you finish reading the data, order the companies by the name in ascending order. 

            SortedDictionary<string, List<string>> companyRegistrar = new SortedDictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                string[] line = input
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string nameCompany = line[0];
                string userID = line[1];

                if (companyRegistrar.ContainsKey(nameCompany))
                {
                    if (companyRegistrar[nameCompany].Contains(userID)==false)
                    {
                        companyRegistrar[nameCompany].Add(userID);
                    }
                   
                }

                else
                {
                    companyRegistrar.Add(nameCompany, new List<string>() { userID });
                }
                

                
                


            }

            foreach (var item in companyRegistrar)
            {
                Console.WriteLine($"{item.Key}");
                
                foreach (var user in item.Value)
                {
                    Console.WriteLine(string.Join(Environment.NewLine,$"-- {user}"));
                }
            
            }
        }
    }
}
