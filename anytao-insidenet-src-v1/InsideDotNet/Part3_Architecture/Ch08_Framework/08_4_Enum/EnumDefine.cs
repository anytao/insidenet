// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.Framework.EnumEx
// Release     : 2007/11/03 1.0
// Description : 8.4 ���ײ��򵥣�ö�ٺ�λ���

using System;
using System.Collections.Generic;
using System.Text;

namespace InsideDotNet.Framework.EnumEx
{
    class Enum_Test
    {
        public static void Main_8_4_5()//Main_8_4_5
        {
            LogLevel logger = LogLevel.Information;
            Console.WriteLine("The log level is {0}.", logger.ToString());
            LogLevel log = LogLevel.Information;
            Console.WriteLine(log.Equals(logger));
            Console.WriteLine(ReferenceEquals(log, logger));
            object o = (object)LogLevel.Information;
            GetCurrentLog(log);

            int logger3 = LoggerLevel.Warnning;
            GetCurrentLogger(logger3);
        }

        //ö����ǿ����
        private static void GetCurrentLog(LogLevel log)
        {
            Console.WriteLine(log.ToString());
        }

        //�����ʵ�ֵ�ö���Ƿ�ǿ���͵�
        private static void GetCurrentLogger(int logger)
        {
            Console.WriteLine(logger.ToString());
        }
    }

    enum LogLevel
    {
        Trace = 1,
        Debug = 1,
        Information,
        Warnning,
        Error,
        Fatal
    }

    public class LoggerLevel
    {
        public static int Trace = 0;
        public static int Debug = 1;
        public static int Information = 2;
        public static int Warnning = 3;
        public static int Error = 4;
        public static int Fatal = 5;
    }
}
