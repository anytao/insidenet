// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.Conception.ClassAndStruct
// Release     : 2007/12/23 1.0
// Description : 7.2  �������ϣ�class��struct

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
            ms.name = "С��";
            Console.WriteLine(ms.i);
            //������������ֶεĳ�ʼ�������ܵ���ShowMsg() 
            ms.ShowMsg();
        }
    }

}
