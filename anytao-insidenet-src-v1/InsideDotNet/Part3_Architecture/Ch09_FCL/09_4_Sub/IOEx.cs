// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.FCL.Sub
// Release     : 2007/11/20 1.0
// Description : 9.4 核心---System次级命名空间--System.IO简介

using System;
using System.IO;
using System.Text;

namespace InsideDotNet.FCL.Sub
{
    class IOEx
    {
        public static void Main()//Main_9_4_1
        {
            using (FileStream fs = File.Create(@"c:\temp.txt"))
            {
                byte[] txts = new UTF8Encoding(true).GetBytes("我是小王。");
                //将字节块写入FileStream
                fs.Write(txts, 0, txts.Length);
            }
        }

        public static void Main_9_4_2()//Main_9_4_2
        {
            string filePath = @"c:\temp.txt";

            //创建一个文本文件
            if (!File.Exists(filePath))
            {
                FileStream fs = new FileStream(filePath, FileMode.Append);
                fs.Close();
            }

            //使用StreamWriter向文件中写入文本
            using (StreamWriter sw = new StreamWriter(filePath, true, Encoding.UTF8))
            {
                sw.WriteLine("我是小王。");
                sw.WriteLine("我的年龄是27。");
            }

            //使用StreamReader从文件中读取文本
            using (StreamReader sr = new StreamReader(filePath))
            {
                string txt;
                while ((txt = sr.ReadLine()) != null)
                {
                    Console.WriteLine(txt);
                }
            }
        }
    }
}
