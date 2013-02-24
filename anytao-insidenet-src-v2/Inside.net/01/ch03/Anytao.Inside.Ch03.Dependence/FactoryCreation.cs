// Copyright   : 你必须知道的.NET，第2版
// Author      : Anytao，http://www.anytao.com
// FileName    : Anytao.Inside.Ch03.Dependence
// Release     : 2011/02/10 1.0
// Description : 3.2  依赖的哲学

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anytao.Inside.Ch03.Dependence
{
    //public class FactoryCreation
    //{
    //    public static void Main()
    //    {
    //        EndpointAddress ea = new EndpointAddress("http://api.anytao.com /UserService");
    //        BasicHttpBinding binding = new BasicHttpBinding();
    //        IChannelFactory<IRequestChannel> facotry = binding.BuildChannelFactory<IRequestChannel>();
    //        facotry.Open();
    //        IRequestChannel channel = facotry.CreateChannel(ea);
    //        channel.Open();
    //        //Do something continue...
    //    }
    //}


    //public interface IChannelFactory<TChannel> : IChannelFactory, ICommunicationObject
    //{
    //    TChannel CreateChannel(EndpointAddress to);
    //    TChannel CreateChannel(EndpointAddress to, Uri via);
    //}


}
