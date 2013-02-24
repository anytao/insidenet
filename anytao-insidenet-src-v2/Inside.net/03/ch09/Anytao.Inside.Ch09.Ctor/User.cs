// Copyright   : 你必须知道的.NET，第2版
// Author      : Anytao，http://www.anytao.com
// FileName    : Anytao.Inside.Ch09.Ctor
// Release     : 2010/08/12 1.0
// Description : 9.4  给力细节：深入类型构造器

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anytao.Inside.Ch09.Ctor
{
    public class User
    {
        //static User()
        //{
        //    message = "Initialize in static constructor.";
        //}

        public User()
        {
            message = "Initialize in normal construcotr.";
        }

        public User(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public static string message = "Initialize when defined.";
    }
}
