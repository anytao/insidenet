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
    public class Tag
    {
        /// <summary>
        /// 根据用户信息，构建标签信息
        /// </summary>
        /// <param name="memberId">用户Id，根据用户Id,获取<see cref="Member"/>的实例信息</param>
        /// <param name="tag">标签信息</param>
        /// <returns>标签信息对象</returns>
        public Tag BuildTag(int memberId, string tag)
        {
            return new Tag();
        }
    }
}
