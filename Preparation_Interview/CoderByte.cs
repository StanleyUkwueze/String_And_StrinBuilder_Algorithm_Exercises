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
        public static int beautifulDays(int num)
        {
            var newNum =   num.ToString();
            
            var output = "";
      
            for(int n = newNum.Length - 1; n >= 0; n--)
            {
                output += newNum[n];
            }
           return Convert.ToInt32(output);
           
        }

        public static int beautifulDays(int i, int j, int k)
        {
            int count = 0;
            for(int n = i; n <= j; n++)
            {
                if (Math.Abs(n - beautifulDays(n)) % k == 0) count++;
            }
            return count;
        }


        //LeetCode
        /*
         *Given an integer array nums and an integer k, 
         *return true if there are two distinct indices i 
         *and j in the array such that nums[i] == nums[j] 
         *and abs(i - j) <= k.
         */

        public static bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length && j <= i + k; j++)
                {
                    if (nums[i] == nums[j] && Math.Abs(i - j) <= k) return true;
                }
            }
            return false;
        }

        //Hankerrank====> Kangaro Number line jump

        public static string kangaroo(int x1, int v1, int x2, int v2)
        {
            if (x1 > x2 && v1 > v2) return "NO";
            if (x1 < x2 && v1 < v2) return "NO";
            if (v1 == v2) return "NO";
            if ((x2 - x1) % (v1 - v2) == 0 || (x2 - x1) % (v2 - v1) == 0) return "YES";
            return "NO";
        }

        //Hankerrank
        public static int divisibleSumPairs(int n, int k, List<int> ar)
        {
            int counter = 0;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if ((ar[i] + ar[j]) % k == 0) counter++;
                }
            }
            return counter;
        }

        //hankerrenk =====> Angry Professor
        public static string angryProfessor(int k, List<int> a)
        {
            var output = "";
            var countM = 0;
            
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] <= 0) countM++;
               
            }
            if (countM >= k) output = "NO";
            else
            {
                output = "YES";
            }
            return output;
        }
        //hankerrank =====> migratory birds
        public static int migratoryBirds(List<int> arr)
        {
            int output = 0;
            int max = 0;
            arr.Sort();
            Dictionary<int, int> store = new Dictionary<int, int>();
            for (int i = 0; i < arr.Count; i++)
            {
                if (store.ContainsKey(arr[i]))
                {
                    store[arr[i]]++;
                }
                else
                {
                    store.Add(arr[i], 1);
                }
            }
            foreach (KeyValuePair<int, int> pair in store)
            {
                if (pair.Value > max)
                {
                    max = pair.Value;
                    output = pair.Key;
                }
            }

            return output;
        }


        //Hankerrank

        public static List<int> JimOrders(List<List<int>> orders)
        {
            Dictionary<int, int> store = new Dictionary<int, int>();
            List<int> result = new List<int>();
          
            for (int i = 0; i < orders.Count; i++)
            {
                store.Add(i + 1, orders[i][0] + orders[i][1]);
            }

            foreach (KeyValuePair<int, int> pair in store.OrderBy(key => key.Value))
            {
                result.Add(pair.Key);
            }

            return result;
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
