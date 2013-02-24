// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.OOThink.Interface
// Release     : 2007/12/19 1.0
// Description : 1.5 玩转接口

using System;
using System.Reflection;
using System.Configuration;

namespace InsideDotNet.OOThink.Interface
{
    class PetshopDAL
    {
    }

    public interface IUser
    {
        User GetUser(string ID);
        Int32 InsertUser(User user);
    }

    public class User
    {
    }

    public sealed class DataAccessFactory
    {
        private static readonly string assemblyPath = ConfigurationManager.AppSettings["AssemblyPath"];
        private static readonly string accessPath = ConfigurationManager.AppSettings["AccessPath"];

        public static IUser CreateUser()
        {
            string className = accessPath + ".User";
            return (IUser)Assembly.Load(assemblyPath).CreateInstance(className);
        }
    }

    public class BLL
    {
        private static readonly IUser user = DataAccessFactory.CreateUser();

        private static User userInfo = new User();

        public static void HandleUserInfo(string ID)
        {
            userInfo = user.GetUser(ID);
            //对userInfo实体对象进行操作
        }
    }
}
