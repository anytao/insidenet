// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Conception.InterfaceAndAbstractClass
// Release     : 2007/04/12 1.0
// Description : 7.4  面向抽象编程：接口和抽象类

using System;

namespace InsideDotNet.Conception.InterfaceAndAbstractClass
{
    //定义抽象类
    abstract public class AnimalEx
    {
        //定义字段
        protected int _id;
        //定义属性
        public abstract int Id
        {
            get;
            set;
        }

        //定义方法
        public abstract void Eat();

        //定义索引器
        public string this[int index]
        {
            get { return null; }
            set { ;}
        }
    }

    //实现抽象类
    public class DogEx : AnimalEx
    {
        public override int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public override void Eat()
        {
            Console.Write("Dog Eats.");
        }
    }

}
