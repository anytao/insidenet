// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Framework.Equals
// Release     : 2007/10/25 1.0
// Description : 8.2 规则而定：对象判等

using System;

namespace InsideDotNet.Framework.Equals
{
    class ReferenceEqualEx
    {
        public static void Main()//Main_8_2_1
        {
            string strA = "ABCDEF";
            string strB = "ABCDEF";

            Console.WriteLine(ReferenceEquals(strA, strB));
        }
        //执行结果：True
    }
}
