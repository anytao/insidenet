// Copyright   : 你必须知道的.NET，第2版
// Author      : Anytao，http://www.anytao.com
// FileName    : Anytao.Inside.Ch11.BestGeneric
// Release     : 2011/03/10 1.0
// Description : 11.4  实践泛型

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anytao.Inside.Ch11.BestGeneric
{
    public class Utils
    {
        public static void Swap(ref object obj1, ref object obj2)
        {
            object temp = obj1;
            obj1 = obj2;
            obj2 = temp;
        }

        public static void Swap<T>(ref T t1, ref T t2)
        {
            T temp = t1;
            t1 = t2;
            t2 = temp;
        }
    }
}
