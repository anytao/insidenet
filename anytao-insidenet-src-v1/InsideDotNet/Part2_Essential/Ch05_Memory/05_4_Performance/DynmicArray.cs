// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.Memory.Performance
// Release     : 2007/11/30 1.0
// Description : 5.4 ���ܿ��ƵĶ෽̽��

using System;
using System.Collections;

namespace InsideDotNet.Memory.Performance
{
    class DynmicArray
    {
        public static void Main_5_4_2()//Main_5_4_2
        {
            ArrayList al = new ArrayList(2);
            al.Add("One");
            al.Add("Two");
            //������̬����һ��
            al.Add("Three");

            Console.WriteLine(al.Capacity);
        }
    }
}
