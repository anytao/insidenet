// Copyright   : 你必须知道的.NET，第2版
// Author      : Anytao，http://www.anytao.com
// FileName    : Anytao.Inside.Ch14.TupleEx
// Release     : 2010/12/19 1.0
// Description : 14.8  Tuple一二

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anytao.Inside.Ch14.TupleEx
{
    class Program
    {
        static void Main(string[] args)
        {
            //var trest = Tuple.Create<int>(8);
            //var t8 = new Tuple<int, int, int, int, int, int, int, Tuple<int>>(1, 2, 3, 4, 5, 6, 7, trest);
            //Console.WriteLine(t8.Rest);

            //var t8 = Tuple.Create<int, int, int, int, int, int, int, int>(1, 2, 3, 4, 5, 6, 7, 8);
            //Console.WriteLine(t8.Rest);

            // IStructuralEquatable
            var t1 = Tuple.Create(1, "Hello");
            var t2 = Tuple.Create(1, "Hello");
            var t3 = Tuple.Create(2, "AT");

            Console.WriteLine(t1.Equals(t2));
            Console.WriteLine(t1.Equals(t3));


        }
    }
}
