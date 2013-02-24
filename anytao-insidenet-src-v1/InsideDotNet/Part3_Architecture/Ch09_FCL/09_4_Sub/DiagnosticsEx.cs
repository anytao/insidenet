// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.FCL.Sub
// Release     : 2007/11/20 1.0
// Description : 9.4 ����---System�μ������ռ�--System.Diagnostics���

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

            //����������Ӧ��FileName��Arguments���� 
            myProcess.StartInfo.FileName = "iexplore.exe";
            myProcess.StartInfo.Arguments = myUrl;
            //��������
            myProcess.Start();
        }

        public static void Main_9_4_4()//Main_9_4_4
        {
            Int32 num = 100;

            Debug.Listeners.Add(new TextWriterTraceListener(Console.Out));
            Debug.Assert(num > 100, "num������100");
            Debug.WriteLine(num);
        }

        public static void Main_9_4_5()//Main_9_4_5
        {
            //����EventLogʵ��
            EventLog myLog = new EventLog("MyLog", ".", "AnyLog");
            //д����־�¼�
            myLog.WriteEntry("It's my log.", EventLogEntryType.Information, 1);
            //��ȡ��־�¼�
            foreach (EventLogEntry ele in myLog.Entries)
            {
                Console.WriteLine(ele.Message);
            }
        }

        public static void Main_9_4_6()//Main_9_4_6
        {
            ArrayList al = new ArrayList(100000);

            //��������ʼ����
            Stopwatch sw = Stopwatch.StartNew();
            for (Int32 i = 0; i < 100000; i++)
            {
                al.Add(i);
            }
            //ֹͣ����
            sw.Stop();
            //���ز�����ʱ��
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
