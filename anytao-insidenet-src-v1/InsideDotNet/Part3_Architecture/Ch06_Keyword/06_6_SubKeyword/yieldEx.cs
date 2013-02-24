// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Keyword.SubKeyword
// Release     : 2007/11/24 1.0
// Description : 6.6 非主流关键字--yield关键字分析

using System;
using System.Collections.Generic;
using System.Text;

namespace InsideDotNet.Keyword.SubKeyword
{
    class UserInfo
    {
        string[] users =  { "小王", "张三", "李四" };

        public IEnumerator<string> GetEnumerator()
        {
            for (Int32 i = 0; i < users.Length; i++)
            {
                yield return users[i];
            }

            yield break;
            yield return "BREAK"; //代码不可访问
        }

        public static void Main_6_6_2()//Main_6_6_2
        {
            UserInfo userlist = new UserInfo();
            foreach (string str in userlist)
            {
                Console.WriteLine(str);
            }
        }
    }

    //class UserInfoEx : IEnumerable<string>
    //{
    //    string[] users = { "小王", "张三", "李四"};

    //    IEnumerator<string> IEnumerable<string>.GetEnumerator()
    //    {
    //        return new NestedEnumerator(this);
    //    }

    //    //内部一个实现了IEnumerator接口的嵌套类
    //    class NestedEnumerator : IEnumerator<string>
    //    {
    //        private UserInfo userInfo;
    //        private int index;

    //        public NestedEnumerator(UserInfo userInfo)
    //        {
    //            this.userInfo = userInfo;
    //            this.index = -1;
    //        }

    //        //实现MoveNext方法
    //        public bool MoveNext()
    //        {
    //            index++;
    //            if (index < userInfo.users.Length)
    //                return true;
    //            else
    //                return false;
    //        }

    //        //实现Current属性
    //        string IEnumerator<string>.Current
    //        {
    //            get{ return (string)userInfo.users[index];}
    //        }

    ////实现Reset方法
    //public void Reset()
    //{
    //    this.index = -1;
    //    this.userInfo = null;
    //}

    //        public void Dispose() { }
    //    }
    //}
}