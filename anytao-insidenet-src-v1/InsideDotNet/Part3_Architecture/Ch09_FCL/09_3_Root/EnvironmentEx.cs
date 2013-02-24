// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.FCL.Root
// Release     : 2007/11/20 1.0
// Description : 9.3 根基---System命名空间--Environment简介

using System;
using System.Collections.Generic;
using System.Text;

namespace InsideDotNet.FCL.Root
{
    class EnvironmentEx
    {
        public static void Main_9_3_3()//Main_9_3_3
        {
            //获取当前目录
            Console.WriteLine("当前目录：{0}", Environment.CurrentDirectory);
            //获取机器名
            Console.WriteLine("机器名：{0}", Environment.MachineName);
            //获取操作系统信息
            Console.WriteLine("操作系统：{0}", Environment.OSVersion);
            //获取当前用户名
            Console.WriteLine("当前用户：{0}", Environment.UserName);
        }
    }
}
