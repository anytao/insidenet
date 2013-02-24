// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Conception.Collections
// Release     : 2007/11/17 1.0
// Description : 7.9 集合通论--Hashtable应用

using System;
using System.Collections;

namespace InsideDotNet.Conception.Collections
{
    class HashtableEx
    {
        public static void Main_7_9_5()//Main_7_9_5
        {
            Hashtable ht = new Hashtable();

            //添加集合元素
            ht.Add("Name", "小王");
            ht.Add("Age", 27);
            ht.Add("Degree", "硕士");

            //以键值查找集合
            Console.WriteLine("{0}的年龄是{1}", ht["Name"], ht["Age"]);

            //集合遍历
            foreach (DictionaryEntry de in ht)
            {
                Console.WriteLine("{0}--{1}", de.Key.ToString(), de.Value.ToString());
            }

            //删除集合元素
            ht.Remove("Age");

            //集合排序
            ArrayList als = new ArrayList(ht.Keys);
            als.Sort();
            foreach (string key in als)
            {
                Console.WriteLine("{0}--{1}", key, ht[key].ToString());
            }

            //集合清空
            ht.Clear();
        }
    }
}
