using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preparation_Interview
{
    class Prob_Desc
    {
        // Book Drawing
        /*
         Problem: https://www.hackerrank.com/challenges/drawing-book/problem
         C# Language Version: 6.0
         .Net Framework Version: 4.5.2
         Thoughts :
         1. Let total number of pages in the book be totalPagesInBook and the page number we want to open is targetPageNumber.
         2. Let the minimum number of pages which are to be turned to reach targetPageNumber is minimumPagesToTurn.
         3. Set minimumPagesToTurn to 0
         4. There are three cases in which user will not have to turn even a single page
            - If targetPageNumber is 1 OR
            - If targetPageNumber is equal to totalPagesInBook OR
            - If totalPagesInBook is an odd number and targetPageNumber is totalPagesInBook-1
            If either of the above three conditions are met then jump to step 7.
         5. If totalPagesInBook is an even number then
            - if targetPageNumber is less than or equal to half of totalPagesInBook then starting from front will be beneficial.
              Set minimumPagesToTurn to half of targetPageNumber.
            - otherwise starting from end will be beneficial.
              Set minimumPagesToTurn to half of difference between totalPagesInBook and targetPageNumber. If the operation
              results in a decimal value then round it off to its nearest higher integer.
         6. If totalPagesInBook is an odd number then
            - If targetPageNumber is the exact median of totalPagesInBook and totalPagesInBook in book
                is exacly one less than the nearest multiple of 4 then starting from end will be beneficial.
                Set minimumPagesToTurn to half of difference of totalPagesInBook and targetPageNumber.
            - If targetPageNumber is less than, equal to or one more than half of totalPagesInBook then starting from front will be beneficial.
              Set minimumPagesToTurn to half of targetPageNumber.
            - otherwise starting from back will be beneficial.
              Set minimumPagesToTurn to half of difference between totalPagesInBook and targetPageNumber. 
          7. Print minimumPagesToTurn
         Time Complexity:  O(1)
         Space Complexity: O(1)
                
        */


        //Laptop Rentals...
        /*
         You're given a list of time intervals during which students at a school need a laptop. These time intervals are represented by pairs of integers [start, end], where 0 <= start < end. However, start and end don't represent real times; therefore, they may be greater than 24.

        No two students can use a laptop at the same time, but immediately after a student is done using a laptop, another student can use that same laptop. For example, if one student rents a laptop during the time interval [0, 2], another student can rent the same laptop during any time interval starting with 2.

        Write a function that returns the minimum number of laptops that the school needs to rent such that all students will always have access to a laptop when they need one.


        [[0,2],[1,4],[4,6],[0,4],[7,8],[9,11],[3,10]] ===>	3

        [[0,4],[2,3],[2,3],[2,3]] ===>	4

        [[1,5],[5,6],[6,7],[7,9]]=====>	1
         */


        /*
         You're given a two-dimensional array (a matrix) of distinct integers and a target integer. Each row in the matrix is sorted, and each column is also sorted; the matrix doesn't necessarily have the same height and width.

            Write a function that returns an array of the row and column indices of the target integer if it's contained in the matrix, otherwise [-1, -1].

            Challenge.SearchInSortedMatrix(matrix, target)
            Parameters
            matrix: Array<int[]> - A matrix of distinct integers

            target: int - The target integer to find in the matrix

            Return Value
            int[] - The row and column index of the target integer in the matrix.

            Given the matrix

            [
              [1, 4, 7, 12, 15, 1000],
              [2, 5, 19, 31, 32, 1001],
              [3, 8, 24, 33, 35, 1002],
              [40, 41, 42, 44, 45, 1003],
              [99, 100, 103, 106, 128, 1004],
            ]
            and a target value of 44, your function should return [3, 3]. Meaning, the target value 44 can be found at row index 3 and column index 3 in the matrix.

            If the target value cannot be found in the matrix, you should return [-1, -1]
         */


        /*
         Max StockProfit

        Your algorithms have become so good at predicting the market that you now know what the share price of Wooden Orange Toothpicks Inc. (WOT) will be for the next number of days.

            Each day, you can either buy one share of WOT, sell any number of shares of WOT that you own, or not make any transaction at all. What is the maximum profit you can obtain with an optimum trading strategy?

            Example

            Buy one share day one, and sell it day two for a profit of . Return .


            No profit can be made so you do not buy or sell stock those days. Return .

            Function Description

            Complete the stockmax function in the editor below.

            stockmax has the following parameter(s):

            prices: an array of integers that represent predicted daily stock prices
            Returns

            int: the maximum profit achievable
            Input Format

            The first line contains the number of test cases .

            Each of the next  pairs of lines contain:
            - The first line contains an integer , the number of predicted prices for WOT.
            - The next line contains n space-separated integers , each a predicted stock price for day .

            Constraints

            Output Format

            Output  lines, each containing the maximum profit which can be obtained for the corresponding test case.

            Sample Input

            STDIN       Function
            -----       --------
            3           q = 3
            3           prices[] size n = 3
            5 3 2       prices = [5, 3, 2]
            3           prices[] size n = 3
            1 2 100     prices = [1, 2, 100]
            4           prices[] size n = 4
            1 3 1 2     prices =[1, 3, 1, 2]
            Sample Output

            0
            197
            3
            Explanation

            For the first case, there is no profit because the share price never rises, return .
            For the second case, buy one share on the first two days and sell both of them on the third day for a profit of .
            For the third case, buy one share on day 1, sell one on day 2, buy one share on day 3, and sell one share on day 4. The overall profit is .
         */

        /*
         MaximumToys
         Mark and Jane are very happy after having their first child. Their son loves toys, so Mark wants to buy some. There are a number of different toys lying in front of him, tagged with their prices. Mark has only a certain amount to spend, and he wants to maximize the number of toys he buys with this money. Given a list of toy prices and an amount to spend, determine the maximum number of gifts he can buy.

            Note Each toy can be purchased only once.

            Example


            The budget is  units of currency. He can buy items that cost  for , or  for  units. The maximum is  items.
         */
    }
}
