// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.NewFeature.CSharp3
// Release     : 2007/12/12 1.0
// Description : 12.2  赏析C＃3.0--隐式类型变量（Implicitly Typed Local Variables）和隐式类型数组（Implicitly Typed Array）

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InsideDotNet.NewFeature.CSharp3
{
    class ImplicitlyType
    {
        public static void Main_12_2_10()//Main_12_2_10
        {
            //定义基元类型
            var i = 100;
            var str = "Hello, world.";
            //定义数组类型
            var arr = new[] { "小王", "张三", "李四" };
            //定义自定义类型
            var user = new User { Name = "小王", Age = 27 };
            Console.WriteLine(i);
            Console.WriteLine(str);
        }

        ////反编译结果
        //public static void Main()
        //{
        //    int i = 100;
        //    string str = "Hello, world.";
        //    string[] arr = new string[] { "小王", "张三", "李四" };
        //    User <>g__initLocal0 = new User();
        //    <>g__initLocal0.Name = "小王";
        //    <>g__initLocal0.Age = 0x1b;
        //    User user = <>g__initLocal0;
        //    Console.WriteLine(i);
        //    Console.WriteLine(str);
        //}



    }
}
