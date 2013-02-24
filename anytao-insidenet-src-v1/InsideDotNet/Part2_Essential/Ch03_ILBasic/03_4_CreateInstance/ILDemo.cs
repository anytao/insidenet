// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.ILBasic.CreateInstance
// Release     : 2007/07/01 1.0
// Description : 3.4 经典指令解析之实例创建--- newobj、initobj、Newarr、ldstr

using System;

namespace InsideDotNet.ILBasic.CreateInstance
{
    struct MyStruct
    {
    }

    class MyClass
    {
    }

    class ILDemo
    {
        public static void Main()//Main_3_4_1
        {
            MyStruct ms = new MyStruct();
            MyClass mc = new MyClass();
            Console.WriteLine("IL Keywords.");
            Console.Read();
        }
    }
}
