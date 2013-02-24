// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.Conception.OverrideAndOverload
// Release     : 2007/10/03 1.0
// Description : 7.6 ò�����룺��д������

using System;
using System.Collections.Generic;
using System.Text;

namespace InsideDotNet.Conception.OverrideAndOverload
{
    class override_overload
    {
    }

    class Base
    {
        public virtual void MyFunc()
        {
            Console.WriteLine();
        }

        //�Բ�����ͬ��virtual����������
        public virtual void MyFunc(string str)
        {
            Console.WriteLine("{0} in Base", str);
        }

        //�����б�ͬ������ֵ��ͬ
        public bool MyFunc(string str, int id)
        {
            Console.WriteLine("AAA");
            return true;
        }

        //�����б�ͬ����Ϊ������ͬ��������ͬλ�õĲ������Ͳ�ͬ 
        public bool MyFunc(int id, string str)
        {
            Console.WriteLine("BBB");
            return false;
        }

        //�������أ���������б���ͬ
        public bool MyFunc<T>(string str, int id)
        {
            Console.WriteLine();
            return true;
        }

        //������󷽷�
        //public abstract void Func();
    }

    class Derived : Base
    {
        //��������Ա
        public new void MyFunc()
        {
        }

        //��д�����Ա
        public new void MyFunc(string str)
        {
            //�������з��ʸ����Ա
            //base.MyFunc(str);
            Console.WriteLine("{0} in Derived", str);
        }

        //��д������󷽷�
        //public override void Func()
        //{
        //    //base.Func();
        //    //throw new Exception("The method or operation is not implemented.");
        //}

        public static void Main()//Main_7_6_1
        {
            Base B = new Base();
            B.MyFunc("Hello");
            Derived A = new Derived();
            B = A;
            B.MyFunc("Morning");
        }

        public static void Main_7_6_2()//Main_7_6_2
        {
            Base bd = new Derived();
            bd.MyFunc("Hello");
            bd.MyFunc<int>("111", 111);
        }
    }

    class Test_override_overload
    {

    }
}
