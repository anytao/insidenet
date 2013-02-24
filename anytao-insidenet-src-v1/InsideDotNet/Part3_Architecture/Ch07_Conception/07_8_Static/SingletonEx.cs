// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Conception.Static
// Release     : 2007/10/06 1.0
// Description : 7.8 动静之间：静态和非静态

using System;

namespace InsideDotNet.Conception.Static
{
    class Singleton
    {
        //定义一个静态成员
        private static Singleton _instance = null;

        //定义一个静态属性（或方法）
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

        //定义一个私有构造函数
        private Singleton()
        { 
        }
    }
}
