// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Framework.StringEx
// Release     : 2007/10/29 1.0
// Description : 8.3 如此特殊：大话String--String类型的常用操作

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
            //C#中的转义字符
            string strName = "Name:\n\t\"小雨\"";

            //C#中的字面字符串
            string strPath = @"C:\Program Files\Anytao\'Mynet.exe";
            string strPath2 = "C:\\Program Files\\Anytao\\Mynet.exe";

            Console.WriteLine(strName);
        }
    }
}
