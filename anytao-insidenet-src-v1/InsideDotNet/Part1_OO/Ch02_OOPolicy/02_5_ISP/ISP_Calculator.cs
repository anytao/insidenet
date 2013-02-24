// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.OOPolicy.ISP
// Release     : 2007/12/06 1.0
// Description : 2.5 �ӿڸ���ԭ��

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
            //��Ҫ�ǹ���
            myWork.ToWork();
            //����������
            myFun.ToBeFun();
        }
    }

    class Child
    {
        private IComputerLearn myLearn;

        public void UseComputer()
        {
            //ֻ��ѧϰ���������������ķ���
            myLearn.ToLearn();
        }
    }
}
