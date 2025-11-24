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

        #region 3712. Sum of Elements With Frequency Divisible by K

        //Example 1:

        //Input: nums = [1, 2, 2, 3, 3, 3, 3, 4], k = 2

        //Output: 16

        //Explanation:

        //The number 1 appears once(odd frequency).
        //The number 2 appears twice(even frequency).
        //The number 3 appears four times(even frequency).
        //The number 4 appears once(odd frequency).
        //So, the total sum is 2 + 2 + 3 + 3 + 3 + 3 = 16.

        //Example 2:

        //Input: nums = [1, 2, 3, 4, 5], k = 2

        //Output: 0

        //Explanation:

        //There are no elements that appear an even number of times, so the total sum is 0.


        public void sumofelements(int[] nums, int K)
        {


            int count = 0;

            HashSet<int> h = new HashSet<int>(nums);

            int p = 0;

            foreach (int k in h)
            {
                int cnt = 0;
                foreach (int x in nums)
                {

                    if (x == k)
                    {
                        cnt++;
                    }
                }

                if (cnt % K == 0)
                {
                    p += k * cnt;


                }


            }

            Console.WriteLine(p);




        }


        #endregion

        #region 1636. Sort Array by Increasing Frequency

        //Example 1:

        //Input: nums = [1, 1, 2, 2, 2, 3]
        //Output: [3, 1, 1, 2, 2, 2]
        //Explanation: '3' has a frequency of 1, '1' has a frequency of 2, and '2' has a frequency of 3.
        //Example 2:

        //Input: nums = [2, 3, 1, 3, 2]
        //Output: [1, 3, 3, 2, 2]
        //Explanation: '2' and '3' both have a frequency of 2, so they are sorted in decreasing order.


        public void sortarray(int[] nums)
        {

            int[] numss = { 1, 1, 2, 2, 2, 3 };
            HashSet<int> h = new HashSet<int>(numss);

            foreach (int x in numss)
            {
                foreach (int y in h)
                {


                }



            }
        }

        #endregion

        #region 1323. Maximum 69 Number

        public void max69(int nums)
        {

            //Input: num = 9669
            //Output: 9969
            //Explanation:
            //            Changing the first digit results in 6669.
            //Changing the second digit results in 9969.
            //Changing the third digit results in 9699.
            //Changing the fourth digit results in 9666.
            //The maximum number is 9969.

            int num = 9669;

            char[] chars = num.ToString().ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                {
                    if (chars[i] == '6')
                    {
                        chars[i] = '9';

                        break;

                    }


                }


            }

            Console.WriteLine(int.Parse(new string(chars)));
        }


        #endregion


        #region 3162.Find the Number of Good Pairs I

        //Input: nums1 = [1, 3, 4], nums2 = [1, 3, 4], k = 1

        //Output: 5
 
        //Explanation:

        //The 5 good pairs are(0, 0), (1, 0), (1, 1), (2, 0), and(2, 2).

        public void goodpairs(int[] nums1,int[] nums3, int k)
        {


            int count = 0;


            foreach(int x in nums1)
            {

                foreach(int y in nums3)
                {
                    if(x % (y * k) ==0)
                    {
                        count++;
                    } 
                }
            }

            Console.WriteLine($"GoodPair 1 count is {count}");
        }
            

            #endregion





        }
    }
