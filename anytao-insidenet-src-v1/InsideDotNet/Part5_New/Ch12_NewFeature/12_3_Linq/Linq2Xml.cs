// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.NewFeature.Linq
// Release     : 2007/12/14 1.0
// Description : 12.3  体验LINQ--Linq to XML示例

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.IO;

namespace InsideDotNet.NewFeature.Linq
{
    class Linq2Xml
    {
        public static void Main_12_3_3()//Main_12_3_3
        {
            string filePath = AppDomain.CurrentDomain.BaseDirectory + @"12_3_Linq\User.xml";

            //将XML加载到内存对象
            XElement xmlData = XElement.Parse(File.ReadAllText(filePath));
            //XDocument xmlData = XDocument.Load(filePath);

            //var users = xEleData.Elements().OrderBy(user => user.Name == "Age").Where(user => user.Name == "User");

            //执行LINQ查询
            var users = from user in xmlData.Descendants("User")
                        where int.Parse(user.Element("Age").Value) < 30
                        orderby int.Parse(user.Element("Age").Value) descending
                        select new
                        {
                            Name = user.Element("Name").Value,
                            Age = user.Element("Age").Value
                        };

            //遍历查询结果
            foreach (var user in users)
            {
                Console.WriteLine(user.Name);
            }
        }
    }
}
