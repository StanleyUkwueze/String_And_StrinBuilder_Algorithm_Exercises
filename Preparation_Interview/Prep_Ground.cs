using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preparation_Interview
{
   public class Prep_Ground
    {
        //challenge Token: "2wedey54knmf"
     //given a string of words find the word with more number of repeating characters
     //if there is no word with repeating character return -1
     // after combind the word with the challenge token separated by :, reverse each and return the output
     
        private static string reverseWord(string str)
        {
            var output = "";
            for(int i =str.Length-1; i >=0; i--)
            {
                output += str[i];
            }
            return output;
        }

        private static int countRepetition(string str)
        {
            Dictionary<char, int> store = new Dictionary<char, int>();
            int max = 0;

            for(int i = 0; i < str.Length; i++)
            {
                if (store.ContainsKey(str[i]))
                {
                    store[str[i]]++;
                }
                else
                {
                    store.Add(str[i], 1);
                }
              
            }
            foreach(KeyValuePair<char,int> pair in store)
            {
                if (pair.Value > max) max = pair.Value;
            }

            return max;
        }

        public static string Solution(string sentence)
        {
            var strArr = sentence.Split(" ");
            var output = "";
            int max = 0;
            var token = "challengeToken";
            for (int i = 0; i < strArr.Length; i++)
            {
                if(countRepetition(strArr[i]) > max)
                {
                    max = countRepetition(strArr[i]);
                    output = strArr[i];
                }
            }
            if(max <= 1)
            {
                output = $"-1:{reverseWord(token)}";
            }
            else
            {
                output = $"{reverseWord(output)}:{reverseWord(token)}";
            }
            return output;
        }

        public static int MatchingCharacters(string str)
        {
            Dictionary<char, List<int>> store = new Dictionary<char, List<int>>();
            int index = 0;

            foreach(var c in str)
            {
                if (store.ContainsKey(c))
                {
                    store[c].Add(index);
                }
                else
                {
                    store.Add(c, new List<int> { index });
                }

                index++;
            }

            //====> stage 1
            //create dict of Key:char and value: List<int>,
            //to filter out the char that occurred multiple time.
            //intialize an index = 0
            //on each loop of str add the index to the list accordingly and index++.

            //Stage 2

            //create a  list of lists ====> doubledList
            //loop through the dict and for each char that occurred more than once
            //add the min and max indicies in a new list
            //add the resulting list into doubled.
            var doubled = new List<List<int>>();

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
            //stage ===>3
            //intialize int result = 0
            //loop through doubled and create a new hashset inside it to store chars
            //as you loop through the inner for loop without duplicate
            //then an inner forloop i = d[0] + 1; i < d[1]; i++
            //after each inner, reinitialize result thus: result = Math.Math(result, set.Count)
            //finally return reseult.Tostring() after the outer loop.

            int result = 0;
            foreach(var d in doubled)
            {
                HashSet<char> set = new HashSet<char>();
                for(int i = d[0] + 1; i < d[1]; i++)
                {
                    set.Add(str[i]);
                }
                result = Math.Max(result, set.Count);
            }

            return result;
        }
    }
}
