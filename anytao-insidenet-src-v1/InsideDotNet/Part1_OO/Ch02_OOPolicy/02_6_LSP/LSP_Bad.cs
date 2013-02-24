// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.OOPolicy.LSP
// Release     : 2007/12/06 1.0
// Description : 2.6  Liskov�滻ԭ��

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

        //���෽��
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
        //������ڸ��಻���еķ���
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
