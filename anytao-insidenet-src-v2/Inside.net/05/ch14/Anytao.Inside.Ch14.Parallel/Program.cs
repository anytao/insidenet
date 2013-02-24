// Copyright   : 你必须知道的.NET，第2版
// Author      : Anytao，http://www.anytao.com
// FileName    : Anytao.Inside.Ch14.ParallelEx
// Release     : 2010/12/15 1.0
// Description : 14.4  趋势必行，并行计算

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Anytao.Inside.Ch14.ParallelEx
{
    class Program
    {
        static void Main1(string[] args)
        {
            DoForeach();

            //DoInvoke();

            //DoTasks();

            // DoWithDegree();
        }

        static void Main()
        {
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId.ToString());
        }


        public static void DoForeach()
        {
            List<int> list = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                list.Add(i);
            }

            DateTime dt = DateTime.Now;

            //foreach (var x in list)
            //{
            //    System.Threading.Thread.Sleep(100);
            //    Console.WriteLine(x);
            //}

            var ls = list.Select(x => x + 10);
            var ls2 = list.AsParallel().Select(x => x + 10);

            foreach (var item in ls2)
            {
                Console.WriteLine(item);
            }

            //Task.Factory.StartNew(() => Console.WriteLine("Hello."));

            //Parallel.ForEach(list, x =>
            //{
            //    System.Threading.Thread.Sleep(100);

            //    Console.WriteLine(x);
            //});

            //double time = (DateTime.Now - dt).TotalMilliseconds;

            //Console.WriteLine(time);
            //Console.Read();

        }

        public static void DoInvoke()
        {
            Parallel.Invoke(
                () => Console.WriteLine("Run task A"),
                () => Console.WriteLine("Run task B"),
                () => Console.WriteLine("Run task C")
                );
        }

        public static void DoTasks()
        {
            Task[] tasks = new Task[] 
            {
                Task.Factory.StartNew(() => Console.WriteLine("Run task A")),
                Task.Factory.StartNew(() => Console.WriteLine("Run task B")),
                Task.Factory.StartNew(() => Console.WriteLine("Run task C"))
            };

            Task.WaitAll(tasks);
            Console.WriteLine("Task Finished.");
        }

        public static void DoWithDegree()
        {
            var list = Enumerable.Range(1, 10000).AsParallel().WithDegreeOfParallelism(4);

            Console.WriteLine();
        }
    }

    public class TreeWalk
    {
        static void Main5()
        {
            Tree<MyClass> tree = new Tree<MyClass>();
            tree.Data = new MyClass() { Name = "Tree", Number = 1 };

            Tree<MyClass> left = new Tree<MyClass>();
            left.Data = new MyClass() { Name = "Left", Number = 1 };
            tree.Left = left;

            // ...populate tree (left as an exercise)

            // Define the Action to perform on each node.
            Action<MyClass> myAction = x => Console.WriteLine("{0} : {1}", x.Name, x.Number);

            // Traverse the tree with parallel tasks.
            ProcessTree(tree, myAction);
        }

        private static object Process()
        {
            throw new NotImplementedException();
        }

        public class MyClass
        {
            public string Name { get; set; }
            public int Number { get; set; }
        }

        public class Tree<T>
        {
            public Tree<T> Left;
            public Tree<T> Right;
            public T Data;
        }

        // By using tasks explcitly.
        public static void ProcessTree<T>(Tree<T> tree, Action<T> action)
        {
            if (tree == null)
            {
                return;
            }

            var left = Task.Factory.StartNew(() => ProcessTree(tree.Left, action));
            var right = Task.Factory.StartNew(() => ProcessTree(tree.Right, action));

            action(tree.Data);

            try
            {
                Task.WaitAll(left, right);
            }
            catch (AggregateException ae)
            {
                ae.Handle((x) =>
                    {
                        if (x is ATException)
                        {
                            Console.WriteLine("App exception, please contact administrator.");
                            return true;
                        }

                        return false;
                    });

            }
        }

    }
}
