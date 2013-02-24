// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.Type.Arguments
// Release     : 2007/07/03 1.0
// Description : 4.3  ����֮��---���ݵ�����

using System;

namespace InsideDotNet.Type.Arguments
{
    class Test_RefAndOut
    {
        static void ShowInfo(string str)
        {
            Console.WriteLine(str);
        }

        static void ShowInfo(ref string str)
        {
            Console.WriteLine(str);
        }

        //ShowInfo���ܶ������ ref �� out ���в������ط���
        //static void ShowInfo(out string str)
        //{
        //    str = "Hello, anytao.";
        //    Console.WriteLine(str);
        //}
    }
}
