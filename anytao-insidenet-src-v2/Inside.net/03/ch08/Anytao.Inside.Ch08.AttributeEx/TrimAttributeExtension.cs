// Copyright   : 你必须知道的.NET，第2版
// Author      : Anytao，http://www.anytao.com
// FileName    : Anytao.Inside.Ch08.AttributeEx
// Release     : 2010/08/02 1.0
// Description : 8.3  历史纠葛：特性和属性

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace Anytao.Inside.Ch08.AttributeEx
{
    public static class TrimAttributeExtension
    {
        public static void Trim(this object obj)
        {
            Type t = obj.GetType();
            foreach (var prop in t.GetProperties())
            {
                foreach (var attr in prop.GetCustomAttributes(typeof(TrimAttribute), true))
                {
                    TrimAttribute tsa = (TrimAttribute)attr;
                    if (prop.GetValue(obj, null) != null && (tsa.Type == typeof(string)))
                    {
                        prop.SetValue(obj, GetPropertyValue(obj, prop.Name).ToString().Trim(), null);
                    }
                }
            }
        }

        private static object GetPropertyValue(object instance, string propertyName)
        {
            return instance.GetType().InvokeMember(propertyName, BindingFlags.GetProperty,
                null, instance, new object[] { });
        }
    }
}
