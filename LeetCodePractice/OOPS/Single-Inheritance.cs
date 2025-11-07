namespace LeetCodePractice.OOPS
{
    public class SingleInheritance
    {



        public class Loggers
        {

            public void Log(string message)
            {
                Console.WriteLine($"Log Entries:{message}");
            }
        }

        public class FileLogger : Loggers
        {

            public void File(string message)
            {
                Log(message);
                Console.WriteLine("Message for file upload successfully");

            }

        }
    }
}
