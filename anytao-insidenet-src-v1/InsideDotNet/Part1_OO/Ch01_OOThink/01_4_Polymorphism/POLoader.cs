// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.OOThink.Polymorphism
// Release     : 2007/10/08 1.0
// Description : 1.4  多态的艺术---以多态方式实现

using System;
using System.Collections.Generic;

namespace InsideDotNet.OOThink.Polymorphism
{
    class POLoader
    {
    }

    class FileManager
    {
        //打开Word文档
        public void OpenDocFile()
        {
            Console.WriteLine("Alibaba, Open the Word file.");
        }

        //打开PDF文档
        public void OpenPdfFile()
        {
            Console.WriteLine("Alibaba, Open the PDF File.");
        }

        //打开Jpg文档
        public void OpenJpgFile()
        {
            Console.WriteLine("Alibaba, Open the Jpg File.");
        }

        //打开MP3文档
        public void OpenMp3File()
        {
            Console.WriteLine("Alibaba, Open the MP3 File.");
        }
    }

    class FileClient2
    {
        public static void Main()//Main_1_4_1
        {
            //首先启动文件加载器
            FileManager fm = new FileManager();

            //看到一堆一堆的电脑资料
            IList<Files> files = new List<Files>();

            //当前的万能加载器该如何完成工作呢？
            foreach (Files file in files)
            {
                switch (file.FileType)
                {
                    case FileType.doc:
                        fm.OpenDocFile();
                        break;
                    case FileType.pdf:
                        fm.OpenPdfFile();
                        break;
                    case FileType.jpg:
                        fm.OpenJpgFile();
                        break;
                    case FileType.mp3:
                        fm.OpenMp3File();
                        break;
                    //……部分省略……
                }
            }
        }
    }
}
