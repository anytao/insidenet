// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Framework.StringEx
// Release     : 2007/10/29 1.0
// Description : 8.3 如此特殊：大话String--String类型的参数传递

using System;

namespace InsideDotNet.Framework.StringEx
{
    class StringArgument
    {
        public static void Main_8_3_7()//Main_8_3_7
        {
            string strA = "String A";
            string strB = "String B";

            //参数为String类型的按值传递（strA）和按引用传递（strB）
            ChangeString(strA, ref strB);

            Console.WriteLine(strA);
            Console.WriteLine(strB);
        }

        private static void ChangeString(string stra, ref string strb)
        {
            stra = "Changing String A";
            strb = "Changing String B";
        }
    }
    //执行结果
    //String A
    //Changing String B

}
