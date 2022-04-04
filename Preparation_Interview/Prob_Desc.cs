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

        /*
         You're given a list of time intervals during which students at a school need a laptop. These time intervals are represented by pairs of integers [start, end], where 0 <= start < end. However, start and end don't represent real times; therefore, they may be greater than 24.

No two students can use a laptop at the same time, but immediately after a student is done using a laptop, another student can use that same laptop. For example, if one student rents a laptop during the time interval [0, 2], another student can rent the same laptop during any time interval starting with 2.

Write a function that returns the minimum number of laptops that the school needs to rent such that all students will always have access to a laptop when they need one.


[[0,2],[1,4],[4,6],[0,4],[7,8],[9,11],[3,10]] ===>	3

[[0,4],[2,3],[2,3],[2,3]] ===>	4

[[1,5],[5,6],[6,7],[7,9]]=====>	1
         */
    }
}
