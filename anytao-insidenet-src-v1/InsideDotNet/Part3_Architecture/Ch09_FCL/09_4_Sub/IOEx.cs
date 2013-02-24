// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.FCL.Sub
// Release     : 2007/11/20 1.0
// Description : 9.4 ����---System�μ������ռ�--System.IO���

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
                byte[] txts = new UTF8Encoding(true).GetBytes("����С����");
                //���ֽڿ�д��FileStream
                fs.Write(txts, 0, txts.Length);
            }
        }

        public static void Main_9_4_2()//Main_9_4_2
        {
            string filePath = @"c:\temp.txt";

            //����һ���ı��ļ�
            if (!File.Exists(filePath))
            {
                FileStream fs = new FileStream(filePath, FileMode.Append);
                fs.Close();
            }

            //ʹ��StreamWriter���ļ���д���ı�
            using (StreamWriter sw = new StreamWriter(filePath, true, Encoding.UTF8))
            {
                sw.WriteLine("����С����");
                sw.WriteLine("�ҵ�������27��");
            }

            //ʹ��StreamReader���ļ��ж�ȡ�ı�
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
