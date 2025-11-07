namespace LeetCodePractice.LeetCode_Programs
{
    public class Easy
    {

        #region 3110.Score of a String
        public void ScoreofString(string s)
        {

            // Example 1:

            //Input: s = "hello"

            //Output: 13

            //Explanation:

            //The ASCII values of the characters in s are: 'h' = 104, 'e' = 101, 'l' = 108, 'o' = 111. So, the score of s would be |104 - 101| + |101 - 108| + |108 - 108| + |108 - 111| = 3 + 7 + 0 + 3 = 13.

            char[] arr = s.ToCharArray();

            int o = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                {
                    int k = Math.Abs(arr[i] - arr[i + 1]);


                    o = k + o;
                }

            }

            Console.WriteLine(o);
        }

        #endregion

        #region 58. Length of Last Word
        public void LastWord(string s)
        {
            {


                //Example 1:

                //Input: s = "Hello World"
                //Output: 5
                //Explanation: The last word is "World" with length 5.

                //Example 2:

                //Input: s = "   fly me   to   the moon  "
                //Output: 4
                //Explanation: The last word is "moon" with length 4.

                string[] word = s.Split(" ");

                int count = 0;

                int count2 = 0;

                for (int i = word.Length - 1; i > 0; i--)
                {
                    if (count > 1)
                    {
                        break;

                    }
                    for (int j = 0; j < word[i].Length; j++)
                    {

                        count2++;
                        count++;
                    }
                }

                Console.WriteLine(count2);

            }
        }




        #endregion

        #region 3498. Reverse Degree of a String

        //Input: s = "abc"

        //Output: 148

        //The reversed degree is 26 + 50 + 72 = 148.
        public void reverse(string s)
        {


            int p = 26;
            int o = 71;
            int k = 0;

            Dictionary<char, int> dic = new Dictionary<char, int>();
            List<int> list = new List<int>();

            for (char i = 'a'; i <= 'z'; i++)
            {
                int op = (int)i - o;

                dic[i] = op - k;

                k++;
                o++;

            }

            foreach (char c in s)
            {

                {
                    if (dic.ContainsKey(c))
                    {

                        list.Add(dic[c]);

                    }

                }
             }

                int T = 1;
                int G = 0;
            int z = 0;


                for (int i = 0; i < list.Count; i++)
                {
                    {

                        G = list[i] * T;

                    z = z + G;

                        T++;


                    }

                }
            Console.WriteLine(z);



        }
        #endregion

    }
}
