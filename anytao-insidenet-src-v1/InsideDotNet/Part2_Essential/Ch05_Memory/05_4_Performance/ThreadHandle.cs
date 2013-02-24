// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Memory.Performance
// Release     : 2007/11/30 1.0
// Description : 5.4 性能控制的多方探讨

using System;
using System.Threading;

namespace InsideDotNet.Memory.Performance
{
    class ThreadHandle
    {
        public static void Main_5_4_5()//Main_5_4_5
        {
            ThreadHandle th = new ThreadHandle();

            //将方法排入线程池队列执行
            ThreadPool.QueueUserWorkItem(new WaitCallback(th.MyProcOne), "线程1");
            Thread.Sleep(1000);
            ThreadPool.QueueUserWorkItem(new WaitCallback(th.MyProcTwo), "线程2");

            //实现阻塞主线程
            Console.Read();
        }

        //在不同的线程执行不同的回调操作
        public void MyProcOne(object stateInfo)
        {
            Console.WriteLine(stateInfo.ToString());
            Console.WriteLine("起床了。");
        }

        public void MyProcTwo(object stateInfo)
        {
            Console.WriteLine(stateInfo.ToString());
            Console.WriteLine("刷牙了。");
        }
    }
}
