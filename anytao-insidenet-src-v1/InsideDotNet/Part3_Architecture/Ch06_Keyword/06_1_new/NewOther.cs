// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.Keyword.New
// Release     : 2007/04/28 1.0
// Description : 6.1  ��new˵͸

using System;

namespace InsideDotNet.Keyword.New
{
    class NewOther
    {
        public static void Main_6_1_4()//Main_6_1_4
        {
            string strA = new string('*', 100);
            string strB = new string(new char[] { 'a', 'b', 'c' });
            string strC = "***************************************";
        }
    }
}
