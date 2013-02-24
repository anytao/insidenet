// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.FCL.Root
// Release     : 2007/11/20 1.0
// Description : 9.3 根基---System命名空间--Nullable简介

using System;
using System.Collections.Generic;
using System.Text;

namespace InsideDotNet.FCL.Root
{
    class NullableEx
    {
        public static void Main_9_3_5()//Main_9_3_5
        {
            Nullable<int>[] arrs = new Nullable<int>[5];
            //int?[] arrs = new int?[5];
            arrs[0] = 100;
            arrs[1] = 200;
            arrs[3] = 300;

            foreach (int? j in arrs)
            {
                if (j == null)
                    Console.WriteLine("No value");
                else
                    Console.WriteLine(j);
            }
        }
    }
}
