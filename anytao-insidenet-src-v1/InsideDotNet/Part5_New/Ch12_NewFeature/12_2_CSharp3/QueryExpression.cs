// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.NewFeature.CSharp3
// Release     : 2007/12/12 1.0
// Description : 12.2  查询表达式（Query Expressions）

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InsideDotNet.NewFeature.CSharp3
{
    class QueryExpression
    {
        public static void Main_12_2_9()//Main_12_2_9
        {
            List<User> users = new List<User>
            {
                new User{Name = "小王", Age = 27},
                new User{Name = "张三", Age = 32},
                new User{Name = "李四", Age = 15}
            };

            //查询表达式
            IEnumerable<User> selectUsers2 = from user in users
                                             where user.Age < 30
                                             orderby user.Age descending
                                             select user;

            IEnumerable<User> selectUsers = users.Where(user => user.Age < 30).
                OrderByDescending(user => user.Age);

            foreach (User user in selectUsers)
            {
                Console.WriteLine(user.Name);
            }
        }

        public static void Main_12_2_10()//Main_12_2_10
        {
            string[] strs = { "1", "2" };
            var strss = from str in strs select str;
            //foreach (var s in strss)
            //{
            //    Console.WriteLine(s);
            //}
        }
    }

}
