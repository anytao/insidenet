// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.FCL.Root
// Release     : 2007/11/20 1.0
// Description : 9.3 ����---System�����ռ�--Convert���

using System;

namespace InsideDotNet.FCL.Root
{
    class ConvertEx
    {
        public static void Main()//Main_9_3_1
        {
            try
            {
                double num = 123.456789;
                //����ת��������Ϊ"123.456789"
                string str = Convert.ToString(num);
                //ת������������ʧ������Ϊ123
                Int32 iNum = Convert.ToInt32(num);
                //��Чת���������쳣
                DateTime dt = Convert.ToDateTime(num);

            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine("������Чת����");
            }
        }
    }
}
