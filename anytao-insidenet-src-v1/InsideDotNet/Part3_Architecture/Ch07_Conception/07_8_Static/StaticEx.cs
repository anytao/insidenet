// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.Conception.Static
// Release     : 2007/10/06 1.0
// Description : 7.8 ����֮�䣺��̬�ͷǾ�̬

using System;

namespace InsideDotNet.Conception.Static
{
    static class MyStatic
    {
        //������̬�ֶ�
        private static string staticString = "static string";

        //������̬����
        private static string StaticString
        {
            get { return staticString; }
            set { staticString = value; }
        }

        //ʵ�־�̬����
        public static void ShowMsg()
        {
            Console.WriteLine(StaticString);
        }

        public static void Main_7_8_2()//Main_7_8_2
        {
            //���ʾ�̬����
            MyStatic.ShowMsg();
        }
    }

    class ClassHelper
    {
        //���徲̬�ֶ�
        public static string StaticString = "Initial static string.";
        //����Ǿ�̬�ֶ�
        public string NonStaticString = "Initial non static string.";

        //��̬�޲ι��캯��
        static ClassHelper()
        {
            //ֻ�ܳ�ʼ����̬��Ա
            StaticString = "Change static string in static constructor.";
        }

        //ʵ�����캯��
        public ClassHelper()
        {
            //��ʼ���Ǿ�̬��Ա
            NonStaticString = "Change non static string in instance constructor. ";
            //��ʼ����̬��Ա
            StaticString = "Change static string in instance constructor.";

        }

        public static void Main()//Main_7_8_1
        {
            Console.WriteLine(ClassHelper.StaticString);

            ClassHelper ch = new ClassHelper();
            Console.WriteLine(ClassHelper.StaticString);
            Console.WriteLine(ch.NonStaticString);
        }
    }

    class Consumer
    {
        //����ʵ����Ա��ÿ���˵�����
        private double cost;

        public double Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        //���徲̬��Ա���ܼ�����
        private static double costAll;

        public static double CostAll
        {
            get { return Consumer.costAll; }
            set { Consumer.costAll = value; }
        }

        public void AddCost()
        {
            costAll += cost;
        }

        public void ShowCost()
        {
            Console.WriteLine(CostAll);
        }
    }

    class Test_Consumer
    {
        public static void Main_7_8_3()//Main_7_8_3
        {
            Consumer c1 = new Consumer();
            c1.Cost = 5.25;
            c1.AddCost();
            Consumer c2 = new Consumer();
            c2.Cost = 3.23;
            c2.AddCost();
            c1.ShowCost();
            c2.ShowCost();
        }
    }


    class MyMethodClass
    {
        private static string staticString = "A static string";
        private string nonStaticString = "Not a static string";

        //��̬��Ա
        //��������Ϊvirtual, abstract��override
        public static void StaticMethod()
        {
            //ֻ�ܷ��ʾ�̬��Ա
            //������this����
            Console.WriteLine(staticString);
        }

        //ʵ����Ա
        public void NonStaticMethod()
        {
            //���Է��ʾ�̬��Ա
            Console.WriteLine(staticString);
            //Ҳ���Է���ʵ����Ա
            //������this�ؼ��ַ���
            Console.WriteLine(this.nonStaticString);
        }
    }

    class MyMethodClassDerived : MyMethodClass
    {
        //�����ඨ�弰ʵ��        
    }

    class Test_MyMethodClass
    {
        public static void Main_7_8_4()//Main_7_8_4
        {
            MyMethodClass mmc = new MyMethodClass();
            //ʵ������ֻ���ɶ������
            mmc.NonStaticMethod();
            //��̬����ֻ���������
            MyMethodClass.StaticMethod();
            //��������Է��ʾ�̬���������ǲ��ܸ�д��̬����
            MyMethodClassDerived.StaticMethod();
        }
    }
}
