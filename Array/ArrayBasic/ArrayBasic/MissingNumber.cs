using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayBasic
{
    class MissingNumber
    {
        /// <summary>
        /// Given an array nums containing n distinct numbers in the range [0, n], return the only number in the range that is missing from the array.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        
        /// Optimal-> Sum has limitation due to Integer size overflow, hence XOR is optimal
        public int Run(int[] nums)
        {
            int n = nums.Length;
            int x1 = 0, x2 = 0, res;
            for (int i = 0; i < n; i++)
            {
                x1 = x1 ^ nums[i];
                x2 = x2 ^ (i + 1);
            }

            res = x1 ^ x2;

            return res;
        }

    }
}
