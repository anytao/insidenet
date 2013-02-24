// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.OOPolicy.SRP
// Release     : 2007/12/10 1.0
// Description : 2.2  ��һְ��ԭ��

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
                Console.WriteLine("����Ա�����������ݡ�");
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
            //ִ����������
            Console.WriteLine("�������ݳɹ���");
        }

        public bool Delete()
        {
            //ִ������ɾ��
            return true;
        }

        public void View()
        {
            //ִ�����ݲ鿴
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

        //����Ȩ���жϵ��߼�
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
