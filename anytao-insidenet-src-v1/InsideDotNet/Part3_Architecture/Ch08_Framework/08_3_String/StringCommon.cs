// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.Framework.StringEx
// Release     : 2007/10/29 1.0
// Description : 8.3 ������⣺��String--String���͵ĳ��ò���

using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace InsideDotNet.Framework.StringEx
{
    class StringCommon
    {
        public static void Main_8_3_6()//Main_8_3_6
        {
            //C#�е�ת���ַ�
            string strName = "Name:\n\t\"С��\"";

            //C#�е������ַ���
            string strPath = @"C:\Program Files\Anytao\'Mynet.exe";
            string strPath2 = "C:\\Program Files\\Anytao\\Mynet.exe";

            Console.WriteLine(strName);
        }
    }
}
