// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.Keyword.Preprocessor
// Release     : 2007/11/23 1.0
// Description : 6.5 Ԥ����ָ��ؼ���

#define debug
#define release
#define inline

#define TRACE_WARNING
#define TRACE_ERROR


using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace InsideDotNet.Keyword.Preprocessor
{
    class If_Else
    {
        public static void Main()//Main_6_5_1
        {
            #if debug
            Console.WriteLine("It's debug.");
            #if inline
            Console.WriteLine("It's inline.");
            #endif
            #elif release
                Console.WriteLine("It's release.");
            #endif
        }

        #if debug
        public static void Show()
        {
            Console.WriteLine("dd");
        }
        #endif

        public static void Main_6_5_2()//Main_6_5_2
        {
            ShowDebug();
        }

        [Conditional("debug"), Conditional("release")]
        private static void ShowDebug()
        {
            Console.WriteLine("It's debug or release.");
        }

        public static void Main_6_5_3()//Main_6_5_3
        {
            #if TRACE_WARNING
            #warning "�����˻�������û�д���"
            #endif

            #if TRACE_ERROR
            //#error "�����Ǵ�ģ�ע������"
            #endif

            //Show();
        }

        public static void Main_6_5_4()//Main_6_5_4
        {
            #line 100 "warning.cs"
            #warning "���档"

            #line default
            //#error "�����Ǵ�ģ�ע������"
        }

    }


}
