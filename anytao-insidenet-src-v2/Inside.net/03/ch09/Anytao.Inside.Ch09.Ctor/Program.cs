// Copyright   : 你必须知道的.NET，第2版
// Author      : Anytao，http://www.anytao.com
// FileName    : Anytao.Inside.Ch09.Ctor
// Release     : 2010/08/12 1.0
// Description : 9.4  给力细节：深入类型构造器

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anytao.Inside.Ch09.Ctor
{

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Start ...");
            Foo.GetString("Manually invoke the static GetString() method!");

            //string field = Foo.Field;
        }
    }

    class Foo
    {
        public static string Field = GetString("Initialize the static field!");

        // ...

        static Foo() { }

        public static string GetString(string s)
        {
            Console.WriteLine(s);
            return s;
        }
    }
}
