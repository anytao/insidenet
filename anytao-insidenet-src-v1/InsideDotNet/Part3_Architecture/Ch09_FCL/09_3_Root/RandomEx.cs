// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.FCL.Root
// Release     : 2007/11/20 1.0
// Description : 9.3 根基---System命名空间--Random简介

using System;
using System.Collections.Generic;
using System.Text;

namespace InsideDotNet.FCL.Root
{
    class RandomEx
    {
        public static void Main_9_3_2()//Main_9_3_2
        {
            Random rd = new Random();
            //产生5个随机数
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(rd.Next());
            }
        }
    }
}
