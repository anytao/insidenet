// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.Keyword.SubKeyword
// Release     : 2007/11/24 1.0
// Description : 6.6 �������ؼ���--yield�ؼ��ַ���

using System;
using System.Collections.Generic;
using System.Text;

namespace InsideDotNet.Keyword.SubKeyword
{
    class UserInfo
    {
        string[] users =  { "С��", "����", "����" };

        public IEnumerator<string> GetEnumerator()
        {
            for (Int32 i = 0; i < users.Length; i++)
            {
                yield return users[i];
            }

            yield break;
            yield return "BREAK"; //���벻�ɷ���
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
    //    string[] users = { "С��", "����", "����"};

    //    IEnumerator<string> IEnumerable<string>.GetEnumerator()
    //    {
    //        return new NestedEnumerator(this);
    //    }

    //    //�ڲ�һ��ʵ����IEnumerator�ӿڵ�Ƕ����
    //    class NestedEnumerator : IEnumerator<string>
    //    {
    //        private UserInfo userInfo;
    //        private int index;

    //        public NestedEnumerator(UserInfo userInfo)
    //        {
    //            this.userInfo = userInfo;
    //            this.index = -1;
    //        }

    //        //ʵ��MoveNext����
    //        public bool MoveNext()
    //        {
    //            index++;
    //            if (index < userInfo.users.Length)
    //                return true;
    //            else
    //                return false;
    //        }

    //        //ʵ��Current����
    //        string IEnumerator<string>.Current
    //        {
    //            get{ return (string)userInfo.users[index];}
    //        }

    ////ʵ��Reset����
    //public void Reset()
    //{
    //    this.index = -1;
    //    this.userInfo = null;
    //}

    //        public void Dispose() { }
    //    }
    //}
}