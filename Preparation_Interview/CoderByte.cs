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

        //Reverse each word
        private static string reverseWord(string str1)
        {
            var output = "";
            for (int i = 0; i < str1.Length; i++)
            {
                output += str1[i];
            }
            return output;
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
                    res.Append(reverseWord(sb.ToString()) + " ");
                    sb = new StringBuilder();
                }
            }
            res.Append(reverseWord(sb.ToString()));
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
            && (Regex.IsMatch(str.Substring(0, 1), @"[a-zA-Z]+$"))
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
    }
}
