using System.Collections.Generic;

namespace LeetCode_solutions.Easy
{
    public class ContainsDuplicateSolution {
        public static bool ContainsDuplicate(int[] nums) {
        
            if(nums.Length <= 1){
                return false;
            }
        
            var alreadyFound = new Dictionary<int, bool>();
            foreach(var num in nums){
                if(alreadyFound.ContainsKey(num)){
                    return true;
                }
                alreadyFound[num] = true;
            }
        
            return false;
        }
    }
}