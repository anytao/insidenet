// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.Keyword.SubKeyword
// Release     : 2007/11/23 1.0
// Description : 6.6 �������ؼ���--checked/unchecked�ؼ��ַ���

using System;
using System.Collections.Generic;
using System.Text;

namespace InsideDotNet.Keyword.SubKeyword
{
    class CheckedEx
    {
        public static void Main()//Main_6_6_1
        {
            byte a = 100;
            byte b = 200;
            Console.WriteLine(CheckSum(a, b));

            Int32 i = 256;
            Console.WriteLine(UncheckCast(i));

            //checked���
            checked
            {
                byte c = (byte)(i + a);
                Console.WriteLine(c);
            }

            checked
            {
                UncheckCast(1000);
            }
        }

        private static byte CheckSum(byte a, byte b)
        {
            byte c = 0;
            try
            {
                //����������
                c = checked((byte)(a + b));
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return c;
        }

        private static byte UncheckCast(Int32 i)
        {
            //������������
            return unchecked((byte)i);
        }
    }
}
