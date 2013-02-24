// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Conception.Collections
// Release     : 2007/11/17 1.0
// Description : 7.9 集合通论

using System;
using System.Collections;

namespace InsideDotNet.Conception.Collections
{
    class SyncArray
    {
        public static void Main_7_9_7()//Main_7_9_7
        {
            ArrayList al = new ArrayList();
            al.Add("Hello");
            al.Add("World");

            //生成一个线程同步的包装
            ArrayList syncAl = ArrayList.Synchronized(al);
        }

        //public override int Add(object value)
        //{
        //    lock (this._root)
        //    {
        //        return this._list.Add(value);
        //    }
        //}



    }
}
