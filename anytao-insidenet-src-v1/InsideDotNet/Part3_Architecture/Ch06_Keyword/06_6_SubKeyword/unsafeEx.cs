// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.Keyword.SubKeyword
// Release     : 2007/11/24 1.0
// Description : 6.6 �������ؼ���--unsafe�ؼ��ַ���

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
            //��ȡMyStruct���׵�ַ
            Console.WriteLine((uint)&ms);
            //��ȡֵ���͵Ĵ�С
            Console.WriteLine(sizeof(MyStruct));
            //�ڶ�ջ�Ϸ����ڴ�ռ�
            int* p = stackalloc int[10];
            *p = 100;
            Console.WriteLine(*p);
        }
    }
}
