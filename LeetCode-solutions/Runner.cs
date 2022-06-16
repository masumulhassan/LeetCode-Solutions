using System;
using LeetCode_solutions.Easy;
using LeetCode_solutions.Medium;

namespace LeetCode_solutions
{
    public class Runner
    {
        public static void Main(string[] args)
        {
            var result = ContainsDuplicateSolution.ContainsDuplicate(new int[]{1,1,2,5,6,9,8});
            Console.Out.Write(result);
        }
    }
}