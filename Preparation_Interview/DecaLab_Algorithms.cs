using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preparation_Interview
{
    class DecaLab_Algorithms
    {

        //laptop rentals ====> week_1
        public static int Get(List<List<int>> times)
        {
            int count = 0;
            Dictionary<int, List<int>> store = new Dictionary<int, List<int>>();
            int min = times.Select(x => x[0]).Min();
            int max = times.Select(x => x[0]).Max();

            foreach (var time in times)
            {
                if (store.ContainsKey(time[0]))
                {
                    store[time[0]].Add(time[1]);
                }
                else
                {
                    store.Add(time[0], new List<int>() { time[1] });
                }
            }

            while (store.Count > 0)
            {
                for (int m = min; m <= max; m++)
                {
                    if (store.ContainsKey(m))
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


        //week 2
        public static int[] SearchInSortedMatrix(int[][] matrix, int target)
        {
            var indicies = new List<int>();
            int[] vals = { -1, -1 };
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int k = 0; k < matrix[i].Length; k++)
                {
                    if (matrix[i][k] == target)
                    {
                        indicies.Add(i);
                        indicies.Add(k);
                        return indicies.ToArray();
                    }
                }
            }
            return vals;
        }

        //Stock Max Profit ====> Hankerrank

        public static long stockmax(List<int> prices)
        {
            int n = prices.Count;
            long profit = 0;
            int peak = 0;
            for (int i = n - 1; i >= 0; i--)
            {
                if (prices[i] >= peak)
                {
                    peak = prices[i];
                }
                else
                {
                    profit += peak - prices[i];
                }

            }
            return profit;
        }

        //Giving an array and a size, split the array items into a list of arrays of the given size
        //1.) chunk([1,2,3,4], 2) => [[1, 2][3, 4]]
        //2.) chunk([1,2,3,4], 3) => [[1, 2, 3][4]]

        public static List<int>[] ChunkArray(int[] array, int size)
        {
            var result = new List<List<int>>();
            var resultToAdd = new List<int>();
            int tracker = 0;
            for (int i = 0; i < array.Length; i++)
            {
                resultToAdd.Add(array[i]);
                tracker++;
                if (tracker == size || i == array.Length - 1)
                {
                    result.Add(resultToAdd);
                    tracker = 0;
                    resultToAdd = new List<int>();
                }
            }
            return result.ToArray();
        }

        //week ==> 3
        public static List<int> NumberSplit(int num, int space)
        {
            int digitNum = num / space; //3
            var numAdd = num - (digitNum * space); // 2
            int count = 0;
            var diff = space - numAdd; //1
            var result = new List<int>();
           // var sum = 0;
            while (count < space)
            {
                if (count >= diff)
                {
                    result.Add(digitNum + 1);
                    count++;
                }
                else
                {
                    result.Add(digitNum);
                    count++;
                }
            }
            return result;
        }


    }

}

