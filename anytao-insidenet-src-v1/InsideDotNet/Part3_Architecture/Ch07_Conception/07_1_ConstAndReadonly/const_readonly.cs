// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.Conception.ConstAndReadonly
// Release     : 2007/10/01 1.0
// Description : 7.1 ʲô���ǲ��䣺const��readonly

using System;
using System.Collections.Generic;
using System.Text;

namespace InsideDotNet.Conception.ConstAndReadonly
{
    //const��readonly����ʾ��
    public class ConstAndReadonly
    {
        //�����ֶ�
        private const string NAME = "Wang Tao";
        private readonly Int32 AGE = 22;
        private readonly string SEX;
        private static readonly string PASSWORD = "000000";

        private static string astr = "abc";
        private readonly string str = astr + "efg";

        //���캯��
        public ConstAndReadonly()
        {
            AGE = 23;
        }

        public ConstAndReadonly(Int32 age, string sex)
        {
            AGE = age;
            SEX = sex;
        }

        //��̬�޲ι��캯��
        static ConstAndReadonly()
        {
            PASSWORD = "123456";
        }

        //�ֲ���������
        public void InlineConst()
        {
            const string myDescription = "Good morning.";
            Console.WriteLine(myDescription);
        }

        ////�����ھֲ�������ʹ��readonly
        //public void InlineFunction()
        //{
        //    readonly string myName = "Wang";
        //}

        public static void Main()//Main_7_1_1
        {
            //���ʾ�̬��Ա
            Console.WriteLine(ConstAndReadonly.NAME);
            Console.WriteLine(ConstAndReadonly.PASSWORD);

            //���ʷǾ�̬��Ա
            ConstAndReadonly cr = new ConstAndReadonly();
            Console.WriteLine(cr.AGE);
            Console.WriteLine(cr.SEX);
            ConstAndReadonly cr2 = new ConstAndReadonly(27, "Man");
            Console.WriteLine(cr2.AGE);
            Console.WriteLine(cr2.SEX);

            //�ֲ�����
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

            //static readonlyֻ�������ھ�̬�޲ι��캯����
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
        #region static readonly������ʼ��
        //������ʱ��ʼ��
        public static readonly int ID = 99;

        //�ھ�̬�޲ι��캯���г�ʼ��
        public static readonly string NAME;
        static MyReadonly()
        {
            NAME = "Wang Tao";
        }

        #endregion

        #region readonly������ʼ��

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
