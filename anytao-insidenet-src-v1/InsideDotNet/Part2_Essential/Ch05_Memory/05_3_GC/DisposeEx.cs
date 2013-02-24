// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.Memory.GC
// Release     : 2007/11/29 1.0
// Description : 5.3 ��������

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
        //����һ�������ⲿ��Դ�ľ��
        private IntPtr _handle;
        //���Dispose�Ƿ񱻵���
        private bool disposed = false;

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
            if (!disposed)
            {
                if (disposing)
                {
                    //�����й���Դ
                }
                //������й���Դ
                if (_handle != IntPtr.Zero)
                {
                    //ִ����Դ�����ڴ�Ϊ�رն�����
                    //CloseHandle(_handle);
                    _handle = IntPtr.Zero;
                }
            }
            disposed = true;
        }

        public void Close()
        {
            //���ڲ�����Dispose��ʵ��
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
                    //������Դ����
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
