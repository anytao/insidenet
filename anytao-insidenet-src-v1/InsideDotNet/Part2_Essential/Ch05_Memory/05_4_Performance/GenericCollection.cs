// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Memory.Performance
// Release     : 2007/11/30 1.0
// Description : 5.4 性能控制的多方探讨

using System;
using System.Collections.Generic;
using System.Collections;

namespace InsideDotNet.Memory.Performance
{
    class GenericCollection
    {
        public static void Main()//Main_5_4_1
        {
            //List<T>性能测试
            List<Int32> list = new List<Int32>();
            for (Int32 i = 0; i < 10000; i++)
                //未发生装箱
                list.Add(i);

            //ArrayList性能测试
            ArrayList al = new ArrayList();
            for (Int32 j = 0; j < 10000; j++)
                //发生装箱
                al.Add(j);
        }
    }
}
