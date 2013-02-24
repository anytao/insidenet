// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Conception.InterfaceAndAbstractClass
// Release     : 2007/04/12 1.0
// Description : 7.4  面向抽象编程：接口和抽象类

using System;

namespace InsideDotNet.Conception.InterfaceAndAbstractClass
{
    //1. 定义抽象类
    public abstract class Animal
    {
        protected string _name;

        //声明抽象属性
        public abstract string Name
        {
            get;
        }

        //声明抽象方法
        public abstract void Show();

        //实现一般方法
        public void MakeVoice()
        {
            Console.WriteLine("All animals can make voice!");
        }
    }

    //2. 定义接口
    public interface IAction
    {
        //定义公共方法标签
        void Move();
    }

    //3. 实现抽象类和接口
    public class Duck : Animal, IAction
    {
        public Duck(string name)
        {
            _name = name;
        }

        //重载抽象方法
        public override void Show()
        {
            Console.WriteLine(_name + " is showing for you.");
        }

        //重载抽象属性
        public override string Name
        {
            get { return _name; }
        }

        //实现接口方法
        public void Move()
        {
            Console.WriteLine("Duck also can swim.");
        }

    }

    public class Dog : Animal, IAction
    {
        public Dog(string name)
        {
            _name = name;
        }

        public override void Show()
        {
            Console.WriteLine(_name + " is showing for you.");
        }

        public override string Name
        {
            get { return _name; }
        }

        public void Move()
        {
            Console.WriteLine(_name + " also can run.");
        }

    }

    //4. 客户端调用
    public class TestAnmial
    {
        public static void Main_7_4_1(string[] args)//Main_7_4_1
        {
            Animal duck = new Duck("Duck");
            duck.MakeVoice();
            duck.Show();

            Animal dog = new Dog("Dog");
            dog.MakeVoice();
            dog.Show();

            IAction dogAction = new Dog("A big dog");
            dogAction.Move();
        }
    }

}
