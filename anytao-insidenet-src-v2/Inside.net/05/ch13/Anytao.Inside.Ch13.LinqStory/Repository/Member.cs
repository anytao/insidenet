﻿// Copyright   : 你必须知道的.NET，第2版
// Author      : Anytao，http://www.anytao.com
// FileName    : Anytao.Inside.Ch13.LinqStory
// Release     : 2011/01/05 1.0
// Description : 13.4  LINQ江湖

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anytao.Inside.Ch13.LinqStory.Repository
{
    public class Member : EntityBase<Member>
    {
        public int Id { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
    }
}
