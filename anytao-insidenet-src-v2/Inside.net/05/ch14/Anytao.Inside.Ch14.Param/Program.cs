// Copyright   : 你必须知道的.NET，第2版
// Author      : Anytao，http://www.anytao.com
// FileName    : Anytao.Inside.Ch14.Param
// Release     : 2010/12/16 1.0
// Description : 14.5  命名参数和可选参数

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace Anytao.Inside.Ch14.Param
{
    class Program
    {
        static void Main(string[] args)
        {
            Write();
            Write("subs");
            Write(y: 200, x: 100);
            Write(x: 200, y: 123, method: "subs");

            Register("anytao@live.com");
            Register("anytao@live.com", 30);
        }

        static void Write(string method = "add", int x = 1, int y = 2)
        {
            if (method == "add")
            {
                Console.WriteLine("{0} + {1} = {2}", x , y, x + y);
            }
            else if (method == "subs")
            {
                Console.WriteLine("{0} - {1} = {2}", x, y, x - y);
            }           
        }

        static void Register(string email, [Optional, DefaultParameterValue(27)] int age)
        {
            Console.WriteLine(string.Format("{0} is {1} now.", email, age));
        }
    }


 


 


}
