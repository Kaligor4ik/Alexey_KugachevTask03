using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class CharsDuplicator
    {
        public static string ifPresentDuplicate(string targetStr, string inputStr)
        {
            IEnumerable<char> arr = inputStr.ToArray().Distinct();
            foreach(char c in arr)
            {
                string str = c.ToString();
                targetStr = targetStr.Replace(str, str + str);
            }
            return targetStr;
        }
    }
}
