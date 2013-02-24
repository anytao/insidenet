// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Type.Box
// Release     : 2007/09/12 1.0
// Description : 4.4  皆有可能---装箱与拆箱

using System;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;

namespace InsideDotNet.Type.Box
{
    public class Boxthing
    {
    }

    class BoxinDotNet
    {
        //典型的装箱拆箱操作
        public static void Main_4_4_1()
        {
            Int32 x = 222;
            object o = x;
            Int32 y = (Int32)o;
        }

        public static void Main_4_4_2()
        {
            DateTime dt = DateTime.Now;
            dt.ToString();
            dt.GetType();

            //Point p = new Point(10, 20);
            //p.GetType();

            int i = 123;
            string s = i.ToString();

            Int32 x = 222;
            object o = x;
            Int16 y = (Int16)o;


            //int z = (int)new Boxthing();


            Console.Read();
        }

        //装箱的变化过程
        public static void Main_4_4_3()
        {
            char A = 'a';
            object o = A;
            A = 'b';
            Console.WriteLine(A);
            Console.WriteLine(o);
            if (o is char)
                Console.WriteLine("It's char type.");
            Console.WriteLine(o.GetType());
        }

        //多次转换示例
        public static void Main_4_4_4()
        {
            int i = 100;
            object o = i;
            o = 200;
            Hashtable ht = new Hashtable();
            ht.Add("I", i);
            ht["I"] = o;
            Console.WriteLine(i + " is original, " + (int)ht["I"] + " is changing.");
        }

        //装箱拆箱必须类型一致
        public static void Main()//Main_4_4_5
        {
            float f = 1.01F;
            object o = f;
            double d = (double)o;

            object o1 = "string";
            int j = (int)o1;
        }

        //不经意的装箱与拆箱
        public static void Main_4_4_6()
        {
            Hashtable ht = new Hashtable();
            int x = 100;
            //发生1次装箱
            object o = x;
            for (int i = 0; i < 100; i++)
            {
                //发生100次装箱
                ht.Add(i, o);
                //发生200次装箱
                ht.Add(i, x);
            }
        }

        //泛型与装箱与拆箱的比较
        public static void Main_4_4_7_1()
        {
            ArrayList array = new ArrayList();
            array.Add(1);
            int i = (int)array[0];
        }

        public static void Main_4_4_7_2()
        {
            List<int> list = new List<int>();
            list.Add(1);
            int i = list[0];
        }

        //Hashtable的装箱
        public static void Main_4_4_8()
        {
            int i = 100;
            Hashtable ht = new Hashtable();
            ht.Add(1, i);
            ht.Add(2, i + 1);
            ht.Remove(1);
            object o = null;

        }

        //枚举装箱
        enum Color
        {
            Red,
            Black,
            Blue
        }

        public static void Main_4_4_9()
        {
            Color red = Color.Red;
            IComparable comparer = red;
            IFormattable formater = red;
            IConvertible converter = red;
            Console.WriteLine(red.ToString());
            Console.WriteLine(red);
        }


        //不经意的隐式转换
        public static void Main_4_4_10()
        {
            int i = 100;
            //执行装箱
            i.GetType();
            //未执行装箱
            i.ToString();
            //进行装箱，避免发生隐式转换
            object o = i;
            Hashtable ht = new Hashtable();
            ht.Add("One", o);
            ht.Add("Two", o);
        }

    }
}
