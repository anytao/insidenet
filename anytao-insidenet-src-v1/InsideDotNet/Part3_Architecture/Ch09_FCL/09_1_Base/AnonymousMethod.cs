// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.FCL.Base
// Release     : 2007/11/19 1.0
// Description : 9.1  基础---.NET框架概览--匿名方法应用

using System;
using System.Collections.Generic;
using System.Text;

namespace InsideDotNet.FCL.Base
{
    class AnonymousMethodEx
    {
        delegate void MyDelegate();

        public void InvokeHello()
        {
            MyDelegate myDelegate = delegate()
            {
                Console.WriteLine("Hello, world.");
            };

            myDelegate();
        }

        public static void Main_9_1_2()//Main_9_1_2
        {
            AnonymousMethodEx am = new AnonymousMethodEx();
            am.InvokeHello();

        }
    }
}
