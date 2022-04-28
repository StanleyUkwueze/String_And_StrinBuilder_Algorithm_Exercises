using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preparation_Interview
{
    class Hankerrank
    {
        //decent Number

        public static void decentNumber(int n)
        {
            int f = n / 5;
            int fcount = f * 3;
            int rem = n % 5;
            int t = n - rem;
            int trac = n - fcount;
            var output = "";
            if (n % 3 == 0)
            {
                for (int i = 0; i < n; i++)
                {
                    output += "5";
                }
                Console.WriteLine(output);
            }
            else if (trac % 5 == 0)
            {
                for (int i = 0; i < fcount; i++)
                {
                    output += "5";
                }
                for (int i = 0; i < n - fcount; i++)
                {
                    output += "3";
                }

                Console.WriteLine(output);
            }

            else if (n >= 5 && rem % 3 == 0)
            {
                for (int i = 0; i < rem; i++)
                {
                    output += "5";
                }
                for (int i = 0; i < t; i++)
                {
                    output += "3";
                }

                Console.WriteLine(output);
            }

            if (n < 3) Console.WriteLine("-1");


        }
        //Max Sum
        public static void miniMaxSum(List<int> arr)
        {
            long min = 0;
            long max = 0;
            arr.Sort();
            for (int i = 0; i < arr.Count; i++)
            {
                if (i != 0) max += arr[i];
                if (i != arr.Count - 1) min += arr[i];
            }
            Console.WriteLine($"{min} {max}");
        }

        //Plus Minus
        public static void plusMinus(List<int> arr)
        {
            double z = 0;
            double m = 0;
            double p = 0;
            int n = arr.Count;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == 0) z++;
                if (arr[i] > 0) p++;
                if (arr[i] < 0) m++;
            }

            var zr = String.Format("{0:0.000000}", z / n);
            var pr = String.Format("{0:0.000000}", p / n);
            var mr = String.Format("{0:0.000000}", m / n);

            Console.WriteLine($"{zr},{pr},{mr}");
        }

        //Beautiful day
        public static string reverse(string str)
        {
            if (str.Length == 0) return "";
            return reverse(str.Substring((1), str.Length - 1)) + str[0];
        }
        public static int beautifulDays(int i, int j, int k)
        {
            int output = 0;
            for (int m = i; m <= j; m++)
            {
                var res = Math.Abs(m - Convert.ToInt32(reverse(m.ToString())));
                if (res % k == 0) output++;
            }
            return output;
        }
        //Priyanka and Toys

        public static int toys(List<int> w)
        {
            int count = 1;
            w.Sort();
            int min = w[0] + 4;
            for (int i = 0; i < w.Count; i++)
            {
                if (w[i] > min)
                {
                    min = w[i] + 4;
                    count++;
                }
            }
            return count;
        }

        //Viral Advertising

        public static int viralAdvertising(int n)
        {
            int todayLike = 5 / 2;
            int output = todayLike;
            for (int i = 2; i <= n; i++)
            {
                todayLike = (todayLike * 3) / 2;
                output += todayLike;
            }
            return output;
        }
        // Bill sharing

        public static void bonAppetit(List<int> bill, int k, int b)
        {
            int sum = 0;
            int actSum = 0;
            for (int i = 0; i < bill.Count; i++)
            {
                sum += bill[i];
            }
            actSum = (sum - bill[k]) / 2;
            if (b > actSum) Console.WriteLine(b - actSum);
            if (b == actSum) Console.WriteLine("Bon Appetit");
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

    }

}

