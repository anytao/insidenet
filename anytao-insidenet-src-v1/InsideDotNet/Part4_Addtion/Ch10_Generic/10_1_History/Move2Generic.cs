// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Generic.History
// Release     : 2007/12/01 1.0
// Description : 10.1  追溯泛型

using System;

namespace InsideDotNet.Generic.History
{
    class Move2Generic
    {
        public static void Main_10_1_1()//Main_10_1_1
        {
            MyArray myArr = new MyArray();

            //可以接受任何类型的元素
            myArr.Add("Hello, world");
            myArr.Add(123);
            myArr.Add(new MyArray());

            Console.WriteLine(myArr[2]);

            //潜在的类型安全问题
            Int32 myItem = (Int32)myArr[0];
            Console.WriteLine(myItem);
        }

        public static void Main()//Main_10_1_2
        {
            MyArray<int> myIntArr = new MyArray<int>();
            myIntArr.Add(123);
            Console.WriteLine(myIntArr[0]);
            //保证类型安全，无法通过编译检测
            //string myItem = (string)myIntArr[0];  
            MyArray<string> myStringArr = new MyArray<string>();
            myStringArr.Add("222");
            Console.WriteLine(myStringArr[0]);
        }
    }

    //初始版本的自定义集合--仅能管理string类型
    class MyArray_1
    {
        //自定义集合的目标元素
        private string[] _items;
        private Int32 _size = 0;

        //实现元素增加功能
        public void Add(string item)
        {
            _items[_size] = item;
            _size++;
        }

        //实现索引器
        public string this[Int32 index]
        {
            get { return _items[index]; }
            set { _items[index] = value; }
        }

        //实现构造器
        public MyArray_1()
        {
            _items = new string[100];
        }
    }

    //修改版本的自定义集合--能够管理任何类型
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

    //最终版本的自定义集合--能够安全管理任何类型
    class MyArray<T>
    {
        //自定义集合的目标元素
        private T[] _items;


        //集合大小计数
        private Int32 _size = 0;

        //实现元素增加功能
        public void Add(T item)
        {
            _items[_size] = item;
            _size++;
        }

        //实现索引器
        public T this[Int32 index]
        {
            get { return _items[index]; }
            set { _items[index] = value; }
        }

        //实现构造器
        public MyArray()
        {
            _items = new T[100];
        }
    }
}
