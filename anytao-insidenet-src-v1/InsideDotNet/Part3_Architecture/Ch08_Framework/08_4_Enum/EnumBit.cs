// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Framework.EnumEx
// Release     : 2007/11/03 1.0
// Description : 8.4 简易不简单：枚举和位标记

using System;

namespace InsideDotNet.Framework.EnumEx
{
    class EnumBit
    {
        public static void Main_8_4_4()//Main_8_4_4
        {
            ColorStyle mycs = ColorStyle.Red | ColorStyle.Yellow | ColorStyle.Blue;
            Console.WriteLine(mycs.ToString());


            //对位标记执行IsDefined方法
            //Enum.IsDefined(typeof(ColorStyle), 0x15);
            //Enum.IsDefined(typeof(ColorStyle), "Red, Yellow, Blue");
            //if(Enum.IsDefined(typeof(ColorStyle), "Red, Yellow, Blue"))
            if (Enum.IsDefined(typeof(ColorStyle), 0x15))
            {
                Console.WriteLine(ColorStyle.All);
            }

            if ((mycs & ColorStyle.Red) != 0)
                Console.WriteLine(ColorStyle.Red + " is in ColorStyle");

        }
    }

    [Flags]
    enum ColorStyle
    {
        None = 0x00,
        Red = 0x01,
        Orange = 0x02,
        Yellow = 0x04,
        Greeen = 0x08,
        Blue = 0x10,
        Indigotic = 0x20,
        Purple = 0x40,
        All = Red | Orange | Yellow | Greeen | Blue | Indigotic | Purple
    }
}
