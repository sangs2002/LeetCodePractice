namespace LeetCodePractice.OOPS
{
    public class Multi_Level_Inheritance
    {

        public class Company
        {
            public void ceo(string name)
            {
                Console.WriteLine($"CEO name is : {name}");
            }
        }

        public class Employee : Company
        {
            public void employee(string name)
            {
                Console.WriteLine($"Employee name is : {name}");
            }
        }

        public class Contactor : Employee
        {
            public void contactor(string name)
            {
                Console.WriteLine($"Contactor name is : {name}");
            }
        }
    }
}
