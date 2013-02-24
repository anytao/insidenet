// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.OOPolicy.ISP
// Release     : 2007/12/06 1.0
// Description : 2.5 接口隔离原则

using System;

namespace InsideDotNet.OOPolicy.ISP
{
    class ISP_Calculator
    {
        public static void Main()
        { 
        }
    }

    interface ICalculator
    {
    }

    interface IComputerLearn
    {
        void ToLearn();
    }

    interface IComputerWork
    {
        void ToWork();
    }

    interface IComputerBeFun
    {
        void ToBeFun();
    }

    class Adult
    {
        private IComputerLearn myLearn;
        private IComputerWork myWork;
        private IComputerBeFun myFun;

        public void UseComputer()
        {
            //主要是工作
            myWork.ToWork();
            //还可以娱乐
            myFun.ToBeFun();
        }
    }

    class Child
    {
        private IComputerLearn myLearn;

        public void UseComputer()
        {
            //只有学习，不会依赖其他的方法
            myLearn.ToLearn();
        }
    }
}
