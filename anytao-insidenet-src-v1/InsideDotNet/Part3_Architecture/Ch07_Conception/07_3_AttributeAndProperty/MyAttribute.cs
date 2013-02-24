// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Conception.AttributeAndProperty
// Release     : 2007/04/19 1.0
// Description : 7.3  历史纠葛：特性和属性

using System;
using System.Reflection;

namespace InsideDotNet.Conception.AttributeAndProperty
{
    //定制特性也可以应用在其他定制特性上，
    //应用AttributeUsage，来控制如何应用新定义的特性
    [AttributeUsageAttribute(AttributeTargets.All,       //可应用任何元素
        AllowMultiple = true,                            //允许应用多次
        Inherited = false)]                              //不继承到派生类
    //特性也是一个类，
    //必须继承自System.Attribute类，
    //命名规范为："类名"+Attribute。		
    public class MyselfAttribute : System.Attribute
    {
        //定义字段
        private string _name;
        private int _age;
        private string _memo;

        //必须显式的定义其构造函数
        public MyselfAttribute()
        {
        }
        public MyselfAttribute(string name, int age)
        {
            _name = name;
            _age = age;
        }

        //定义属性
        //显然特性和属性不是一回事儿
        public string Name
        {
            get { return _name == null ? string.Empty : _name; }
        }

        public int Age
        {
            get { return _age; }
        }

        public string Memo
        {
            get { return _memo; }
            set { _memo = value; }
        }

        //定义方法
        public void ShowName()
        {
            Console.WriteLine("Hello, {0}", _name == null ? "world." : _name);
        }
    }

    //应用自定义特性
    //可以以Myself或者MyselfAttribute作为特性名
    //可以给属性Memo赋值
    //[Myself("Emma", 25, Memo = "Emma is my good girl.")]
    [Myself()]
    public class Mytest
    {
        public void SayHello()
        {
            Console.WriteLine("Hello, my.net world.");
        }
    }

    public class Myrun
    {
        public static void Main_7_3_1(string[] args)//Main_7_3_1
        {
            //如何以反射确定特性信息
            Type tp = typeof(Mytest);
            MemberInfo info = tp;
            MyselfAttribute myAttribute =
                (MyselfAttribute)Attribute.GetCustomAttribute(info, typeof(MyselfAttribute));
            if (myAttribute != null)
            {
                //嘿嘿，在运行时查看注释内容，是不是很爽
                Console.WriteLine("Name: {0}", myAttribute.Name);
                Console.WriteLine("Age: {0}", myAttribute.Age);
                Console.WriteLine("Memo of {0} is {1}", myAttribute.Name, myAttribute.Memo);
                myAttribute.ShowName();
            }

            //多点反射
            object obj = Activator.CreateInstance(typeof(Mytest));

            MethodInfo mi = tp.GetMethod("SayHello");
            mi.Invoke(obj, null);
            Console.ReadLine();
        }
    }
}
