// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.Conception.InterfaceAndAbstractClass
// Release     : 2007/04/12 1.0
// Description : 7.4  ��������̣��ӿںͳ�����

using System;

namespace InsideDotNet.Conception.InterfaceAndAbstractClass
{
    //���������
    abstract public class AnimalEx
    {
        //�����ֶ�
        protected int _id;
        //��������
        public abstract int Id
        {
            get;
            set;
        }

        //���巽��
        public abstract void Eat();

        //����������
        public string this[int index]
        {
            get { return null; }
            set { ;}
        }
    }

    //ʵ�ֳ�����
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
