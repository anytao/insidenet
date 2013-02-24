// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Memory.GC
// Release     : 2007/11/27 1.0
// Description : 5.3 垃圾回收

using System;
using System.Collections.Generic;
using System.Text;

namespace InsideDotNet.Memory.GC
{
    class A
    {
        private B objB;

        public A(B o)
        {
            objB = o;
        }

        ~A()
        {
            Console.WriteLine("Destory A.");
        }
    }

    class B
    {
        private C objC;

        public B(C o)
        {
            objC = o;
        }

        ~B()
        {
            Console.WriteLine("Destory B.");
        }
    }

    class C
    {
        ~C()
        {
            Console.WriteLine("Destory C.");
        }
    }

    class D : C
    {

    }

    public class Test_GCRun
    {
        public static void Main()//Main_5_3_1
        {
            //A a = new A(new B(new C()));
            D d = new D();

            //强制执行垃圾回收
            System.GC.Collect(0);
            System.GC.WaitForPendingFinalizers();
        }
    }
}
