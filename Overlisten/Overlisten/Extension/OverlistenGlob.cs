using OverlistenClassLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace Overlisten.Extension
{
    internal static class OverlistenGlob
    {
        internal static string FormatHeroName(string name)
        {
            return name.Replace('_', ':').Replace("Torbjorn", "Torbjörn").Replace("Lucio", "Lúcio"); ;
        }
    }
}
