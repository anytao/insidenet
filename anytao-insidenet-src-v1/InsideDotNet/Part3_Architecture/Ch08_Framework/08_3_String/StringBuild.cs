// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.Framework.StringEx
// Release     : 2007/10/27 1.0
// Description : 8.3 ������⣺��String

using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Reflection;

namespace InsideDotNet.Framework.StringEx
{
    class StringBuild
    {
        public static void Main()//Main_8_3_1
        {
            #region ���ܱȽ�
            Stopwatch sw = Stopwatch.StartNew();
            //String���ܲ���
            string str = "";
            for (int i = 0; i < 100; i++)
                str += i.ToString();
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);

            //StringBuilder���ܲ���
            sw.Reset();
            sw.Start();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 100; i++)
                sb.Append(i.ToString());
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);

            //ִ�н��
            //422
            //3
            #endregion

            #region StringBuilder���͵Ĺ���
            //StringBuilder sb2 = new StringBuilder("Hello, word.", 20);            
            #endregion

            #region StringBuilder��Append����
            StringBuilder sbs = new StringBuilder("Hello, ");
            sbs.Append("Word.");
            Console.WriteLine(sbs);

            StringBuilder formatStr = new StringBuilder("The price is ");
            formatStr.AppendFormat("{0:C}", 22);
            formatStr.AppendFormat("\r\nThe Date is {0:D}", DateTime.Now.Date);
            Console.WriteLine(formatStr);
            //ִ�н��
            //Hello, Word.            
            #endregion

            #region StringBuilder��Insert����
            StringBuilder mysb = new StringBuilder("My name XiaoWang");
            mysb.Insert(8, "is ");
            Console.WriteLine(mysb);
            Console.WriteLine(mysb.Length);
            //ִ�н��
            //My name is XiaoWang            
            #endregion

            #region StringBuilder��Replace����
            StringBuilder sb3 = new StringBuilder("I love game.");
            sb3.Replace("game", ".NET");
            Console.WriteLine(sb3);
            //ִ�н��
            //I love .NET.

            #endregion
        }

    }
}
