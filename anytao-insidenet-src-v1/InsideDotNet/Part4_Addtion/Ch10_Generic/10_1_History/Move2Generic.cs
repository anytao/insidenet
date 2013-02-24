// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.Generic.History
// Release     : 2007/12/01 1.0
// Description : 10.1  ׷�ݷ���

using System;

namespace InsideDotNet.Generic.History
{
    class Move2Generic
    {
        public static void Main_10_1_1()//Main_10_1_1
        {
            MyArray myArr = new MyArray();

            //���Խ����κ����͵�Ԫ��
            myArr.Add("Hello, world");
            myArr.Add(123);
            myArr.Add(new MyArray());

            Console.WriteLine(myArr[2]);

            //Ǳ�ڵ����Ͱ�ȫ����
            Int32 myItem = (Int32)myArr[0];
            Console.WriteLine(myItem);
        }

        public static void Main()//Main_10_1_2
        {
            MyArray<int> myIntArr = new MyArray<int>();
            myIntArr.Add(123);
            Console.WriteLine(myIntArr[0]);
            //��֤���Ͱ�ȫ���޷�ͨ��������
            //string myItem = (string)myIntArr[0];  
            MyArray<string> myStringArr = new MyArray<string>();
            myStringArr.Add("222");
            Console.WriteLine(myStringArr[0]);
        }
    }

    //��ʼ�汾���Զ��弯��--���ܹ���string����
    class MyArray_1
    {
        //�Զ��弯�ϵ�Ŀ��Ԫ��
        private string[] _items;
        private Int32 _size = 0;

        //ʵ��Ԫ�����ӹ���
        public void Add(string item)
        {
            _items[_size] = item;
            _size++;
        }

        //ʵ��������
        public string this[Int32 index]
        {
            get { return _items[index]; }
            set { _items[index] = value; }
        }

        //ʵ�ֹ�����
        public MyArray_1()
        {
            _items = new string[100];
        }
    }

    //�޸İ汾���Զ��弯��--�ܹ������κ�����
    class MyArray
    {
        private object[] _items;
        private Int32 _size = 0;

        public void Add(object item)
        {
            _items[_size] = item;
            _size++;
        }

        public object this[Int32 index]
        {
            get { return _items[index]; }
            set { _items[index] = value; }
        }

        public MyArray()
        {
            _items = new object[100];
        }
    }

    //���հ汾���Զ��弯��--�ܹ���ȫ�����κ�����
    class MyArray<T>
    {
        //�Զ��弯�ϵ�Ŀ��Ԫ��
        private T[] _items;


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
        }
    }
}
