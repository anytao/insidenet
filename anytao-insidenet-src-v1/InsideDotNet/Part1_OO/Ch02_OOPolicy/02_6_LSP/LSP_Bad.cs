// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.OOPolicy.LSP
// Release     : 2007/12/06 1.0
// Description : 2.6  Liskov替换原则

using System;
using System.Collections.Generic;
using System.Text;

namespace InsideDotNet.OOPolicy.LSP
{
    class LSP_Bad
    {
    }


    class FatherClass
    {
        public string Type;

        //父类方法
        public void Method()
        {
            Console.WriteLine("Father Method.");
        }

        public FatherClass()
        {
            Type = "FatherClass";
        }
    }

    class SonClass : FatherClass
    {
        //子类存在父类不具有的方法
        public void SonMethod()
        {
            Console.WriteLine("Son Method.");
        }

        public SonClass()
        {
            Type = "SonClass";
        }
    }

    class GrandsonClass : SonClass
    {
        public void GrandsonMethod()
        {
            Console.WriteLine("Grandson Method.");
        }
    }

    class Test_LSP
    {
        public static void DoSomething(FatherClass f)
        {
            switch (f.Type)
            {
                case "FatherClass":
                    f.Method();
                    break;
                case "SonClass":
                    ((SonClass)f).SonMethod();
                    break;
                case "GrandsonClass":
                    ((GrandsonClass)f).GrandsonMethod();
                    break;
            }
        }

        public static void Main()//Main_2_6_1
        {
            DoSomething(new FatherClass());
        }
    }
}
