// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.OOThink.Polymorphism
// Release     : 2007/10/08 1.0
// Description : 1.4  ��̬������---�Զ�̬��ʽʵ��

using System;
using System.IO;
using System.Collections.Generic;

namespace InsideDotNet.OOThink.Polymorphism
{
    class OOLoader
    {
    }

    //��֧���ļ����ͣ����ļ���չ������
    enum FileType
    {
        doc,   //Word�ĵ�
        pdf,   //PDF�ĵ�
        txt,    //�ı��ĵ�
        ppt,   //Ponwerpoint�ĵ�
        jpg,   //jpg��ʽͼƬ
        gif,    //gif��ʽͼƬ
        mp3, //mp3��Ƶ�ļ� 
        avi,    //avi��Ƶ�ļ�
        all     //���������ļ�
    }

    interface IFileOpen
    {
        void Open();
    }

    abstract class Files : IFileOpen
    {
        //�����ļ�����
        private FileType fileType = FileType.doc;

        public FileType FileType
        {
            get { return fileType; }
        }

        //�����ļ�����
        private string fileName;

        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }

        public abstract void Open();

        public void Delete()
        {
            //ʵ�ֶ��ļ���ɾ������
        }

        public void ReName()
        {
            //ʵ�ֶ��ļ�������������
        }

        public string GetFilePath()
        {
            //��ȡ�ļ�ȫ·��
            return "Hello";
        }
    }

    abstract class DocFile : Files
    {
        public int GetPageCount()
        {
            //�����ĵ�ҳ��
            return 1;
        }
    }

    abstract class ImageFile : Files
    {
        public void ZoomIn()
        {
            //�Ŵ����
        }

        public void ZoomOut()
        {
            //��С����
        }
    }

    abstract class MediaFile : Files
    {
    }

    class WORDFile : DocFile
    {
        public override void Open()
        {
            Console.WriteLine("Open the WORD file.");
        }
    }

    class PDFFile : DocFile
    {
        public override void Open()
        {
            Console.WriteLine("Open the PDF file.");
        }
    }

    class JPGFile : ImageFile
    {
        public override void Open()
        {
            Console.WriteLine("Open the JPEG file.");
        }
    }

    class AVIFile : MediaFile
    {
        public override void Open()
        {
            Console.WriteLine("Open the AVI file.");
        }
    }

    class MPEGFile : MediaFile
    {
        public override void Open()
        {
            Console.WriteLine("Open the MPEG file.");
        }
    }

    class LoadManager : ICloneable
    {
        private IList<Files> files = new List<Files>();

        public IList<Files> Files
        {
            get { return files; }
        }

        public LoadManager()
        {
        }

        private LoadManager(IList<Files> loaderFiles)
        {
            foreach (Files file in loaderFiles)
            {
                files.Add(file);
            }
        }

        public void LoadFiles(Files file)
        {
            files.Add(file);
        }

        //����������
        public void OpenAllFiles()
        {
            foreach (IFileOpen file in files)
            {
                file.Open();
            }
        }

        //�򿪵�������
        public void OpenFile(IFileOpen file)
        {
            file.Open();
        }

        //��ȡ�ļ�����
        public FileType GetFileType(string fileName)
        {
            //����ָ��·���ļ������ļ�����
            FileInfo fi = new FileInfo(fileName);

            return (FileType)Enum.Parse(typeof(FileType), fi.Extension);
        }


        //ʵ�ֶ������
        public object Clone()
        {
            return new LoadManager(files);
        }

    }

    /// <summary>
    /// ʵ���ļ��򿪵Ŀͻ�����
    /// </summary>
    class FileClient
    {
        public static void Main_1_4_2()//Main_1_4_2
        {
            //���������ļ�������
            LoadManager lm = new LoadManager();

            //���Ҫ������ļ�
            lm.LoadFiles(new WORDFile());
            lm.LoadFiles(new PDFFile());
            lm.LoadFiles(new JPGFile());
            lm.LoadFiles(new AVIFile());
            lm.LoadFiles(new MPEGFile());

            foreach (Files file in lm.Files)
            {
                ////if (file is үүѡ���)
                //{
                //}              
                lm.OpenFile(file);
            }

            Console.WriteLine("*******************************");
            lm.OpenAllFiles();

            Files myFile = new WORDFile();
            myFile.Open();


            //һ��һ�ѵĵ�������
            List<Files> files = new List<Files>();
            //......ʡ�Լ����ļ�����......



            //�µ����ܼ������ָ������ɹ����أ�
            foreach (IFileOpen file in files)
            {
                file.Open();
            }

            //��һ�ֽⷨ
            IFileOpen file2;
            FileType ft = FileType.all;
            switch (ft)
            {
                case (FileType.doc):
                    file2 = new WORDFile(); ;
                    break;
                case (FileType.pdf):
                    file2 = null;
                    break;
            }

            //lm.OpenFile(file2);
        }
    }
}