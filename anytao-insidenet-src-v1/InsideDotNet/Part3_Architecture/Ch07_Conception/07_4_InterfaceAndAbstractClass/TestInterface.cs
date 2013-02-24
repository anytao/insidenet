// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Conception.InterfaceAndAbstractClass
// Release     : 2007/04/12 1.0
// Description : 7.4  面向抽象编程：接口和抽象类

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
            //使用as模式进行转型判断
            TestInterface tester = o as TestInterface;

            if (tester != null)
            {
                //实现抽象方法，调用int的CompareTo实现
                return _value.CompareTo(tester._value);
            }
            return 0;
        }
    }

}
