using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task01
{
    class SentenceParser
    {
        public static string[] Parse(string str)
        {
            String pattern = @"s?\W\s?";
            return Regex.Split(str, pattern);
        }
    }
}
