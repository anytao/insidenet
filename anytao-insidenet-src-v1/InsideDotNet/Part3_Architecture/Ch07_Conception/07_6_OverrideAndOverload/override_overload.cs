// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Conception.OverrideAndOverload
// Release     : 2007/10/03 1.0
// Description : 7.6 貌合神离：覆写和重载

using System;
using System.Collections.Generic;
using System.Text;

namespace InsideDotNet.Conception.OverrideAndOverload
{
    class override_overload
    {
    }

    class Base
    {
        public virtual void MyFunc()
        {
            Console.WriteLine();
        }

        //以参数不同，virtual不足以区分
        public virtual void MyFunc(string str)
        {
            Console.WriteLine("{0} in Base", str);
        }

        //参数列表不同，返回值不同
        public bool MyFunc(string str, int id)
        {
            Console.WriteLine("AAA");
            return true;
        }

        //参数列表不同表现为个数不同，或者相同位置的参数类型不同 
        public bool MyFunc(int id, string str)
        {
            Console.WriteLine("BBB");
            return false;
        }

        //泛型重载，允许参数列表相同
        public bool MyFunc<T>(string str, int id)
        {
            Console.WriteLine();
            return true;
        }

        //定义抽象方法
        //public abstract void Func();
    }

    class Derived : Base
    {
        //阻隔父类成员
        public new void MyFunc()
        {
        }

        //覆写基类成员
        public new void MyFunc(string str)
        {
            //在子类中访问父类成员
            //base.MyFunc(str);
            Console.WriteLine("{0} in Derived", str);
        }

        //覆写基类抽象方法
        //public override void Func()
        //{
        //    //base.Func();
        //    //throw new Exception("The method or operation is not implemented.");
        //}

        public static void Main()//Main_7_6_1
        {
            Base B = new Base();
            B.MyFunc("Hello");
            Derived A = new Derived();
            B = A;
            B.MyFunc("Morning");
        }

        public static void Main_7_6_2()//Main_7_6_2
        {
            Base bd = new Derived();
            bd.MyFunc("Hello");
            bd.MyFunc<int>("111", 111);
        }
    }

    class Test_override_overload
    {

    }
}
