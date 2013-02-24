// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.Memory.GC
// Release     : 2007/11/29 1.0
// Description : 5.3 ��������

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace InsideDotNet.Memory.GC
{
    class ManagedRes : IDisposable
    {
        public void Dispose()
        {
        }
    }

    class FileDealer : IDisposable
    {
        //����һ�������ļ���Դ��Win32���
        private IntPtr fileHandle;
        //�������õ��й���Դ
        private ManagedRes managedRes;

        //���幹��������ʼ���й���Դ�ͷ��й���Դ
        public FileDealer(IntPtr handle, ManagedRes res)
        {
            fileHandle = handle;
            managedRes = res;
        }

        //ʵ���ս���������Finalize
        ~FileDealer()
        {
            if (fileHandle != IntPtr.Zero)
            {
                Dispose(false);
            }
        }

        //ʵ��IDisposable�ӿ�
        public void Dispose()
        {
            Dispose(true);
            //��ֹGC����Finalize����
            System.GC.SuppressFinalize(this);
        }

        //ʵ��һ��������Դ����ľ��巽��
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                //�����й���Դ
                managedRes.Dispose();
            }
            //ִ����Դ�����ڴ�Ϊ�رն�����
            if (fileHandle != IntPtr.Zero)
            {
                CloseHandle(fileHandle);
                fileHandle = IntPtr.Zero;
            }
        }

        public void Close()
        {
            //���ڲ�����Dispose��ʵ��
            Dispose();
        }

        //ʵ�ֶ��ļ����������Ӧ�÷���
        public void Write() { }
        public void Read() { }

        //�����ⲿWin32API
        [DllImport("Kernel32")]
        private extern static Boolean CloseHandle(IntPtr handle);
    }

    class Test_FileDealer
    {
        public static void Main_5_3_2()//Main_5_3_2
        {
            FileDealer fd = null;
            try
            {
                fd = new FileDealer(new IntPtr(), new ManagedRes());
                fd.Read();
            }
            finally
            {
                if (fd != null)
                    fd.Dispose();
            }

            //using(FileDealer fd = new FileDealer(new IntPtr(), new ManagedRes()))
            //{
            //    fd.Read();
            //}
        }
    }

    //public class Resurrection
    //{
    //    public int Data;
    //    public Resurrection(int data)
    //    {
    //        this.Data = data;
    //    }
    //    ~Resurrection()
    //    {
    //        Main.Instance = this;
    //    }
    //}
    //public class Main
    //{
    //    public static Resurrection Instance;
    //    public static void Main()
    //    {
    //        Instance = new Resurrection(1); Instance = null; GC.Collect(); GC.WaitForPendingFinalizers();    // �����������������ˡ�    
    //        Console.WriteLine(Instance.Data); Instance = null; GC.Collect(); Console.ReadLine();
    //    }
    //}

    public class ReLife
    {
        ~ReLife()
        {
            //�������±�һ��������
            Test_ReLife.Instance = this;
            //���½�������ӵ���ֹ������
            System.GC.ReRegisterForFinalize(this);
        }

        public void ShowInfo()
        {
            Console.WriteLine("�����ָ����ˡ�");
        }
    }

    public class Test_ReLife
    {
        public static ReLife Instance;

        public static void Main_5_3_3()//Main_5_3_3
        {
            Instance = new ReLife();
            Instance = null;
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
            //�����ָ�����
            Instance.ShowInfo();
        }
    }
}
