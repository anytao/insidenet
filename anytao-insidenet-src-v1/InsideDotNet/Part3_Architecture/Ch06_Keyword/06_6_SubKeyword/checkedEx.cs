// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Keyword.SubKeyword
// Release     : 2007/11/23 1.0
// Description : 6.6 非主流关键字--checked/unchecked关键字分析

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

            //checked语句
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
                //进行溢出检查
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
            //不进行溢出检查
            return unchecked((byte)i);
        }
    }
}
