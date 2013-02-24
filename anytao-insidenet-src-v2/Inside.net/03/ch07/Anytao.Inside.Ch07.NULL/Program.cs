// Copyright   : 你必须知道的.NET，第2版
// Author      : Anytao，http://www.anytao.com
// FileName    : Anytao.Inside.Ch07.NULL
// Release     : 2010/07/15 1.0
// Description : 7.4  认识全面的null

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anytao.Inside.Ch07.NULL
{
    class Program
    {
        static void Main(string[] args)
        {
            //int? a = 100;
            //Int32 b = (Int32)a;
            //a = null;

            //int? c = (int?)200;

   
            

            // Console.WriteLine(c.Value.ToString());

            string a = null;
            object b = null;
            object c = 1;

            Console.WriteLine(a ?? null ?? b ?? c ?? null);
        }
    }
}
