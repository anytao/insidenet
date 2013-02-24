// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Generic.More
// Release     : 2007/12/03 1.0
// Description : 10.3 深入泛型

using System;
using System.Collections.Generic;
using System.Text;

namespace InsideDotNet.Generic.More
{
    class Student : IComparable<Student>
    {
        public Int32 CompareTo(Student other)
        {
            return 1;
        }
    }

    class GenericInterface
    {
        public static void Main_10_3_1()//Main_10_3_1
        {
            MyArray<Int32> myArr = new MyArray<int>();
            myArr._intValue = 100;
            Console.WriteLine(myArr.CompareTo(100));

            MyArray<string> myStrArr = new MyArray<string>();
            myStrArr._strValue = "ABC";
            Console.WriteLine(myStrArr.CompareTo("abc"));

            //MyArray<Student> myStudentArray = new MyArray<Student>();
            //myStudentArray._value = new Student();
            //Console.WriteLine(myStudentArray.CompareTo(new Student()));
        }
    }

    class MyArray2<T> : IComparable<T>
    {
        public T _value = default(T);

        //实现IComparable<T>方法
        public Int32 CompareTo(T other)
        {
            IComparable<T> tmp = (IComparable<T>)_value;
            return tmp.CompareTo(other);
        }
    }

    class MyArray<T> : IComparable<Int32>, IComparable<String>
    {
        public Int32 _intValue = 0;
        public String _strValue = null;

        //实现IComparable<Int32>的接口方法
        public Int32 CompareTo(Int32 other)
        {
            return _intValue.CompareTo(other);
        }

        //实现Comparable<String>的接口方法
        public Int32 CompareTo(String other)
        {
            return _strValue.CompareTo(other);
        }
    }





    //public interface IList<T> : ICollection<T>, IEnumerable<T>, IEnumerable
    //{
    //    int IndexOf(T item);
    //    void Insert(int index, T item);
    //    void RemoveAt(int index);

    //    T this[int index] { get; set; }
    //}

    //public interface IDictionary<TKey, TValue>
}
