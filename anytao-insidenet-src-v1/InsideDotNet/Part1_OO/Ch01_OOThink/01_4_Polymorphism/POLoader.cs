// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.OOThink.Polymorphism
// Release     : 2007/10/08 1.0
// Description : 1.4  ��̬������---�Զ�̬��ʽʵ��

using System;
using System.Collections.Generic;

namespace InsideDotNet.OOThink.Polymorphism
{
    class POLoader
    {
    }

    class FileManager
    {
        //��Word�ĵ�
        public void OpenDocFile()
        {
            Console.WriteLine("Alibaba, Open the Word file.");
        }

        //��PDF�ĵ�
        public void OpenPdfFile()
        {
            Console.WriteLine("Alibaba, Open the PDF File.");
        }

        //��Jpg�ĵ�
        public void OpenJpgFile()
        {
            Console.WriteLine("Alibaba, Open the Jpg File.");
        }

        //��MP3�ĵ�
        public void OpenMp3File()
        {
            Console.WriteLine("Alibaba, Open the MP3 File.");
        }
    }

    class FileClient2
    {
        public static void Main()//Main_1_4_1
        {
            //���������ļ�������
            FileManager fm = new FileManager();

            //����һ��һ�ѵĵ�������
            IList<Files> files = new List<Files>();

            //��ǰ�����ܼ������������ɹ����أ�
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
                    //��������ʡ�ԡ���
                }
            }
        }
    }
}
