using System;
using System.Collections.Generic;
using System.Text;

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

        public static void RearrangeArrayElts(int[] arr)
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
            for (i = 0; i < n; i++)
                Console.WriteLine(arr[i]);

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


        static void Main(string[] args)
        {
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
            RearrangeArrayElts(arr);
            Console.WriteLine("=======Prime======");
            Console.WriteLine(CheckPrimeNumber(1));
            Console.WriteLine("====String of prime=====");
            int[] nums = { 3, 6, 7, 9, 23, 17 };
            Console.WriteLine(PrimeNumber_String(nums));


        }
    }
}
