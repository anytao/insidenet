// Copyright   : 你必须知道的.NET，第2版
// Author      : Anytao，http://www.anytao.com
// FileName    : Anytao.Inside.Ch14.Dynamic
// Release     : 2011/01/27 1.0
// Description : 14.3  动态变革：dynamic

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anytao.Inside.Ch14.Dynamic
{
    public class DynamicWork
    {
        // A dynamic property
        dynamic Name { get; set; }

        // A dynamic field
        private dynamic value = 100;

        // Dynamic return value, parameter
        public dynamic Work(dynamic x, dynamic y)
        {
            // A dynamic local variable
            dynamic result = x + y;

            return result;
        }
    }
}
