// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.Memory.NewObj
// Release     : 2007/11/27 1.0
// Description : 5.2  ���󴴽�ʼĩ

using System;

namespace InsideDotNet.Memory.NewObj
{
    class RefAndValue
    {
    }

    public struct MyValueType
    {
        //ֵ�����е����������ֶ�
        public object RefField;

        public MyValueType(object o)
        {
            RefField = new object();
        }
    }

    public class MyRefType
    {
        //���������е�ֵ�����ֶ�
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