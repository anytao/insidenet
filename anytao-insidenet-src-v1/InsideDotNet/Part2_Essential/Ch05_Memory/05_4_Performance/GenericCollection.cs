// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.Memory.Performance
// Release     : 2007/11/30 1.0
// Description : 5.4 ���ܿ��ƵĶ෽̽��

using System;
using System.Collections.Generic;
using System.Collections;

namespace InsideDotNet.Memory.Performance
{
    class GenericCollection
    {
        public static void Main()//Main_5_4_1
        {
            //List<T>���ܲ���
            List<Int32> list = new List<Int32>();
            for (Int32 i = 0; i < 10000; i++)
                //δ����װ��
                list.Add(i);

            //ArrayList���ܲ���
            ArrayList al = new ArrayList();
            for (Int32 j = 0; j < 10000; j++)
                //����װ��
                al.Add(j);
        }
    }
}
