// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.OOThink.Polymorphism
// Release     : 2007/10/08 1.0
// Description : 1.4  多态的艺术---以多态方式实现

using System;
using System.IO;
using System.Collections.Generic;

namespace InsideDotNet.OOThink.Polymorphism
{
    class OOLoader
    {
    }

    //可支持文件类型，以文件扩展名划分
    enum FileType
    {
        doc,   //Word文档
        pdf,   //PDF文档
        txt,    //文本文档
        ppt,   //Ponwerpoint文档
        jpg,   //jpg格式图片
        gif,    //gif格式图片
        mp3, //mp3音频文件 
        avi,    //avi视频文件
        all     //所有类型文件
    }

    interface IFileOpen
    {
        void Open();
    }

    abstract class Files : IFileOpen
    {
        //定义文件类型
        private FileType fileType = FileType.doc;

        public FileType FileType
        {
            get { return fileType; }
        }

        //定义文件名称
        private string fileName;

        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }

        public abstract void Open();

        public void Delete()
        {
            //实现对文件的删除处理
        }

        public void ReName()
        {
            //实现对文件的重命名处理
        }

        public string GetFilePath()
        {
            //获取文件全路径
            return "Hello";
        }
    }

    abstract class DocFile : Files
    {
        public int GetPageCount()
        {
            //计算文档页数
            return 1;
        }
    }

    abstract class ImageFile : Files
    {
        public void ZoomIn()
        {
            //放大比例
        }

        public void ZoomOut()
        {
            //缩小比例
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

        //打开所有资料
        public void OpenAllFiles()
        {
            foreach (IFileOpen file in files)
            {
                file.Open();
            }
        }

        //打开单个资料
        public void OpenFile(IFileOpen file)
        {
            file.Open();
        }

        //获取文件类型
        public FileType GetFileType(string fileName)
        {
            //根据指定路径文件返回文件类型
            FileInfo fi = new FileInfo(fileName);

            return (FileType)Enum.Parse(typeof(FileType), fi.Extension);
        }


        //实现对象深拷贝
        public object Clone()
        {
            return new LoadManager(files);
        }

    }

    /// <summary>
    /// 实现文件打开的客户端类
    /// </summary>
    class FileClient
    {
        public static void Main_1_4_2()//Main_1_4_2
        {
            //首先启动文件加载器
            LoadManager lm = new LoadManager();

            //添加要处理的文件
            lm.LoadFiles(new WORDFile());
            lm.LoadFiles(new PDFFile());
            lm.LoadFiles(new JPGFile());
            lm.LoadFiles(new AVIFile());
            lm.LoadFiles(new MPEGFile());

            foreach (Files file in lm.Files)
            {
                ////if (file is 爷爷选择的)
                //{
                //}              
                lm.OpenFile(file);
            }

            Console.WriteLine("*******************************");
            lm.OpenAllFiles();

            Files myFile = new WORDFile();
            myFile.Open();


            //一堆一堆的电脑资料
            List<Files> files = new List<Files>();
            //......省略加载文件过程......



            //新的万能加载器又该如何完成工作呢？
            foreach (IFileOpen file in files)
            {
                file.Open();
            }

            //另一种解法
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