﻿namespace LeetCode_solutions
{
    public class PalindromeNumber
    {
        public bool IsPalindrome(int x) {
            if(x < 0) return false;
        
            string xs = x.ToString();
            string revX = "";
            for(int i = xs.Length - 1; i >= 0; i--){
                revX += xs[i];
            }
        
            return revX == xs;
        }
    }
}