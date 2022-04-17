using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Preparation_Interview
{
    public class Program
    {
        //Reverse the characters of a word
        public static string ReverseWord(string str)
        {
            string result = "";
            int n = str.Length - 1;
            for (int i = n; i >= 0; i--)
            {
                result += str[i].ToString();
            }
            return result;
        }

        //Reverse each word in sentence

        public static string ReverseEachWord(string str)
        {
            if (str.Length < 1) return string.Empty;
            string result = "";
            var arr = str.Trim().Split(" ");
            for (int i = 0; i < arr.Length; i++)
            {

                result += ReverseWord(arr[i]) + " ";

            }

            return result.Trim();
        }

        //Reverse word without spliting the string

        public static string ReverseEachWordWithoutSplitting(string str)
        {
            string res1 = string.Empty;
            string res = string.Empty;

            StringBuilder result = new StringBuilder();
            StringBuilder newsentence = new StringBuilder();

            Stack<char> CharStack = new Stack<char>();

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    CharStack.Push(str[i]);
                }

                else
                {
                    while (CharStack.Count > 0)
                    {
                        char c = CharStack.Pop();
                        result.Append(c.ToString());
                        newsentence = result;

                    }
                    res += newsentence.ToString() + " ";
                    result = new StringBuilder();
                }
            }
            while (CharStack.Count > 0)
            {
                char c = CharStack.Pop();
                result.Append(c.ToString());
                newsentence = result;

            }
            res1 = res + newsentence.ToString();

            return res1.Trim();
        }

        //Check if two words are anagram...

        public static bool CheckAngram(string input1, string input2)
        {
            if (input1.Length != input2.Length) return false;
            char[] CharArrInput1 = input1.ToLower().ToCharArray();
            char[] CharArrInput2 = input2.ToLower().ToCharArray();
            Array.Sort(CharArrInput1);
            Array.Sort(CharArrInput2);
            for (int i = 0; i < CharArrInput1.Length; i++)
            {
                if (CharArrInput1[i] != CharArrInput2[i])
                {
                    return false;
                }

            }
            return true;
        }

        //Check if a word is a palidrome...
        public static bool CheckPalidrome(string word)
        {
            if (string.IsNullOrEmpty(word)) return false;
            string newword = word.ToLower().Trim();
            int max = word.Length - 1;
            int min = 0;
            int lent = newword.Length;
            for (int i = 0; i < lent; i++)
            {
                if (newword[min] != newword[max])
                {
                    return false;
                }
                min++;
                max--;
            }
            return true;
        }

        //count the number of Palidrome words in a sentence

        public static int CountPalidrome(string sentence)
        {
            int count = 0;
            var arr = sentence.Split(" ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (CheckPalidrome(arr[i]))
                {
                    count++;
                }
            }
            return count;
        }

        //count the number of Palidrome words in a sentence without splitting the sentence
        public static int CountPalidromeWithoutSplitting(string sentence)
        {
            StringBuilder stringBuilder = new StringBuilder();

            int count1 = 0;
            int count2 = 0;
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] != ' ')
                {
                    stringBuilder.Append(sentence[i]);
                }
                else
                {
                    if (CheckPalidrome(stringBuilder.ToString()))
                    {
                        count1++;
                    }
                    stringBuilder = new StringBuilder();
                }
            }

            if (CheckPalidrome(stringBuilder.ToString()))
            {
                count2++;
            }
            return count1 + count2;

        }

        //Get the maximum occured character in a word
        public static char? MaxOccurrence(string word)
        {
            int maxOccuredValue = 0;
            char? maxOccurredChar = null;
            if (String.IsNullOrEmpty(word))
            {
                return null;
            }
            char[] arr = word.ToLower().Trim().ToCharArray();

            Dictionary<char, int> occurrenceDictionary = new Dictionary<char, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (!occurrenceDictionary.ContainsKey(arr[i]))
                {
                    occurrenceDictionary.Add(arr[i], 1);
                }
                else
                {
                    occurrenceDictionary[arr[i]]++;
                }
            }

            foreach (KeyValuePair<char, int> c in occurrenceDictionary)
            {
                if (c.Value > maxOccuredValue)
                {
                    maxOccuredValue = c.Value;
                    maxOccurredChar = c.Key;
                }
            }
            return maxOccurredChar;
        }

        //Arrange the elments of an int array such that odd and even numbers appear alternatively in an increasing order 

        public static int[] RearrangeArrayElts(int[] arr)
        {
            List<int> Oddlist = new List<int>();
            List<int> Evenlist = new List<int>();
            Array.Sort(arr);
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] % 2 == 0)
                    Evenlist.Add(arr[j]);
                else
                {
                    Oddlist.Add(arr[j]);
                }
            }

            int index = 0;
            int i = 0;
            int k = 0;
            int n = arr.Length;
            bool flag = false;

            if (arr[0] % 2 == 0)
                flag = true;

            while (index < n)
            {
                if (flag == true)
                {
                    arr[index] = Evenlist[i];
                    index++;
                    i++;
                    flag = !flag;
                }

                else
                {
                    arr[index] = Oddlist[k];
                    index++;
                    k++;
                    flag = !flag;
                }
            }
            return arr;
        }

        //check if a number is a prime number
        public static bool CheckPrimeNumber(int num)
        {
            if (num == 2) return true;
            if (num <= 1) return false;

            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                    return false;

            }
            return true;
        }

        //return a string of prime numbers
        public static string PrimeNumber_String(int[] num)
        {
            StringBuilder Result = new StringBuilder();
            for (int i = 0; i < num.Length; i++)
            {
                if (CheckPrimeNumber(num[i]))
                {
                    Result.Append(num[i] + ",");
                }
            }
            return Result.ToString().Trim().Remove(Result.Length - 1);
        }

        public static string Solution(string str)
        {
            string output = "";
            int count = 1;
            char prev = str[0];
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] == prev)
                {
                    count++;                 
                    prev = str[i];
                }
                else
                {
                    output += $"{count}{prev}";
                    prev = str[i];
                    count = 1;
                }
            }
            output += $"{count}{prev}";
            return output;
        }

        //Factorial Number
        public static int FactorialNumber(int num)
        {
            int factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

        //Left Rotation of an Array
        public static void RotateLeft(int[] arr)
        {
            int temp = arr[0];
            for (int i = 1; i < arr.Length - 1; i++)
            {
                arr[i - 1] = arr[i];
            }
            arr[(arr.Length - 1)] = temp;

            for (int i = 0; i < arr.Length; i++) Console.WriteLine(arr[i]);
        }

        //return a list of anagrams

        private static bool checkanagram(string str, string str1)
        {
            if (str.Length != str1.Length)
            {
                return false;
            }
            str = str.ToLower().Trim();
            str1 = str1.ToLower().Trim();

            char[] arr1 = str.ToCharArray();
            char[] arr2 = str1.ToCharArray();

            Array.Sort(arr1);
            Array.Sort(arr2);

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    return false;
                }
            }
            return true;
        }

        public static List<string> Anagrams(string word, List<string> words)
        {
            List<string> list = new List<string>();

            for (int i = 0; i < words.Count; i++)
            {
                if (checkanagram(word, words[i]))
                {
                    list.Add(words[i]);
                }
            }
            return list;
        }

        //Hankerrank

        public static int getMoneySpent(int[] keyboards, int[] drives, int b)
        {
            /*
             * Write your code here.

             */
            List<int> results = new List<int>();
            int sum = 0;
            for (int i = 0; i < keyboards.Length; i++)
            {
                for (int k = 0; k < drives.Length; k++)
                {
                    sum = keyboards[i] + drives[k];
                    if (sum < b) results.Add(sum);
                }
            }
            if (results.Count < 1) return -1;
            else
            {
                results.Sort();
                return results[results.Count - 1];
            }

        }

        //sockMerchant

        public static int sockMerchant(int n, List<int> ar)
        {
            Dictionary<int, int> con = new Dictionary<int, int>();
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                if (!con.ContainsKey(ar[i]))
                {
                    con.Add((ar[i]), 1);
                }
                else
                {
                    con[ar[i]]++;
                }
            }

            foreach (KeyValuePair<int, int> num in con)
            {
                if (num.Value >= 2)
                {
                    sum += (int)(num.Value / 2);
                }
            }
            return sum;
        }

        public static int[][] Pyramid(int n)
        {
            // your code here
            if (n == 0)
            {
                return new int[0][];
            }
            var list = new List<List<int>>();
            var list2 = new List<int>();
            // list.Add(list2);
            for (int i = 0; i < n; i++)
            {

                for (int j = i; j >= 0; j--)
                {
                    list2.Add(1);
                }
                list.Add(list2);
            }
            return list.Select(l => l.ToArray()).ToArray();

        }

        //Coderbyte ======>>> find Intersection
        public static string FindIntersection(string[] strArr)
        {

            // code goes here  
            var arr1 = strArr[0].Split(", ");
            var arr2 = strArr[1].Split(", ");
            var list = "";
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr2.Contains(arr1[i]))
                {
                    list += arr1[i] + ",";
                    //Console.WriteLine(arr1[i]);
                }
            }
            if (list.Length > 0)
            {
                return list.Remove(list.Length - 1, 1);
            }
            else
            {
                return "false";
            }

        }

       


        public static string charcount(string str)
        {
            //aabbbaccc
            //output ===> 2a3b1a3c
            int count = 1;
            var prev = str[0];

            var output = "";
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] == prev)
                {
                    count++;
                    prev = str[i];
                }
                else
                {
                    output += $"{count}{prev}";
                    count = 1;
                    prev = str[i];
                }
            }
            output += $"{count}{prev}";
            return output;
        }

        //Bracket Matcher



        public static string BracketMatcher(string str)
        {
            // code goes here  
            int open = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '(') open++;
                if (str[i] == ')')
                {
                    if (open > 0)
                    {
                        open--;
                    }
                    else
                    {
                        return "0";
                    }
                }
            }

            return open < 1 ? "1" : "0";
        }

        //Qouestion Marks

        public static string QuestionsMarks(string str)
        {
            // code goes here 
            int count = 0;
            var output = "false";
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = i + 1; j < str.Length; j++)
                {
                    int a = Convert.ToInt32(str[i]-'0');
                    int b = Convert.ToInt32(str[j] - '0');
                    if (a + b == 10)
                    {
                        output = "true";
                        count = 0;

                        var str1 = str.Substring(i, str.Length - j);
                        for (int k = 0; k < str1.Length; k++)
                        {
                            if (str1[k] == '?')
                            {
                                count++;
                            }
                        }
                        if (count >= 3)
                        {
                            return output;
                        }
                    }
                }
            }

            return output;
        }
        
        //Time Conversion
        public static string print24(String str)
        {
            // Get hours
            int h1 = (int)str[1] - '0';
            int h2 = (int)str[0] - '0';
            int hh = (h2 * 10 + h1 % 10);
            var output = "";
            // If time is in "AM"
            if (str[8] == 'A')
            {
                if (hh == 12)
                {
                    output += "00";
                    for (int i = 2; i <= 7; i++)
                        output += str[i];
                }
                else
                {
                    for (int i = 0; i <= 7; i++)
                        output +=  str[i];
                }
            }

            // If time is in "PM"
            else
            {
                if (hh == 12)
                {
                    output += 12;
                    for (int i = 2; i <= 7; i++)
                        output +=  str[i];
                }
                else
                {
                    hh = hh + 12;
                    output += hh;
                    for (int i = 2; i <= 7; i++)
                        output += str[i];
                }
            }
            return output;
        }

        //public static string angryProfessor(int k, List<int> a)
        //{
        //    int negativeCount = 0;
        //    int positiveCount = 0;
        //    var output = "";
        //    for (int i = 0; i < a.Count; i++)
        //    {
        //        if (a[i] <= 0) negativeCount++;
        //        if (a[i] > 0) positiveCount++;
        //    }
        //    if (negativeCount >= k) output = "YES";
        //    else if (positiveCount < k) output ="NO";

        //    return output;
        //}

        //public static int toys(List<int> w)
        //{
        //    int min = w.Min() + 4;
        //    //int n = w.Count;
        //    int count = 1;
        //    var resultToAdd = new List<int>();
        //    for (int i = 0; i < w.Count; i++)
        //    {
        //        if (w[i] <= min && w[i] >= min-4 )
        //        {
        //            //min = w[i];
        //            // w.Remove(w[i]);
        //            resultToAdd.Add(w[i]);
                    
        //        }
        //        else
        //        {
        //            resultToAdd = new List<int>();
        //            resultToAdd.Add(w[i]);
        //            count++;
        //            min = w[i] + 4;
        //        }
        //    }

        //    return count;

        //}

        static void Main(string[] args)
            {
            // string[] res = { "ahffaksfajeeubsne", "jefaa" };
            //Console.WriteLine(CoderByte.MinWindowSubstring(res));
            //int res = 2345;
            Console.WriteLine(CoderByte.beautifulDays(1, 2000000 ,23047885));
            //Console.WriteLine(CoderByte.ContainsNearbyDuplicate(arr,3));
                //[1, 2, 3, 1, 2, 3]
            //Console.WriteLine(toys(list));
            //Console.WriteLine(angryProfessor(2,list));
            //var str = "ahyjakh";
            //Console.WriteLine(CoderByte.MatchingCharacter(str));
            // Console.WriteLine(CoderByte.FirstReverse(str));
            //Console.WriteLine(CodeWars.reverseWord(str));
            //Console.WriteLine(CodeWars.combineString("aabbbaccc"));
            //Console.WriteLine(CodeWars.print12To24(str));
            // Console.WriteLine(print24(str)); 
            //var str = "?fun&!! time";
            //Console.WriteLine(LongestWord(str));
            //var eg = "!a_a6???49";
            //Console.WriteLine(CodeWars.QuestionsMarks(eg));


            // var str = "(hello (world))";
            //Console.WriteLine(BracketMatcher(str));
            //var str = "aabbbaccc";
            //Console.WriteLine(Solution(str));
            //var arr = new string[] {"4, 3, 5, 6, 7, 8", "4, 7, 8, 9" };
            //Console.WriteLine(FindIntersection(arr));


            //  Console.WriteLine(Pyramid(3));
            //page count 

            //int n = Convert.ToInt32(Console.ReadLine());
            //int p = Convert.ToInt32(Console.ReadLine());
            //int result = CodeWars.solve(n, p);
            //Console.WriteLine(result);

            /*

            Console.WriteLine(ReverseWord("Hello"));

            Console.WriteLine(ReverseEachWord("hello world we are going to london"));
            Console.WriteLine(ReverseEachWordWithoutSplitting("Then as soon as we encounter a space"));
            Console.WriteLine(CheckAngram("listen","silenm"));
            Console.WriteLine(CheckPalidrome("Madamd"));
            Console.WriteLine(CountPalidrome("we are Madafm abbad if"));
            Console.WriteLine(CountPalidromeWithoutSplitting("we are Madam abba if"));
            Console.WriteLine(MaxOccurrence("werertuwE"));

            Console.WriteLine("======Alternate Arrangement=======");
            int[] arr = { 9, 8, 13, 2, 19, 14 }; 
            List<int> list = new List<int> { 9, 8, 13, 2, 19, 2, 14 };

            Console.WriteLine("====Minimum value====");
            list.Remove(list.Min());
            foreach(int i in list) Console.WriteLine(i);

            RearrangeArrayElts(arr);
            Console.WriteLine("=======Prime======");
            Console.WriteLine(CheckPrimeNumber(1));
            Console.WriteLine("====String of prime=====");
            int[] nums = { 2, 3, 4, 6, 11, 15, 17 };
            Console.WriteLine(PrimeNumber_String(nums));


            Console.WriteLine(Solution("aabbbacc"));
            Console.WriteLine("======Factorial=======");
            Console.WriteLine(FactorialNumber(5));
            RotateLeft(list.ToArray());

            Console.WriteLine("========GetMoney======");
            int[] keyboards = { 10, 20, 20, 10, 10, 30, 50, 10, 20 };
            int[] drives = { 4 };
            int b = 5;
            Console.WriteLine(getMoneySpent(keyboards, drives, b));

            Console.WriteLine(sockMerchant(9,keyboards.ToList()));
            //https://youtu.be/-IzpsC-0eBk
            */
        }
    }
}
