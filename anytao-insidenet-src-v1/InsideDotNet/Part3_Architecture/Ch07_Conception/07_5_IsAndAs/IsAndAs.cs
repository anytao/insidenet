// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.Conception.IsAndAs
// Release     : 2007/04/07 1.0
// Description : 7.5  ��Թ���is��as

using System;
using System.Collections.Generic;
using System.Text;

namespace InsideDotNet.Conception.IsAndAs
{
    class ISSample
    {
        public static void Main()//Main_7_5_1
        {
            object o = new object();

            //ִ�е�һ�����ͼ����Լ��
            if (o is ISSample)
            {
                //ִ�еڶ������ͼ����Լ��
                ISSample a = (ISSample)o;
            }
        }
    }

    class ASSample
    {
        public static void Main_7_5_2()//Main_7_5_2
        {
            object o = new object();

            //ִ��һ�����ͼ��ݼ��
            ASSample b = o as ASSample;
            //ASSample b = o is ASSample ? (ASSample)o : null;
            if (b != null)
            {
                //ִ�й���b�Ĳ���
            }

        }
    }

    class IsAndAs
    {

    }
}
