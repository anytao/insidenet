// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Conception.InterfaceAndAbstractClass
// Release     : 2008/01/12 1.0
// Description : 7.4  面向抽象编程：接口和抽象类

using System;
using System.Collections.Generic;
using System.Text;

namespace InsideDotNet.Conception.InterfaceAndAbstractClass
{
    class CallbackEx
    {
    }

    public interface IEvent
    {
        void MyEvent();
    }

    public class EventNotifier
    {
        private IEvent ie;

        public EventNotifier(IEvent ie)
        {
            this.ie = ie;
        }

        public void DoWork()
        {
            ie.MyEvent();
        }
    }

    public class CallMe : IEvent
    {
        private EventNotifier en;

        public CallMe()
        {
            en = new EventNotifier(this);
        }

        public void MyEvent()
        {
            Console.WriteLine("Something Happened.");
        }
    }

    public class Test_MyEvent
    {
        public static void Main_7_4_2()//Main_7_4_2
        {
            IEvent ie = new CallMe();
            EventNotifier en = new EventNotifier(ie);
            en.DoWork();
        }
    }
}
