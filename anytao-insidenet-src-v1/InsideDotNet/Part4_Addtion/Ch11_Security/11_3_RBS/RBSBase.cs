// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Security.RBS
// Release     : 2007/12/08 1.0
// Description : 11.3 基于角色的安全

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
            string[] roles = { "将军", "士官", "士兵" };
            //创建GenericIdentity对象
            GenericIdentity identity = new GenericIdentity("小王");
            //创建GenericPrincipal对象
            GenericPrincipal principal = new GenericPrincipal(identity, roles);
            //将principal对象附加到当前线程
            Thread.CurrentPrincipal = principal;

            //执行验证
            if (Thread.CurrentPrincipal.Identity.Name == "小王")
            {
                Console.WriteLine("小王可以指挥士兵。");
            }

            //执行角色检查
            if (Thread.CurrentPrincipal.IsInRole("士官"))
            {
                Console.WriteLine(identity.Name + "，士官你好。");
            }
        }

        [PrincipalPermissionAttribute(SecurityAction.Demand, Name = "小王", Role = "士官")]
        public static void OfficerMethod2()
        {
            //
        }

        public static void OfficerMethod()
        {
            string name = "小王";
            string role = "士官";
            PrincipalPermission principalPermission = new PrincipalPermission(name, role);
            principalPermission.Demand();
        }

    }

    class WindowsRoleBaseSecurity
    {
        public static void Main()//Main_11_3_2
        {
            //创建一个Windows标识
            WindowsIdentity wi = WindowsIdentity.GetCurrent();
            //创建一个WindowsPrincipal实例
            WindowsPrincipal wp = new WindowsPrincipal(wi);
            //将wp对象附加到当前线程
            Thread.CurrentPrincipal = wp;

            //基于角色的验证
            try
            {
                WindowsUserMethod();
            }
            catch (SecurityException ex)
            {
                Console.WriteLine("未通过验证！");
            }
        }

        [PrincipalPermissionAttribute(SecurityAction.Demand, Role = "BUILTIN\\Users")]
        public static void WindowsUserMethod()
        {
            Console.WriteLine("通过验证。");
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
