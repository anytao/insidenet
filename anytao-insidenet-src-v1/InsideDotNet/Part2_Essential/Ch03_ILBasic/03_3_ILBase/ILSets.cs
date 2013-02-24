// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.ILBasic.ILBase
// Release     : 2007/09/09 1.0
// Description : 3.3  教你认识IL代码--- IL语言基础

using System;
using System.Collections.Generic;
using System.Text;

namespace InsideDotNet.ILBasic.ILBase
{
    class ILsetsTest
    {
        public static void Main()
        {
            int i = 2;
            string str = "Hello";
            char c = 'A';
        }
    }

    class IL_Operation
    {
        public static void Main3_3_2()
        {
            int x = 10;
            int y = 8;
            Console.WriteLine(x + y);
            Console.WriteLine(x - y);
            Console.WriteLine(x * y);
            //Console.Read();
        }
    }

    class IL_Loop
    {
        public static void Main3_3_3()
        {
            int x = 10;
            int y = 6;
            if (x > y)
                Console.WriteLine(x);
            else
                Console.WriteLine(y);
            Console.Read();
        }
    }
}
