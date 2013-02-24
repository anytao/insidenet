// Copyright   : 你必须知道的.NET，第2版
// Author      : Anytao，http://www.anytao.com
// FileName    : Anytao.Inside.Ch03.Closure.Program
// Release     : 2011/03/23 1.0
// Description : 3.5  也谈.NET闭包

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anytao.Inside.Ch03.Closure
{
    class Program
    {
        delegate void MessageDelegate();

        static void Main1(string[] args)
        {
            string value = "Hello, Closure.";

            MessageDelegate message = delegate()
            {
                Show(value);
            };

            message();
        }

        private static void Show(string message)
        {
            Console.WriteLine(message);
        }

        static void Main2()
        {
            int value = 100;

            IList<Func<int>> funcs = new List<Func<int>>();
            funcs.Add(() => value + 1);
            funcs.Add(() => value - 2);

            foreach (var f in funcs)
            {
                //int v = value;
                //value = f();
                int v = f();
                Console.WriteLine(v);
            }
        }

        static void Main3()
        {
            int[] values = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int result1 = 0;
            int result2 = 100;

            values.ForEach(x => result1 += x);
            values.ForEach(x => result2 -= x);

            Console.WriteLine(result1);
            Console.WriteLine(result2);
        }

        static void Main()
        {
            IList<Action> actions = new List<Action>();

            for (int i = 1; i < 5; i++)
            {
                int v = i;
                actions.Add(() => Console.WriteLine(v));
            }

            actions.ForEach(x => x());
        }
    }

    public static class IEnumerableExtension
    {
        public static void ForEach<T>(this IEnumerable<T> source, Action<T> func)
        {
            foreach (var item in source)
            {
                func(item);
            }
        }

    }
}
