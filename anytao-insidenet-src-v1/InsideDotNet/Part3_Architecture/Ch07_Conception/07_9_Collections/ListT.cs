// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.Conception.Collections
// Release     : 2007/11/10 1.0
// Description : 7.9 ����ͨ��--List<T>Ӧ��

using System;
using System.Collections.Generic;

namespace InsideDotNet.Conception.Collections
{
    class ListT
    {
        //List<T>�����Է���˵��
        public static void Main()//Main_7_9_1
        {
            List<Int32> nums = new List<int>();
            nums.Add(0);
            nums.Add(20);
            nums.Add(33);
            nums.Add(59);
            nums.Add(100);

            //����ָ����������ƥ��Ԫ��
            List<Int32> numTens = nums.FindAll(IsDivisionByTen);

            //ͨ��ForEach�����Լ��ϳ�Ա��������
            numTens.ForEach(Console.WriteLine);
        }

        //ָ���Ĳ�������
        private static bool IsDivisionByTen(int num)
        {
            if (num % 10 == 0)
                return true;
            else
                return false;
        }
    }
}
