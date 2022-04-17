using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Preparation_Interview
{
   public static class CoderByte
    {
       

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
                    int a = Convert.ToInt32(str[i] - '0');
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
       


       
       


       
        //===========

        public static int Solution(int[] arr)
        {
            Dictionary<int, int> result = new Dictionary<int, int>();
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (result.ContainsKey(arr[i]))
                {
                    result[arr[i]]++;
                }
                else
                {
                    result.Add(arr[i], 1);
                }
            }
            foreach (KeyValuePair<int, int> kvp in result)
            {
                if (kvp.Value%2 == 1) count = kvp.Key;
            }
            return count;
        }

        //Matching characters
        public static string MatchingCharacters(string str)
        {
            //===============================
            //mmmeryme
            Dictionary<char, List<int>> store = new Dictionary<char, List<int>>();
            int index = 0;
            foreach(var c in str)
            {
                if (store.ContainsKey(c))
                {
                    store[c].Add(index); // add value to a given key
                }
                else
                {
                    store.Add(c, new List<int>() { index });
                }
                index++;
            }
            //===============================

            //create a list containing the lists of min and max indices at which  a character occured
            var doubled = new List<List<int>>(); 
            //iterate through the store checkin for values with more than one input
            foreach(var s in store)
            {
                if(s.Value.Count > 1)
                {
                    var list = new List<int>()
                    {
                        s.Value.Min(),
                        s.Value.Max()
                    };
                    doubled.Add(list);
                }
            }

            //=============================

            if (doubled.Count == 0) return "0"; //if no character appeared more than once

            int result = 0;
            foreach(var d in doubled)
            {
                HashSet<char> set = new HashSet<char>();
                for(int i = d[0] + 1 ; i < d[1]; i++)
                {
                    set.Add(str[i]);
                }
                result = Math.Max(result, set.Count);
            }
            return result.ToString();
        }

        public static string FirstReverse(string str)
        {

            // code goes here  

            StringBuilder sb = new StringBuilder();
            StringBuilder res = new StringBuilder();

            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (str[i] != ' ')
                {
                    sb.Append(str[i]);
                }
                else
                {
                    res.Append(sb.ToString() + " ");
                    sb = new StringBuilder();
                }
            }
            res.Append(sb.ToString().Trim());
            return res.ToString();

        }

        //Longest word
        private static bool MatchStr(string str)
        {
            if (Regex.IsMatch(str, @"^[a-zA-Z0-9]+$")) return true;
            return false;
        }
        public static string LongestWord(string sen)
        {
            // code goes here  
            string[] arr = sen.Split(" ");
            var output = "";
            for (int i = 0; i < arr.Length; i++)
            {
                if (MatchStr(arr[i]))
                {
                    if (arr[i].Length > output.Length) output = arr[i];
                }
            }
            return output;
        }

        //CodeLand Username validation...
        public static string CodelandUsernameValidation(string str)
        {

            // code goes here  
            var isValidUser = "false";
            if (
               (str.Length > 4 && str.Length < 25)
            && (str.Substring(str.Length - 1, 1) != "_")
            && (Regex.IsMatch(str, @"^[a-zA-Z0-9_]+$")
            && (Regex.IsMatch(str.Substring(0, 1), @"^[a-zA-Z]+$"))
            )

            )
            isValidUser = "true";
            return isValidUser;

        }

        //MinWindowSubstring
        public static string MinWindowSubstring(string[] strArr)
        {
            //input: {"ahffaksfajeeubsne", "jefaa"}
            //output:aksfaje

            var n = strArr[0];
            var k = strArr[1];
            var dic = new Dictionary<char, int>();

            foreach (var s in k)
            {
                if (dic.ContainsKey(s))
                    dic[s] = dic[s] + 1;
                else
                    dic[s] = 1;
            }

            for (int i = k.Length; i <= n.Length; i++)
            {
                for (int j = 0; j < n.Length; j++)
                {
                    if (j + i <= n.Length)
                    {
                        var sub = n.Substring(j, i).ToCharArray();
                        if (dic.Keys.All(key => sub.Count(s => s == key) >= dic[key]))
                        {
                            return new string(sub);
                        }
                    }
                }
            }

            // code goes here  
            return "";

        }

        //Char maching==========

        public static string MatchingCharacter(string str)
        {

            //stage 1
            Dictionary<char, List<int>> stor = new Dictionary<char, List<int>>();
            int index = 0; //to keep track of the index of every character in the string
            foreach(var c in str)
            {
                if (stor.ContainsKey(c))
                {
                    stor[c].Add(index);
                }
                else
                {
                    stor.Add(c, new List<int>() { index });
                }
                index++;
            }

            //Stage 2
            var doubled = new List<List<int>>();
            foreach(var s in stor)
            {
                if(s.Value.Count > 1)
                {
                    var list = new List<int>()
                    {
                        s.Value.Min(),
                        s.Value.Max()
                    };
                    doubled.Add(list);
                }
            }

            //stage 3

            int result = 0;
            foreach(var d in doubled)
            {
                HashSet<int> set = new HashSet<int>();
                for(int i = d[0] + 1; i < d[1]; i++)
                {
                    set.Add(str[i]);
                }
                result = Math.Max(result, set.Count);
            }
            return result.ToString();
        }
    }
}
