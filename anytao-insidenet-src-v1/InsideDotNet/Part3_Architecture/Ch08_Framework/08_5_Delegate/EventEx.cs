// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.Framework.DelegateEx
// Release     : 2007/12/22 1.0
// Description : 8.5 һ����У�ί�С�����������Lambda���ʽ

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
        //����һ��CalculateEventArgs��
        //���ڴ���¼�����ʱ������򴫵ݵ�״̬��Ϣ
        public class CalculateEventArgs : EventArgs
        {
            public readonly Int32 x, y;

            public CalculateEventArgs(Int32 x, Int32 y)
            {
                this.x = x;
                this.y = y;
            }
        }

        //�����¼�ί��
        public delegate void CalculateEventHandler(object sender, CalculateEventArgs e);

        //�����¼���Ա���ṩ�ⲿ��
        public event CalculateEventHandler MyCalculate;

        //�ṩ�ܱ������鷽�������������าд���ܾ�����
        protected virtual void OnCalculate(CalculateEventArgs e)
        {
            if (MyCalculate != null)
            {
                MyCalculate(this, e);
            }
        }

        //���м��㣬���ø÷�����ʾ���µļ��㷢��
        public void Calculate(Int32 x, Int32 y)
        {
            CalculateEventArgs e = new CalculateEventArgs(x, y);
            //֪ͨ���е��¼���ע����
            OnCalculate(e);
        }
    }

    //�����¼�������
    public class CalculatorManager
    {
        //������Ϣ֪ͨ����
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
            //�¼�������
            CalculatorManager cm = new CalculatorManager();

            //�¼���
            calculator.MyCalculate += cm.Add;
            calculator.Calculate(100, 200);
            calculator.MyCalculate += cm.Substract;
            calculator.Calculate(100, 200);

            //�¼�ע��
            calculator.MyCalculate -= cm.Add;
            calculator.Calculate(100, 200);
        }
    }

}
