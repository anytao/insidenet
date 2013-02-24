// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Conception.AttributeAndProperty
// Release     : 2007/04/19 1.0
// Description : 7.3  历史纠葛：特性和属性

using System;
using System.Reflection;

namespace InsideDotNet.Conception.AttributeAndProperty
{
    [AttributeUsage(AttributeTargets.Class |
        AttributeTargets.Method,
        Inherited = true)]
    public class TestAttribute : System.Attribute
    {
        public TestAttribute(string message)
        {
            Console.WriteLine(message);
        }
        public void RunTest()
        {
            Console.WriteLine("TestAttribute here.");
        }
    }

    public class Tester
    {
        [Test("Error Here.")]
        public void CannotRun()
        {
            //
        }

        public static void Main_7_3_3()//Main_7_3_3
        {
            Tester t = new Tester();
            t.CannotRun();

            Type tp = typeof(Tester);
            MethodInfo mInfo = tp.GetMethod("CannotRun");
            TestAttribute myAtt = (TestAttribute)Attribute.GetCustomAttribute(mInfo, typeof(TestAttribute));
            myAtt.RunTest();
        }
    }
}
