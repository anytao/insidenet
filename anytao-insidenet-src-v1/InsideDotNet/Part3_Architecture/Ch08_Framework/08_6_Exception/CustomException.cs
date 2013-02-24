// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Framework.ExceptionEx
// Release     : 2007/11/07 1.0
// Description : 8.6 直面异常--自定义异常

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
                    //向高层调用方抛出自定义异常
                    throw new MyException("这是系统异常信息。", "\n这是自定义异常信息。", ex);
                }
            }
            catch (MyException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    //Serializable指定了自定义异常可以被序列化
    [Serializable]
    public class MyException : Exception, ISerializable
    {
        //自定义本地文本信息
        private string myMsg;

        public string MyMsg
        {
            get { return myMsg; }
        }

        //重写只读本地文本信息属性
        public override string Message
        {
            get
            {
                string msgBase = base.Message;
                return myMsg == null ? msgBase : msgBase + myMsg;
            }
        }

        //实现基类的3个公有构造函数
        public MyException()
            : base() { }

        public MyException(string message)
            : base(message) { }

        public MyException(string message, Exception innerException)
            : base(message, innerException) { }

        //为新增字段实现构造函数
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

        //用于序列化的构造函数，以支持跨应用程序域或远程边界的封送处理
        protected MyException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            myMsg = info.GetString("MyMsg");
        }

        //重写基类GetObjectData方法，实现向SerializationInfo中添加自定义字段信息
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("MyMsg", myMsg);
            base.GetObjectData(info, context);
        }
    }
}
