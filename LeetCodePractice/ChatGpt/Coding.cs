using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Xml.Linq;

namespace LeetCodePractice.ChatGpt
{
    public class Coding
    {

        #region reverse a number
        //Problem:
        //Write a program to reverse a number

        //Input:
        //1234

        //Output:
        //4321

        public void ReverseNumber(int number)
        {
            int reversed = 0;

            while (number > 0)
            {
                int digit = number % 10;       // get last digit
                reversed = reversed * 10 + digit;
                number = number / 10;          // remove last digit
            }

            Console.WriteLine(reversed);
        }

        #endregion

        #region Check Palindrome Number

        //Input:
        //121

        //Output:
        //Palindrome

        public void palindrome(int number)
        {

            int reverse = 0;

            while (number > 0)
            {

                int digit = number % 10;
                reverse = reverse * 10 + digit;
                number = number / 10;

            }

            if (number == reverse)
            {
                Console.WriteLine($"{number} is palindrome");
            }
            else
            {
                Console.WriteLine($"{number} is not palindrome");
            }
        }

        #endregion

        #region Count Number of Digits

        //Input:
        //45678

        //Output:
        //5

        public void count(int count)

        {
            int digit = 0;

            int Countnumber = 0;

            while (count > 0)
            {
                digit = count % 10;
                int reverse = digit * 10 + digit;
                count = count / 10;
                Countnumber++;
            }

            Console.WriteLine($"Count of the Integer is : {Countnumber}");
        }
        #endregion

        #region  Sum of Digits

        //Question 4: Sum of Digits

        //Input:
        //1234

        //Output:
        //10

        public void sum(int sum)
        {
            int sumofdigit = 0;
            int digit = 0;
            int reverse = 0;

            while (sum > 0)
            {
                digit = sum % 10;
                reverse = reverse + digit;
                sum = sum / 10;
            }

            Console.WriteLine($"sum of the digit is {reverse}");
        }

        #endregion

        #region ODD or Even
        //Question 5: Check Even or Odd

        //Input: 7
        //Output: Odd

        public void check(int EorO)
        {
            if (EorO % 2 == 0)

            {
                Console.WriteLine($"{EorO} is Even");

            }
            else
            {
                Console.WriteLine($"{EorO} is Odd");
            }
        }
        #endregion

        #region Largest Element

        //Question 6: Find Largest Element in an Array

        //Input:
        //[2, 5, 1, 9, 3]

        //Output:
        //9

        public void Large(int[] Large)
        {

            int max = Large[0];   // start with first element

            for (int i = 0; i < Large.Length; i++)
            {
                if (Large[i] > max)
                {
                    max = Large[i];
                }

            }

            Console.WriteLine($"{max} is Maximum");

        }

        #endregion

        #region Second Largest Element

        //Question 7: Find Second Largest Element

        //Input:
        //[10, 5, 20, 8]

        //Output:
        //10

        public void SecondLargest(int[] Large)
        {
            int max = 0;
            int Secondmax = 0;

            for (int i = 0; i < Large.Length; i++)
            {
                if (Large[i] > max)
                {
                    max = Large[i];
                }
            }

            for (int i = 0; i < Large.Length; i++)
            {
                if (Large[i] != max)
                {


                    if (Large[i] > Secondmax)
                    {
                        Secondmax = Large[i];
                    }
                }
            }

            Console.WriteLine($"{Secondmax} is an SecondMax");


        }
        public void FindSecondLargest(int[] numbers)
        {
            if (numbers.Length < 2)
            {
                Console.WriteLine("Second largest element does not exist");
                return;
            }

            int max = int.MinValue;
            int secondMax = int.MinValue;

            foreach (int num in numbers)
            {
                if (num > max)
                {
                    secondMax = max;
                    max = num;
                }
                else if (num > secondMax && num != max)
                {
                    secondMax = num;
                }
            }

            if (secondMax == int.MinValue)
            {
                Console.WriteLine("Second largest element does not exist");
            }
            else
            {
                Console.WriteLine($"{secondMax} is the second largest element");
            }
        }


        #endregion

        #region Count the Frequency

        //Problem

        //Count the frequency of each element in the array.

        //Input:
        //[1, 2, 2, 3, 1, 1]

        public void Frequency(int[] frequency)
        {


            Dictionary<int, int> freq = new Dictionary<int, int>();

            foreach (int count in frequency)
            {

                if (freq.ContainsKey(count))
                {
                    freq[count] = freq[count] + 1;
                }
                else
                {
                    freq[count] = 1;
                }
            }

            foreach (var item in freq)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }


        }

        #endregion

        #region Find the First Repeating Element

        //Input:
        //[1, 2, 3, 2, 1]

        //Output:
        //2

        public void FirstRepeating(int[] arr)
        {
            HashSet<int> seen = new HashSet<int>();

            foreach (int num in arr)
            {
                if (seen.Contains(num))
                {
                    Console.WriteLine($"First repeating element is: {num}");
                    return;
                }
                else
                {
                    seen.Add(num);
                }
            }

            Console.WriteLine("No repeating element found");
        }


        #endregion

        #region TWO SUM
        //Given an array of integers and a target value, return the indices of the two numbers such that they add up to the target.

        //nums = [2, 7, 11, 15]
        //target = 9
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int needed = target - nums[i];

                if (map.ContainsKey(needed))
                {
                    return new int[] { map[needed], i };
                }

                if (!map.ContainsKey(nums[i])) // avoid overwrite confusion
                {
                    map.Add(nums[i], i);
                }
            }

            return Array.Empty<int>();
        }


        public void TwoPointer(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;


            while (left < right)
            {
                int sum = nums[left] + nums[right];

                if (sum == target)
                {
                    Console.WriteLine($"Pair found: {nums[left]} and {nums[right]}");
                    return;
                }

                else if (sum < target)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

        }
        #endregion

        #region  First Non-Repeating Character

        //First Non-Repeating Character

        //Input:

        //"swiss"

        //Output:

        //'w'

        public void nonrepeating(string name)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();

            foreach (char k in name)
            {

                if (map.ContainsKey(k))
                {
                    map[k]++;
                }
                else
                {
                    map[k] = 1;
                }
            }

            foreach (var l in map)

                if (l.Value == 1)
                {
                    Console.WriteLine($"{l.Key} -> {l.Value}");
                    return;

                }


        }

        #endregion

        #region Anagrams
        //Check if two strings are ANAGRAMS(using HashMap)

        //Example:

        //"listen", "silent" → true

        public void anangram(string anagaram1, string anagaram2)
        {
            int count = 0;

            Dictionary<char, int> maps = new Dictionary<char, int>();

            foreach (char k in anagaram1)
            {
                if (maps.ContainsKey(k))
                {
                    maps[k]++;
                }
                else
                {
                    maps[k] = 1;
                }
            }

            foreach (char k in anagaram2)
            {
                if (!maps.ContainsKey(k))
                {
                    Console.WriteLine("Not an Anagram");
                }

                maps[k]--;

                if (maps[k] < 0)
                {
                    Console.WriteLine("Not an Anagram");

                }
            }

            Console.WriteLine("This is an Anagram");


        }


        #endregion

        #region Remove the Duplicate

        //Remove Duplicate Characters from a String

        //(Very common interview question)

        //Problem

        //Given a string, remove duplicate characters while preserving order.

        //Input
        //"programming"

        //Output
        //"progamin"


        public void removeduplicate(string duplicate)
        {

            HashSet<char> removed = new HashSet<char>();

            StringBuilder stringBuilder = new StringBuilder();

            foreach (char d in duplicate)
            {
                if (removed.Contains(d))
                {
                    continue;
                }
                else
                {
                    removed.Add(d);
                    stringBuilder.Append(d);
                }

            }

            Console.WriteLine(stringBuilder.ToString());


        }

        #endregion

        #region Longest Substring 

        //Longest Substring Without Repeating Characters

        //(Very famous – asked in almost every product company)

        //Example:

        //"abcabcbb" → 3  ("abc")
        public int LongestSubstringWithoutRepeating(string s)
        {
            HashSet<char> set = new HashSet<char>();

            int left = 0;
            int maxLength = 0;

            for (int right = 0; right < s.Length; right++)
            {
                // If duplicate found, shrink window from left
                while (set.Contains(s[right]))
                {
                    set.Remove(s[left]);
                    left++;
                }

                // Add current character
                set.Add(s[right]);

                // Update max length
                maxLength = Math.Max(maxLength, right - left + 1);
            }

            return maxLength;
        }

        #endregion

        #region Longest Substring with At Most 2 Distinct Characters

        //Example
        //Input:  "eceba"
        //Output: 3
        //Substring: "ece

        //Sliding Window + HashMap(Dictionary)

        //Why?

        //We must track count of characters(not just presence)

        //Window must have ≤ 2 distinct characters

        public void LongestSubstring2DistinctCharacters(string s)
        {

            Dictionary<char, int> map = new Dictionary<char, int>();

            int left = 0;
            int maxLength = 0;

            for (int right = 0; right < s.Length; right++)
            {
                char current = s[right];

                if (map.ContainsKey(current))
                {
                    map[current]++;
                }

                else
                {
                    map[current] = 1;
                }


                while (map.Count > 2)
                {
                    char remove = s[left];

                    map[remove]--;


                    if (map[remove] == 0)
                        map.Remove(remove);

                    left++;
                }

                maxLength = Math.Max(maxLength, right - left + 1);
            }

            Console.WriteLine($"And the Substrinng length is {maxLength}");

        }

        #endregion

        #region missing number in an array

        //Problem:
        //Find the missing number in an array containing numbers from 1 to n.

        //[1, 2, 4, 5]


        //public void missingnumber(int [] array)
        //{

        //    int length = array.Length;

        //    int missingnumber = 0;

        //    Dictionary<int,int> map = new Dictionary<int,int>();

        //    for (int i = 0; i < length; i++)
        //    {
        //        if(map.ContainsKey(array[i]))
        //        {
        //            map[array[i]]++;
        //        }
        //        else
        //        {
        //            map[array[i]] = 1;
        //        }

        //    }

        //    for(int i = 1;i < length; i++)
        //    {
        //        if (!map.ContainsKey(i))
        //        {
        //            missingnumber = i;
        //        }

        //    }

        //    Console.WriteLine(missingnumber);


        //}

        public void MissingNumber(int[] arr)
        {
            int n = arr.Length + 1;   // because one number is missing
            int expectedSum = n * (n + 1) / 2;

            int actualSum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                actualSum += arr[i];
            }

            int missingNumber = expectedSum - actualSum;
            Console.WriteLine(missingNumber);
        }

        #endregion

        #region Reverse each word in a sentence.

        //Input:

        //"Hello World"

        //Output:

        //"olleH dlroW"

        public void ReverseWord(string s)
        {
            string[] array = s.Split(" ");

            StringBuilder SB = new StringBuilder();

            foreach (string word in array)
            {
                for (int i = word.Length-1; i >= 0; i--)
                {
                    
                     SB.Append(word[i]);

                }

               SB.Append(" ");

            }

            Console.WriteLine(SB.ToString().TrimEnd());
        }

        #endregion

        #region Move all 0s to the end 

        //Problem:
        //Move all 0s to the end of the array while maintaining the order of non-zero elements.

        //Input:

        //[0, 1, 0, 3, 12]


        //Output:

        //[1, 3, 12, 0, 0]


        public void moveall(int[] arr)
        {

            int temp = 0;
            int j = 0;

            for (int i = 0;i < arr.Length; i++)
            {
                if(arr[i] != 0)
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;

                    j++;
                }
            }

            Console.WriteLine(string.Join(", ", arr));

        }

        #endregion


    }
}
