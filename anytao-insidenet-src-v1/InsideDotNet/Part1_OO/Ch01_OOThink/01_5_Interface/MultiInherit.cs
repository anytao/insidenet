// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.OOThink.Interface
// Release     : 2007/12/19 1.0
// Description : 1.5 ��ת�ӿ�

using System;

namespace InsideDotNet.OOThink.Interface
{
    class MultiInherit
    {
        public static void Main_1_5_2()//Main_1_5_2
        {
            DateTime dt = DateTime.Today;

            int result = ((IComparable)dt).CompareTo(DateTime.MaxValue);

            DateTime dt2 = ((IConvertible)dt).ToDateTime(new System.Globalization.DateTimeFormatInfo());
        }
    }

}
