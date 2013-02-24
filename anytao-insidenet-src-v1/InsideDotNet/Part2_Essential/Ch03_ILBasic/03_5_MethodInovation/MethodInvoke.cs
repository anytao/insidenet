// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.ILBasic.MethodInovation
// Release     : 2007/09/02 1.0
// Description : 3.5  ����ָ�����֮��������

using System;
using System.Collections.Generic;
using System.Text;

namespace InsideDotNet.ILBasic.MethodInovation
{
    public class MethodInvoke
    {
        public static void StaticMethod()
        {
        }

        public void InstanceMethod()
        {
        }
    }

    public class Father
    {
        public void DoWork()
        {
            Console.WriteLine("Father.DoWork()");
        }

        public virtual void DoVirtualWork()
        {
            Console.WriteLine("Father.DoVirtualWork()");
        }

        public virtual void DoVirtualAll()
        {
            Console.WriteLine("Father.DoVirtualAll()");
        }
    }

    public class Son : Father
    {
        public static void DoStaticWork()
        {
            Console.WriteLine("Son.DoStaticWork()");
        }

        public new void DoWork()
        {
            Console.WriteLine("Son.DoWork()");
        }

        public new virtual void DoVirtualWork()
        {
            base.DoVirtualWork();
            Console.WriteLine("Son.DoVirtualWork()");
        }

        public override void DoVirtualAll()
        {
            Console.WriteLine("Son.DoVirtualAll()");
        }
    }

    public class Grandson : Son
    {
        public override void DoVirtualWork()
        {
            base.DoVirtualWork();
            Console.WriteLine("Grandson.DoVirtualWork()");
        }

        public override void DoVirtualAll()
        {
            base.DoVirtualAll();
            Console.WriteLine("Grandson.DoVirtualAll()");
        }
    }

    public class MyRefMethod
    {
        public void ShowInfo()
        {
        }
    }

    class IL_Method_Test
    {
        public static void Main()//Main_3_5_2
        {
            #region ��̬������Ǿ�̬�����ĵ���

            //���þ�̬����
            MethodInvoke.StaticMethod();
            //����ʵ������
            MethodInvoke mi = new MethodInvoke();
            mi.InstanceMethod();

            #endregion

            #region callvirt�����������͵ķ��鷽��

            //MyRefMethod aRefMethod = new MyRefMethod();
            //aRefMethod = null;
            //aRefMethod.ShowInfo();

            #endregion

            #region call��callvirt�Ƚ�

            //Father father = new Father();
            //father.DoWork();
            //father.DoWorkByVirtual();

            Father son = new Son();
            son.DoWork();
            son.DoVirtualWork();

            if (son is Father)
            {
                Console.WriteLine("He is right.");
            }

            //Son aSon = new Son();
            //aSon.DoWork();
            //aSon.DoWorkByVirtual();
            Son.DoStaticWork();

            //Grandson.DoWork();
            Father aGrandSon = new Grandson();
            aGrandSon.DoWork();
            aGrandSon.DoVirtualWork();
            aGrandSon.DoVirtualAll();


            Console.Read();

            #endregion

        }
    }
}
