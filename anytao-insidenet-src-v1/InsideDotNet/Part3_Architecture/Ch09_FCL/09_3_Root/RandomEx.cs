// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.FCL.Root
// Release     : 2007/11/20 1.0
// Description : 9.3 ����---System�����ռ�--Random���

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
            //����5�������
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(rd.Next());
            }
        }
    }
}
