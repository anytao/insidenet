// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.Framework.StringEx
// Release     : 2007/10/29 1.0
// Description : 8.3 ������⣺��String--String���͵Ĳ�������

using System;

namespace InsideDotNet.Framework.StringEx
{
    class StringArgument
    {
        public static void Main_8_3_7()//Main_8_3_7
        {
            string strA = "String A";
            string strB = "String B";

            //����ΪString���͵İ�ֵ���ݣ�strA���Ͱ����ô��ݣ�strB��
            ChangeString(strA, ref strB);

            Console.WriteLine(strA);
            Console.WriteLine(strB);
        }

        private static void ChangeString(string stra, ref string strb)
        {
            stra = "Changing String A";
            strb = "Changing String B";
        }
    }
    //ִ�н��
    //String A
    //Changing String B

}
