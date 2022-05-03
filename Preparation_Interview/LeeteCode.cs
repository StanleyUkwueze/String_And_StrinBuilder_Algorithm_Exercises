using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preparation_Interview
{
   public class LeeteCode
    {
       
        public static int[] GreaterNextelement(int[] arr)
        {
            var res = new List<int>();
            int count = 0;
            for(int i =0; i < arr.Length; i++)
            {
                for(int j = i + 1; j < arr.Length; j++)
                {
                    if(arr[j] > arr[i])
                    {
                        res.Add(arr[j]);
                        count++;
                        break;
                    }
                    if(i == arr.Length - 1)
                    {
                        res.Add(-1);
                        count++;
                        break;
                    }
                }
                if (count > 0) count = 0;
                else
                {
                    res.Add(-1);

                }
            }
            return res.ToArray();
        }
        private static int beautifulDays(int num)
        {
            var newNum = num.ToString();

            var output = "";

            for (int n = newNum.Length - 1; n >= 0; n--)
            {
                output += newNum[n];
            }
            return Convert.ToInt32(output);

        }

        public static int beautifulDays(int i, int j, int k)
        {
            int count = 0;
            for (int n = i; n <= j; n++)
            {
                if (Math.Abs(n - beautifulDays(n)) % k == 0) count++;
            }
            return count;
        }

       
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
        public static void MoveZeroes(int[] nums)
        {
            int pos = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[pos] = nums[i];
                    pos++;
                }
            }
            while (pos < nums.Length)
            {
                nums[pos++] = 0;

            }
            foreach (var c in nums)
            {
                Console.WriteLine(c);
                Console.WriteLine("===================");
            }
        }

    }
}
