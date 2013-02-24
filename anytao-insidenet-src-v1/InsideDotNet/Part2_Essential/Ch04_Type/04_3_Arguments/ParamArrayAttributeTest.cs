// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Type.Arguments
// Release     : 2007/07/05 1.0
// Description : 4.3  参数之惑---传递的艺术

using System;

namespace InsideDotNet.Type.Arguments
{
    class ParamArrayAttributeTest
    {
        static void Main_4_3_3()//Main_4_3_3
        {
            //编译器找到相应的方法就先调用不包含
            //param特性的方法
            ShowAgeSum("Anycall", 1, 2, 3);
            //编译器找不到五个证型参数的方法，故调用包含
            //param特性的方法，同时构造这5个整数为
            //一维整形数组
            ShowAgeSum("Anytao", 1, 2, 3, 4, 5);
        }

        static void ShowAgeSum(string team, int i, int j, int k)
        {
            Console.WriteLine("The No Param team {0}'s age sum is {1}", team, i + j + k);
        }

        static void ShowAgeSum(string team, params int[] ages)
        {
            int ageSum = 0;
            for (int i = 0; i < ages.Length; i++)
                ageSum += ages[i];
            Console.WriteLine("The Param team {0}'s age sum is {1}", team, ageSum);
        }


        //static void ShowAgeSum(string team, params int[] ages){//...}
        //static void ShowAgeSum(string team, [ParamArrayAttribute] int[] ages){//...}
    }
}