using System;
using System.Linq;

namespace PyramidMaxSumChallenge
{
    /// <summary>
    /// A class is used to find the path that provides the maximum possible sum of the numbers 
    /// in a given pyramid. The route should start from the top and move downward to the bottom
    /// and following a list of roles.
    /// </summary>
    public class PyramidMaxSum
    {
        /// <summary>
        /// Calculate the max sum of route nodes
        /// Assume that the max sum is from the max value of the bottom line to up
        /// , line by line all the way to top
        /// </summary>
        /// <param name="pyramid">int[,] to present the data struct of pyramid</param>
        /// <returns>Max sum</returns>
        public int GetMaxSum(int[,] pyramid)
        {
            var length = pyramid.GetLength(0);
            var sums = new int[length];

            var isTopNumOdd = IsOdd(pyramid[0, 0]);
            // Initialise the sum from bottom line
            for (int i = 0; i < length; i++)
            {
                sums[i] = GetValidNumber(pyramid[length - 1, i], isTopNumOdd, length - 1);
            }

            // Summary on each line from bottom to top 
            for (int i = length - 2; i >= 0; i--)
            {
                for (int j = 0; j <= i; j++)
                {
                    // 
                    var num = GetValidNumber(pyramid[i, j], isTopNumOdd, i);
                    sums[j] = num != 0 && !(sums[j] == 0 && sums[j + 1] == 0) ?
                            num + Math.Max(sums[j], sums[j + 1])
                            : 0;
                }
                // in this case, no valid path to reach the bottom of the pyramid
                if (i > 0 && sums.Take(i).All(ent => ent == 0))
                    return 0;
            }

            return sums[0];
        }

        /// <summary>
        /// Every second line should have the same kind of number(odd or even) as the top line number([0,0])
        /// </summary>
        /// <param name="num">Input integer</param>
        /// <param name="isTopNumOdd">Is the top line number([0,0] an odd?)</param>
        /// <param name="lineNr">Which line is this number located?</param>
        /// <returns>If it is valid, returns the number, otherwise returns 0</returns>
        private int GetValidNumber(int num, bool isTopNumOdd, int lineNr)
        {
            return (IsOdd(lineNr + 1) && isTopNumOdd) == IsOdd(num) ? num : 0;
        }

        /// <summary>
        /// Whether the input is an odd number
        /// </summary>
        /// <param name="num">Input integer</param>
        /// <returns></returns>
        private bool IsOdd(int num)
        {
            return num % 2 != 0;
        }
    }
}
