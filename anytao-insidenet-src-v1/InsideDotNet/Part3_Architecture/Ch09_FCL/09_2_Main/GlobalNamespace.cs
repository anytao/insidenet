// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.FCL.Main
// Release     : 2007/11/19 1.0
// Description : 9.2 布局---框架类库研究

using System;
using System.Collections.Generic;
using System.Text;

namespace InsideDotNet.FCL.Base
{
    class GlobalNamespace
    {
        public class System
        {
        }

        public static void Main()
        {
            //System.Console.WriteLine("Hello");
            global::System.Console.WriteLine("Hello");
        }
    }

}
