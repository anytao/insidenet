// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Memory.NewObj
// Release     : 2007/11/27 1.0
// Description : 5.2  对象创建始末

using System;

namespace InsideDotNet.Memory.NewObj
{
    class RefAndValue
    {
    }

    public struct MyValueType
    {
        //值类型中的引用类型字段
        public object RefField;

        public MyValueType(object o)
        {
            RefField = new object();
        }
    }

    public class MyRefType
    {
        //引用类型中的值类型字段
        public Int32 ValueField;

        public MyRefType()
        {
            ValueField = 0;
        }

        public static void Main()
        {
            MyRefType refType = new MyRefType();
            MyValueType valueType = new MyValueType(refType);
        }
    }
}