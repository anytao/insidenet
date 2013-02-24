// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.Framework.Object
// Release     : 2007/10/27 1.0
// Description : 8.1  ������ڣ�System.Object

using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace InsideDotNet.Framework.Object
{
    //ToString�����ض���������Ϣ
    class MyLocation
    {
        private int x = 0;
        private int y = 0;

        public override string ToString()
        {
            return String.Format("The location is ({0}, {1}).", x, y);
        }
    }

    ////ģ��Boolean���͵�ToString������д
    //class MyBoolean
    //{
    //    public override string ToString()
    //    {
    //        if (!this)
    //        {
    //            return "False";
    //        }

    //        return "True";                
    //    }
    //}


    class MyString
    {
        public static void Main_8_1_5()//Main_8_1_5
        {
            MyLocation ml = new MyLocation();
            Console.WriteLine(ml.ToString());

            bool b = true;
            Console.WriteLine(b.ToString());
            double d = 10.11;
            Console.WriteLine(d.ToString());

            //���ڵ�ToString��д����ʾ��
            DateTime dt = DateTime.Now;
            string time = dt.ToString("D", DateTimeFormatInfo.CurrentInfo);
            Console.WriteLine(time);
            string stime = dt.ToString("d", DateTimeFormatInfo.InvariantInfo);
            Console.WriteLine(stime);
            Console.WriteLine(dt.GetHashCode());

        }
    }
}
