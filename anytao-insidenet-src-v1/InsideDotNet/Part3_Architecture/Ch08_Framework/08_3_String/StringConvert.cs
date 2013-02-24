// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Framework.StringEx
// Release     : 2007/10/27 1.0
// Description : 8.3 如此特殊：大话String--String类型的类型转换

using System;
using System.Collections.Generic;
using System.Text;

namespace InsideDotNet.Framework.StringEx
{
    class StringConvert
    {
        public static void Main_8_3_5()//Main_8_3_5
        {
            #region Double类型转换为String类型
            //Double num = 123.456;
            //string str = num.ToString();
            //Console.WriteLine(str);
            #endregion

            #region String类型转换为Double类型
            string str = null;
            Double num = 0.0;

            num = Double.Parse(str);
            Double.TryParse(str, out num);
            num = Convert.ToDouble(str);
            Console.WriteLine(num);
            #endregion
        }
    }
}
