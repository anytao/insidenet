// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.Keyword.Using
// Release     : 2008/02/01 1.0
// Description : 6.3 using�Ķ������

using System;
using System.Collections.Generic;
using System.Text;

namespace InsideDotNet.Keyword.Using
{
    public class FileHandler : IDisposable
    {
        public void Dispose()
        {
            //ִ������
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
            //ִ������
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
                    //ִ�в���
                }
            }
        }
    }
}
