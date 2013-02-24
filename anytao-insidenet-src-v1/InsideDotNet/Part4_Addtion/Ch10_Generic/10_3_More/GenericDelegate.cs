// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Generic.More
// Release     : 2007/12/04 1.0
// Description : 10.3 深入泛型

using System;
using System.Drawing;

namespace InsideDotNet.Generic.More
{
    class GenericDelegate
    {
        //首先声明一个泛型委托
        public delegate string MyGenericDelegate<T>(T t);

        //实现两个测试方法
        public static string GetPoint(Point p)
        {
            return String.Format("The location is ({0}, {1}).", p.X, p.Y);
        }
        public static string GetMsg(string txt)
        {
            return txt;
        }

        //实现测试代码
        public static void Main()//Main_10_3_2
        {
            MyGenericDelegate<string> myStrDel = new MyGenericDelegate<string>(GetMsg);
            Console.WriteLine(myStrDel("Hello, world."));

            MyGenericDelegate<Point> myPointDel = new MyGenericDelegate<Point>(GetPoint);
            Console.WriteLine(myPointDel(new Point(100, 200)));
        }
    }
}
