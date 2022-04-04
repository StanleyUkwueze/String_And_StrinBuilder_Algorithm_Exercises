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
            for(int i = n; i >= 0; i--)
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
            for(int i = 0; i < arr.Length; i++)
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

            for(int i = 0; i < str.Length; i++)
            {
                if(str[i] != ' ')
                {
                    CharStack.Push(str[i]);
                }

                else
                {
                    while(CharStack.Count > 0)
                    {
                        char c = CharStack.Pop();
                        result.Append(c.ToString()) ;
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
            var temp = "Hello world";
          var arr =  temp.Split(" ");
            if(input1.Length != input2.Length) return false;
          char[] CharArrInput1 =  input1.ToLower().ToCharArray();
          char[] CharArrInput2 = input2.ToLower().ToCharArray();
            Array.Sort(CharArrInput1);
            Array.Sort(CharArrInput2);
            for (int i = 0;i < CharArrInput1.Length; i++)
            {
                if(CharArrInput1[i] != CharArrInput2[i])
                {
                    return false;
                }
             
            }
            return true;
        }

        //Check if a word is a palidrome...
        public static bool CheckPalidrome(string word)
        {
            if(string.IsNullOrEmpty(word)) return false;
           string newword =  word.ToLower().Trim();
             int max = word.Length - 1;
             int min = 0;
            int lent = newword.Length;
            for(int i = 0; i < lent; i++)
            {
                if(newword[min] != newword[max])
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
            for(int i = 0; i < arr.Length; i++)
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
            for(int i = 0; i < sentence.Length; i++)
            {
               if(sentence[i] != ' ')
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

            foreach(KeyValuePair<char,int> c in occurrenceDictionary)
            {
                if(c.Value > maxOccuredValue)
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
            for (int j = 0;j < arr.Length; j++)
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

            if(arr[0] %2 == 0) 
                flag = true;

            while(index < n)
            {
                if(flag == true)
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
          if(num == 2) return true;
          if(num <= 1) return false;
          
            for(int i = 2; i < num; i++)
            {
             if(num % i == 0) 
                    return false;
            
            }
            return true;
        }

        //return a string of prime numbers
        public static string PrimeNumber_String(int[] num)
        {
            StringBuilder Result = new StringBuilder();
            for(int i = 0; i < num.Length; i++)
            {
                if (CheckPrimeNumber(num[i]))
                {
                    Result.Append(num[i] + ",") ;
                }
            }
            return Result.ToString().Trim().Remove(Result.Length-1);
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
                    output += count.ToString() + prev.ToString();
                }
                else
                {
                    prev = str[i];
                    count = 1;                   
                }
            }
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
            for(int i = 1; i<arr.Length-1; i++)
            {
                arr[i-1] = arr[i];
            }
            arr[(arr.Length - 1)] = temp;

            for(int i = 0; i < arr.Length; i++) Console.WriteLine(arr[i]);    
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


        public static int Get(List<List<int>> times)
        {
            int count = 0;
            Dictionary<int, List<int>> store = new Dictionary<int, List<int>>();
            int min = times.Select(x => x[0]).Min();
            int max = times.Select(x => x[0]).Max();
            foreach(var time in times)
            {
                if(store.ContainsKey(time[0]))
                {
                    store[time[0]].Add(time[1]);
                } else
                {
                    store.Add(time[0], new List<int>() { time[1] });
                }
            }
            //Console.WriteLine(min);
            //Console.WriteLine(max);
            while(store.Count > 0)
            {
                for(int m = min; m <= max; m++)
                {
                    //Console.WriteLine(m);
                    if(store.ContainsKey(m))
                    {
                        int val = store[m][0];
                        store[m].RemoveAt(0);
                        if (store[m].Count == 0) store.Remove(m);
                        m = val - 1;
                        
                    }
                }
                count++;
            }
            return count;
        }

        static void Main(string[] args)
        {
            //List<List<int>> array = new List<List<int>>();

            //[[1,5],[5,6],[6,7],[7,9]]
            // [[0,2],[1,4],[4,6],[0,4],[7,8],[9,11],[3,10]]
            //array.Add(new List<int>() { 0, 2 });
            //array.Add(new List<int>() { 1, 4 });
            //array.Add(new List<int>() { 4, 6 });
            //array.Add(new List<int>() { 0, 4 });
            //array.Add(new List<int>() { 7, 8 });
            //array.Add(new List<int>() { 9, 11 });
            //array.Add(new List<int>() { 3, 10 });
            //Console.WriteLine(Get(array));

            //page count 

            int n = Convert.ToInt32(Console.ReadLine());
            int p = Convert.ToInt32(Console.ReadLine());
            int result = CodeWars.solve(n, p);
            Console.WriteLine(result);

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
