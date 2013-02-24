// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.Type.Arguments
// Release     : 2007/07/05 1.0
// Description : 4.3  ����֮��---���ݵ�����

using System;

namespace InsideDotNet.Type.Arguments
{
    class ParamArrayAttributeTest
    {
        static void Main_4_3_3()//Main_4_3_3
        {
            //�������ҵ���Ӧ�ķ������ȵ��ò�����
            //param���Եķ���
            ShowAgeSum("Anycall", 1, 2, 3);
            //�������Ҳ������֤�Ͳ����ķ������ʵ��ð���
            //param���Եķ�����ͬʱ������5������Ϊ
            //һά��������
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