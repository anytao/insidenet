// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Security.CAS
// Release     : 2007/12/05 1.0
// Description : 11.2 代码访问安全

using System;
using System.Collections;
using System.Reflection;
using System.Security.Policy;
using System.Security.Permissions;
using System.Security;

namespace InsideDotNet.Security.CAS
{
    [FileIOPermission(SecurityAction.Demand, Write = @"E:\tmp.txt")]
    class CASBase
    {
        public static void Main()//Main_11_2_1
        {
            //获取当前程序集的证据
            System.Security.Policy.Evidence e = Assembly.GetExecutingAssembly().Evidence;

            //枚举程序集具有的所有证据
            IEnumerator enumerator = e.GetHostEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }


        }

        public static void Main_11_2_2()//Main_11_2_2
        {
            Type tp = Type.GetType("System.Object");
            Evidence e = Assembly.GetAssembly(tp).Evidence;

            IEnumerator enumerator = e.GetHostEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }

        public static void Main_11_2_3()//Main_11_2_3
        {
            //获取读取和写入tmp.txt文件的权限
            FileIOPermission fileIOPermission = new FileIOPermission(FileIOPermissionAccess.Read
                | FileIOPermissionAccess.Write, @"E:\tmp.txt");

            try
            {
                //执行权限检测
                fileIOPermission.Demand();
            }
            catch (SecurityException se)
            {
                Console.WriteLine("没有操作该文件的权限！");
            }
            Console.Read();
        }
    }
}
