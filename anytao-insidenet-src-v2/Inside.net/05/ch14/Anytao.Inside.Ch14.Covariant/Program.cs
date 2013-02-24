// Copyright   : 你必须知道的.NET，第2版
// Author      : Anytao，http://www.anytao.com
// FileName    : Anytao.Inside.Ch14.Covariant
// Release     : 2011/01/25 1.0
// Description : 14.6  协变与逆变

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anytao.Inside.Ch14.Covariant
{
    class Program
    {
        public delegate void Write(Derived d);

        public static void WriteBase(Base b)
        {
            Console.WriteLine(b.Id);
        }

        static void Main(string[] args)
        {
            //委托的逆变
            //Write w = WriteBase;
            //w(new Derived() { Id = 100});

            //Derive d = new Derive();
            //Base b = d;

            //IEnumerable<int> list = new List<int> { d };
            //IEnumerable<Base> list2 = list;

            //IComparer<Base> c = new MyComparer<Base>();
            //IComparer<Derived> c2 = c;

            //IFactory<Derived> f = new Factory<Derived>();
            //IFactory<Base> f2 = f;  //协变过程
            //Base b = f2.Create();
            //b.Write();

            //INotifier<INotification> notifier = new Notifier<INotification>();
            //INotifier<MailNotification> mailNotifier = notifier;  // 逆变过程
            //mailNotifier.Notify(new MailNotification());


            // MailDispatcher
            IMessage mail = new Email { From = "anytao@live.com", To = "admin@anytao.net", Subject = "Hello", Message = "Hello" };
            MessageDispatcher dispatcher = new MessageDispatcher();
            dispatcher.Dispatch(mail);

            IList<SMS> sms = new List<SMS> 
            {
                new SMS { To = "111111111", Message = "Hello." },                
                new SMS { To = "123456789", Message = "Happy birthday." }
            };

            dispatcher.Dispatch(sms);
        }
    }

    public class Base
    {
        public int Id { get; set; }

        public void Write()
        {
            Console.WriteLine("Base");
        }
    }

    public class Derived : Base
    {
        public void Write()
        {
            Console.WriteLine("Derived");
        }
    }

    //public sealed class MyFacotry : ObjectFactory<string, Base>
    //{
    //    public MyFacotry()
    //    {
    //    }
    //}
}
