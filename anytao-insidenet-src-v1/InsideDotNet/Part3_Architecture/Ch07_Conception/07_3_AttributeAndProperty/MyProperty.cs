// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.Conception.AttributeAndProperty
// Release     : 2007/04/19 1.0
// Description : 7.3  ��ʷ�������Ժ�����

using System;

namespace InsideDotNet.Conception.AttributeAndProperty
{
    public class MyProperty
    {
        //�����ֶ�
        private string _name;
        private int _age;

        //�������ԣ�ʵ�ֶ�_name�ֶεķ�װ
        public string Name
        {
            get { return (_name == null) ? string.Empty : _name; }
            set { _name = value; }
        }

        //�������ԣ�ʵ�ֶ�_age�ֶεķ�װ
        //������ֶεķ�Χ����
        public int Age
        {
            get { return _age; }
            set
            {
                if ((value > 0) && (value < 150))
                {
                    _age = value;
                }
                else
                {
                    throw new Exception("Not a real age");
                }
            }
        }
    }

    public class MyTest
    {
        public static void Main_7_3_2(string[] args)//Main_7_3_2
        {
            MyProperty myProperty = new MyProperty();
            //����set������
            myProperty.Name = "Anytao";
            //����get������
            Console.WriteLine(myProperty.Name);
            myProperty.Age = 66;
            Console.WriteLine(myProperty.Age.ToString());
            Console.ReadLine();
        }
    }
}
