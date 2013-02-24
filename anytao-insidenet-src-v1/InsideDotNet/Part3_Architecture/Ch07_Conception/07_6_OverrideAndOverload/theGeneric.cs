// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Conception.OverrideAndOverload
// Release     : 2007/10/04 1.0
// Description : 7.6 貌合神离：覆写和重载

using System;
using System.Collections.Generic;
using System.Text;

namespace InsideDotNet.Conception.OverrideAndOverload
{
    class theGeneric
    {
    }

    class BaseClass
    {
        //public virtual T MyFunc<T, U>(T t, U u) where U : T
        //{
        //}

        //public virtual T MyFunction<T t>where U: IComparable;

        public virtual void MyFunc<T>(T t) where T : new()
        {
            Console.WriteLine("{0} in Base", t.ToString());
        }

        public void MyFunc(string t)
        {
            Console.WriteLine(t);
        }

        ////不可构成重载的情况
        //public void MyFunc<T>(T t);
        //public void MyFunc<U>(U u);

        //public void MyFunc<T>(T t) where T : A;
        //public void MyFunc<T>(T t) where T : B;
    }

    class DerivedClass : BaseClass
    {
        public override void MyFunc<T>(T t)
        {
            Console.WriteLine("{0} in Derived", t.ToString());
        }

        public static void Main_7_6_3()//Main_7_6_3
        {
            BaseClass b = new DerivedClass();
            b.MyFunc<int>(100);
            b.MyFunc<char>('A');
            //b.MyFunc<string>("Hello");
            BaseClass c = new BaseClass();
            c.MyFunc<int>(100);
            c.MyFunc("100");
        }
    }
}
