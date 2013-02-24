// Copyright   : 你必须知道的.NET，第2版
// Author      : Anytao，http://www.anytao.com
// FileName    : Anytao.Inside.Ch11.BestGeneric
// Release     : 2011/03/10 1.0
// Description : 11.4  实践泛型

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anytao.Inside.Ch11.BestGeneric
{
    public class MailDispatcher
    {
        public event EventHandler<MailEventArgs> Sending;

        public void Send(EMail mail)
        {
            OnSending(mail, new MailEventArgs(mail));

            try
            {
                // Send mail...

            }
            catch (Exception ex)
            {
                // Error log...
            }
        }

        protected virtual void OnSending(EMail sender, MailEventArgs e)
        {
            EventHandler<MailEventArgs> handler = Sending;

            if (handler != null)
            {
                handler(sender, e);
            }
        }
    }
}
