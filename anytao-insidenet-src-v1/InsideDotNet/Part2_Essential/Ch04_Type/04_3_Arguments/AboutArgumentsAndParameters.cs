// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Type.Arguments
// Release     : 2007/07/03 1.0
// Description : 4.3  参数之惑---传递的艺术 

using System;
using System.Collections.Generic;
using System.Text;

namespace InsideDotNet.Type.Arguments
{
    public class MyArguments
    {
        public static void Main_4_3_1()//Main_4_3_1
        {
            string myString = "This is your argument.";
            //myString是实际参数
            ShowString(myString);
        }

        private static void ShowString(string astr)
        {
            Console.WriteLine(astr);
        }


        ////通过函数重载实现参数默认值的方法
        //static void JudgeKind(string name, string kind)
        //{
        //    Console.WriteLine("{0} is a {1}", name, kind);
        //}

        //static void JudgeKind(string name)
        //{
        //    //伪代码
        //    if (name is Person)
        //    {
        //        //变相实现参数默认值“People”
        //        Console.WriteLine(name, "People");
        //    }
        //}


    }
}
