// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Keyword.Using
// Release     : 2007/09/29 1.0
// Description : 6.3 using的多重身份

using System;

namespace InsideDotNet.Keyword.Using
{
    using MyConsole = System.Console;
    using BoyPlayer = Boyspace.Player;
    using GirlPlayer = Girlspace.Player;



    class UsingAlias
    {

        public static void Main_6_3_1()//Main_6_3_1
        {
            MyConsole.WriteLine("应用了类的别名。");
            BoyPlayer.Play();
            GirlPlayer.Play();
            Boyspace.Player.Play();
            Girlspace.Player.Play();
        }
    }


    namespace Anytao.NestedNamespace
    {
        public class NestedCls
        {
            public void MyMethod()
            {
                Console.WriteLine("This is nested class.");
            }
        }
    }
}



namespace Boyspace
{
    public class Player
    {
        public static void Play()
        {
            System.Console.WriteLine("Boys play football.");
        }
    }
}

namespace Girlspace
{
    public class Player
    {
        public static void Play()
        {
            System.Console.WriteLine("Girls play violin.");
        }
    }
}


