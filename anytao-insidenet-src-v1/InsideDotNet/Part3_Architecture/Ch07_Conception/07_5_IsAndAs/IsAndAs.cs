// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Conception.IsAndAs
// Release     : 2007/04/07 1.0
// Description : 7.5  恩怨情仇：is和as

using System;
using System.Collections.Generic;
using System.Text;

namespace InsideDotNet.Conception.IsAndAs
{
    class ISSample
    {
        public static void Main()//Main_7_5_1
        {
            object o = new object();

            //执行第一次类型兼容性检查
            if (o is ISSample)
            {
                //执行第二次类型兼容性检查
                ISSample a = (ISSample)o;
            }
        }
    }

    class ASSample
    {
        public static void Main_7_5_2()//Main_7_5_2
        {
            object o = new object();

            //执行一次类型兼容检查
            ASSample b = o as ASSample;
            //ASSample b = o is ASSample ? (ASSample)o : null;
            if (b != null)
            {
                //执行关于b的操作
            }

        }
    }

    class IsAndAs
    {

    }
}
