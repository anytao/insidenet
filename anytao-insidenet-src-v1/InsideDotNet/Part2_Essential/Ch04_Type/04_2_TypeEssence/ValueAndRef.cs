// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.Type.TypeEssence
// Release     : 2007/05/28 1.0
// Description : 4.2  Ʒζ����---ֵ�������������� 

using System;

namespace InsideDotNet.Type.TypeEssence
{
    // 01 ����ֵ����
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

        // 01.1 ֵ���͵������е�
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        // 01.2 �Զ�������ת������->MyStruct��
        static public explicit operator MyStruct(int myNo)
        {
            return new MyStruct(myNo);
        }
    }

    // 02 ������������
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

        // 02.1 �������͵������е�
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        // 02.2 �Զ�������ת����MyClass->string��
        static public implicit operator string(MyClass mc)
        {
            return mc.ToString();
        }

        public override string ToString()
        {
            return _myNo.ToString();
        }
    }

    // 03 ������ʾ����
    public class MyTestOfValueAndRef
    {
        public static void Main_4_2_4()//Main_4_2_4
        {
            //�ڴ�������̵߳Ķ�ջ��
            //������ֵΪ�ȼ�"0"��ʵ��
            MyStruct myStruct = new MyStruct();
            //���̵߳Ķ�ջ�ϴ��������ã���δָ���κ�ʵ��
            MyClass myClass;
            //�ڴ�������йܶ���
            myClass = new MyClass();

            //�ڶ�ջ���޸ĳ�Ա
            myStruct.MyNo = 1;
            //��ָ��ָ���йܶ�
            myClass.MyNo = 2;

            myStruct.ShowNo();
            myClass.ShowNo();

            //�ڶ�ջ���½��ڴ棬��ִ�г�Ա����
            MyStruct myStruct2 = myStruct;
            //�������õ�ַ
            MyClass myClass2 = myClass;

            //�ڶ�ջ���޸�myStruct��Ա
            myStruct.MyNo = 3;
            //���йܶ����޸ĳ�Ա
            myClass.MyNo = 4;

            myStruct.ShowNo();
            myClass.ShowNo();
            myStruct2.ShowNo();
            myClass2.ShowNo();

            #region 03. ����ת��
            MyStruct MyNum;
            int i = 100;
            MyNum = (MyStruct)i;
            Console.WriteLine("������ʽת��ΪMyStruct��---");
            Console.WriteLine(i);

            MyClass MyCls = new MyClass(200);
            string str = MyCls;
            Console.WriteLine("MyClass����ʽת��Ϊstring��---");
            Console.WriteLine(str);
            #endregion

            #region 04. ʹ��sizeof�ж�ֵ���ʹ�С
            //unsafe
            //{
            //    Console.WriteLine("ʹ��sizeof�ж�ֵ���ʹ�С---");
            //    Console.WriteLine(sizeof(MyStruct));
            //}
            #endregion


            #region 05 �����е�
            Console.WriteLine("�����е�---");
            // 05.1 ReferenceEquals�е�
            //ֵ�������Ƿ���false����������װ���myStruct������ָ��ͬһ��ַ
            Console.WriteLine(ReferenceEquals(myStruct, myStruct));
            //ͬһ�������Ͷ��󣬽�ָ��ͬ�����ڴ��ַ
            Console.WriteLine(ReferenceEquals(myClass, myClass));
            //RefenceEquals��Ϊnull����null����˷���true
            Console.WriteLine(ReferenceEquals(null, null));

            // 05.2 Equals�е�
            //���ص�ֵ�����еȷ�������Ա��С��ͬ
            Console.WriteLine(myStruct.Equals(myStruct2));

            //���ص����������еȷ�����ָ��������ͬ
            Console.WriteLine(myClass.Equals(myClass2));

            #endregion

            #region 06 �������յļ򵥲���
            //ʵ�����弰��ʼ��
            MyClass mc1 = new MyClass();
            //��������ʵ�廯
            MyClass mc2;
            //�������ã�mc2��mc1ָ��ͬһ�йܵ�ַ
            mc2 = mc1;
            //������һʵ��������ɳ�ʼ��
            MyClass mc3 = new MyClass();
            //���ÿ�����mc1��mc2ָ�����µ��йܵ�ַ
            //��ôԭ���ĵ�ַ��ΪGC���յĶ�����
            mc1 = mc3;
            mc2 = mc3;
            #endregion
        }
    }

    // 04 ref��out
    public class RefAndOut
    {
        public static void Main_4_2_5()//Main_4_2_5
        {
            //������г�ʼ��������ʹ��ref��ʽ����
            int x = 10;
            ValueWithRef(ref x);
            Console.WriteLine(x);

            //ʹ��out��ʽ���ݣ����س�ʼ��
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