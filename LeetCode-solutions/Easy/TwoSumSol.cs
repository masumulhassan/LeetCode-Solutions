using System;
using System.Collections.Generic;

namespace LeetCode_solutions
{
    public class TwoSumSol
    {
        
        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> previous = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (previous.ContainsKey(target - nums[i]))
                {
                    return new[] {i, previous[target - nums[i]]};
                }

                if (!previous.ContainsKey(nums[i]))
                {
                    previous.Add(nums[i], i);
                }
            }

            return new []{0};
        }
    }
}