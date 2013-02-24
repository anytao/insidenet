// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Type.TypeEssence
// Release     : 2007/05/23 1.0
// Description : 4.2  品味类型---值类型与引用类型  

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
            //定义一个string类型
            string myMsg = "Anytao is anytao.";
            //改变string值，并显示
            ChangeMsg(myMsg);
            //当前的myMsg是否发生了改变？
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
            //改变参数内容，实际是生成了新的string对象
            //执行初始化，但是函数外部无法取得变化
            str = "Anytao is not anytao.";
            Console.WriteLine(str);
        }

        public static void ShowMsg(string str)
        {
            Console.WriteLine(str);
        }
    }


    //  <summary>
    //  02 string类型的equals特性
    //  </summary>
    public class TestEquals
    {
        public static void Main_4_2_2()//Main_4_2_2
        {
            string aString = "123";
            string bString = "123";
            Console.WriteLine((aString == bString)); //显示为true，等价于aString.Equals(bString)；
            string cString = bString;
            cString = "456";
            Console.WriteLine((bString == cString)); //显示为false，等价于bString.Equals(cString)；


            char a = 'c';
            char b = 'c';
            Console.WriteLine((a.Equals(b)));      //输出true;
        }
    }


    // <summary>
    // 03 isValueType属性的使用
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