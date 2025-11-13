using static LeetCodePractice.Linq.ForReference;

namespace LeetCodePractice.Linq
{
    public class LinqQueries
    {
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


            //✅ Question 1: Filtering

            //Get all employees who belong to the IT department and have salary greater than 55,000.

            //Expected output:
            //Arun, Chitra

            var filtering = employees.Where(g => g.Department == "IT" && g.Salary > 55000).ToList();

            foreach (var emp in filtering)
            {
                Console.WriteLine($"{emp.Name}");
            }


            //✅ Question 2: Sorting

            //Sort employees by salary descending, then by name ascending.

            //Expected output order:
            //Deepa → Chitra → Arun → Eshwar → Bala

            var sorting = employees.OrderBy(e => e.Name).OrderByDescending(highPaid => highPaid.Salary).ToList();

            foreach (var emp in sorting)
            {
                Console.WriteLine($"Soring order is : {emp.Name}");
            }


            //✅ Question 3: Projection

            //Select only employee names and their departments.

            var projection = employees.Select(g=>new
            {
                name = g.Name,
                Department = g.Department,
            }).ToList();

            foreach (var emp in projection)
            {
                Console.WriteLine($"Projection is : {emp}");
            }


        }
    }
}
