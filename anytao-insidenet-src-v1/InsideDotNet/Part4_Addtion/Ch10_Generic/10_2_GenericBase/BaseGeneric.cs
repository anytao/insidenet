// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.Generic.GenericBase
// Release     : 2007/12/02 1.0
// Description : 10.2 �˽ⷺ��

using System;
using System.Collections;

namespace InsideDotNet.Generic.GenericBase
{
    class BaseGeneric
    {
        public static void Main()//Main_10_2_1
        {
            //MyArray<Int32> myArr = new MyArray<Int32>();
            ////myArr.Add("ABC");
            //MyArray<string> myStr = new MyArray<string>();
            //Console.WriteLine(myStr.myData);
        }

        public static void Main_10_2_2()//Main_10_2_2
        {
            MyArray<Student> myArr = new MyArray<Student>();
            myArr.Add(new Student());
            Console.WriteLine(myArr[0]);
            MyArray<CollegeStudent> myArrs = new MyArray<CollegeStudent>();
        }

        public static void Main_10_2_3()//Main_10_2_3
        {
            MyArray<Student> myArr = new MyArray<Student>();
            myArr.myData = new Student();
            myArr.ShowInfo();
            //ʵ�ָ����Ŀ���
            myArr.ShowInfo<CollegeStudent>(new CollegeStudent());

            //ʵ�ָ����ķ�ʽ������
            myArr.ShowInfo(new CollegeStudent());
            myArr.ShowInfo("Hello, world.");

            //myArr.ShowInfo<string>("Hello, world.");
        }

        public static void Main_10_2_4()//Main_10_2_4
        {
            MyArray<Student> myArr = new MyArray<Student>();
            //myArr.ShowInfo<Student, Student>(new Student(), new Student());

        }

        public static void Main_10_2_5()//Main_10_2_5
        {
            MyArray<Int32> myIntArr = new MyArray<Int32>();
            myIntArr.Add(123);
        }
    }

    class Student
    {

    }

    class CollegeStudent : Student
    {
    }

    class B
    {
        //ʵ�ַ��ͷ���
        public TData ShowInfo<TData>(TData myData)
        {
            TData temp = default(TData);
            return temp;
        }
    }



    class MyArray<T> : ArrayList //where T: Student, new()
    {
        //�Զ��弯�ϵ�Ŀ��Ԫ��
        private T[] _items;

        public T myData;


        //���ϴ�С����
        private Int32 _size = 0;

        //ʵ��Ԫ�����ӹ���
        public void Add(T item)
        {
            _items[_size] = item;
            _size++;
        }

        //ʵ��������
        public T this[Int32 index]
        {
            get { return _items[index]; }
            set { _items[index] = value; }
        }

        //ʵ�ֹ�����
        public MyArray()
        {
            _items = new T[100];
            //��ʼ��Ĭ��ֵ
            myData = default(T);
        }

        //ʵ�ַ��ͷ���
        public void ShowInfo<TData>(TData data) where TData : Student
        {
            Console.WriteLine(data.ToString());
        }

        //ʵ�ַǷ��ͷ���
        public void ShowInfo()
        {
            Console.WriteLine(myData.ToString());
        }

        public void ShowInfo(string str)
        {
            Console.WriteLine(str);
        }

        //���Ͳ�����ʶ����ͬ��������������Ϣ
        //public void ShowInfo<T>(T t)
        //{
        //}


        public void ShowInfo<TA, TB>(TA a, TB b)
        {
        }

        public void ShowInfo<TB, TA>(TA a, TB b)
        {
        }

    }
}
