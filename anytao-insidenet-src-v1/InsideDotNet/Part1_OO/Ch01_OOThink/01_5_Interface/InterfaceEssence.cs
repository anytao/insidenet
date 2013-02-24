// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.OOThink.Interface
// Release     : 2007/12/20 1.0
// Description : 1.5 玩转接口

using System;

namespace InsideDotNet.OOThink.Interface
{
    class InterfaceEssence
    {
    }


    interface IMyInterface
    {
        void MyMethod();
    }


    //.class private interface abstract auto ansi IMyInterface
    //{
    //    .method public hidebysig newslot abstract virtual instance void MyMethod() cil managed
    //    {
    //    }
    //} 


    class MyClass : IMyInterface
    {
        void IMyInterface.MyMethod()
        {
        }

        public void MyMethod()
        {
        }
    }

    //.class private auto ansi beforefieldinit MyClass
    //    extends [mscorlib]System.Object
    //    implements InsideDotNet.OOThink._1_5_Interface.IMyInterface
    //{
    //    .method public hidebysig specialname rtspecialname instance void .ctor() cil managed
    //    {
    //    }

    //    .method private hidebysig newslot virtual final instance void InsideDotNet.OOThink._1_5_Interface.IMyInterface.MyMethod() cil managed
    //    {
    //        .override InsideDotNet.OOThink._1_5_Interface.IMyInterface::MyMethod
    //    }

    //    .method public hidebysig instance void MyMethod() cil managed
    //    {
    //    }

    //}

    class Test_Interface
    {
        public static void Main()//Main_1_5_3
        {
            MyClass mc = new MyClass();
            ((IMyInterface)mc).MyMethod();
            mc.MyMethod();
        }
    }
}
