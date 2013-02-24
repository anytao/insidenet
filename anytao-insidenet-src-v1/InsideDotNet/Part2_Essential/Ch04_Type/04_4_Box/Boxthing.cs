// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.Type.Box
// Release     : 2007/09/12 1.0
// Description : 4.4  ���п���---װ�������

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
        //���͵�װ��������
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

        //װ��ı仯����
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

        //���ת��ʾ��
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

        //װ������������һ��
        public static void Main()//Main_4_4_5
        {
            float f = 1.01F;
            object o = f;
            double d = (double)o;

            object o1 = "string";
            int j = (int)o1;
        }

        //�������װ�������
        public static void Main_4_4_6()
        {
            Hashtable ht = new Hashtable();
            int x = 100;
            //����1��װ��
            object o = x;
            for (int i = 0; i < 100; i++)
            {
                //����100��װ��
                ht.Add(i, o);
                //����200��װ��
                ht.Add(i, x);
            }
        }

        //������װ�������ıȽ�
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

        //Hashtable��װ��
        public static void Main_4_4_8()
        {
            int i = 100;
            Hashtable ht = new Hashtable();
            ht.Add(1, i);
            ht.Add(2, i + 1);
            ht.Remove(1);
            object o = null;

        }

        //ö��װ��
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


        //���������ʽת��
        public static void Main_4_4_10()
        {
            int i = 100;
            //ִ��װ��
            i.GetType();
            //δִ��װ��
            i.ToString();
            //����װ�䣬���ⷢ����ʽת��
            object o = i;
            Hashtable ht = new Hashtable();
            ht.Add("One", o);
            ht.Add("Two", o);
        }

    }
}
