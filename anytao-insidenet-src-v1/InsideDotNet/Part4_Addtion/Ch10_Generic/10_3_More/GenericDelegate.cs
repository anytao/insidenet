// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.Generic.More
// Release     : 2007/12/04 1.0
// Description : 10.3 ���뷺��

using System;
using System.Drawing;

namespace InsideDotNet.Generic.More
{
    class GenericDelegate
    {
        //��������һ������ί��
        public delegate string MyGenericDelegate<T>(T t);

        //ʵ���������Է���
        public static string GetPoint(Point p)
        {
            return String.Format("The location is ({0}, {1}).", p.X, p.Y);
        }
        public static string GetMsg(string txt)
        {
            return txt;
        }

        //ʵ�ֲ��Դ���
        public static void Main()//Main_10_3_2
        {
            MyGenericDelegate<string> myStrDel = new MyGenericDelegate<string>(GetMsg);
            Console.WriteLine(myStrDel("Hello, world."));

            MyGenericDelegate<Point> myPointDel = new MyGenericDelegate<Point>(GetPoint);
            Console.WriteLine(myPointDel(new Point(100, 200)));
        }
    }
}
