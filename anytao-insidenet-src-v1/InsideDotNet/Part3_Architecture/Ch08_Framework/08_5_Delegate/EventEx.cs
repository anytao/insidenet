// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Framework.DelegateEx
// Release     : 2007/12/22 1.0
// Description : 8.5 一脉相承：委托、匿名方法和Lambda表达式

using System;
using System.Collections.Generic;
using System.Text;

namespace InsideDotNet.Framework.DelegateEx
{
    class EventEx
    {
    }

    public class Calculator
    {
        //定义一个CalculateEventArgs，
        //用于存放事件引发时向处理程序传递的状态信息
        public class CalculateEventArgs : EventArgs
        {
            public readonly Int32 x, y;

            public CalculateEventArgs(Int32 x, Int32 y)
            {
                this.x = x;
                this.y = y;
            }
        }

        //声明事件委托
        public delegate void CalculateEventHandler(object sender, CalculateEventArgs e);

        //定义事件成员，提供外部绑定
        public event CalculateEventHandler MyCalculate;

        //提供受保护的虚方法，可以由子类覆写来拒绝监视
        protected virtual void OnCalculate(CalculateEventArgs e)
        {
            if (MyCalculate != null)
            {
                MyCalculate(this, e);
            }
        }

        //进行计算，调用该方法表示有新的计算发生
        public void Calculate(Int32 x, Int32 y)
        {
            CalculateEventArgs e = new CalculateEventArgs(x, y);
            //通知所有的事件的注册者
            OnCalculate(e);
        }
    }

    //定义事件触发者
    public class CalculatorManager
    {
        //定义消息通知方法
        public void Add(object sender, Calculator.CalculateEventArgs e)
        {
            Console.WriteLine(e.x + e.y);
        }

        public void Substract(object sender, Calculator.CalculateEventArgs e)
        {
            Console.WriteLine(e.x - e.y);
        }
    }

    public class Test_Calculator
    {
        public static void Main()//Main_8_5_1
        {
            Calculator calculator = new Calculator();
            //事件触发者
            CalculatorManager cm = new CalculatorManager();

            //事件绑定
            calculator.MyCalculate += cm.Add;
            calculator.Calculate(100, 200);
            calculator.MyCalculate += cm.Substract;
            calculator.Calculate(100, 200);

            //事件注销
            calculator.MyCalculate -= cm.Add;
            calculator.Calculate(100, 200);
        }
    }

}
