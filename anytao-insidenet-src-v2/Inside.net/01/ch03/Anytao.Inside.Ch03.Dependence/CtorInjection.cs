// Copyright   : 你必须知道的.NET，第2版
// Author      : Anytao，http://www.anytao.com
// FileName    : Anytao.Inside.Ch03.Dependence
// Release     : 2011/02/10 1.0
// Description : 3.2  依赖的哲学

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anytao.Inside.Ch03.Dependence
{
    public class PicWorker
    {
    }

    public class PicClient
    {
        private PicWorker worker;

        public PicClient(PicWorker worker)
        {
            // 通过构造器注入
            this.worker = worker;
        }

        // 通过属性注入
        public PicWorker Woker
        {
            get { return this.worker; }
            set { this.worker = value; }
        }
    }
}
