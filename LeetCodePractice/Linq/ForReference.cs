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
            public int DepartmentId { get; set; }

            public int project { get; set; }

        }

        public class Department
        {
            public int Id { get; set; }
            public string Name { get; set; }
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

            var Department = new List<Department>
            {
                new Department{ Id =1, Name ="IT"},
                  new Department{ Id =2, Name ="PRODUCT"},
                    new Department{ Id =3, Name ="HR"},
                      new Department{ Id =4, Name ="QA"}
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

            var deptcount = employees.GroupBy(a => a.Department).Select(g => new { Department = g.Key, Count = g.Count() }).ToList();

            //Q6.Get top 3 highest paid employees.

            var highest = employees.OrderByDescending(e => e.Salary).Take(3).ToList();

            //Q7. Get employees who joined after 2022 and work in “IT”.

            var emp = employees.Where(k => k.JoiningDate.Year > 2022 && k.Department == "IT").ToList();

            //Q8. Check if any employee earns more than 1 lakh.

            bool hasHighEarner = employees.Any(e => e.Salary > 100000);

            //Q9. Get employee with the maximum salary.

            var max = employees.Max(e => e.Salary);

            var min = employees.OrderBy(emp => emp.Salary).FirstOrDefault();

            //Q10. Find distinct department names.

            var distinct = employees.Select(global => global.Department).Distinct().ToList();

            //Q11. Join two collections: Employees and Departments

            var result = from e in employees
                         join d in Department
                         on e.DepartmentId equals d.Id
                         select new
                         {
                             e.Name,
                             DepartmentName = d.Name,
                             e.Salary
                         };

            //Q12. Get department with highest average salary.

            var dept = employees.GroupBy(k => k.Department)
                       .Select(g => new
                       {

                           Department = g.Key,
                           Avgsalary = g.Average(e => e.Salary),


                       }).OrderByDescending(T => T.Avgsalary).FirstOrDefault();


            //Q13. Get all employees who don’t have any assigned Salary.

            //var noProjectEmployees = employees
            //    .Where(e => !projects.Any(p => p.EmployeeId == e.Id))
            //    .ToList();


            //Q17.Filter employees whose names start with “A” and end with “n”

            var str = employees.Where(K => K.Name.StartsWith("K") && K.Name.EndsWith('P'));

            //Q18.Find employees with duplicate emails.

            var duplicate = employees.GroupBy (k => k.Department).Where(g => g.Count()> 1).ToList();


            //Q19.Pagination using LINQ (for API endpoints)

            var page = 2;
            var pagesize = 5;


            var pagenation = employees.Skip((page - 1) * pagesize).Take(pagesize).ToList();
















        }






    }
}
