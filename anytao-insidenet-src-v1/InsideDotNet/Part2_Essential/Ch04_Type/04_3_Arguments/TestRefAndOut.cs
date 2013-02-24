// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Type.Arguments
// Release     : 2007/07/03 1.0
// Description : 4.3  参数之惑---传递的艺术

using System;

namespace InsideDotNet.Type.Arguments
{
    class Test_RefAndOut
    {
        static void ShowInfo(string str)
        {
            Console.WriteLine(str);
        }

        static void ShowInfo(ref string str)
        {
            Console.WriteLine(str);
        }

        //ShowInfo不能定义仅在 ref 和 out 上有差别的重载方法
        //static void ShowInfo(out string str)
        //{
        //    str = "Hello, anytao.";
        //    Console.WriteLine(str);
        //}
    }
}
