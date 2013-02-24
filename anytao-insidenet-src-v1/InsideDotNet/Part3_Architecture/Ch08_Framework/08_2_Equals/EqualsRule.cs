// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Framework.Equals
// Release     : 2007/10/24 1.0
// Description : 8.2 规则而定：对象判等

using System;
using System.Collections.Generic;
using System.Text;

namespace InsideDotNet.Framework.Equals
{
    class MyClass
    {
    }

    struct MyStruct
    {
    }
    class EqualsEx
    {
        //定义值类型成员ms
        private MyStruct ms;
        //定义引用类型成员mc
        private MyClass mc;

        public override bool Equals(object obj)
        {
            //为null，则必不相等
            if (obj == null) return false;

            //引用判等为真，则二者必定相等
            if (ReferenceEquals(this, obj)) return true;

            //类型判断
            EqualsEx objEx = obj as EqualsEx;
            if (objEx == null) return false;

            //最后是成员判断，分值类型成员和引用类型成员
            //通常可以提供强类型的判等方法来单独处理对各个成员的判等
            return EqualsHelper(this, objEx);
        }

        private static bool EqualsHelper(EqualsEx objA, EqualsEx objB)
        {
            //值类型成员判断
            if (!objA.ms.Equals(objA.ms)) return false;
            //引用类型成员判断
            if (!Equals(objA.mc, objB.mc)) return false;

            //最后，才可以判定两个对象是相等的
            return true;
        }
    }
}
