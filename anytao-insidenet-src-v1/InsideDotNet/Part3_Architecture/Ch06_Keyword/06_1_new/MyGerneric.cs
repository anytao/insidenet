// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Keyword.New
// Release     : 2007/04/28 1.0
// Description : 6.1  把new说透

using System;

namespace InsideDotNet.Keyword.New
{
    class MyCls
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public MyCls()
        {
            _name = "Emma";
        }
    }

    class Genericer<T> where T : new()
    {
        public T GetItem()
        {
            return new T();
        }
    }

    class MyGenericTester
    {
        public static void Main_6_1_2(string[] args)//Main_6_1_2
        {
            Genericer<MyCls> MyGen = new Genericer<MyCls>();
            Console.WriteLine(MyGen.GetItem().Name);
        }
    }
}
