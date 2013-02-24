// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Framework.StringEx
// Release     : 2007/10/27 1.0
// Description : 8.3 如此特殊：大话String

using System;
using System.Collections.Generic;
using System.Text;

namespace InsideDotNet.Framework.StringEx
{
    class CreateString
    {
        public static void Main_8_3_2()//Main_8_3_2
        {
            string mystr = "Hello";
            //String mystr2 = new String("Hello");
            Char[] cs = { 'a', 'b', 'c' };
            String strArr = new String(cs);
            Console.WriteLine(strArr);
        }
    }

    class StringImmutability
    {
        public static void Main_8_3_3()//Main_8_3_3
        {
            string str = "This is a test about immutablitity of string type.";
            Console.WriteLine(str.Insert(0, "Hi, ").Substring(19).ToUpper());
            Console.WriteLine(str);
        }
    }
}
