using LeetCodePractice.Coding_Questions_for_Interview.Basic_Level.Basic_level;
using System.Diagnostics.Metrics;

namespace LeetCodePractice
{
    public class Codings
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Enter the Number:");
            int evenOrOdd = Convert.ToInt32(Console.ReadLine());
            variable_loops even = new variable_loops();
            even.evenOrOdd(evenOrOdd);

            int k = 25;
            int c = 30;
            int p = 34;
            even.largestthreenum(k, c, p);
            even.print100(100);
            int N = 10;
            even.FirstNnum(N);

            int reverse = 1234;
            even.ReverseAnumber(reverse);




        }
    }
}
