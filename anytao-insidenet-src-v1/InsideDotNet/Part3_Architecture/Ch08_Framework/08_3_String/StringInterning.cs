// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Framework.StringEx
// Release     : 2007/10/28 1.0
// Description : 8.3 如此特殊：大话String--字符串驻留

using System;

namespace InsideDotNet.Framework.StringEx
{
    class StringInterning
    {
        public static void Main_8_3_4()//Main_8_3_4
        {
            string strA = "abcdef";
            string strB = "abcdef";
            Console.WriteLine(ReferenceEquals(strA, strB));
            string strC = "abc";
            string strD = strC + "def";
            Console.WriteLine(ReferenceEquals(strA, strD));
            strD = String.Intern(strD);
            Console.WriteLine(ReferenceEquals(strA, strD));

            string strE = "abc" + "def";
            Console.WriteLine(ReferenceEquals(strA, strE));
        }

        public static void Main_8_3_5()//Main_8_3_5
        {
            string strA = "abcdef";
            string strC = "abc";
            string strD = strC + "def";
            Console.WriteLine(ReferenceEquals(strA, strD));

            string strE = "abc" + "def";
            Console.WriteLine(ReferenceEquals(strA, strE));

        }
    }
    //执行结果：
    //True
    //False
    //True
    //public static string Intern(string str);
    //public static string IsInterned(string str);

}
