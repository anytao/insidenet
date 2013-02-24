// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.NewFeature.Linq
// Release     : 2007/12/13 1.0
// Description : 12.3  体验LINQ--Linq to object示例

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace InsideDotNet.NewFeature.Linq
{
    class User
    {
        public string Name { get; set; }
        public Int32 Age { get; set; }
        public UserInfo UserInfo { get; set; }
    }

    class UserInfo
    {
        public bool IsVIP { get; set; }
        public string Emal { get; set; }
    }

    class Linq2Obj
    {
        public static void Main_12_3_2()//Main_12_3_2
        {
            List<User> users = new List<User>
            {
                new User{Name = "小王", Age = 27, UserInfo = new UserInfo{IsVIP = true, Emal = "xw@anytao.com"}},
                new User{Name = "张三", Age = 53, UserInfo = new UserInfo{IsVIP =false, Emal = "zs@msn.com"}},
                new User{Name = "李四", Age = 15, UserInfo = new UserInfo{IsVIP = true, Emal = "ls@live.com"}}
            };

            //实现数据对象的查询
            IEnumerable<User> selectUsers = from user in users
                                            where user.Age < 30
                                            orderby user.Age descending
                                            select user;

            var myUsers = users.Where(user => user.Age < 30)
                .OrderByDescending(user => user.Age).Select(user => user);

            foreach (var user in myUsers)
            {
                Console.WriteLine(user.Name);
            }

        }
    }
}
