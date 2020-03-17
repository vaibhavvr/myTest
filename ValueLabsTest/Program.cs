using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueLabsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program 1 inputs and call
            //string input1 = "Hello my name is ABC Hello my name is XYZ";
            //getNumberOfWords(input1);

            // Program 2 inputs and call
            //int[] input2 = { 1, 1, 3, 3, 4, 5, 5, 7, 7, 8, 8 };
            //int[] input2 = { 1, 2, 3,4,5, 6, 23, 24, 25, 26, 88 };            
            //LongestSequence(input2, input2.Length);
            //Console.ReadLine();

            ////Program3 inputs and call
            //string input3 = "webmd";
            //ReverseString(input3);

            ////Program4 inputs and call
            //int[] input4 = { 1, 1, 3, 3, 4, 5, 5, 7, 7, 8, 8 };
            //int[] input4 = { 1, 1, 3, 3, 4, 4, 5, 5, 7, 7, 8 };
            //GetLastOnceAppearedElement(input4);

            ////Program5 inputs and call
            //isSubstring("apple", "pleap"); 
            //isSubstring("apple", "ppale");

        }

        #region  Methods for Program 1
        public static void getNumberOfWords(string input)
        {           
            string[] strArr = input.Split(' ');            
            string[] dist = strArr.Distinct().ToArray();
            Hashtable hashtable = new Hashtable();          
            foreach(string inp in dist)
            {
                int occurence = CheckOccurences(input,inp);
                hashtable.Add(inp, occurence);
            }
            foreach (DictionaryEntry entry in hashtable)
            {
                Console.WriteLine("{0}: {1}", entry.Key, entry.Value);
            }
            Console.ReadLine();
        }     
        public static int CheckOccurences(string input, string checkString)
        {
            int count = 0;
            int a = 0;
            while ((a = input.IndexOf(checkString, a)) != -1)
            {
                a += checkString.Length;
                count++;
            }
            return count;
        }
        #endregion

        #region  Method for Program 2
        public static void LongestSequence(int[] a, int n)
        {
            
            Dictionary<int,
                       int> mp = new Dictionary<int,
                                                int>();
          
            int[] dp = new int[n];

            int maximum = -100000000;
           
            int index = -1;
            for (int i = 0; i < n; i++)
            {              
                if (mp.ContainsKey(a[i] - 1) == true)
                {                  
                    int lastIndex = mp[a[i] - 1] - 1;
                  
                    dp[i] = 1 + dp[lastIndex];
                }
                else
                    dp[i] = 1;
              
                mp[a[i]] = i + 1;
              
                if (maximum < dp[i])
                {
                    maximum = dp[i];
                    index = i;
                }
            }
            for (int curr = a[index] - maximum + 1;
                curr <= a[index]; curr++)
                Console.Write(curr + " ");
        }
        #endregion

        #region  Method for Program 3
        public static void ReverseString(string input)
        { 
            char[] charArr = input.ToCharArray();
            for(int i = input.Length-1; i>=0 ; i--)
            {
                Console.Write(charArr[i]);               
            }
            Console.ReadLine();
        }
        #endregion

        #region  Method for Program 4
        public static void GetLastOnceAppearedElement(int[] input)
        {
            int res = input[0];
            for(int i =1; i < input.Length; i++)
            {
                res = res ^ input[i];
            }
            Console.WriteLine(res);
            Console.ReadLine();
        }
        #endregion

        #region  Method for Program 5
        public static void isSubstring(string s1, string s2)
        {
            if (s1.Length == s2.Length && ((s1 + s1).IndexOf(s2)!= -1))
            {
                Console.WriteLine("s2 is rotation of s1");
            }
            else
            {
                Console.WriteLine("s2 is not rotation of s1");
            }
            Console.ReadLine();
        }
        #endregion
    }
}
