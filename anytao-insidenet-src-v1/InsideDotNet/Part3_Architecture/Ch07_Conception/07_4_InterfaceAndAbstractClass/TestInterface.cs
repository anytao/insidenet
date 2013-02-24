// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.Conception.InterfaceAndAbstractClass
// Release     : 2007/04/12 1.0
// Description : 7.4  ��������̣��ӿںͳ�����

using System;

namespace InsideDotNet.Conception.InterfaceAndAbstractClass
{
    public interface IComparable
    {
        int CompareTo(object o);
    }

    public class TestInterface : IComparable
    {
        public TestInterface()
        {
        }

        private int _value;
        public int Value
        {
            get { return _value; }
            set { _value = value; }
        }

        public int CompareTo(object o)
        {
            //ʹ��asģʽ����ת���ж�
            TestInterface tester = o as TestInterface;

            if (tester != null)
            {
                //ʵ�ֳ��󷽷�������int��CompareToʵ��
                return _value.CompareTo(tester._value);
            }
            return 0;
        }
    }

}
