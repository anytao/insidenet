// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.OOThink.Encapsulation
// Release     : 2007/08/23 1.0
// Description : 1.3 ��װ������

using System;

namespace InsideDotNet.OOThink.Encapsulation
{
    /// <summary>
    /// ATM��
    /// </summary>
    public class ATM
    {
        #region ����˽�з��������ؾ���ʵ��

        private Client GetUser(string userID) { Client client = null; return client; }

        private bool IsValidUser(Client user) { return false; }

        private int GetCash(int money) { return 0; }

        #endregion

        #region ���幫�з������ṩ����ӿ�
        public void CashProcess(string userID, int money)
        {
            Client tmpUser = GetUser(userID);
            if (IsValidUser(tmpUser))
            {
                GetCash(money);
            }
            else
            {
                Console.Write("�㲻�ǺϷ��û����ǲ����뱻�����ϼ���");
            }
        }
        #endregion
    }

    /// <summary>
    /// �û���
    /// </summary>
    public class Client
    {
        private string name;         //�û�����

        public string Name
        {
            get { return name; }
            set
            {
                name = value == null ? String.Empty : value;
            }
        }

        //private string firstName;
        //private string secondName;

        //public string MyName
        //{
        //    get { return firstName + secondName; }
        //}

        private int age;                //�û�����

        public int Age
        {
            get { return age; }
            set 
            {
                if ((value > 0) && (value < 150))
                {
                    age = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("������Ϣ����ȷ��");
                }
            }
        }

        private string password;  //�û�����

        public string Password
        {
            get { return password; }
            set 
            {
                if (value.Length < 6)
                    password = value;
            }
        }

        //public string get_Password()
        //{
        //    return password;
        //}

        //public string set_Password(string value)
        //{
        //    if (value.Length < 6)
        //        password = value;
        //}
    }

    public class TestEncpsulation
    {
        public static void Main()
        {
            Client xiaoWang = new Client();
            xiaoWang.Name = null;
            Console.WriteLine(xiaoWang.Name);
            Console.Read();
            //xiaoWang.name = "Xiao Wang";
            //xiaoWang.age = 27;
            //xiaoWang.password = "123456"

            //xiaoWang.age = 1000;
            //xiaoWang.password = "5&@@Ld;afk99";
        }

    }
}
