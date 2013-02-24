// Copyright   : 你必须知道的.NET，第2版
// Author      : Anytao，http://www.anytao.com
// FileName    : Anytao.Inside.Ch09.Naming
// Release     : 2010/09/15 1.0
// Description : 9.5  如此特殊：大话String


using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;


namespace Anytao.Inside.Ch09.String
{
    [CompilationRelaxationsAttribute(CompilationRelaxations.NoStringInterning)]
    class Program
    {
        static void Main1()
        {
            string s1 = "abc";
            string s2 = "ab";
            string s3 = s2 + "c";

            //返回acb
            Console.WriteLine(string.IsInterned(s3) ?? "null");
            //返回false
            Console.WriteLine(ReferenceEquals(s1, s3));
        }

        // Release : code10, 2008/08/25                
        // Author  : Anytao, http://www.anytao.com
        static void Main2()
        {
            //在这个位置返回abc
            string s1 = GetStr();

            string s2 = "ab";
            s2 += "c";
            Console.WriteLine(string.IsInterned(s2) ?? "null");

            
        }

        private static string GetStr()
        {
            return "abc";
        }

        public const string s1 = "abc";

        static void Main()
        {
            //string s1 = "abc";
            //string s2 = "ab";
            //s2 += "c";

            //string s3 = "ab";

            //Console.WriteLine(string.IsInterned(s1) ?? "null");
            //Console.WriteLine(string.IsInterned(s2) ?? "null");

            //Console.WriteLine(string.IsInterned(s3) ?? "null");

            Console.WriteLine(s1);

            string s2 = "ab";
            s2 += "c";

            Console.WriteLine(string.IsInterned(s2) ?? "null");

            //string s1 = GetStr(); 
   
        }

    }
}
