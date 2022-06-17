using System;
using LeetCode_solutions.Easy;
using LeetCode_solutions.Medium;

namespace LeetCode_solutions
{
    public class Runner
    {
        public static void Main(string[] args)
        {
            var result = GroupAnagramsSolution.GroupAnagrams(new []{"eat","tea","tan","ate","nat","bat"});
            Console.Out.Write(result);
        }
    }
}