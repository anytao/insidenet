// Copyright   : 你必须知道的.NET，第2版
// Author      : Anytao，http://www.anytao.com
// FileName    : Anytao.Inside.Ch14.Covariant
// Release     : 2011/01/25 1.0
// Description : 14.6  协变与逆变

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anytao.Inside.Ch14.Covariant
{
    //public interface IFactory<in TKey, out TValue> where TKey : IComparable where TValue : new()
    //{
    //    void Register(TKey key);
    //    TValue Resolve(TKey key);
    //}

    //public class ObjectFactory<TKey, TValue> : IFactory<TKey, TValue> where TKey : IComparable where TValue : new()
    //{
    //    public void Register(TKey key)
    //    {
    //        container.Add(key, () => new TValue());
    //    }

    //    public TValue Resolve(TKey key)
    //    {
    //        if (key == null || !container.ContainsKey(key))
    //        {
    //            throw new ArgumentNullException("key");
    //        }

    //        return container[key]();
    //    }

    //    private readonly Dictionary<TKey, Func<TValue>> container = new Dictionary<TKey, Func<TValue>>();
    //}

    public interface IFactory<out T>
    {
        T Create();
    }

    public class Factory<T> : IFactory<T>
    {
        #region IFactory<T> Members

        public T Create()
        {
            return (T)Activator.CreateInstance<T>();
        }

        #endregion
    }

}
