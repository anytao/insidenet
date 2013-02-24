// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Keyword.Convert
// Release     : 2007/11/22 1.0
// Description : 6.4 转换关键字

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

        //整型到MyAge的隐式转换
        public static implicit operator MyAge(Int32 year)
        {
            return new MyAge(year > 1980 ? (year - 1980) : -1);
        }

        //MyAge到整型的显式转换
        public static explicit operator Int32(MyAge age)
        {
            if (age == null)
            {
                throw new ArgumentNullException("参数为空。");
            }

            if ((age.Age < 0) || (age.Age > 150))
            {
                throw new InvalidCastException("不可能的年龄值。");
            }

            return age.Age;
        }

        ////MyAge到String类型的显式转换
        //public static explicit operator String(MyAge age)
        //{
        //    return age.Age.ToString();
        //}

        //MyAge到String类型的隐式转换
        public static implicit operator String(MyAge age)
        {
            return "我的年龄是：" + age.Age.ToString();
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
            //执行显式类型转换：MyAge转换为Int32
            Int32 bornAge = (Int32)age;
            //执行隐式类型转换：Int32转换为MyAge
            age = DateTime.Now.Year;
            //执行隐式转换：MyAge转换为string            
            Console.WriteLine(age);

            int i = 9;
            double d = (double)i;

        }
    }

    class A
    {

    }

}
