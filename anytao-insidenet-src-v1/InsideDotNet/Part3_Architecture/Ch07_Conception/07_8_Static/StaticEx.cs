// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Conception.Static
// Release     : 2007/10/06 1.0
// Description : 7.8 动静之间：静态和非静态

using System;

namespace InsideDotNet.Conception.Static
{
    static class MyStatic
    {
        //声明静态字段
        private static string staticString = "static string";

        //声明静态属性
        private static string StaticString
        {
            get { return staticString; }
            set { staticString = value; }
        }

        //实现静态方法
        public static void ShowMsg()
        {
            Console.WriteLine(StaticString);
        }

        public static void Main_7_8_2()//Main_7_8_2
        {
            //访问静态方法
            MyStatic.ShowMsg();
        }
    }

    class ClassHelper
    {
        //定义静态字段
        public static string StaticString = "Initial static string.";
        //定义非静态字段
        public string NonStaticString = "Initial non static string.";

        //静态无参构造函数
        static ClassHelper()
        {
            //只能初始化静态成员
            StaticString = "Change static string in static constructor.";
        }

        //实例构造函数
        public ClassHelper()
        {
            //初始化非静态成员
            NonStaticString = "Change non static string in instance constructor. ";
            //初始化静态成员
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
        //定义实例成员：每个人的消费
        private double cost;

        public double Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        //定义静态成员：总计消费
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

        //静态成员
        //不能修饰为virtual, abstract或override
        public static void StaticMethod()
        {
            //只能访问静态成员
            //不能以this访问
            Console.WriteLine(staticString);
        }

        //实例成员
        public void NonStaticMethod()
        {
            //可以访问静态成员
            Console.WriteLine(staticString);
            //也可以访问实例成员
            //可以以this关键字访问
            Console.WriteLine(this.nonStaticString);
        }
    }

    class MyMethodClassDerived : MyMethodClass
    {
        //派生类定义及实现        
    }

    class Test_MyMethodClass
    {
        public static void Main_7_8_4()//Main_7_8_4
        {
            MyMethodClass mmc = new MyMethodClass();
            //实例方法只能由对象访问
            mmc.NonStaticMethod();
            //静态方法只能由类访问
            MyMethodClass.StaticMethod();
            //派生类可以访问静态方法，但是不能覆写静态方法
            MyMethodClassDerived.StaticMethod();
        }
    }
}
