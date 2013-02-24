// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.FCL.Sub
// Release     : 2007/11/20 1.0
// Description : 9.4 核心---System次级命名空间--System.Diagnostics简介

using System;
using System.Diagnostics;
using System.Collections;
using System.Runtime;

namespace InsideDotNet.FCL.Sub
{
    class DiagnosticsEx
    {
        public static void Main_9_4_3()//Main_9_4_3
        {
            Process myProcess = new Process();
            string myUrl = "http://www.anytao.com";

            //必须设置相应的FileName和Arguments属性 
            myProcess.StartInfo.FileName = "iexplore.exe";
            myProcess.StartInfo.Arguments = myUrl;
            //启动进程
            myProcess.Start();
        }

        public static void Main_9_4_4()//Main_9_4_4
        {
            Int32 num = 100;

            Debug.Listeners.Add(new TextWriterTraceListener(Console.Out));
            Debug.Assert(num > 100, "num不大于100");
            Debug.WriteLine(num);
        }

        public static void Main_9_4_5()//Main_9_4_5
        {
            //创建EventLog实例
            EventLog myLog = new EventLog("MyLog", ".", "AnyLog");
            //写入日志事件
            myLog.WriteEntry("It's my log.", EventLogEntryType.Information, 1);
            //读取日志事件
            foreach (EventLogEntry ele in myLog.Entries)
            {
                Console.WriteLine(ele.Message);
            }
        }

        public static void Main_9_4_6()//Main_9_4_6
        {
            ArrayList al = new ArrayList(100000);

            //创建并开始测量
            Stopwatch sw = Stopwatch.StartNew();
            for (Int32 i = 0; i < 100000; i++)
            {
                al.Add(i);
            }
            //停止测量
            sw.Stop();
            //返回测试总时间
            Console.WriteLine(sw.ElapsedMilliseconds);

            //Stopwatch sw = new Stopwatch();
            //sw.Start();
            //TestFor(al);
            //sw.Stop();
            //Console.WriteLine(sw.ElapsedMilliseconds);

            //sw.Reset();
            //sw.Start();
            //TestForeach(al);
            //sw.Stop();
            //Console.WriteLine(sw.ElapsedMilliseconds);

        }

        private static void TestFor(ArrayList al)
        {
            ArrayList alTemp = new ArrayList();
            for (Int32 i = 0; i < al.Count; i++)
            {
                alTemp.Add(al[i]);
            }
        }

        private static void TestForeach(ArrayList al)
        {
            ArrayList alTemp = new ArrayList();
            foreach (object arr in al)
            {
                alTemp.Add(arr);
            }
        }
    }
}
