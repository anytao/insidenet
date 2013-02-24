// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.Keyword.Convert
// Release     : 2007/11/22 1.0
// Description : 6.4 ת���ؼ���

using System;
using System.Collections.Generic;
using System.Text;

namespace InsideDotNet.Keyword.Convert
{
    class MyAge
    {
        private Int32 age = 0;

        public Int32 Age
        {
            get { return age; }
            set { age = value; }
        }

        public MyAge()
        {
        }

        private MyAge(Int32 age)
        {
            this.age = age;
        }

        //���͵�MyAge����ʽת��
        public static implicit operator MyAge(Int32 year)
        {
            return new MyAge(year > 1980 ? (year - 1980) : -1);
        }

        //MyAge�����͵���ʽת��
        public static explicit operator Int32(MyAge age)
        {
            if (age == null)
            {
                throw new ArgumentNullException("����Ϊ�ա�");
            }

            if ((age.Age < 0) || (age.Age > 150))
            {
                throw new InvalidCastException("�����ܵ�����ֵ��");
            }

            return age.Age;
        }

        ////MyAge��String���͵���ʽת��
        //public static explicit operator String(MyAge age)
        //{
        //    return age.Age.ToString();
        //}

        //MyAge��String���͵���ʽת��
        public static implicit operator String(MyAge age)
        {
            return "�ҵ������ǣ�" + age.Age.ToString();
        }

        //public static implicit operator MyAge(MyAge age)
        //{
        //    return age;
        //}
    }

    class Test_MyAge
    {
        public static void Main()
        {
            MyAge age = new MyAge();
            //ִ����ʽ����ת����MyAgeת��ΪInt32
            Int32 bornAge = (Int32)age;
            //ִ����ʽ����ת����Int32ת��ΪMyAge
            age = DateTime.Now.Year;
            //ִ����ʽת����MyAgeת��Ϊstring            
            Console.WriteLine(age);

            int i = 9;
            double d = (double)i;

        }
    }

    class A
    {

    }

}
