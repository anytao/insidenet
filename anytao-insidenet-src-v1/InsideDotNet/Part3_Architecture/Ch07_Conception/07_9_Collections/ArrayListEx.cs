// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.Conception.Collections
// Release     : 2007/11/13 1.0
// Description : 7.9 ����ͨ��

using System;
using System.Collections;

namespace InsideDotNet.Conception.Collections
{
    class ArrayListEx
    {
        public static void Main_7_9_2()//Main_7_9_2
        {
            //���弯������
            ArrayList arrs = new ArrayList();
            //����Add���������Ӽ���Ԫ��
            arrs.Add(10);
            arrs.Add(new object());
            arrs.Add("I'm OK.");
            arrs.Add(new MyClass());
            arrs.Add(100);

            //����Remove�������Ƴ�ָ������
            arrs.Remove(100);

            //����Insert�������������ָ������λ��
            arrs.Insert(2, "A insert value");

            //IndexOf���������ڴ���ʼλ�������������ص�һ��ƥ���������λ��
            Int32 index = arrs.IndexOf("I'm OK.");

            //��ȡ���ϵ�ָ��Ԫ��
            object obj = arrs[index];
            Console.WriteLine("{0} -- {1}", obj, index);

            //��ȡ���ϵ�Ԫ�ظ���
            Console.WriteLine(arrs.Count);

            //ͨ��ö������������Ԫ��
            IEnumerator myEnumerator = arrs.GetEnumerator();
            while (myEnumerator.MoveNext())
            {
                Console.WriteLine(myEnumerator.Current);
            }

            //����ӵķ�ʽ����Ϊ
            foreach (object o in arrs)
            {
                Console.WriteLine(o.ToString());
            }

            //������ϵ�����Ԫ��
            arrs.Clear();
        }

        //˵��ArrayList�������Ƕ�̬��
        public static void Main_7_9_3()//Main_7_9_3
        {
            //��ʼ��arrs����Ϊ2
            ArrayList arrs = new ArrayList(2);

            arrs.Add(1);
            arrs.Add(2);
            arrs.Add(3);

            Console.WriteLine("��ǰ������{0}", arrs.Capacity);         //���Ϊ4

            arrs.TrimToSize();
            Console.WriteLine("ѹ�����������{0}", arrs.Capacity);  //���Ϊ3
        }
    }

    class MyClass
    {
        public override string ToString()
        {
            return "�����Զ������͡�";
        }
    }


}
