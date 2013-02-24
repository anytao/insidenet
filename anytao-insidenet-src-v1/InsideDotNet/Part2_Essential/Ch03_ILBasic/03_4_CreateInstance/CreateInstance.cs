// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.ILBasic.CreateInstance
// Release     : 2007/09/01 1.0
// Description : 3.4 经典指令解析之实例创建--- newobj、initobj、Newarr、ldstr

using System;

namespace InsideDotNet.ILBasic.CreateInstance
{
    class CreateInstance
    {
        public static void Main_3_4_2()//Main_3_4_2
        {
            char[] arrChars = new char[5];
            for (int i = 0; i < 5; i++)
            {
                arrChars[i] = 'a';
            }

            Console.WriteLine(arrChars[0]);

            int[,] arrNum = new Int32[2, 3];
            arrNum[1, 2] = 5;
            Console.WriteLine(arrNum[1, 2]);
            Console.Read();
            Console.Read();

            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine(arrChars[j]);
            }
            Console.Read();
        }
    }
}
