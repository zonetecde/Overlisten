using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Overlisten.Extension
{
    internal static class StringExt
    {
        internal static string AddSpacesBeforeCaps(string input)
        {
            string pattern = @"(?<!^)(?=[A-Z])";
            string replacement = " ";
            string result = Regex.Replace(input, pattern, replacement);
            return result;
        }
    }
}
