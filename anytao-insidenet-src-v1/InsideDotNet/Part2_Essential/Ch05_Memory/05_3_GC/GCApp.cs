// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Memory.GC
// Release     : 2007/11/28 1.0
// Description : 5.3 垃圾回收

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
            //执行资源清理
        }
    }

    //protected override void Finalize()
    //{
    //    try
    //    {
    //        //执行自定义资源清理操作
    //    }
    //    finally
    //    {
    //        base.Finalize();
    //    }
    //}

}
