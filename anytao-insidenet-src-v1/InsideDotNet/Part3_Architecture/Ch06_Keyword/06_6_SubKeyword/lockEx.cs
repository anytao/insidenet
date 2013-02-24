// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Keyword.SubKeyword
// Release     : 2007/11/24 1.0
// Description : 6.6 非主流关键字--lock关键字分析

using System;
using System.Threading;
using System.Collections;

namespace InsideDotNet.Keyword.SubKeyword
{
    class lockEx
    {
        public static void Main_6_6_3()//Main_6_6_3
        {
            object obj = new object();
            Console.WriteLine(obj.GetHashCode());
            lock (obj)
            {
                //执行线程同步相关操作
            }
            Console.WriteLine(obj.GetHashCode());
        }

        //实现一个等效操作
        public static void Main_6_6_4()//Main_6_6_4
        {
            object obj = new object();
            System.Threading.Monitor.Enter(obj);
            try
            {
                //执行线程同步相关操作
            }
            finally
            {
                System.Threading.Monitor.Exit(obj);
            }
        }


    }

    class LockApp
    {
        private static ArrayList al = new ArrayList();

        public static void AddItems()
        {
            lock (al)
            {
                al.Add(DateTime.Now.ToString());
                Thread.Sleep(1000);
            }
            //al.Add(DateTime.Now.ToString());
            //Thread.Sleep(5000);
        }

        public static void Main_6_6_6()//Main_6_6_6
        {
            Thread t1 = new Thread(new ThreadStart(AddItems));
            Thread t2 = new Thread(new ThreadStart(AddItems));
            t1.Start();
            t2.Start();

            Console.Read();

            foreach (string str in al)
            {
                Console.WriteLine(str);
            }
        }

    }


}
