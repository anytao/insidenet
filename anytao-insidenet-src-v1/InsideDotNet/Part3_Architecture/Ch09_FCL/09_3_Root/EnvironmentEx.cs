// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.FCL.Root
// Release     : 2007/11/20 1.0
// Description : 9.3 ����---System�����ռ�--Environment���

using System;
using System.Collections.Generic;
using System.Text;

namespace InsideDotNet.FCL.Root
{
    class EnvironmentEx
    {
        public static void Main_9_3_3()//Main_9_3_3
        {
            //��ȡ��ǰĿ¼
            Console.WriteLine("��ǰĿ¼��{0}", Environment.CurrentDirectory);
            //��ȡ������
            Console.WriteLine("��������{0}", Environment.MachineName);
            //��ȡ����ϵͳ��Ϣ
            Console.WriteLine("����ϵͳ��{0}", Environment.OSVersion);
            //��ȡ��ǰ�û���
            Console.WriteLine("��ǰ�û���{0}", Environment.UserName);
        }
    }
}
