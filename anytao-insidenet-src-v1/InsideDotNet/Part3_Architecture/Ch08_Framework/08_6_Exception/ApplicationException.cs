// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Framework.ExceptionEx
// Release     : 2007/11/06 1.0
// Description : 8.6 直面异常

using System;
using System.IO;

namespace InsideDotNet.Framework.ExceptionEx
{
    class ApplicationException
    {
        public static void Main_8_7_2()//Main_8_7_2
        {
            try
            {
                TestException();
            }
            catch (Exception ex)
            {
                //输出当前调用堆栈上的异常的抛出位置 
                Console.WriteLine(ex.StackTrace);
            }
        }

        private static void TestException()
        {
            //直接抛出异常
            throw new FileNotFoundException("Error.");
        }
    }
}
