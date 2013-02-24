// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Keyword.Using
// Release     : 2008/02/01 1.0
// Description : 6.3 using的多重身份

using System;
using System.Collections.Generic;
using System.Text;

namespace InsideDotNet.Keyword.Using
{
    public class FileHandler : IDisposable
    {
        public void Dispose()
        {
            //执行清理
        }
    }

    public class DBHandler : IDisposable
    {
        public DBHandler()
        {
            throw new Exception();
        }


        public void Dispose()
        {
            //执行清理
        }
    }

    class MoreUsing
    {
        public static void Main()//Main_6_3_3
        {
            FileHandler fh = new FileHandler();
            DBHandler dh = new DBHandler();

            using (fh)
            {
                using (dh)
                {
                    //执行操作
                }
            }
        }
    }
}
