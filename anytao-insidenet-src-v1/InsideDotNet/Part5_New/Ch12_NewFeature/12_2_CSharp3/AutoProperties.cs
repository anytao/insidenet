// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.NewFeature.CSharp3
// Release     : 2007/12/12 1.0
// Description : 12.2  赏析C＃3.0--自动属性（Automatic Properties）

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InsideDotNet.NewFeature.CSharp3
{
    class AutoProperties
    {

    }

    //2.0方式
    class User2_0
    {
        private string name;

        //定义只读属性
        public string Name
        {
            get { return name; }
        }

        private Int32 age;

        public Int32 Age
        {
            get { return age; }
            set { age = value; }
        }

        public Int32 Age2
        {
            get { return age; }
            set
            {
                if ((value > 0) && (value < 150))
                {
                    age = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("年龄不合法。");
                }
            }
        }
    }

    //3.0方式
    class User3_0
    {
        public string Name { get; private set; }
        public Int32 Age { get; set; }
    }

    //反编译结果
    //internal class User3_0
    //{
    //    // Fields
    //    [CompilerGenerated]
    //    private int <Age>k__BackingField;
    //    [CompilerGenerated]
    //    private string <Name>k__BackingField;

    //    // Properties
    //    public int Age
    //    {
    //        [CompilerGenerated]
    //        get
    //        {
    //            return this.<Age>k__BackingField;
    //        }
    //        [CompilerGenerated]
    //        set
    //        {
    //            this.<Age>k__BackingField = value;
    //        }
    //    }

    //    public string Name
    //    {
    //        [CompilerGenerated]
    //        get
    //        {
    //            return this.<Name>k__BackingField;
    //        }
    //        private [CompilerGenerated]
    //        set
    //        {
    //            this.<Name>k__BackingField = value;
    //        }
    //    }
    //}

    //抽象属性方式
    abstract class UserAbstract
    {
        //定义自动属性
        public string Name { get; set; }
        //定义抽象属性
        abstract public Int32 Age { get; }
    }
}
