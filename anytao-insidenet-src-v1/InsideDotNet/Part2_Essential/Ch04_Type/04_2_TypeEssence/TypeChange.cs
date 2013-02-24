// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Type.TypeEssence
// Release     : 2007/05/23 1.0
// Description : 4.2  品味类型---值类型与引用类型  

using System;

namespace InsideDotNet.Type.TypeEssence
{
    class TypeChange
    {
        public static void Main()
        {
            //编译不可通过
            //short s = 1;
            //s = s + 1;

            //编译不可通过
            //short s1 = 1;
            //short s2 = 2;
            //short s3 = s1 + s2;

            short s = 1;
            s += 1;
        }
    }
}
