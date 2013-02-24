// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.ILBasic.MethodInovation
// Release     : 2007/09/01 1.0
// Description : 3.5  经典指令解析之方法调度

using System;
using System.Collections.Generic;
using System.Text;

namespace InsideDotNet.ILBasic.MethodInovation
{
    public class Fathers
    {
        public void DoWork()
        {
            Console.WriteLine("Father.DoWork()");
        }

        public virtual void DoVirtualWork()
        {
            Console.WriteLine("Father.DoVirtualWork()");
        }
    }

    public class Sons : Fathers
    {
        public new void DoWork()
        {
            Console.WriteLine("Son.DoWork()");
        }

        public new virtual void DoVirtualWork()
        {
            base.DoVirtualWork();
            Console.WriteLine("Son.DoVirtualWork()");
        }

        //public virtual void M()
        //{
        //    Console.WriteLine("Tao is right.");
        //}
    }

    public class Grandsons : Sons
    {
        public override void DoVirtualWork()
        {
            base.DoVirtualWork();
            Console.WriteLine("GrandSon.DoVirtualWork()");
        }

        //public new void M()
        //{
        //    Console.WriteLine("Guan is right.");
        //}
    }

    public class Sonson : Sons
    {
        public override void DoVirtualWork()
        {
            base.DoVirtualWork();
        }
    }

    public class TestNew
    {
        public static void Main_3_5_1()//Main_3_5_1
        {
            Fathers person = new Grandsons();
            person.DoVirtualWork();


            Sons son = new Sons();
            son.DoVirtualWork();


            //Sons a = new Grandsons();
            //a.M();

            Console.Read();
        }
    }
}
