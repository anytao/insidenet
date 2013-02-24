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
    public class MessageDispatcher
    {
        public void Dispatch(IMessage mail)
        {
            Send(mail);
        }

        public void Dispatch(IEnumerable<IMessage> mails)
        {
            foreach (var item in mails)
            {
                Send(item);
            }
        }

        private void Send(IMessage mail)
        {
            Console.WriteLine("Send message {0}.", mail.Message); 
        }
    }


    public interface IMessage
    {
        string Message { get; set; }
    }

    public class SMS : IMessage
    {
        public string To { get; set; }
        public string Message { get; set; }
    }

    public class Email : IMessage
    {
        public string From { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
    }
}
