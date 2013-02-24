// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.Security.RBS
// Release     : 2007/12/08 1.0
// Description : 11.3 ���ڽ�ɫ�İ�ȫ

using System;
using System.Security;
using System.Security.Principal;
using System.Threading;
using System.Security.Permissions;

namespace InsideDotNet.Security.RBS
{
    class RBSBase
    {
        public static void Main_11_3_1()//Main_11_3_1
        {
            string[] roles = { "����", "ʿ��", "ʿ��" };
            //����GenericIdentity����
            GenericIdentity identity = new GenericIdentity("С��");
            //����GenericPrincipal����
            GenericPrincipal principal = new GenericPrincipal(identity, roles);
            //��principal���󸽼ӵ���ǰ�߳�
            Thread.CurrentPrincipal = principal;

            //ִ����֤
            if (Thread.CurrentPrincipal.Identity.Name == "С��")
            {
                Console.WriteLine("С������ָ��ʿ����");
            }

            //ִ�н�ɫ���
            if (Thread.CurrentPrincipal.IsInRole("ʿ��"))
            {
                Console.WriteLine(identity.Name + "��ʿ����á�");
            }
        }

        [PrincipalPermissionAttribute(SecurityAction.Demand, Name = "С��", Role = "ʿ��")]
        public static void OfficerMethod2()
        {
            //
        }

        public static void OfficerMethod()
        {
            string name = "С��";
            string role = "ʿ��";
            PrincipalPermission principalPermission = new PrincipalPermission(name, role);
            principalPermission.Demand();
        }

    }

    class WindowsRoleBaseSecurity
    {
        public static void Main()//Main_11_3_2
        {
            //����һ��Windows��ʶ
            WindowsIdentity wi = WindowsIdentity.GetCurrent();
            //����һ��WindowsPrincipalʵ��
            WindowsPrincipal wp = new WindowsPrincipal(wi);
            //��wp���󸽼ӵ���ǰ�߳�
            Thread.CurrentPrincipal = wp;

            //���ڽ�ɫ����֤
            try
            {
                WindowsUserMethod();
            }
            catch (SecurityException ex)
            {
                Console.WriteLine("δͨ����֤��");
            }
        }

        [PrincipalPermissionAttribute(SecurityAction.Demand, Role = "BUILTIN\\Users")]
        public static void WindowsUserMethod()
        {
            Console.WriteLine("ͨ����֤��");
        }
    }

    //public interface IIdentity
    //{
    //    string AuthenticationType { get; }
    //    bool IsAuthenticated { get; }
    //    string Name { get; }
    //}


    //public interface IPrincipal
    //{
    //    bool IsInRole(string role);
    //    IIdentity Identity { get; }
    //}

    //public virtual bool IsInRole(SecurityIdentifier sid);
    //public virtual bool IsInRole(WindowsBuiltInRole role);
    //public virtual bool IsInRole(string role);

}
