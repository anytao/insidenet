// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Memory.Performance
// Release     : 2007/11/30 1.0
// Description : 5.4 性能控制的多方探讨

using System;
using System.IO;

namespace InsideDotNet.Memory.Performance
{
    class ExceptionPerformance
    {
        public class My
        {
            public void Close()
            {
            }
        }
        public static void Main_5_4_4()//Main_5_4_4
        {
            object obj = new object();
            //obj = null;////

            Console.WriteLine(obj == null ? String.Empty : obj.ToString());

            try
            {
                Console.WriteLine(obj.ToString());
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
