// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.Framework.Equals
// Release     : 2007/10/25 1.0
// Description : 8.2 ��������������е�

using System;

namespace InsideDotNet.Framework.Equals
{
    class ReferenceEqualEx
    {
        public static void Main()//Main_8_2_1
        {
            string strA = "ABCDEF";
            string strB = "ABCDEF";

            Console.WriteLine(ReferenceEquals(strA, strB));
        }
        //ִ�н����True
    }
}
