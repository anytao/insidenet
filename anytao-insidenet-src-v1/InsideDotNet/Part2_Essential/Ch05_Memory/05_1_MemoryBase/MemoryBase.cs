// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Memory.MemoryBase
// Release     : 2007/11/26 1.0
// Description : 5.1  内存管理概要

using System;
using System.IO;
using System.Text;

namespace InsideDotNet.Memory.MemoryBase
{
    class BasicMemory
    {
     
    }

    class MemoryProcess
    {
        public static void Main()
        {
            //创建对象，分配内存，并初始化
            FileStream fs = new FileStream(@"E:\temp.txt", FileMode.Create);
            try
            {
                //对象成员的操作和应用
                byte[] txts = new UTF8Encoding(true).GetBytes("Hello, world.");
                fs.Write(txts, 0, txts.Length);
            }
            finally
            {
                //执行资源清理
                if (fs != null) fs.Close();
            }
        }
    }
}
