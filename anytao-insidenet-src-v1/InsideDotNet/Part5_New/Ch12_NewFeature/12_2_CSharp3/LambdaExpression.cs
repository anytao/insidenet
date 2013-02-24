﻿// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.NewFeature.CSharp3
// Release     : 2007/12/12 1.0
// Description : 12.2  赏析C＃3.0--  Lambda表达式（LambdaExpressions）(History Frome Delegate to Lambda)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InsideDotNet.NewFeature.CSharp3
{
    class LambdaExpression
    {
    }

    //.NET 1.1--Delegate
    class DelegateEx
    {
        //声明一个委托
        delegate void CalculateDelegate(Int32 x, Int32 y);

        //创建与委托关联的方法，二者具有相同的返回值类型和参数列表
        public static void Add(Int32 x, Int32 y)
        {
            Console.WriteLine(x + y);
        }

        public static void Subtract(Int32 x, Int32 y)
        {
            Console.WriteLine(x - y);
        }

        public static void Multiply(Int32 x, Int32 y)
        {
            Console.WriteLine(x * y);
        }

        //定义委托类型变量
        private static CalculateDelegate myDelegate;

        public static void Main_12_2_5()//Main_12_2_5
        {
            //进行委托绑定
            myDelegate = new CalculateDelegate(Add);
            //回调Add方法
            //myDelegate(100, 200);
            myDelegate.Invoke(100, 200);

            myDelegate = new CalculateDelegate(Subtract);
            //myDelegate(100, 200);
            myDelegate.Invoke(100, 200);
        }

        public static void Main_12_2_8()//Main_12_2_8
        {
            myDelegate = new CalculateDelegate(Add);
            myDelegate += new CalculateDelegate(Subtract);
            myDelegate += new CalculateDelegate(Multiply);
            myDelegate(100, 200);
            myDelegate -= new CalculateDelegate(Add);
            myDelegate(100, 200);

            myDelegate = (CalculateDelegate)Delegate.Combine(new CalculateDelegate(Add),
                new CalculateDelegate(Subtract), new CalculateDelegate(Multiply));
            myDelegate(100, 200);
            myDelegate = (CalculateDelegate)Delegate.Remove(myDelegate,
                new CalculateDelegate(Add));
            myDelegate(100, 200);
        }
    }

    //.NET 2.0--Anonymous Method
    class AnonymousMethodEx
    {
        delegate void CalculateDelegate(Int32 x, Int32 y);

        public static void Main()//Main_12_2_6
        {
            //匿名方法
            CalculateDelegate mySubstractDelegate = delegate(Int32 x, Int32 y)
            {
                Console.WriteLine(x - y);
            };

            CalculateDelegate myAddDelegate = delegate(Int32 x, Int32 y)
            {
                Console.WriteLine(x + y);
            };

            mySubstractDelegate(100, 200);
        }
    }

    //.NET 3.0--Lambda Expression
    class LambdaExpressionEx
    {
        delegate void CalculateDelegate(Int32 x, Int32 y);

        public static void Main_12_2_7()//Main_12_2_7
        {
            CalculateDelegate myDelegate = (x, y) => Console.WriteLine(x - y);
            myDelegate(100, 200);
        }
    }
}

