// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Framework.EnumEx
// Release     : 2007/10/30 1.0
// Description : 8.4 简易不简单：枚举和位标记

using System;
using System.Globalization;

namespace InsideDotNet.Framework.EnumEx
{
    class EnumMethod
    {
        public static void Main_8_4_2()//Main_8_4_2
        {
            //由GetName获取枚举常数名称的数组
            foreach (string item in Enum.GetNames(typeof(Week)))
            {
                Console.WriteLine(item.ToString());
            }

            //由GetValues获取枚举常数值的数组
            foreach (Week item in Enum.GetValues(typeof(Week)))
            {
                Console.WriteLine("{0} : {1}", item.ToString("D"), item.ToString());
            }

            //以IsDefined方法来判断符号或者整数存在于枚举
            if (Enum.IsDefined(typeof(Week), "Fri"))
            {
                Console.WriteLine("Today is {0}.", Week.Fri.ToString("G"));
            }

            //将整数或者符号名称字符串转换为等效的枚举类型
            Week myday = (Week)Enum.Parse(typeof(Week), "Mon", true);
            Console.WriteLine(myday);
            //相同关联值的等效映射
            Week theDay = (Week)Enum.Parse(typeof(Week), "7");
            Console.WriteLine(theDay.ToString());

            //以GetUnderlyingType返回声明类型
            Console.WriteLine(Enum.GetUnderlyingType(typeof(Week)));

            //枚举类型和整数类型的相互转换
            //枚举转换为整数
            int i = (int)Week.Sun;
            //将整数转换为枚举
            Week day = (Week)Enum.Parse(typeof(Week), "10");
            Console.WriteLine(day.ToString());
            Week da2y = (Week)3;
            da2y++;
            Console.WriteLine(da2y.ToString());

            //不同枚举类型的相互转换
            MusicType mtToday = MusicType.Jazz;
            Week today = (Week)mtToday;
            Console.WriteLine(today.ToString());

            //枚举类型和接口类型的转换
            IConvertible iConvert = (IConvertible)MusicType.Jazz;
            Int32 x = iConvert.ToInt32(CultureInfo.CurrentCulture);
            Console.WriteLine(x);

            //枚举的初始化
            Week myweek = new Week();
            Console.WriteLine(myweek.ToString("G"));

            Console.WriteLine("***************************************");

            WithZero wz = new WithZero();
            Console.WriteLine(wz.ToString("G"));

            WithNonZero wnz = new WithNonZero();
            Console.WriteLine(wnz.ToString("G"));
            //执行结果
            //Zero
            //0


        }

    }
}
