// Copyright   : 你必须知道的.NET，第2版
// Author      : Anytao，http://www.anytao.com
// FileName    : Anytao.Inside.Ch14.Covariant
// Release     : 2011/01/25 1.0
// Description : 14.6  协变与逆变

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anytao.Inside.Ch14.Covariant
{
    public class MyComparer<T> : IComparer<T>
    {
        #region IComparer<T> Members

        public int Compare(T x, T y)
        {
            return 1;
        }

        #endregion
    }
}
