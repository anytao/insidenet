// Copyright   : 你必须知道的.NET，第2版
// Author      : Anytao，http://www.anytao.com
// FileName    : Anytao.Inside.Ch11.BestGeneric
// Release     : 2011/03/10 1.0
// Description : 11.4  实践泛型

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Runtime.Remoting.Messaging;
using System.Diagnostics;

namespace Anytao.Inside.Ch11.BestGeneric
{
    class Program
    {
        static void Main1(string[] args)
        {
            ATFactory<Element> factory = new ATFactory<Element>();

            //PipelineBase<object> pipeline = new PipelineBase<object>();

            ////调用泛型方法
            //pipeline.Execute(1);
            ////调用非泛型方法
            //IMessage message = new Message();
            //pipeline.Execute(message);
        }

        static void Main2()
        {
            User model = new User();

            UserEntity entity = null;// DB.Get(1);

            if (entity != null)
            {
                model.Id = entity.UserId;
                //model.FriendId = entity.FriendId == null ? -1 : entity.FriendId.Value;
                model.FriendId = entity.FriendId;
                model.Name = entity.Name;
            }

            //...
        }

        static void Main3()
        {
            MailList list = new MailList();

            foreach (EMail mail in list)
            {
                //...
            }
        }

        static void Main()
        {
            object o1 = 1;
            object o2 = 2;
            Utils.Swap(ref o1, ref o2);

            Console.WriteLine(o2);
        }
    }
}
