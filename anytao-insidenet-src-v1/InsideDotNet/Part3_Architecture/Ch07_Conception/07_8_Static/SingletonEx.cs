// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.Conception.Static
// Release     : 2007/10/06 1.0
// Description : 7.8 ����֮�䣺��̬�ͷǾ�̬

using System;

namespace InsideDotNet.Conception.Static
{
    class Singleton
    {
        //����һ����̬��Ա
        private static Singleton _instance = null;

        //����һ����̬���ԣ��򷽷���
        public static Singleton Instance
        {
            get 
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                }

                return _instance;
            }
        }

        //����һ��˽�й��캯��
        private Singleton()
        { 
        }
    }
}
