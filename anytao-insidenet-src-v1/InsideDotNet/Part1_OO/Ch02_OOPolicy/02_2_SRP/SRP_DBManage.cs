// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.OOPolicy.SRP
// Release     : 2007/12/10 1.0
// Description : 2.2  单一职责原则

using System;

namespace InsideDotNet.OOPolicy.SRP
{
    class SRP_DBManage
    {
    }

    class DBManager_2
    {
        private string id;
        public string GetPermission(string id)
        {
            return null;
        }

        public void Add()
        {
            if (GetPermission(id) == "CanAdd")
            {
                Console.WriteLine("管理员可以增加数据。");
            }
        }
    }

    class DBClient2
    {
        public static void Main_2_2_1()//Main_2_2_1
        {
        }
    }

    public interface IDBAction
    {
        void Add();
        bool Delete();
        void View();
    }

    public class DBManager : IDBAction
    {
        public DBManager(string id)
        {
        }

        public void Add()
        {
            //执行数据增加
            Console.WriteLine("增加数据成功。");
        }

        public bool Delete()
        {
            //执行数据删除
            return true;
        }

        public void View()
        {
            //执行数据查看
        }
    }

    public class DBManagerProxy : IDBAction
    {
        private string id;
        private IDBAction dbManager;

        public DBManagerProxy(IDBAction dbAction)
        {
            dbManager = dbAction;
        }

        //处理权限判断的逻辑
        public string GetPermission(string id)
        {
            return null;
            //return "CanAdd";
        }

        public void Add()
        {
            if (GetPermission(id) == "CanAdd")
            {
                dbManager.Add();
            }
        }

        public bool Delete()
        {
            if (GetPermission(id) == "CanDelete")
            {
                dbManager.Delete();
            }

            return true;
        }

        public void View()
        {
            if (GetPermission(id) == "View")
            {
                dbManager.View();
            }
        }
    }

    public class DBClient
    {
        public static void Main()//Main_2_2_2
        {
            IDBAction DBManager = new DBManagerProxy(new DBManager("CanAdd"));
            DBManager.Add();
        }
    }
}
