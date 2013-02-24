// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.Framework.Object
// Release     : 2007/10/22 1.0
// Description : 8.1  ������ڣ�System.Object

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
            //mc1��mc3ָ��ͬһ����ʵ��
            MyClass mc3 = mc1;

            //��ʽ��False
            Console.WriteLine(ReferenceEquals(mc1, mc2));
            //��ʽ��True
            Console.WriteLine(ReferenceEquals(mc1, mc3));
            //��ʽ��True
            Console.WriteLine(ReferenceEquals(null, null));
            //��ʽ��False
            Console.WriteLine(ReferenceEquals(mc1, null));

            //��ʾ��False
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
        //���캯��
        public Object()
        {
        }

        public virtual int GetHashCode()
        {
            return 1;
        }

        //��ȡ����������Ϣ
        public System.Type GetType()
        {
            return typeof(Object);
        }

        //ִ�ж����ǳ����
        protected object MemberwiseClone()
        {
            return null;
        }

        //�鷽�������ض�����ַ�����ʾ��ʽ
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

        //��������
        protected virtual void Finalize()
        {

        }
    }

    //public interface IFormattable
    //{
    //    string ToString(string format, System.IFormatProvider formatProvider);
    //} 

    //����DataTime.ToString����
    //public struct DateTime : IFormattable
    //{
    //    public string ToString(string format, IFormatProvider provider)
    //    {
    //        return DateTimeFormat.Format(this, format, DateTimeFormatInfo.GetInstance(provider));
    //    }
    //}
}
