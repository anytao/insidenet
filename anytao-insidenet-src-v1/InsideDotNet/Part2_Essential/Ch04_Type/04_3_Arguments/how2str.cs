// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Type.Arguments
// Release     : 2007/07/05 1.0
// Description : 4.3  参数之惑---传递的艺术

using System;

namespace InsideDotNet.Type.Arguments
{
    class StringArgs
    {
        static void Main()//Main_4_3_2
        {
            string str = "Old String";
            ChangeStr(str);
            Console.WriteLine(str);
        }

        static void ChangeStr(string aStr)
        {
            aStr = "Changing String";
            Console.WriteLine(aStr);
        }

        //static void ShowInfo(string aStr){//...}
    }
}