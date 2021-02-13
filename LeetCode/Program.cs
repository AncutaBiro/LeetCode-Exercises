/*
LeetCode task 1672. Richest Customer Wealth
You are given an m x n integer grid accounts where accounts[i][j] is the amount of money the i​​​​​​​​​​​th​​​​ customer has in the j​​​​​​​​​​​th​​​​ bank. Return the wealth that the richest customer has.

A customer's wealth is the amount of money they have in all their bank accounts. The richest customer is the customer that has the maximum wealth.

Example 1:

Input: accounts = [[1,2,3],[3,2,1]]
Output: 6
Explanation:
1st customer has wealth = 1 + 2 + 3 = 6
2nd customer has wealth = 3 + 2 + 1 = 6
Both customers are considered the richest with a wealth of 6 each, so return 6.
 
 */

using System;

namespace LeetCode
{
    class Program
    {

        static void Main(string[] args)
        {
            // initialization of a jagged array
            int[][] accounts = {
                             new int[] { 2, 8, 7},
                             new int[] { 7, 1, 3 },
                             new int[] { 1, 9, 5}
                               };

            int m = MaximumWealth(accounts);

            Console.WriteLine(m);
        }

        public static int MaximumWealth(int[][] accounts)
        {
            // creata an array to keep the sums of every row
            int[] sum = new int[accounts.Length];

            // iterate the rows
            for (int i = 0; i < accounts.Length; i++)
            {
                // iterate every row until the final element (accounts[row].Length)
                for (int j = 0; j < accounts[i].Length; j++)
                {
                    sum[i] += accounts[i][j];
                    
                }
            }

            // find the max elemet for the sum array, select the first element as max, and if any emente is greater it will become the new max as soo on
            int max = sum[0];

            for (int k = 1; k < sum.Length; k++) 
            {
                if (sum[k] > max)
                    max = sum[k];
            }
            return max;
        }
    }
}
