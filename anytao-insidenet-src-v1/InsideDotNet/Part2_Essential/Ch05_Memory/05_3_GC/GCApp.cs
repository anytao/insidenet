// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.Memory.GC
// Release     : 2007/11/28 1.0
// Description : 5.3 ��������

using System;
using System.Collections.Generic;
using System.Text;
using System.DirectoryServices.ActiveDirectory;


namespace InsideDotNet.Memory.GC
{
    class GCApp : Object
    {
        ~GCApp()
        {
            //ִ����Դ����
        }
    }

    //protected override void Finalize()
    //{
    //    try
    //    {
    //        //ִ���Զ�����Դ�������
    //    }
    //    finally
    //    {
    //        base.Finalize();
    //    }
    //}

}
