// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.Memory.Performance
// Release     : 2007/11/30 1.0
// Description : 5.4 ���ܿ��ƵĶ෽̽��

using System;
using System.Threading;

namespace InsideDotNet.Memory.Performance
{
    class ThreadHandle
    {
        public static void Main_5_4_5()//Main_5_4_5
        {
            ThreadHandle th = new ThreadHandle();

            //�����������̳߳ض���ִ��
            ThreadPool.QueueUserWorkItem(new WaitCallback(th.MyProcOne), "�߳�1");
            Thread.Sleep(1000);
            ThreadPool.QueueUserWorkItem(new WaitCallback(th.MyProcTwo), "�߳�2");

            //ʵ���������߳�
            Console.Read();
        }

        //�ڲ�ͬ���߳�ִ�в�ͬ�Ļص�����
        public void MyProcOne(object stateInfo)
        {
            Console.WriteLine(stateInfo.ToString());
            Console.WriteLine("���ˡ�");
        }

        public void MyProcTwo(object stateInfo)
        {
            Console.WriteLine(stateInfo.ToString());
            Console.WriteLine("ˢ���ˡ�");
        }
    }
}
