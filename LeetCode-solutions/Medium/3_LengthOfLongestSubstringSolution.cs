using System;
using System.Collections.Generic;

namespace LeetCode_solutions.Medium
{
    public class LengthOfLongestSubstringSolution {
        public static int LengthOfLongestSubstring(string s)
        {
            int longestLength = 0;
            var charLookupList = new List<char>();

            foreach (var c in s.ToCharArray())
            {
                if (charLookupList.Contains(c))
                {
                    charLookupList.RemoveRange(0, charLookupList.IndexOf(c) + 1);
                }

                charLookupList.Add(c);

                if (charLookupList.Count > longestLength)
                {
                    longestLength = charLookupList.Count;
                }
            }
            
            return longestLength;
        }

        public static int LengthOfLongestSubstringInitialSol(string s)
        {
            int longestLength = 0;
            int currentSubstringLength = 0;
            var lookupTable = new Dictionary<char, int>();

            foreach (var c in s.ToCharArray())
            {
                if (lookupTable.ContainsKey(c))
                {
                    if (currentSubstringLength == lookupTable[c])
                    {
                        currentSubstringLength = 0;
                        lookupTable.Clear();
                    }
                    else
                    {
                        int charPos = lookupTable[c];
                        currentSubstringLength -= charPos;
                        
                        foreach (var item in lookupTable)
                        {
                            if (item.Value <= charPos)
                            {
                                lookupTable.Remove(item.Key);
                            }
                            else
                            {
                                lookupTable[item.Key] = item.Value - charPos;
                            }
                        }
                    }
                }

                currentSubstringLength++;
                lookupTable.Add(c, currentSubstringLength);

                if (currentSubstringLength > longestLength)
                {
                    longestLength = currentSubstringLength;
                }
            }
            
            return longestLength;
        }
    }
}