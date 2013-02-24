// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Framework.Object
// Release     : 2007/10/22 1.0
// Description : 8.1  万物归宗：System.Object

using System;
using System.Collections.Generic;
using System.Text;

namespace InsideDotNet.Framework.Object
{
    class MyClass
    {
    }

    class MyObject
    {
        public static void Main_8_1_2() //Main_8_1_2
        {
            MyClass mc1 = new MyClass();
            MyClass mc2 = new MyClass();
            //mc1和mc3指向同一对象实例
            MyClass mc3 = mc1;

            //显式：False
            Console.WriteLine(ReferenceEquals(mc1, mc2));
            //显式：True
            Console.WriteLine(ReferenceEquals(mc1, mc3));
            //显式：True
            Console.WriteLine(ReferenceEquals(null, null));
            //显式：False
            Console.WriteLine(ReferenceEquals(mc1, null));

            //显示：False
            Console.WriteLine(ReferenceEquals(1, 1));

            string str1 = "acb";
            string str2 = "acb";
            Console.WriteLine(str1 == str2);
        }

        public static void Main_8_1_3() //Main_8_1_3
        {
            object o = null;
            o.Equals(null);
        }
    }

    public class Object
    {
        //构造函数
        public Object()
        {
        }

        public virtual int GetHashCode()
        {
            return 1;
        }

        //获取对象类型信息
        public System.Type GetType()
        {
            return typeof(Object);
        }

        //执行对象的浅拷贝
        protected object MemberwiseClone()
        {
            return null;
        }

        //虚方法，返回对象的字符串表示方式
        public virtual string ToString()
        {
            return this.GetType().FullName.ToString();
        }

        public virtual bool Equals(object obj)
        {
            if (this == obj)
                return true;
            else
                return false;
            //return InternalEquals(this, obj);
        }

        public static bool Equals(object objA, object objB)
        {
            if (objA == objB)
            {
                return true;
            }

            if ((objA != null) && (objB != null))
            {
                return objA.Equals(objB);
            }

            return false;
        }

        public static bool ReferenceEquals(object objA, object objB)
        {
            return (objA == objB);
        }

        //析构函数
        protected virtual void Finalize()
        {

        }
    }

    //public interface IFormattable
    //{
    //    string ToString(string format, System.IFormatProvider formatProvider);
    //} 

    //描述DataTime.ToString方法
    //public struct DateTime : IFormattable
    //{
    //    public string ToString(string format, IFormatProvider provider)
    //    {
    //        return DateTimeFormat.Format(this, format, DateTimeFormatInfo.GetInstance(provider));
    //    }
    //}
}
