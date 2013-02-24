// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Memory.NewObj
// Release     : 2007/11/26 1.0
// Description : 5.2  对象创建始末

using System;
using System.Collections.Generic;
using System.Text;

namespace InsideDotNet.Memory.NewObj
{
    class RefProc
    {
    }

    public class UserInfo
    {
        private Int32 age = -1;
        private char level = 'A';

        public UserInfo()
        {
        }
    }

    public class User
    {
        private Int32 id;
        private UserInfo user;

        public User()
        {
            id = 4;
            user = new UserInfo();
        }
    }

    public class VIPUser : User
    {
        public bool isVip;

        public bool IsVipUser()
        {
            return isVip;
        }

        public VIPUser()
        {
        }

        public static void Main_5_2_2()//Main_5_2_2
        {
            VIPUser aUser;
            aUser = new VIPUser();
            aUser.isVip = true;
            Console.WriteLine(aUser.IsVipUser());
        }
    }

    class ValueProc
    {
        public static void Main_5_2_1()//Main_5_2_1
        {
            int x = 100;
            char c = 'A';
            unsafe
            {
                Console.WriteLine(sizeof(bool));
                Console.WriteLine(sizeof(char));
            }

        }
    }

}
