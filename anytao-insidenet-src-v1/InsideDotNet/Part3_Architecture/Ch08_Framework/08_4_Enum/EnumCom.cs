// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Framework.EnumEx
// Release     : 2007/10/30 1.0
// Description : 8.4 简易不简单：枚举和位标记

using System;
using System.Collections.Generic;
using System.Text;

namespace InsideDotNet.Framework.EnumEx
{
    class EnumCom
    {
        public static void Main()//Main_8_4_1
        {
            MusicType mt = MusicType.Jazz;

            Console.WriteLine(mt.ToString());
            Console.WriteLine(mt.ToString("D"));
            Console.WriteLine(mt.ToString("G"));

        }


        public static void Main_8_4_3()//Main_8_4_3
        {
            frmEnumBinding frm = new frmEnumBinding();
            frm.ShowDialog();
        }
    }

    enum MusicType
    {
        Blue,
        //循环定义
        //Jazz = Pop,
        Jazz,
        Pop
    }

    enum Week : int
    {
        Sun = 7,
        Mon = 1,
        Tue = 1,
        Wed,
        Thur,
        Fri,
        Sat,
        Weekend = Sun,
    }

    //System.Enum类型的定义
    //public abstract class Enum : ValueType, IComparable, IFormattable, IConvertible


    enum WithZero
    {
        First = 1,
        Zero = 0
    }

    enum WithNonZero
    {
        First = 1,
        Second
    }
}
