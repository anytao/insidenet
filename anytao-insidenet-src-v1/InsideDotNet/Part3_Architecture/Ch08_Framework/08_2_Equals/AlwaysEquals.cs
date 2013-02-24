// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Framework.Equals
// Release     : 2007/10/25 1.0
// Description : 8.2 规则而定：对象判等

using System;
using System.Collections.Generic;
using System.Text;

namespace InsideDotNet.Framework.Equals
{
    class AlwaysEquals
    {
        public override bool Equals(object obj)
        {
            return true;
        }
    }
}
