// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.FCL.Root
// Release     : 2007/11/20 1.0
// Description : 9.3 根基---System命名空间--Convert简介

using System;

namespace InsideDotNet.FCL.Root
{
    class ConvertEx
    {
        public static void Main()//Main_9_3_1
        {
            try
            {
                double num = 123.456789;
                //正常转换，返回为"123.456789"
                string str = Convert.ToString(num);
                //转换发生精度损失，返回为123
                Int32 iNum = Convert.ToInt32(num);
                //无效转换，引发异常
                DateTime dt = Convert.ToDateTime(num);

            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine("发生无效转换。");
            }
        }
    }
}
