namespace LeetCodePractice.OOPS
{
    public class Encapsulation
    {



        public class Encap
        {
            private string Email;

            public string Name { get; set; }


            public string Employee
            {
                get => Email;

                set
                {
                    if (value.Contains("@"))
                    {
                        Email = value;
                        Console.WriteLine($"Encapsulation Value is {Email}");
                    }
                    else
                    {

                        Console.WriteLine("Invaild Email");
                    }
                }
            }
        }
    }

}