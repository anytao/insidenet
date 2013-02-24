// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Framework.ExceptionEx
// Release     : 2007/11/08 1.0
// Description : 8.6 直面异常

using System;
using System.Collections;

namespace InsideDotNet.Framework.ExceptionEx
{
    class TryParseEx
    {
        public static void Main_8_7_3()//Main_8_7_3
        {
            DateTime now;
            if (DateTime.TryParse("2007/11/7 23:31:00", out now))
            {
                Console.WriteLine("Now it's {0}", now);
            }
        }
    }
}
