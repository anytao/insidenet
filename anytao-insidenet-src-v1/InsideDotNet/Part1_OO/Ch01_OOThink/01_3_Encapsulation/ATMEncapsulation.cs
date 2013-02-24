// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.OOThink.Encapsulation
// Release     : 2007/08/23 1.0
// Description : 1.3 封装的秘密

using System;

namespace InsideDotNet.OOThink.Encapsulation
{
    /// <summary>
    /// ATM类
    /// </summary>
    public class ATM
    {
        #region 定义私有方法，隐藏具体实现

        private Client GetUser(string userID) { Client client = null; return client; }

        private bool IsValidUser(Client user) { return false; }

        private int GetCash(int money) { return 0; }

        #endregion

        #region 定义公有方法，提供对外接口
        public void CashProcess(string userID, int money)
        {
            Client tmpUser = GetUser(userID);
            if (IsValidUser(tmpUser))
            {
                GetCash(money);
            }
            else
            {
                Console.Write("你不是合法用户，是不是想被发配南极？");
            }
        }
        #endregion
    }

    /// <summary>
    /// 用户类
    /// </summary>
    public class Client
    {
        private string name;         //用户姓名

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

        private int age;                //用户年龄

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
                    throw new ArgumentOutOfRangeException("年龄信息不正确。");
                }
            }
        }

        private string password;  //用户密码

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
