// Copyright   : 你必须知道的.NET，第2版
// Author      : Anytao，http://www.anytao.com
// FileName    : Anytao.Inside.Ch08.AttributeEx
// Release     : 2010/08/02 1.0
// Description : 8.3  历史纠葛：特性和属性

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anytao.Inside.Ch08.AttributeEx
{
    [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
    public sealed class TrimAttribute : Attribute
    {
        private readonly Type type;

        public TrimAttribute(Type type)
        {
            this.type = type;
        }

        public Type Type
        {
            get { return this.type; }
        }
    }
}
