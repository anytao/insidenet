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
    public interface INotifier<in TNotification> where TNotification : INotification
    {
        void Notify(TNotification notification);
    }

    public class Notifier<TNotification> : INotifier<TNotification> where TNotification : INotification
    {
        #region INotifier<TNotification> Members

        public void Notify(TNotification notification)
        {
            Console.WriteLine(notification.Message);
        }

        #endregion
    }

    public interface INotification
    {
        string Message { get; }
    }

    public abstract class Notification : INotification
    {
        public abstract string Message { get; }
    }

    public class MailNotification : Notification
    {

        public override string Message
        {
            get { return "You got a email."; }
        }
    }
}
