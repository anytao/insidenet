// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.Type.Arguments
// Release     : 2007/07/03 1.0
// Description : 4.3  ����֮��---���ݵ����� 

using System;
using System.Collections.Generic;
using System.Text;

namespace InsideDotNet.Type.Arguments
{
    public class MyArguments
    {
        public static void Main_4_3_1()//Main_4_3_1
        {
            string myString = "This is your argument.";
            //myString��ʵ�ʲ���
            ShowString(myString);
        }

        private static void ShowString(string astr)
        {
            Console.WriteLine(astr);
        }


        ////ͨ����������ʵ�ֲ���Ĭ��ֵ�ķ���
        //static void JudgeKind(string name, string kind)
        //{
        //    Console.WriteLine("{0} is a {1}", name, kind);
        //}

        //static void JudgeKind(string name)
        //{
        //    //α����
        //    if (name is Person)
        //    {
        //        //����ʵ�ֲ���Ĭ��ֵ��People��
        //        Console.WriteLine(name, "People");
        //    }
        //}


    }
}
