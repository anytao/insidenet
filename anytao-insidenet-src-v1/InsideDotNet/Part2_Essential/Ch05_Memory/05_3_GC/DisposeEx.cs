// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Memory.GC
// Release     : 2007/11/29 1.0
// Description : 5.3 垃圾回收

using System;
using System.Collections.Generic;
using System.Text;

namespace InsideDotNet.Memory.GC
{
    class DisposeEx
    {
    }

    class MyDispose : IDisposable
    {
        //定义一个访问外部资源的句柄
        private IntPtr _handle;
        //标记Dispose是否被调用
        private bool disposed = false;

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
            if (!disposed)
            {
                if (disposing)
                {
                    //清理托管资源
                }
                //清理非托管资源
                if (_handle != IntPtr.Zero)
                {
                    //执行资源清理，在此为关闭对象句柄
                    //CloseHandle(_handle);
                    _handle = IntPtr.Zero;
                }
            }
            disposed = true;
        }

        public void Close()
        {
            //在内部调用Dispose来实现
            Dispose();
        }
    }

    class My2Dispose : MyDispose
    {
        private bool disposed = false;

        protected override void Dispose(bool disposing)
        {
            if (!disposed)
            {
                try
                {
                    //子类资源清理
                    //......
                    disposed = true;
                }
                finally
                {
                    base.Dispose(disposing);
                }
            }
        }
    }
}
