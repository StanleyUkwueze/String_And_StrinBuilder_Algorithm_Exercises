using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preparation_Interview
{
    public class CodeWars
    {

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

        //page count

       public static int solve(int totalPagesInBook, int targetPageNumber)
        {
            var minimumPagesToTurn = 0;

            if (targetPageNumber == 1 || targetPageNumber == totalPagesInBook)
                return minimumPagesToTurn;

            if (totalPagesInBook % 2 != 0 && targetPageNumber == totalPagesInBook - 1)
                return minimumPagesToTurn;


            if (totalPagesInBook % 2 == 0)
            {
                //even number of total pages e.g. 10
                if (targetPageNumber <= totalPagesInBook / 2)
                {
                    //start from front
                    minimumPagesToTurn = targetPageNumber / 2;
                }
                else
                {
                    //start from end
                    double d = ((double)(totalPagesInBook - targetPageNumber)) / 2;
                    minimumPagesToTurn = (int)Math.Ceiling(d);
                }
            }
            else
            {
                //total number of pages are odd

                //special handling for exactly middle number when total number of pages are like 3,7,11,15...and so on

                if (targetPageNumber == (totalPagesInBook / 2) + 1 && totalPagesInBook % 4 == 3)
                {
                    //this requires special handling as this median will be close to the end instead
                    minimumPagesToTurn = (totalPagesInBook - targetPageNumber) / 2;
                }
                else
                {
                    if (targetPageNumber <= ((totalPagesInBook / 2) + 1))
                    {
                        //start from front
                        minimumPagesToTurn = targetPageNumber / 2;
                    }
                    else
                    {
                        //start from end
                        minimumPagesToTurn = (totalPagesInBook - targetPageNumber) / 2;
                    }
                }

            }
            return minimumPagesToTurn;
        }

    }
   
}
