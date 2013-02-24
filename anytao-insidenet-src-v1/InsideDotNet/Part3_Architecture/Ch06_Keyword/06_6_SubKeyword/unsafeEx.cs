// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Keyword.SubKeyword
// Release     : 2007/11/24 1.0
// Description : 6.6 非主流关键字--unsafe关键字分析

using System;

namespace InsideDotNet.Keyword.SubKeyword
{
    public struct MyStruct
    {
        public int a;
        public int b;
    }

    class unsafeEx
    {
        public static unsafe void Main_6_6_7()//Main_6_6_7
        {
            MyStruct ms = new MyStruct();
            //获取MyStruct的首地址
            Console.WriteLine((uint)&ms);
            //获取值类型的大小
            Console.WriteLine(sizeof(MyStruct));
            //在堆栈上分配内存空间
            int* p = stackalloc int[10];
            *p = 100;
            Console.WriteLine(*p);
        }
    }
}
