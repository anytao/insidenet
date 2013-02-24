using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Anytao.Inside.Ch14.Dynamic;
using System.Dynamic;

namespace Anytao.Inside.Ch14.Test
{
    public class Program
    {
        public static void Main()
        {
            dynamic iron = new IronObject();
            iron.X = 123;
            iron.Say = new Action<string>(source => Console.WriteLine(string.Format("IronObject is saying {0}", source)));

            iron.Say("Hello");

            //dynamic x = new ExpandoObject();
            //x.Say = new Func<string, string>(source => string.Format("Hello, this is {0}", source));

            //Console.WriteLine(x.Say(".NET"));

            //var abc = "Hello, World.";
            //dynamic abc = "Hello, World.";

            // DynamicWord.Create(@"E:\hello.docx", "Anytao");

            //DynamicWork dw = new DynamicWork();

            //Console.WriteLine(dw.Work(100, 1));

            //Console.WriteLine(dw.Work(100, 1));// Result: 101
            //Console.WriteLine(dw.Work("100", "1"));// Result： 1001

        }
    }
}
