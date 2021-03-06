﻿// Copyright   : 你必须知道的.NET，第2版
// Author      : Anytao，http://www.anytao.com
// FileName    : Anytao.Inside.Ch09.Naming
// Release     : 2010/08/15 1.0
// Description : 9.8  Name这回事儿

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anytao.Inside.Ch09.Naming
{
    class Program
    {
        static IDictionary<string, IDataMapper> container;

        static void Main(string[] args)
        {
            MapperRegister();

        }

    static void MapperRegister()
    {
        container = new Dictionary<string, IDataMapper>();

        container.Add(typeof(UserMapper).FullName, new UserMapper());
        container.Add(typeof(ProductMapper).FullName, new ProductMapper());
    }
    }
}
