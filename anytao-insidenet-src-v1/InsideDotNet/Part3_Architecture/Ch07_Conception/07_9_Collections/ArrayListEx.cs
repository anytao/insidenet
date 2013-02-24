// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Conception.Collections
// Release     : 2007/11/13 1.0
// Description : 7.9 集合通论

using System;
using System.Collections;

namespace InsideDotNet.Conception.Collections
{
    class ArrayListEx
    {
        public static void Main_7_9_2()//Main_7_9_2
        {
            //定义集合类型
            ArrayList arrs = new ArrayList();
            //调用Add方法，增加集合元素
            arrs.Add(10);
            arrs.Add(new object());
            arrs.Add("I'm OK.");
            arrs.Add(new MyClass());
            arrs.Add(100);

            //调用Remove方法，移除指定对象
            arrs.Remove(100);

            //调用Insert方法，插入对象到指定索引位置
            arrs.Insert(2, "A insert value");

            //IndexOf方法，用于从起始位置搜索，并返回第一个匹配项的索引位置
            Int32 index = arrs.IndexOf("I'm OK.");

            //获取集合的指定元素
            object obj = arrs[index];
            Console.WriteLine("{0} -- {1}", obj, index);

            //获取集合的元素个数
            Console.WriteLine(arrs.Count);

            //通过枚举器遍历集合元素
            IEnumerator myEnumerator = arrs.GetEnumerator();
            while (myEnumerator.MoveNext())
            {
                Console.WriteLine(myEnumerator.Current);
            }

            //更间接的方式可以为
            foreach (object o in arrs)
            {
                Console.WriteLine(o.ToString());
            }

            //清除集合的所有元素
            arrs.Clear();
        }

        //说明ArrayList的容量是动态的
        public static void Main_7_9_3()//Main_7_9_3
        {
            //初始化arrs容量为2
            ArrayList arrs = new ArrayList(2);

            arrs.Add(1);
            arrs.Add(2);
            arrs.Add(3);

            Console.WriteLine("当前容量：{0}", arrs.Capacity);         //结果为4

            arrs.TrimToSize();
            Console.WriteLine("压缩后的容量：{0}", arrs.Capacity);  //结果为3
        }
    }

    class MyClass
    {
        public override string ToString()
        {
            return "这是自定义类型。";
        }
    }


}
