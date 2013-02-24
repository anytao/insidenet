// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.Conception.InterfaceAndAbstractClass
// Release     : 2007/04/12 1.0
// Description : 7.4  ��������̣��ӿںͳ�����

using System;

namespace InsideDotNet.Conception.InterfaceAndAbstractClass
{
    //1. ���������
    public abstract class Animal
    {
        protected string _name;

        //������������
        public abstract string Name
        {
            get;
        }

        //�������󷽷�
        public abstract void Show();

        //ʵ��һ�㷽��
        public void MakeVoice()
        {
            Console.WriteLine("All animals can make voice!");
        }
    }

    //2. ����ӿ�
    public interface IAction
    {
        //���幫��������ǩ
        void Move();
    }

    //3. ʵ�ֳ�����ͽӿ�
    public class Duck : Animal, IAction
    {
        public Duck(string name)
        {
            _name = name;
        }

        //���س��󷽷�
        public override void Show()
        {
            Console.WriteLine(_name + " is showing for you.");
        }

        //���س�������
        public override string Name
        {
            get { return _name; }
        }

        //ʵ�ֽӿڷ���
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

    //4. �ͻ��˵���
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
