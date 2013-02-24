// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.Framework.ExceptionEx
// Release     : 2007/11/07 1.0
// Description : 8.6 ֱ���쳣--�Զ����쳣

using System;
using System.Runtime.Serialization;

namespace InsideDotNet.Framework.ExceptionEx
{
    class Test_CustomException
    {
        public static void Main_8_7_4()//Main_8_7_4
        {
            try
            {
                try
                {
                    string str = null;
                    Console.WriteLine(str.ToString());
                }
                catch (NullReferenceException ex)
                {
                    //��߲���÷��׳��Զ����쳣
                    throw new MyException("����ϵͳ�쳣��Ϣ��", "\n�����Զ����쳣��Ϣ��", ex);
                }
            }
            catch (MyException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    //Serializableָ�����Զ����쳣���Ա����л�
    [Serializable]
    public class MyException : Exception, ISerializable
    {
        //�Զ��屾���ı���Ϣ
        private string myMsg;

        public string MyMsg
        {
            get { return myMsg; }
        }

        //��дֻ�������ı���Ϣ����
        public override string Message
        {
            get
            {
                string msgBase = base.Message;
                return myMsg == null ? msgBase : msgBase + myMsg;
            }
        }

        //ʵ�ֻ����3�����й��캯��
        public MyException()
            : base() { }

        public MyException(string message)
            : base(message) { }

        public MyException(string message, Exception innerException)
            : base(message, innerException) { }

        //Ϊ�����ֶ�ʵ�ֹ��캯��
        public MyException(string message, string myMsg)
            : this(message)
        {
            this.myMsg = myMsg;
        }

        public MyException(string message, string myMsg, Exception innerException)
            : this(message, innerException)
        {
            this.myMsg = myMsg;
        }

        //�������л��Ĺ��캯������֧�ֿ�Ӧ�ó������Զ�̱߽�ķ��ʹ���
        protected MyException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            myMsg = info.GetString("MyMsg");
        }

        //��д����GetObjectData������ʵ����SerializationInfo������Զ����ֶ���Ϣ
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("MyMsg", myMsg);
            base.GetObjectData(info, context);
        }
    }
}
