// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.NewFeature.Linq
// Release     : 2007/12/13 1.0
// Description : 12.3  体验LINQ--初体验示例

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InsideDotNet.NewFeature.Linq
{
    class LittleLinqEx
    {
        public static void Main()//Main_12_3_1
        {
            string[] strArr = { "Visual C#", "Delphi", "Visual Basic", "Java", "Ruby", "Visual C++" };

            //Linq实现方式
            var msTools = from tool in strArr
                          where tool.StartsWith("Visual")
                          select tool;

            //扩展方法实现
            var msTools2 = strArr.Where(tool => tool.StartsWith("Visual")).Select(tool => tool);

            //Func<>委托类型来实现
            Func<string, bool> filter = tool => tool.StartsWith("Visual");
            Func<string, string> result = tool => tool;
            var msTools3 = strArr.Where(filter).Select(result);

            foreach (var tool in msTools)
            {
                Console.WriteLine(tool);
            }
        }
    }
}
