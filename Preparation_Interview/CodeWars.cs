using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preparation_Interview
{
    public class CodeWars
    {
        public static int FindMissing(List<int> list)
        {
            int n = list.Count;
            int d = (list[n - 1] - list[0]) / n;
            int output = 0;
            int term = 0;
            for (int i = 1; i <= list.Count; i++)
            {
                term = list[0] + (i - 1) * d;
                if (!list.Contains(term))
                {
                    output = term;
                    break;
                }
            }
            return output;
        }
        //+1 Array ====> kata 6
        public static int[] UpArray(int[] num)
        {
            var output = new List<int>();
            num[num.Length - 1] = num[num.Length - 1] + 1;
            if (num[num.Length - 1] == 10)
            {
                num[num.Length - 2] += (num[num.Length - 1] / 10);
                num[num.Length - 1] = num[num.Length - 1] % 10;
            }
            for (int i = 0; i < num.Length; i++)
            {
                output.Add(num[i]);
               
            }
            return output.ToArray();
           
        }

        //question marks
        public static string QuestionsMarks(string str)
        {
            int count = 0;
            var output = "false";
            for(int i = 0; i <str.Length; i++)
            {
                for(int j = i + 1; j < str.Length; j++)
                {
                    int a = Convert.ToInt32(str[i] - '0');
                    int b = Convert.ToInt32(str[j] - '0');
                    if(a+b == 10)
                    {
                        output = "true";
                        count = 0;
                        var res = str.Substring(i, str.Length - j);
                        for(int k = 0; k <res.Length; k++)
                        {
                            if(res[k] == '?')
                            {
                                count++;
                            }
                        }

                        if(count >= 3)
                        {
                            return output;
                        }
                    }
                }
            }

            return output;
        }
        //Time Conversion

        public static string print12To24(String str)
        {
            int h2 = (int)str[1]-'0';
            int h1 = (int)str[0]-'0';
            int hh = (h1 * 10 + h2 % 10);

            var output = string.Empty;

            if(str[8] == 'A' || str[8] == 'a')
            {
                if(hh == 12)
                {
                    output += "00";
                }
                else
                {
                    for(int i = 2; i <=7; i++) output += str[i];                  
                }
            }
            else
            {
                if(hh == 12)
                {                  
                    output += 12;
                    for (int i = 2; i <= 7; i++) output += str[i];
                }
                else
                {
                    hh += 12;
                    output += "12";
                    for (int i = 2; i <= 7; i++) output += str[i];
                }
           
            }

            return output;
        }
        //input ==> aabbbaccc
        //output ===> 2a3b1a3c
        public static string combineString(string str)
        {
            var output = "";
            var prev = str[0];
            int count = 1;

            for(int i = 1; i<str.Length; i++)
            {
                if(str[i] == prev)
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
        //Mark and toys

        public static int maximumToys(List<int> prices, int k)
        {
            prices.Sort();
            int toys = 0;
            int cost = 0;
            for (int i = 0; i < prices.Count; i++)
            {
                if (cost + prices[i] <= k)
                {
                    toys++;
                    cost += prices[i];
                }
                else
                {
                    break;
                }
            }

            return toys;
        }

    
    // Computer problem series #1: Fill the Hard Disk Drive ====> Kata 7

    public static int Save(int[] sizes, int hd)
        {
            //Write your code here
            int sum = 0;
            int count = 0;
            for (int i = 0; i < sizes.Length; i++)
            {
                sum += sizes[i];
                count++;
                if (sum > hd)
                {
                    sum -= sizes[i];
                    count--;
                    break;
                }
            }
            return count;
        }

        // Battle between good and evil ====> Kata 6
        public static string GoodVsEvil(string good, string evil)
        {
            var evilarr = evil.Split(" ");
            var goodArr = good.Split(" ");
            int evilSum = 0;
            int goodSum = 0;

            for (int i = 0; i < evilarr.Length; i++)
            {
                evilSum += Convert.ToInt32(evilarr[i]);
            }
            for (int k = 0; k < goodArr.Length; k++)
            {
                goodSum += Convert.ToInt32(goodArr[k]);
            }
            if (evilSum > goodSum)
            {
                return "Battle Result: Evil eradicates all trace of Good";
            }
            else if (goodSum > evilSum)
            {
                return "Battle Result: Good triumphs over Evil";
            }
            else
            {
                return "Battle Result: No victor on this battle field";
            }
        }

        //Write a function that returns both the minimum and maximum number
        //of the given list/array. ====> Kata 7

        public static int[] minMax(int[] lst)
        {
            // your code
            List<int> list = new List<int>();
            Array.Sort(lst);
            list.Add(lst[0]);
            list.Add(lst[lst.Length - 1]);         
            return list.ToArray();

        }

        //Array Leaders ========> Kata 7

        public static int[] ArrayLeaders(int[] numbers)
        {
            List<int> list = new List<int>();
            int sum = 0;
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                if (numbers[i] > sum)
                {
                    list.Add(numbers[i]);
                }
                sum += numbers[i];
            }

            return list.AsEnumerable().Reverse().ToArray();
        }

        //Sum of Minimums of a 2-Dim Array ========> Kata 7

        public static int SumOfMinimums(int[,] numbers)
        {
            
            var sum = 0;
            for (int i = 0; i < numbers.GetLength(0); i++)
            {

                var min = numbers[i, 0];
                for (int k = 1; k < numbers.GetLength(1); k++)
                {
                    if (numbers[i, k] < min)
                    {
                        min = numbers[i, k];
                    }
                }
                sum += min;
            }
            return sum;
        }


        private static long SumDigit(long num)
        {
            long rem = 0;
            long sum = 0;
            while (num > 0)
            {
                rem = num % 10;
                sum += rem;
                num = num / 10;
            }
            return sum;
        }
        public static long SumDigNthTerm(long initval, long[] patternl, int nthterm)
        {
            int count = 0;
            for (int i = 0; i < nthterm - 1; i++)
            {
                initval += patternl[count++];
                if (count == patternl.Length)
                {
                    count = 0;
                }
            }
            return SumDigit(initval);
        }

        private static bool CheckPrime(long num)
        {
            for (int i = 2; i < num / 2; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return num >= 2;
        }
        public static long[] PrimeBefAft(long num)
        {
            // your code 
            var primes = new long[] { num, num };
            while (!CheckPrime(--primes[0])) ;
            while (!CheckPrime(++primes[1])) ;
            return primes;
        }

        public static int[] TakeWhile(int[] arr, Func<int, bool> pred)
        {
            var list = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (pred(arr[i]))
                {
                    list.Add(arr[i]);
                }
                else
                {
                    break;
                }
            }
            return list.ToArray();
        }

        //page count
       

    }
   
}
