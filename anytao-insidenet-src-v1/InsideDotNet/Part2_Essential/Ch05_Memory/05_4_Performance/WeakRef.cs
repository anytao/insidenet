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
    public class MyClass
    {
    }

    class WeakRefEx
    {
        public void WeakRef()
        {
            MyClass mc = new MyClass();

            //创建短弱引用
            WeakReference wr = new WeakReference(mc);
            //移除强引用
            mc = null;

            if (wr.IsAlive)
            {
                //弱引用转换为强引用，对象可以再次使用
                mc = wr.Target as MyClass;
            }
            else
            {
                //对象已经被回收，重新创建
                mc = new MyClass();
            }
        }
    }
}
