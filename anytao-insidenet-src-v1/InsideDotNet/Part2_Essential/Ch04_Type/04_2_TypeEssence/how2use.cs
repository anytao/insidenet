// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.Type.TypeEssence
// Release     : 2007/05/23 1.0
// Description : 4.2  Ʒζ����---ֵ��������������  

using System;
using System.Diagnostics;

namespace InsideDotNet.Type.TypeEssence
{
    public class HelloWorld
    {
        private char a;

        public char A
        {
            get { return a; }
            set { a = value; }
        }

    }

    public class Test_String
    {
        public static void Main_4_2_1(string[] args)//Main_4_2_1
        {
            //����һ��string����
            string myMsg = "Anytao is anytao.";
            //�ı�stringֵ������ʾ
            ChangeMsg(myMsg);
            //��ǰ��myMsg�Ƿ����˸ı䣿
            ShowMsg(myMsg);

            HelloWorld hw = new HelloWorld();
            hw.A = 'a';
            ChangeHello(ref hw);
            Console.WriteLine(hw.A);

        }

        public static void ChangeHello(ref HelloWorld hw)
        {
            hw.A = 'b';
            Console.WriteLine(hw.A);
        }

        public static void ChangeMsg(string str)
        {
            //�ı�������ݣ�ʵ�����������µ�string����
            //ִ�г�ʼ�������Ǻ����ⲿ�޷�ȡ�ñ仯
            str = "Anytao is not anytao.";
            Console.WriteLine(str);
        }

        public static void ShowMsg(string str)
        {
            Console.WriteLine(str);
        }
    }


    //  <summary>
    //  02 string���͵�equals����
    //  </summary>
    public class TestEquals
    {
        public static void Main_4_2_2()//Main_4_2_2
        {
            string aString = "123";
            string bString = "123";
            Console.WriteLine((aString == bString)); //��ʾΪtrue���ȼ���aString.Equals(bString)��
            string cString = bString;
            cString = "456";
            Console.WriteLine((bString == cString)); //��ʾΪfalse���ȼ���bString.Equals(cString)��


            char a = 'c';
            char b = 'c';
            Console.WriteLine((a.Equals(b)));      //���true;
        }
    }


    // <summary>
    // 03 isValueType���Ե�ʹ��
    // </summary>
    public struct MyStructTester
    { }

    public class Test_IsValueType
    {
        public static void Main_4_2_3()//Main_4_2_3
        {
            MyStructTester aStruct = new MyStructTester();
            System.Type type = aStruct.GetType();

            if (type.IsValueType)
            {
                Console.WriteLine("{0} belongs to value type.", aStruct.ToString());
            }

        }
    }



}