// Copyright   : 你必须知道的.NET，第2版
// Author      : Anytao，http://www.anytao.com
// FileName    : Anytao.Inside.Ch14.Lazy
// Release     : 2010/12/08 1.0
// Description : 14.7  Lazy<T>点滴

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anytao.Inside.Ch14.Lazy
{
    public class BigFactory
    {
        public static Big Build()
        {
            return new Big(100);
        }
    }
}
