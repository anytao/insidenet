// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Memory.Performance
// Release     : 2007/11/30 1.0
// Description : 5.4 性能控制的多方探讨

using System;
using System.Collections;

namespace InsideDotNet.Memory.Performance
{
    class foreach_for
    {
        public static void Main_5_4_3()//Main_5_4_3
        {
            ArrayList al = new ArrayList(3);
            al.Add(100);
            al.Add("Hello, world.");
            al.Add(new char[] { 'A', 'B', 'C' });

            foreach (object o in al)
                Console.WriteLine(o.ToString());

            for (Int32 i = 0; i < al.Count; i++)
                Console.WriteLine(al[i].ToString());
        }
    }
}
