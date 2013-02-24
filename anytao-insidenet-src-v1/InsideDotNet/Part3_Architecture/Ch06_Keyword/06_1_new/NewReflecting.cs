// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Keyword.New
// Release     : 2007/04/28 1.0
// Description : 6.1  把new说透

using System;

namespace InsideDotNet.Keyword.New
{
    class MyClass
    {
        private int _id;

        public MyClass(int id)
        {
            _id = id;
        }
    }

    struct MyStruct
    {
        private string _name;

        public MyStruct(string name)
        {
            _name = name;
        }
    }

    class NewReflecting
    {
        public static void Main_6_1_3()//Main_6_1_3
        {
            int i;
            int j = new int();
            MyClass mClass = new MyClass(123);
            MyStruct mStruct = new MyStruct("My Struct");
        }
    }
}
