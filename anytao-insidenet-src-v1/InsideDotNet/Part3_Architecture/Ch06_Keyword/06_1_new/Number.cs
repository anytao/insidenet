// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Keyword.New
// Release     : 2007/04/28 1.0
// Description : 6.1  把new说透

using System;

namespace InsideDotNet.Keywords.New
{

    class MyC
    {
    }

    class Number
    {
        public static int i = 123;

        public virtual void ShowInfo()
        {
            Console.WriteLine("base class---");
        }

        public virtual void ShowNumber()
        {
            Console.WriteLine(i.ToString());
        }
    }

    class IntNumber : Number
    {
        new public static int i = 456;

        public new virtual void ShowInfo()
        {
            Console.WriteLine("Derived class---");
        }

        public override void ShowNumber()
        {
            Console.WriteLine("Base number is {0}", Number.i.ToString());
            Console.WriteLine("New number is {0}", i.ToString());
        }
    }

    class Test_Number
    {
        public static void Main()//Main_6_1_1
        {
            Number num = new Number();
            num.ShowNumber();
            IntNumber intNum = new IntNumber();
            intNum.ShowNumber();
            intNum.ShowInfo();

            Number number = new IntNumber();
            //究竟调用了谁？
            number.ShowInfo();
            //究竟调用了谁？
            number.ShowNumber();
        }
    }
}


