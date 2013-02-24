// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.Framework.ExceptionEx
// Release     : 2007/11/06 1.0
// Description : 8.6 ֱ���쳣

using System;
using System.IO;

namespace InsideDotNet.Framework.ExceptionEx
{
    class ApplicationException
    {
        public static void Main_8_7_2()//Main_8_7_2
        {
            try
            {
                TestException();
            }
            catch (Exception ex)
            {
                //�����ǰ���ö�ջ�ϵ��쳣���׳�λ�� 
                Console.WriteLine(ex.StackTrace);
            }
        }

        private static void TestException()
        {
            //ֱ���׳��쳣
            throw new FileNotFoundException("Error.");
        }
    }
}
