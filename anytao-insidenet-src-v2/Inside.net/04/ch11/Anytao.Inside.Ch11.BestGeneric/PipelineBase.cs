﻿// Copyright   : 你必须知道的.NET，第2版
// Author      : Anytao，http://www.anytao.com
// FileName    : Anytao.Inside.Ch11.BestGeneric
// Release     : 2011/03/10 1.0
// Description : 11.4  实践泛型

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anytao.Inside.Ch11.BestGeneric
{


    public class PipelineBase<TMessage> where TMessage : IMessage
    {
        public void Execute(TMessage message)
        {
            IMessage temp = message;

            //...
        }

        public void Execute(IMessage message)
        {
 
        }
    }
}