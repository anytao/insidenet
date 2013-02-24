// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Conception.ConstAndReadonly
// Release     : 2007/10/02 1.0
// Description : 7.1 什么才是不变：const和readonly

using System;

namespace InsideDotNet.Conception.ConstAndReadonly
{
    class Readonly_PropertyAndField
    {
        public static void Main_7_1_2()//Main_7_1_2
        {
            MyReadonlyEx myReadonly = new MyReadonlyEx("王", "老五");
            Console.WriteLine(myReadonly.Name);
            Console.WriteLine(myReadonly.NickName);
        }
    }

    //对比只读字段和只读属性
    class MyReadonlyEx
    {
        //定义只读属性
        private string _firstName;
        private string _secondName;

        public string Name
        {
            get { return _firstName + _secondName; }
        }

        //定义只读字段
        public readonly string NickName;

        public MyReadonlyEx(string firstName, string secondName)
        {
            _firstName = firstName;
            _secondName = secondName;
            NickName = "小王";
        }

    }
}
