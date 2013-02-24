// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.OOThink.Inheritance
// Release     : 2007/09/05 1.0
// Description : 1.2 �̳еı���

using System;

namespace InsideDotNet.OOThink.Inheritance
{
    class InheritanceEssential
    {
    }

    interface IFlyable
    {
        void CanFly();
    }

    public abstract class Animal
    {
        public abstract void ShowType();

        public void Eat()
        {
            Console.WriteLine("Animal always eat.");
        }
    }

    public class Bird : Animal
    {
        public string type = "Bird";

        public override void ShowType()
        {
            Console.WriteLine("Type is {0}", type);
        }

        private string color;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }
    }

    public class Chicken : Bird
    {
        public string type = "Chicken";

        public override void ShowType()
        {
            Console.WriteLine("Type is {0}", type);
        }

        public void ShowColor()
        {
            Console.WriteLine("Color is {0}", Color);
        }
    }

    #region ���Adapterģʽ
    interface ITweetable
    {
        void ToTweet();
    }

    public class ChickenAdapter : Chicken, ITweetable
    {
        public void ToTweet()
        {
            Console.WriteLine("Chicken crows.");
        }
    }

    #endregion

    #region �����Adapterģʽ
    public class BirdAdapter : ITweetable
    {
        private Bird _bird;

        public BirdAdapter(Bird bird)
        {
            _bird = bird;
        }

        public void ShowType()
        {
            _bird.ShowType();
        }

        public void ToTweet()
        {
            //Ϊ��ͬ������ʵ�ֲ�ͬ��ToTweet��Ϊ
        }
    }
    #endregion



    public class TestInheritance
    {
        public static void Main()
        {

            Bird animal = new Bird();
            animal.ShowType();
            Chicken chicken = new Chicken();
            chicken.Eat();
            chicken.ShowColor();
            chicken.ShowType();

            Bird bird = new Chicken();
            bird.ShowType();
            Console.WriteLine(bird.type);

            ChickenAdapter ca = new ChickenAdapter();
            ca.ToTweet();

            BirdAdapter ba = new BirdAdapter(new Chicken());
            ba.ShowType();
            ba.ToTweet();

            Console.Read();
        }
    }

}