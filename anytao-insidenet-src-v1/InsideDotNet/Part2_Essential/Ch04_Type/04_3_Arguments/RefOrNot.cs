// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Type.Arguments
// Release     : 2007/07/06 1.0
// Description : 4.3  参数之惑---传递的艺术

using System;

namespace InsideDotNet.Type.Arguments
{
    class Test_Args
    {
        static void Main_4_3_2()//Main_4_3_2
        {
            int i = 100;
            string str = "One";
            ChangeByValue(ref i);
            ChangeByRef(ref str);
            Console.WriteLine(i);
            Console.WriteLine(str);
        }

        static void ChangeByValue(ref int iVlaue)
        {
            iVlaue = 200;
        }

        static void ChangeByRef(ref string sValue)
        {
            sValue = "One more.";
        }
    }
}
