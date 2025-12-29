namespace LeetCodePractice.Coding_Questions_for_Interview.Basic_Level.Basic_level
{
    public class variable_loops
    {

        #region Write a program to check if a number is even or odd.
        public void evenOrOdd(int EvenOrOdd)
        {

            if (EvenOrOdd % 2 == 0)
            {
                Console.WriteLine($"{EvenOrOdd} is Even Number");
            }
            else if (EvenOrOdd % 2 != 0)
            {
                Console.WriteLine($"{EvenOrOdd} is Odd Number");
            }

        }

        #endregion

        #region Find the largest of three numbers.

        public void largestthreenum(int k, int p, int c)
        {


            int largest = k;

            if (p > largest)
            {
                largest = p;

            }
            if (c > largest)
            {
                largest = c;
            }

            Console.WriteLine($"largest of three numbers is {largest}");
        }

        #endregion

        #region Print numbers from 1 to 100 using loops.

        public void print100(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"numbers from 1 to 100 using loops is {i}");
            }
        }

        #endregion

        #region Print the sum of the first N natural numbers.
        public void FirstNnum(int n)
        {
            int k = 0;

            for (int i = 1; i <= n; i++)
            {
                k = k + i;
            }

            Console.WriteLine($"sum of the first N natural numbers: {k}");
        }
        #endregion

        #region Reverse a number (without converting to string)
        public void ReverseAnumber(int n)
        {
            int k = 1234;

            int digit;
            int temp = 0;
            while (k > 0)
            {
                digit = k % 10;
                temp = (temp * 10) + digit;
                k = k / 10;
            }

            Console.WriteLine($"Reverse a number : {temp}");
        }

        #endregion

        #region Check if a number is prime.

        public void primenumber(int n)
        {

            int temp = 0;

            for (int i = 2; i < n / 2; i++)
            {

                if (n % i == 0)
                {

                    temp++;
                    break;

                }
            }

            if (temp == 0)
            {
                Console.WriteLine($"{n} is a prime Number");

            }
            else
            {
                Console.WriteLine($"{n} is not a prime Number");

            }
        }
        #endregion

        #region Print Fibonacci series up to N terms.

        public void fibonacci(int n)
        {
            int cur = 0;

            int pre1 = 1;

            int pre2 = 0;


            for (int i = 0; i < n; i++)
            {
                cur = pre1 + pre2;
                pre1 = pre2;
                pre2 = cur;


                Console.WriteLine($"Fibanocci nummbers are :{cur}");


            }


        }
        #endregion

        #region Count digits in a number.


        #endregion

        #region Check if a character is vowel or consonant.

        public void vowel(char n)
        {

            string j = "aeiou";

            if (j.Contains(n))
            {
                Console.WriteLine( $"{n} character is vowel.");
            }
            else
            {
                Console.WriteLine($"{n} is an Consonants");
            }
        }

        #endregion

    }
}
