// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Memory.Performance
// Release     : 2007/12/01 1.0
// Description : 5.4 性能控制的多方探讨

using System;
using System.Collections.Generic;
using System.Text;

namespace InsideDotNet.Memory.Performance
{
    class StringCompareEx
    {
        public static bool StringCompare(string str1, string str2)
        {
            return str1 == str2;
        }

        public static int StringCompareExx(string str1, string str2)
        {
            return String.Compare(str1, str2, true);
        }

        public static bool IsEmpty(string str)
        {
            return str.Length == 0;
        }

        public static void Main_5_4_6()//Main_5_4_6
        {
            Console.WriteLine(StringCompare("abc", "aBc"));
            Console.WriteLine(StringCompareExx("abc", "aBc"));
        }
    }
}
