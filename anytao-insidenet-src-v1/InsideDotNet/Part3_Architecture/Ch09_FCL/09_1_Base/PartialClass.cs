// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.FCL.Base
// Release     : 2007/11/19 1.0
// Description : 9.1  ����---.NET��ܸ���--������Ӧ��

using System;
using System.Collections.Generic;
using System.Text;

namespace InsideDotNet.FCL.Base
{
    class PartialClass
    {
        public static void Main()//Main_9_1_1
        {
            HelloWorld hw = new HelloWorld();
            hw.SayHello();
        }
    }

    public partial class HelloWorld
    {
        public void SayHello()
        {
            Console.WriteLine("Hello!");
        }
    }
}
