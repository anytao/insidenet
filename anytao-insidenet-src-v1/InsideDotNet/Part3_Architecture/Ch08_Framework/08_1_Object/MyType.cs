// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.Framework.Object
// Release     : 2007/10/27 1.0
// Description : 8.1  ������ڣ�System.Object

using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;


namespace InsideDotNet.Framework.Object
{
    class MyType
    {
        private int number = 0;
        private string name = null;

        public static void ShowType(string type, string info)
        {
            Console.WriteLine("This type is MyType.");
        }

        private void ShowNumber()
        {
            Console.WriteLine(number.ToString());
        }
    }

    class Test_GetType
    {
        public static void Main()//Main_8_1_1
        {
            #region GetType��ʾ
            MyType mt = new MyType();
            //ʹ��Object.GetType����Typeʵ��
            Type tp = mt.GetType();
            Console.WriteLine(tp.ToString());
            Console.WriteLine(tp.Name.ToString());
            #endregion

            #region ����Typeʵ����ȡԪ������Ϣ
            //����Typeʵ���������ͳ�Ա
            foreach (MemberInfo info in tp.GetMembers())
            {
                Console.WriteLine("The member is {0}, {1}", info.Name, info.DeclaringType);
            }

            //����Typeʵ���������ͷ���
            foreach (MethodInfo mi in tp.GetMethods())
            {
                Console.WriteLine("The method is {0}", mi.ToString());
                //���ҷ���������Ϣ
                ParameterInfo[] pis = mi.GetParameters();
                foreach (ParameterInfo pi in pis)
                {
                    Console.WriteLine("{0}'s member is {1}", mi.ToString(), pi.ToString());
                }
            }

            #endregion

            #region Type.GetType �� typeof

            //ʹ��Type.GetType����Typeʵ��
            Type tp2 = Type.GetType("InsideDotNet.Framework.Object.MyType");
            //ʹ��typeof���������Typeʵ��
            Type tp3 = typeof(InsideDotNet.Framework.Object.MyType);

            Console.WriteLine(tp2.Name.ToString());
            Console.WriteLine(tp3.Name.ToString());


            //Type.GetType֧�ֶ�̬����
            Assembly ass = Assembly.LoadFrom(@"C:\Anytao.Utility.exe");
            Type tpd = ass.GetType("Anytao.Utility.Message.AnyMsg");
            Console.WriteLine(tpd.ToString());

            #endregion

        }
    }
}
