// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Memory.Performance
// Release     : 2007/12/01 1.0
// Description : 5.4 性能控制的多方探讨

using System;
using System.Collections.Generic;
using System.Text;

namespace InsideDotNet.Memory.Performance
{
    class TypeCastEx
    {
        public static void Main_5_4_7()//Main_5_4_7
        {
            MyClass mc = new MyClass();
            if (mc is MyClass)
            {
                Console.WriteLine("mc is a MyClass object.");
            }

            object o = new object();
            MyClass mc2 = o as MyClass;

            if (mc2 != null)
            {
                //对转换类型对象执行操作
            }
        }


    }
}
