// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.Memory.MemoryBase
// Release     : 2007/11/26 1.0
// Description : 5.1  �ڴ�����Ҫ

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
            //�������󣬷����ڴ棬����ʼ��
            FileStream fs = new FileStream(@"E:\temp.txt", FileMode.Create);
            try
            {
                //�����Ա�Ĳ�����Ӧ��
                byte[] txts = new UTF8Encoding(true).GetBytes("Hello, world.");
                fs.Write(txts, 0, txts.Length);
            }
            finally
            {
                //ִ����Դ����
                if (fs != null) fs.Close();
            }
        }
    }
}
