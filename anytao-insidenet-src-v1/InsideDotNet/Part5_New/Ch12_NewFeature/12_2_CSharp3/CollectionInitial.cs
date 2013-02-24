// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.NewFeature.CSharp3
// Release     : 2007/12/12 1.0
// Description : 12.2  赏析C＃3.0--集合初始化器（Collection Initializers）

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InsideDotNet.NewFeature.CSharp3
{
    class CollectionInitial
    {
        public static void Main_12_2_2()//Main_12_2_2
        {
            //2.0方式
            List<User> users = new List<User>();
            users.Add(new User { Name = "小王", Age = 27 });
            users.Add(new User { Name = "小佳", Age = 22 });

            //3.0方式
            List<User> userss = new List<User>{
                new User{Name = "小王", Age = 27},
                new User{Name = "小佳", Age = 22}
            };

            foreach (User user in userss)
            {
                Console.WriteLine(user.Name);
            }
        }

        ////反编译结果
        //public static void Main_12_2_2()
        //{
        //    List<User> <>g__initLocal0 = new List<User>();
        //    User <>g__initLocal1 = new User();
        //    <>g__initLocal1.Name = "小王";
        //    <>g__initLocal1.Age = 0x1b;
        //    <>g__initLocal0.Add(<>g__initLocal1);
        //    User <>g__initLocal2 = new User();
        //    <>g__initLocal2.Name = "小佳";
        //    <>g__initLocal2.Age = 0x16;
        //    <>g__initLocal0.Add(<>g__initLocal2);
        //    List<User> userss = <>g__initLocal0;
        //}



    }
}
