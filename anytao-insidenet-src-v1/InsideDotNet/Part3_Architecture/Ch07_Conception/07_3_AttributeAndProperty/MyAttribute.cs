// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.Conception.AttributeAndProperty
// Release     : 2007/04/19 1.0
// Description : 7.3  ��ʷ�������Ժ�����

using System;
using System.Reflection;

namespace InsideDotNet.Conception.AttributeAndProperty
{
    //��������Ҳ����Ӧ�����������������ϣ�
    //Ӧ��AttributeUsage�����������Ӧ���¶��������
    [AttributeUsageAttribute(AttributeTargets.All,       //��Ӧ���κ�Ԫ��
        AllowMultiple = true,                            //����Ӧ�ö��
        Inherited = false)]                              //���̳е�������
    //����Ҳ��һ���࣬
    //����̳���System.Attribute�࣬
    //�����淶Ϊ��"����"+Attribute��		
    public class MyselfAttribute : System.Attribute
    {
        //�����ֶ�
        private string _name;
        private int _age;
        private string _memo;

        //������ʽ�Ķ����乹�캯��
        public MyselfAttribute()
        {
        }
        public MyselfAttribute(string name, int age)
        {
            _name = name;
            _age = age;
        }

        //��������
        //��Ȼ���Ժ����Բ���һ���¶�
        public string Name
        {
            get { return _name == null ? string.Empty : _name; }
        }

        public int Age
        {
            get { return _age; }
        }

        public string Memo
        {
            get { return _memo; }
            set { _memo = value; }
        }

        //���巽��
        public void ShowName()
        {
            Console.WriteLine("Hello, {0}", _name == null ? "world." : _name);
        }
    }

    //Ӧ���Զ�������
    //������Myself����MyselfAttribute��Ϊ������
    //���Ը�����Memo��ֵ
    //[Myself("Emma", 25, Memo = "Emma is my good girl.")]
    [Myself()]
    public class Mytest
    {
        public void SayHello()
        {
            Console.WriteLine("Hello, my.net world.");
        }
    }

    public class Myrun
    {
        public static void Main_7_3_1(string[] args)//Main_7_3_1
        {
            //����Է���ȷ��������Ϣ
            Type tp = typeof(Mytest);
            MemberInfo info = tp;
            MyselfAttribute myAttribute =
                (MyselfAttribute)Attribute.GetCustomAttribute(info, typeof(MyselfAttribute));
            if (myAttribute != null)
            {
                //�ٺ٣�������ʱ�鿴ע�����ݣ��ǲ��Ǻ�ˬ
                Console.WriteLine("Name: {0}", myAttribute.Name);
                Console.WriteLine("Age: {0}", myAttribute.Age);
                Console.WriteLine("Memo of {0} is {1}", myAttribute.Name, myAttribute.Memo);
                myAttribute.ShowName();
            }

            //��㷴��
            object obj = Activator.CreateInstance(typeof(Mytest));

            MethodInfo mi = tp.GetMethod("SayHello");
            mi.Invoke(obj, null);
            Console.ReadLine();
        }
    }
}
