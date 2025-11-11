using System.Xml.Linq;

namespace LeetCodePractice.Linq
{
    public class ForReference
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

            // Q1.Get all employees whose salary is greater than 50,000.
            var highSalaryEmployees = employees
            .Where(e => e.Salary > 50000)
            .ToList();

            // Q2.Select only Name and Department from employee list.

             var empDetails = employees
            .Select(e => new { e.Name, e.Department })
            .ToList();

            // Q3.Sort employees by Salary descending.

             var sortedEmployees = employees
            .OrderByDescending(e => e.Salary)
            .ToList();

            //Q4. Find total salary of all employees.

            var totalSalary = employees.Sum(e => e.Salary);

            //Q5. Find number of employees in each department.

            var deptcount = employees.GroupBy(a=> a.Department).Select(g=> new {Department = g.Key, Count = g.Count()}).ToList();






        }






    }
}
