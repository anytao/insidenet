// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Type.TypeEssence
// Release     : 2007/05/28 1.0
// Description : 4.2  品味类型---值类型与引用类型 

using System;

namespace InsideDotNet.Type.TypeEssence
{
    // 01 定义值类型
    public struct MyStruct
    {
        private int _myNo;

        public int MyNo
        {
            get { return _myNo; }
            set { _myNo = value; }
        }

        public MyStruct(int myNo)
        {
            _myNo = myNo;
        }

        public void ShowNo()
        {
            Console.WriteLine(_myNo);
        }

        // 01.1 值类型的类型判等
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        // 01.2 自定义类型转：整形->MyStruct型
        static public explicit operator MyStruct(int myNo)
        {
            return new MyStruct(myNo);
        }
    }

    // 02 定义引用类型
    public class MyClass
    {
        private int _myNo;

        public int MyNo
        {
            get { return _myNo; }
            set { _myNo = value; }
        }

        public MyClass()
        {
            _myNo = 0;
        }

        public MyClass(int myNo)
        {
            _myNo = myNo;
        }


        public void ShowNo()
        {
            Console.WriteLine(_myNo);
        }

        // 02.1 引用类型的类型判等
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        // 02.2 自定义类型转换：MyClass->string型
        static public implicit operator string(MyClass mc)
        {
            return mc.ToString();
        }

        public override string ToString()
        {
            return _myNo.ToString();
        }
    }

    // 03 类型演示测试
    public class MyTestOfValueAndRef
    {
        public static void Main_4_2_4()//Main_4_2_4
        {
            //内存分配于线程的堆栈上
            //创建了值为等价"0"的实例
            MyStruct myStruct = new MyStruct();
            //在线程的堆栈上创建了引用，但未指向任何实例
            MyClass myClass;
            //内存分配于托管堆上
            myClass = new MyClass();

            //在堆栈上修改成员
            myStruct.MyNo = 1;
            //将指针指向托管堆
            myClass.MyNo = 2;

            myStruct.ShowNo();
            myClass.ShowNo();

            //在堆栈上新建内存，并执行成员拷贝
            MyStruct myStruct2 = myStruct;
            //拷贝引用地址
            MyClass myClass2 = myClass;

            //在堆栈上修改myStruct成员
            myStruct.MyNo = 3;
            //在托管堆上修改成员
            myClass.MyNo = 4;

            myStruct.ShowNo();
            myClass.ShowNo();
            myStruct2.ShowNo();
            myClass2.ShowNo();

            #region 03. 类型转换
            MyStruct MyNum;
            int i = 100;
            MyNum = (MyStruct)i;
            Console.WriteLine("整形显式转换为MyStruct型---");
            Console.WriteLine(i);

            MyClass MyCls = new MyClass(200);
            string str = MyCls;
            Console.WriteLine("MyClass型隐式转换为string型---");
            Console.WriteLine(str);
            #endregion

            #region 04. 使用sizeof判断值类型大小
            //unsafe
            //{
            //    Console.WriteLine("使用sizeof判断值类型大小---");
            //    Console.WriteLine(sizeof(MyStruct));
            //}
            #endregion


            #region 05 类型判等
            Console.WriteLine("类型判等---");
            // 05.1 ReferenceEquals判等
            //值类型总是返回false，经过两次装箱的myStruct不可能指向同一地址
            Console.WriteLine(ReferenceEquals(myStruct, myStruct));
            //同一引用类型对象，将指向同样的内存地址
            Console.WriteLine(ReferenceEquals(myClass, myClass));
            //RefenceEquals认为null等于null，因此返回true
            Console.WriteLine(ReferenceEquals(null, null));

            // 05.2 Equals判等
            //重载的值类型判等方法，成员大小不同
            Console.WriteLine(myStruct.Equals(myStruct2));

            //重载的引用类型判等方法，指向引用相同
            Console.WriteLine(myClass.Equals(myClass2));

            #endregion

            #region 06 垃圾回收的简单阐释
            //实例定义及初始化
            MyClass mc1 = new MyClass();
            //声明但不实体化
            MyClass mc2;
            //拷贝引用，mc2和mc1指向同一托管地址
            mc2 = mc1;
            //定义另一实例，并完成初始化
            MyClass mc3 = new MyClass();
            //引用拷贝，mc1、mc2指向了新的托管地址
            //那么原来的地址成为GC回收的对象，在
            mc1 = mc3;
            mc2 = mc3;
            #endregion
        }
    }

    // 04 ref和out
    public class RefAndOut
    {
        public static void Main_4_2_5()//Main_4_2_5
        {
            //必须进行初始化，才能使用ref方式传递
            int x = 10;
            ValueWithRef(ref x);
            Console.WriteLine(x);

            //使用out方式传递，不必初始化
            int y;
            ValueWithOut(out y);
            Console.WriteLine(y);

            object oRef = new object();
            RefWithRef(ref oRef);
            Console.WriteLine(oRef.ToString());

            object o;
            RefWithOut(out o);
            Console.WriteLine(o.ToString());
        }

        static void ValueWithRef(ref int i)
        {
            i = 100;
            Console.WriteLine(i.ToString());
        }

        static void ValueWithOut(out int i)
        {
            i = 200;
            Console.WriteLine(i.ToString());
        }

        static void RefWithRef(ref object o)
        {
            o = new MyStruct();
            Console.WriteLine(o.ToString());
        }

        static void RefWithOut(out object o)
        {
            o = new String('a', 10);
            Console.WriteLine(o.ToString());
        }
    }
}