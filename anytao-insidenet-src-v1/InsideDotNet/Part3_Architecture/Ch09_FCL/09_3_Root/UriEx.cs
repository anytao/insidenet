// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.FCL.Root
// Release     : 2007/11/20 1.0
// Description : 9.3 根基---System命名空间--Uri简介

using System;
using System.Net;

namespace InsideDotNet.FCL.Root
{
    class UriEx
    {
        public static void Main_9_3_4()//Main_9_3_4
        {
            Uri uri = new Uri("http://www.anytao.com/");
            //应用Uri实例创建WebRequest
            WebRequest request = WebRequest.Create(uri);
            WebResponse response = request.GetResponse();

            Console.WriteLine(response.Headers);
            response.Close();
        }
    }
}
