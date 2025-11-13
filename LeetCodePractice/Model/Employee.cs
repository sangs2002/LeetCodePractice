namespace LeetCodePractice.Model
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
}
