// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.Framework.DelegateEx
// Release     : 2007/10/30 1.0
// Description : 8.5 һ����У�ί�С�����������Lambda���ʽ

using System;
using System.Collections.Generic;
using System.Text;

namespace InsideDotNet.Framework.DelegateEx
{
    //.NET 1.1--Delegate
    class DelegateEx
    {
        //����һ��ί��
        delegate void CalculateDelegate(Int32 x, Int32 y);

        //������ί�й����ķ��������߾�����ͬ�ķ���ֵ���ͺͲ����б�
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

        //����ί�����ͱ���
        private static CalculateDelegate myDelegate;

        public static void Main_12_2_5()//Main_12_2_5
        {
            //����ί�а�
            myDelegate = new CalculateDelegate(Add);
            //�ص�Add����
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
