// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.Memory.Performance
// Release     : 2007/12/01 1.0
// Description : 5.4 ���ܿ��ƵĶ෽̽��

using System;
using System.Collections.Generic;
using System.Text;

namespace InsideDotNet.Memory.Performance
{
    class TypeCastEx
    {
        public static void Main_5_4_7()//Main_5_4_7
        {
            MyClass mc = new MyClass();
            if (mc is MyClass)
            {
                Console.WriteLine("mc is a MyClass object.");
            }

            object o = new object();
            MyClass mc2 = o as MyClass;

            if (mc2 != null)
            {
                //��ת�����Ͷ���ִ�в���
            }
        }


    }
}
