// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Conception.Collections
// Release     : 2007/11/10 1.0
// Description : 7.9 集合通论--List<T>应用

using System;
using System.Collections.Generic;

namespace InsideDotNet.Conception.Collections
{
    class ListT
    {
        //List<T>的特性方法说明
        public static void Main()//Main_7_9_1
        {
            List<Int32> nums = new List<int>();
            nums.Add(0);
            nums.Add(20);
            nums.Add(33);
            nums.Add(59);
            nums.Add(100);

            //按照指定条件查找匹配元素
            List<Int32> numTens = nums.FindAll(IsDivisionByTen);

            //通过ForEach方法对集合成员遍历操作
            numTens.ForEach(Console.WriteLine);
        }

        //指定的操作条件
        private static bool IsDivisionByTen(int num)
        {
            if (num % 10 == 0)
                return true;
            else
                return false;
        }
    }
}
