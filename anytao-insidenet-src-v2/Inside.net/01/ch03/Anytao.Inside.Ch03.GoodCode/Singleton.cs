// Copyright   : 你必须知道的.NET，第2版
// Author      : Anytao，http://www.anytao.com
// FileName    : Anytao.Inside.Ch03.Dependence
// Release     : 2011/02/15 1.0
// Description : 3.6  好代码和坏代码

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anytao.Inside.Ch03.GoodCode
{
    //public sealed class Singleton
    //{
    //    Singleton() { }

    //    public static Singleton Instance
    //    {
    //        get
    //        {
    //            if (instance == null)
    //            {
    //                instance = new Singleton();
    //            }

    //            return instance;
    //        }
    //    }

    //    private static Singleton instance = null;
    //}

    public sealed class Singleton
    {
        static Singleton() { }

        Singleton() { }

        public static Singleton Instance
        {
            get
            {
                return instance;
            }
        }

        static readonly Singleton instance = new Singleton();
    }
}
