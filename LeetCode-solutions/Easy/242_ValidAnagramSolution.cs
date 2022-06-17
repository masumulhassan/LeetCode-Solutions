using System;
using System.Collections.Generic;

namespace LeetCode_solutions.Easy
{
    public class ValidAnagramSolution {
        public static bool IsAnagram(string s, string t)
        {
            var charCount = new Dictionary<char, int>();
            
            int slen = s.Length - 1;
            int tlen = t.Length - 1;
        
            if(slen != tlen) return false;
        
            while(slen >= 0 || tlen >=0) {
                if(slen >= 0 && charCount.ContainsKey(s[slen])) {
                    charCount[s[slen]]++;
                } else {
                    charCount[s[slen]] = 1;
                }
            
                if(tlen >= 0 && charCount.ContainsKey(t[tlen])) {
                    charCount[t[tlen]]--;
                } else {
                    charCount[t[tlen]] = -1;
                }
            
                slen--;
                tlen--;
            }
        
            foreach(var c in charCount) {
                if(c.Value != 0) return false;
            }
            
            
        
            return true;
        }
    }
}