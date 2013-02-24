// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.Conception.AttributeAndProperty
// Release     : 2007/04/19 1.0
// Description : 7.3  ��ʷ�������Ժ�����

using System;
using System.Runtime.InteropServices;

namespace InsideDotNet.Conception.AttributeAndProperty
{
    [assembly: MyselfAttribute()]                          //Ӧ���ڳ���
    [moduel: MyselfAttribute("Wang", 27)]            //Ӧ����ģ��
    class AttributeArea
    {
        //
    }

    [AttributeUsageAttribute(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
    class MyNewAttribute : System.Attribute
    {
        //
    }

    enum Animal
    {
        Dog = 0x0001,
        Cat = 0x0002,
        Duck = 0x0004,
        Chicken = 0x0008
    }

    public class Test_Flags
    {
        public static void Main()//Main_7_3_1
        {
            Animal animals = Animal.Dog | Animal.Cat;
            Console.WriteLine(animals.ToString());
        }
    }

    class DllImportTest
    {
        [DllImport("User32.dll")]
        public static extern int MessageBox(int hParent, string msg, string caption, int type);

        static int Main_7_3_2()//Main_7_3_2
        {
            return MessageBox(0, "How to use attribute in .NET", "InsideDotNet", 0);
        }
    }

}
