// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Conception.ClassAndStruct
// Release     : 2007/12/23 1.0
// Description : 7.2  后来居上：class和struct

using System;
using System.Collections.Generic;
using System.Text;

namespace InsideDotNet.Conception.ClassAndStruct
{
    class StructEx
    {
    }

    struct MyStruct
    {
        public int i;
        public string name;

        public void ShowMsg()
        {
            Console.WriteLine("Hello");
        }
    }

    public class Test_Struct
    {
        public static void Main_7_2_2()//Main_7_2_2
        {
            MyStruct ms;
            ms.i = 10;
            ms.name = "小王";
            Console.WriteLine(ms.i);
            //必须完成所有字段的初始化，才能调用ShowMsg() 
            ms.ShowMsg();
        }
    }

}
