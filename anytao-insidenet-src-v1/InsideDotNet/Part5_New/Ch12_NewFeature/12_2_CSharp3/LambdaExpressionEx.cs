// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.NewFeature.CSharp3
// Release     : 2007/12/12 1.0
// Description : 12.2  赏析C＃3.0--  Lambda表达式（LambdaExpressions）(Lambda Example for LINQ)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InsideDotNet.NewFeature.CSharp3
{
    class LambdaExpressionExx
    {
        public static void Main_12_2_8()//Main_12_2_8
        {
            List<User> users = new List<User>
            {
                new User{Name = "小王", Age = 27},
                new User{Name = "张三", Age = 28},
                new User{Name = "李四", Age = 32}
            };

            IEnumerable<User> youngUsers = users.Where(user => user.Age < 30);

            foreach (var user in youngUsers)
            {
                Console.WriteLine(user.Name);
            }
        }
    }
}
