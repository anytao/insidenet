// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.Conception.ConstAndReadonly
// Release     : 2007/10/02 1.0
// Description : 7.1 ʲô���ǲ��䣺const��readonly

using System;

namespace InsideDotNet.Conception.ConstAndReadonly
{
    class Readonly_PropertyAndField
    {
        public static void Main_7_1_2()//Main_7_1_2
        {
            MyReadonlyEx myReadonly = new MyReadonlyEx("��", "����");
            Console.WriteLine(myReadonly.Name);
            Console.WriteLine(myReadonly.NickName);
        }
    }

    //�Ա�ֻ���ֶκ�ֻ������
    class MyReadonlyEx
    {
        //����ֻ������
        private string _firstName;
        private string _secondName;

        public string Name
        {
            get { return _firstName + _secondName; }
        }

        //����ֻ���ֶ�
        public readonly string NickName;

        public MyReadonlyEx(string firstName, string secondName)
        {
            _firstName = firstName;
            _secondName = secondName;
            NickName = "С��";
        }

    }
}
