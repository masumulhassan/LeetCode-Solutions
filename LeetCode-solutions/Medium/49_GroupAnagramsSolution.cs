using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode_solutions.Medium
{
    public class GroupAnagramsSolution {
        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var result = new List<IList<string>>();
            var alreadyVisited = new Dictionary<string, IList<string>>();
        
            foreach(var str in strs) {
                var charArr = str.ToCharArray();
                Array.Sort(charArr);
                var strSorted = new string(charArr);
                
                if(alreadyVisited.ContainsKey(strSorted)) {
                    alreadyVisited[strSorted].Add(str);
                }
                else {
                    alreadyVisited[strSorted] = new List<string>{str};
                }
            }

            foreach (var groups in alreadyVisited)
            {
                result.Add(groups.Value);
            }
            
            return result;
        }
    }
}