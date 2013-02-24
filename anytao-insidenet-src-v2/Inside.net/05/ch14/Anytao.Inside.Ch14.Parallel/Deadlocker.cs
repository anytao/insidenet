// Copyright   : 你必须知道的.NET，第2版
// Author      : Anytao，http://www.anytao.com
// FileName    : Anytao.Inside.Ch14.ParallelEx
// Release     : 2010/12/15 1.0
// Description : 14.4  趋势必行，并行计算

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anytao.Inside.Ch14.ParallelEx
{
    class Deadlocker
    {
        private static readonly object sync = new object();

        public static void Main6()
        {
            lock (sync)
            {
                Task t = Task.Factory.StartNew(() =>
                {
                    //lock (sync)
                    //{
                        Console.WriteLine("Dead lock here.");
                    //}
                });

                t.Wait();
            }

            Console.Read();
        }
    }
}
