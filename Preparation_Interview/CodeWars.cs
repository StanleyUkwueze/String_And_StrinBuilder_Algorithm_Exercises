using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preparation_Interview
{
    public class CodeWars
    {
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
      
    }
   
}
