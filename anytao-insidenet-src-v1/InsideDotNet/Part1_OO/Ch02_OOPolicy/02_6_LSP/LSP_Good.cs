// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.OOPolicy.LSP
// Release     : 2007/12/06 1.0
// Description : 2.6  Liskov替换原则

using System;
using System.Collections.Generic;
using System.Text;

namespace InsideDotNet.OOPolicy.LSP.Good
{
    class LSP_Good
    {
    }


    class FatherClass
    {
        public virtual void Method()
        {
            //父类的行为
            Console.WriteLine("Father Method.");
        }
    }

    class SonClass : FatherClass
    {
        public override void Method()
        {
            //子类的行为
            Console.WriteLine("Son Method.");
        }
    }

    class GrandsonClass : SonClass
    {
        public override void Method()
        {
            Console.WriteLine("Grandson Method.");
        }
    }

    class Test_LSP
    {
        public static void DoSomething(FatherClass f)
        {
            f.Method();
        }

        public static void Main_2_6_2()//Main_2_6_2
        {
            DoSomething(new SonClass());
            SonClass son = new SonClass();
            FatherClass father = son is FatherClass ? (FatherClass)son : null;
            father.Method();

            FatherClass f2 = new FatherClass();
            SonClass son2 = f2 is SonClass ? (SonClass)f2 : null;
            son2.Method();

        }
    }
}
