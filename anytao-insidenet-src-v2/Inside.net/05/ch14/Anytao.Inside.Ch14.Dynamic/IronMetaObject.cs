// Copyright   : 你必须知道的.NET，第2版
// Author      : Anytao，http://www.anytao.com
// FileName    : Anytao.Inside.Ch14.Dynamic
// Release     : 2011/01/27 1.0
// Description : 14.3  动态变革：dynamic

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Dynamic;
using System.Linq.Expressions;

namespace Anytao.Inside.Ch14.Dynamic
{
    public class IronMetaObject : DynamicMetaObject
    {
        public IronMetaObject(Expression parameter)
            : base(parameter, BindingRestrictions.Empty)
        {
        }

        public override DynamicMetaObject BindInvokeMember(InvokeMemberBinder binder, DynamicMetaObject[] args)
        {
            return this.BindIronMember("Invoke Member: {0}", binder.Name);
        }

        public override DynamicMetaObject BindGetMember(GetMemberBinder binder)
        {
            return this.BindIronMember("Get member: {0}", binder.Name);
        }

        public override DynamicMetaObject BindSetMember(SetMemberBinder binder, DynamicMetaObject value)
        {
            return this.BindIronMember("Set member: {0}", binder.Name);
        }

        private DynamicMetaObject BindIronMember(string message, string name)
        {
            Console.WriteLine(string.Format(message, name));

            return new DynamicMetaObject(Expression, BindingRestrictions.GetTypeRestriction(Expression, typeof(IronObject)));
        }
    }
}
