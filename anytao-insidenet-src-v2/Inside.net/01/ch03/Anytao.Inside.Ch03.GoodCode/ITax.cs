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
    //public interface ITax
    //{
    //    decimal Calculate(decimal value);
    //}

    //public class FoodTax : ITax
    //{
    //    public decimal Calculate(decimal value)
    //    {
    //        return new decimal(1 + 0.15) * value;
    //    }
    //}

    //public class RetailTax : ITax
    //{
    //    public decimal Calculate(decimal value)
    //    {
    //        return new decimal(1 + 0.1) * value;
    //    }
    //}

    public interface ITax
    {
        decimal Calculate(Func<decimal> rateProvider, decimal value);
    }

    public class Tax : ITax
    {
        public decimal Calculate(Func<decimal> rateProvider, decimal value)
        {
            var rate = rateProvider.Invoke();
            return rate * value;
        }
    }


}
