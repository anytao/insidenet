// Copyright   : 你必须知道的.NET，第2版
// Author      : Anytao，http://www.anytao.com
// FileName    : Anytao.Inside.Ch14.Lazy
// Release     : 2010/12/08 1.0
// Description : 14.7  Lazy<T>点滴

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anytao.Inside.Ch14.Lazy
{
    class Program
    {
        static void Main(string[] args)
        {
            Lazy<Big> lazyBig = new Lazy<Big>();

            Console.WriteLine(lazyBig.Value.ID);
        }

        static void Main2(string[] args)
        {
            // Lazy<Big> lazyBig = new Lazy<Big>();
            Lazy<Big> lazyBig = new Lazy<Big>(() => new Big(100));

            Console.WriteLine(lazyBig.Value.ID);
        }

        static void Main3(string[] args)
        {
            Lazy<Big> lazyBig = new Lazy<Big>(() => BigFactory.Build());

            Console.WriteLine(lazyBig.Value.ID);
        }

        static void Main4()
        {
            Console.WriteLine(LazySingleton.Instance.ToString());
        }

        static void Main5()
        {
            MyLazy<Big> myLazy = new MyLazy<Big>(() => BigFactory.Build());

            Console.WriteLine(myLazy.Value.ID);

            Console.WriteLine(myLazy.Value.ID);
        }
    }
}
