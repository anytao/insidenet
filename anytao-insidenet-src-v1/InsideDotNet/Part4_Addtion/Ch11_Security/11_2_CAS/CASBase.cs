// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.Security.CAS
// Release     : 2007/12/05 1.0
// Description : 11.2 ������ʰ�ȫ

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
            //��ȡ��ǰ���򼯵�֤��
            System.Security.Policy.Evidence e = Assembly.GetExecutingAssembly().Evidence;

            //ö�ٳ��򼯾��е�����֤��
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
            //��ȡ��ȡ��д��tmp.txt�ļ���Ȩ��
            FileIOPermission fileIOPermission = new FileIOPermission(FileIOPermissionAccess.Read
                | FileIOPermissionAccess.Write, @"E:\tmp.txt");

            try
            {
                //ִ��Ȩ�޼��
                fileIOPermission.Demand();
            }
            catch (SecurityException se)
            {
                Console.WriteLine("û�в������ļ���Ȩ�ޣ�");
            }
            Console.Read();
        }
    }
}
