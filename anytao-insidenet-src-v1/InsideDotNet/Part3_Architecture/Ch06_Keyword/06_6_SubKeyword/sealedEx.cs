// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Keyword.SubKeyword
// Release     : 2007/11/25 1.0
// Description : 6.6 非主流关键字--sealed关键字分析

using System;

namespace InsideDotNet.Keyword.SubKeyword
{
    class sealedEx
    {
    }

    public class MyBase
    {
        public virtual void ShowMsg()
        {
        }

        private string name;
        public virtual String Name
        {
            get { return name; }
        }
    }

    public sealed class MySealed : MyBase
    {
        public sealed override void ShowMsg()
        {
            base.ShowMsg();
        }

        public sealed override string Name
        {
            get
            {
                return base.Name;
            }
        }
    }
}
