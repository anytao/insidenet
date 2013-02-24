// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.NewFeature.CSharp3
// Release     : 2007/12/12 1.0
// Description : 12.2  赏析C＃3.0--对象初始化器（Object Initializers）

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InsideDotNet.NewFeature.CSharp3
{
    class ObjInitial
    {
        public static void Main_12_2_1()//Main_12_2_1
        {
            //2.0方式
            User user = new User();
            user.Name = "小王";
            user.Age = 27;

            //3.0方式
            User user3_0 = new User { Age = 27, Name = "小王" };

            //嵌套实现
            User user3 = new User { Name = "小王", Age = 27, UserInfo = new UserInfo { PhoneNo = 123456789, Emal = "mail@anytao.com", IsVIP = true } };

            Console.WriteLine(user3.UserInfo.Emal);
        }

        //反编译结果
        //public static void Main()
        //{
        //    User <>g__initLocal0 = new User();
        //    <>g__initLocal0.Age = 0x1b;
        //    <>g__initLocal0.Name = "小王";
        //    User user = <>g__initLocal0;
        //}
    }

    class User
    {
        public string Name { get; set; }
        public Int32 Age { get; set; }

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public UserInfo UserInfo { get; set; }
    }

    class UserInfo
    {
        public bool IsVIP { get; set; }
        public Int32 PhoneNo { get; set; }
        public string Emal { get; set; }
    }
}
