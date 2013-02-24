// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Conception.Collections
// Release     : 2007/11/14 1.0
// Description : 7.9 集合通论

using System;
using System.Collections.Generic;

namespace InsideDotNet.Conception.Collections
{
    class ArrayEx
    {
        public static void Main_7_9_4()//Main_7_9_4
        {
            User[] users = new User[10];
            users[0] = new User("小王");
            users[1] = new User("张三");

            //调用了空对象，引发异常
            Console.WriteLine(users[5].Name);
        }
    }

    class User
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public User(string name)
        {
            this.name = name;
        }
    }
}
