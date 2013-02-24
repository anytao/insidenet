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
    public class Client
    {
        public static void Main3()
        {
            ILog myLogger = new XMLLog();
            try
            {

            }
            catch
            {
                myLogger.Write();
            }
        }
    }

    public interface ILog
    {
        void Read();
        void Write();
    }

    public class XMLLog : ILog
    {
        public void Read()
        {
        }

        public void Write()
        {
        }
    }

}
