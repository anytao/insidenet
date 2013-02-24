// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Conception.ConstAndReadonly
// Release     : 2007/10/01 1.0
// Description : 7.1 什么才是不变：const和readonly

using System;
using System.Collections.Generic;
using System.Text;

namespace InsideDotNet.Conception.ConstAndReadonly
{
    //const和readonly基础示例
    public class ConstAndReadonly
    {
        //声明字段
        private const string NAME = "Wang Tao";
        private readonly Int32 AGE = 22;
        private readonly string SEX;
        private static readonly string PASSWORD = "000000";

        private static string astr = "abc";
        private readonly string str = astr + "efg";

        //构造函数
        public ConstAndReadonly()
        {
            AGE = 23;
        }

        public ConstAndReadonly(Int32 age, string sex)
        {
            AGE = age;
            SEX = sex;
        }

        //静态无参构造函数
        static ConstAndReadonly()
        {
            PASSWORD = "123456";
        }

        //局部常量定义
        public void InlineConst()
        {
            const string myDescription = "Good morning.";
            Console.WriteLine(myDescription);
        }

        ////不能在局部变量中使用readonly
        //public void InlineFunction()
        //{
        //    readonly string myName = "Wang";
        //}

        public static void Main()//Main_7_1_1
        {
            //访问静态成员
            Console.WriteLine(ConstAndReadonly.NAME);
            Console.WriteLine(ConstAndReadonly.PASSWORD);

            //访问非静态成员
            ConstAndReadonly cr = new ConstAndReadonly();
            Console.WriteLine(cr.AGE);
            Console.WriteLine(cr.SEX);
            ConstAndReadonly cr2 = new ConstAndReadonly(27, "Man");
            Console.WriteLine(cr2.AGE);
            Console.WriteLine(cr2.SEX);

            //局部常量
            cr.InlineConst();
        }
    }

    class const_readonly
    {
        public const int ID = 100;
        public const MyClass myCls = null;
        public readonly string NAME = "Anytao";

        public static void Main_7_1_1()//Main_7_1_1
        {
            const int idd = 222;
            Console.WriteLine(idd.ToString());
            Console.WriteLine(const_readonly.ID);

            //MyReadonly mr = new MyReadonly();
            //Console.WriteLine(mr.NAME);

            //MyReadonly mr2 = new MyReadonly(1);
            //Console.WriteLine(mr2.NAME);

            //static readonly只能声明在静态无参构造函数中
            //Console.WriteLine(MyReadonly._name);

            Console.WriteLine(MyReadonly.NAME);

        }
    }

    public class MyClass
    {
        public const string CONST_STRING = "First Const String.";
        public static readonly string READONLY_STRING = "First Readonly String.";
    }

    public class MyReadonly
    {
        #region static readonly常量初始化
        //在声明时初始化
        public static readonly int ID = 99;

        //在静态无参构造函数中初始化
        public static readonly string NAME;
        static MyReadonly()
        {
            NAME = "Wang Tao";
        }

        #endregion

        #region readonly常量初始化

        //public MyReadonly()
        //{
        //    NAME = "Wang";
        //}

        //public MyReadonly(int i)
        //{
        //    NAME = "Liu";
        //}

        #endregion

    }
}
