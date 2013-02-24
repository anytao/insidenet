// Copyright   : 你必须知道的.NET，第2版
// Author      : Anytao，http://www.anytao.com
// FileName    : Anytao.Inside.Ch14.Lazy
// Release     : 2010/12/08 1.0
// Description : 14.7  Lazy<T>点滴

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anytao.Inside.Ch14.Lazy
{
    [Serializable]
    public class MyLazy<T>
    {
        static MyLazy()
        {
        }

        public MyLazy()
        {
        }

        public MyLazy(Func<T> valueFactory)
        {
            this.valueFactory = valueFactory;
        }

        public T Value 
        {
            get
            {
                Boxed boxed = null;

                if (this.boxed != null)
                {
                    boxed = this.boxed as Boxed;
                    if (boxed != null)
                    {
                        return boxed.value;
                    }
                }

                return this.Init();
            }
        }

        private T Init()
        {
            Boxed boxed = null;

            if (this.boxed == null)
            {
                boxed = this.CreateValue();
                this.boxed = boxed;
            }

            return boxed.value;
        }

        private Boxed CreateValue()
        {
            if (this.valueFactory != null)
            {
                return new Boxed(this.valueFactory());
            }
            else
            {
                return new Boxed((T)Activator.CreateInstance(typeof(T)));
            }
        }

        private volatile object boxed;
        private Func<T> valueFactory;

        // A nested class for box the data of T
        private class Boxed
        {
            internal Boxed(T value)
            {
                this.value = value;
            }

            internal T value;
        }
    }
}
