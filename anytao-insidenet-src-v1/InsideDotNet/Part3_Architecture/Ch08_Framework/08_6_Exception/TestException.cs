// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.Framework.ExceptionEx
// Release     : 2007/11/06 1.0
// Description : 8.6 ֱ���쳣

using System;
using System.Collections.Generic;
using System.Text;

namespace InsideDotNet.Framework.ExceptionEx
{
    class TestException
    {
        //�����쳣���������
        public int TestWithException(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch
            {
                return -1;
            }
        }

        //���Է��쳣���������
        public int TestNoExceptioin(int a, int b)
        {
            return a / b;
        }
    }

}
