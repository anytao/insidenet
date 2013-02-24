// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.NewFeature.CSharp3
// Release     : 2007/12/12 1.0
// Description : 12.2  赏析C＃3.0--匿名类型（AnonymousTypes）

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InsideDotNet.NewFeature.CSharp3
{
    class AnonymousType
    {
        public static void Main_12_2_3()//Main_12_2_3
        {
            //User user = new User { Name = "小王", Age = 27 };

            var user = new { Name = "小王", Age = 27 };
            var my = new { Name = "Wang", Emal = "Mail@anytao.com" };
            //等效于User v = new User { Name = "小王", Age = 27 };
            Console.WriteLine(user.Name);
            Console.WriteLine(user.GetType());

            var name = "小王";
            var age = 27;
            //等效于string v2 = "123";
            Console.WriteLine(name.GetType());
            Console.WriteLine(age.GetType());

            //创建不同的Type
            var v1 = new { Name = "Aero", Age = 27 };
            var v2 = new { Name = "Emma", Age = 22 };
            var v3 = new { Age = 27, Name = "Aero" };
            Console.WriteLine(v1.Equals(v2));
            Console.WriteLine(v1.Equals(v3));
            Console.WriteLine(ReferenceEquals(v1.GetType(), v2.GetType()));
            Console.WriteLine(ReferenceEquals(v1.GetType(), v3.GetType()));
        }
    }

    ////反编译结果
    //[DebuggerDisplay(@"\{ Name = {Name}, Age = {Age} }", Type="<Anonymous Type>"), CompilerGenerated]
    //internal sealed class <>f__AnonymousType0<<Name>j__TPar, <Age>j__TPar>
    //{
    //    // Fields
    //    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    //    private readonly <Age>j__TPar <Age>i__Field;
    //    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    //    private readonly <Name>j__TPar <Name>i__Field;

    //    // Methods
    //    [DebuggerHidden]
    //    public <>f__AnonymousType0(<Name>j__TPar Name, <Age>j__TPar Age);
    //    [DebuggerHidden]
    //    public override bool Equals(object value);
    //    [DebuggerHidden]
    //    public override int GetHashCode();
    //    [DebuggerHidden]
    //    public override string ToString();

    //    // Properties
    //    public <Age>j__TPar Age { get; }
    //    public <Name>j__TPar Name { get; }
    //}
}
