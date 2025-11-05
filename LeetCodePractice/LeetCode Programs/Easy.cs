namespace LeetCodePractice.LeetCode_Programs
{
    public class Easy
    {

         public void easy(string s)
        {
            // Example 1:

            //Input: s = "hello"

            //Output: 13

            //Explanation:

            //The ASCII values of the characters in s are: 'h' = 104, 'e' = 101, 'l' = 108, 'o' = 111. So, the score of s would be |104 - 101| + |101 - 108| + |108 - 108| + |108 - 111| = 3 + 7 + 0 + 3 = 13.

            char[] arr = s.ToCharArray();

            int o = 0;

            for (int i = 0; i < arr.Length-1; i++)
            {
                {
                    int k = Math.Abs(arr[i] - arr[i + 1]);


                    o = k + o;
                }

                Console.WriteLine(o);
            }


        }
    }
}
