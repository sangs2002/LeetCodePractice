using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodePractice.Linq
{
    public class LinqQueries
    {
        public class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Department { get; set; }
            public double Salary { get; set; }
            public DateTime JoiningDate { get; set; }
            public List<string> Skills { get; set; }
        }

        public static void Run()
        {
            var employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "Arun", Department = "IT", Salary = 60000, JoiningDate = new DateTime(2021, 5, 1), Skills = new List<string> { "C#", "SQL" } },
                new Employee { Id = 2, Name = "Bala", Department = "HR", Salary = 40000, JoiningDate = new DateTime(2023, 1, 12), Skills = new List<string> { "Communication" } },
                new Employee { Id = 3, Name = "Chitra", Department = "IT", Salary = 75000, JoiningDate = new DateTime(2022, 7, 10), Skills = new List<string> { "C#", "Angular" } },
                new Employee { Id = 4, Name = "Deepa", Department = "Finance", Salary = 85000, JoiningDate = new DateTime(2020, 3, 5), Skills = new List<string> { "Excel", "Accounting" } },
                new Employee { Id = 5, Name = "Eshwar", Department = "IT", Salary = 50000, JoiningDate = new DateTime(2024, 2, 20), Skills = new List<string> { "C#", "React", "SQL" } },
            };

            // Example LINQ query (for testing)
            var highPaid = employees.Where(e => e.Salary > 60000).ToList();

            foreach (var emp in highPaid)
            {
                Console.WriteLine($"{emp.Name} - {emp.Department} - {emp.Salary}");
            }
        }
    }
}
