// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Memory.GC
// Release     : 2007/11/29 1.0
// Description : 5.3 垃圾回收

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
        //定义一个访问文件资源的Win32句柄
        private IntPtr fileHandle;
        //定义引用的托管资源
        private ManagedRes managedRes;

        //定义构造器，初始化托管资源和非托管资源
        public FileDealer(IntPtr handle, ManagedRes res)
        {
            fileHandle = handle;
            managedRes = res;
        }

        //实现终结器，定义Finalize
        ~FileDealer()
        {
            if (fileHandle != IntPtr.Zero)
            {
                Dispose(false);
            }
        }

        //实现IDisposable接口
        public void Dispose()
        {
            Dispose(true);
            //阻止GC调用Finalize方法
            System.GC.SuppressFinalize(this);
        }

        //实现一个处理资源清理的具体方法
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                //清理托管资源
                managedRes.Dispose();
            }
            //执行资源清理，在此为关闭对象句柄
            if (fileHandle != IntPtr.Zero)
            {
                CloseHandle(fileHandle);
                fileHandle = IntPtr.Zero;
            }
        }

        public void Close()
        {
            //在内部调用Dispose来实现
            Dispose();
        }

        //实现对文件句柄的其他应用方法
        public void Write() { }
        public void Read() { }

        //引入外部Win32API
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
    //        Instance = new Resurrection(1); Instance = null; GC.Collect(); GC.WaitForPendingFinalizers();    // 看到了吗，在这里“复活”了。    
    //        Console.WriteLine(Instance.Data); Instance = null; GC.Collect(); Console.ReadLine();
    //    }
    //}

    public class ReLife
    {
        ~ReLife()
        {
            //对象重新被一个根引用
            Test_ReLife.Instance = this;
            //重新将对象添加到终止化队列
            System.GC.ReRegisterForFinalize(this);
        }

        public void ShowInfo()
        {
            Console.WriteLine("对象又复活了。");
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
            //对象又复活了
            Instance.ShowInfo();
        }
    }
}
