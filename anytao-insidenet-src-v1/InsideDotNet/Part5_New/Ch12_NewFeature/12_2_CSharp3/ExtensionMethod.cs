// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.NewFeature.CSharp3
// Release     : 2007/12/12 1.0
// Description : 12.2  赏析C＃3.0--扩展方法（Extension Methods）

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InsideDotNet.NewFeature.CSharp3
{
    static class ExtensionMethod
    {
        public static bool isName(this User user, string name)
        {
            return user.Name == name;
        }

        public static void Main_12_2_4()//Main_12_2_4
        {
            var user = new User { Name = "小王", Age = 27 };
            Console.WriteLine(user.isName("小佳"));

            User user2 = new User { Name = "Emma", Age = 26 };
            //调用扩展方法
            user2.ShowInfo();

            string str = "123abc";
            //调用扩展方法
            str.TellType();
            //调用继承的扩展方法
            str.ShowType();
        }
    }

    static class MyExtensions
    {
        //扩展自定义类型
        public static void ShowInfo(this User user)
        {
            Console.WriteLine("Name: {0}\nAge: {1}", user.Name, user.Age);
        }

        //扩展String的方法，对已有程序集的扩展
        public static void TellType(this string str)
        {
            Console.WriteLine("我是字符串：{0}", str);
        }

        //扩展System.Object
        public static void ShowType(this object o)
        {
            Console.WriteLine(o.GetType().ToString());
        }

        //无法通过编译
        //[System.Runtime.CompilerServices.Extension]
        //public static void Me(object o)
        //{ 
        //}
    }

    //反编译结果
    //.method public hidebysig static void TellType(string str) cil managed
    //{
    //    .custom instance void [System.Core]System.Runtime.CompilerServices.ExtensionAttribute::.ctor()
    //    .maxstack 8
    //    L_0000: nop 
    //    L_0001: ldstr "\u6211\u662f\u5b57\u7b26\u4e32\uff1a{0}"
    //    L_0006: ldarg.0 
    //    L_0007: call void [mscorlib]System.Console::WriteLine(string, object)
    //    L_000c: nop 
    //    L_000d: ret 
    //}


}
