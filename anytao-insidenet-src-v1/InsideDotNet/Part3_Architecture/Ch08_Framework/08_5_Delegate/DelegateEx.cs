// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Framework.DelegateEx
// Release     : 2007/10/30 1.0
// Description : 8.5 一脉相承：委托、匿名方法和Lambda表达式

using System;
using System.Collections.Generic;
using System.Text;

namespace InsideDotNet.Framework.DelegateEx
{
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
}
