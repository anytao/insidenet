// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Conception.AttributeAndProperty
// Release     : 2007/04/19 1.0
// Description : 7.3  历史纠葛：特性和属性

using System;

namespace InsideDotNet.Conception.AttributeAndProperty
{
    public class MyProperty
    {
        //定义字段
        private string _name;
        private int _age;

        //定义属性，实现对_name字段的封装
        public string Name
        {
            get { return (_name == null) ? string.Empty : _name; }
            set { _name = value; }
        }

        //定义属性，实现对_age字段的封装
        //加入对字段的范围控制
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
            //触发set访问器
            myProperty.Name = "Anytao";
            //触发get访问器
            Console.WriteLine(myProperty.Name);
            myProperty.Age = 66;
            Console.WriteLine(myProperty.Age.ToString());
            Console.ReadLine();
        }
    }
}
