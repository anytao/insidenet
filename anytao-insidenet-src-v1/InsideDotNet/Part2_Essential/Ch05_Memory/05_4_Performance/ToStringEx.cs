// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Memory.Performance
// Release     : 2007/11/30 1.0
// Description : 5.4 性能控制的多方探讨

using System;
using System.Collections.Generic;
using System.Text;

namespace InsideDotNet.Memory.Performance
{
    class ToStringEx
    {
    }

    public struct User
    {
        public string Name;
        public Int32 Age;

        //避免方法调用时的装箱
        public override string ToString()
        {
            return "Name: " + Name + ", Age:" + Age.ToString();
        }
    }
}
