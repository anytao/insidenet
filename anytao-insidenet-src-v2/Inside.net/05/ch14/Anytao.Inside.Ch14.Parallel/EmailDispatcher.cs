// Copyright   : 你必须知道的.NET，第2版
// Author      : Anytao，http://www.anytao.com
// FileName    : Anytao.Inside.Ch14.ParallelEx
// Release     : 2010/12/15 1.0
// Description : 14.4  趋势必行，并行计算

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Anytao.Inside.Ch14.ParallelEx
{
    public class EmailDispatcher
    {
        public void Dispatch()
        {
 
        }
    }

    public class EmailClient
    {
        public void Send(Email[] emails)
        {
            Thread.Sleep(300);

        }
    }

    public class Email
    {
        public int Id { get; set; }
    }
}
