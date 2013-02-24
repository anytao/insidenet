// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Type.Arguments
// Release     : 2007/07/01 1.0
// Description : 4.3  参数之惑---传递的艺术

using System;

namespace InsideDotNet.Type.Arguments
{
    class Args
    {
        public static void Main_4_3_1()//Main_4_3_1
        {
            int a = 10;
            Add(a);
            Console.WriteLine(a);

            ArgsByRef abf = new ArgsByRef();
            AddRef(abf);
            Console.WriteLine(abf.i);
        }

        private static void Add(int i)
        {
            i = i + 10;
            Console.WriteLine(i);
        }

        private static void AddRef(ArgsByRef abf)
        {
            abf.i = 20;
            Console.WriteLine(abf.i);
        }

    }

    class ArgsByRef
    {
        public int i = 10;
    }
}