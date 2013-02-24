// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.Conception.InterfaceAndAbstractClass
// Release     : 2007/04/12 1.0
// Description : 7.4  ��������̣��ӿںͳ�����

using System;

namespace InsideDotNet.Conception.InterfaceAndAbstractClass
{
    /// <summary>
    /// ʹ�ýӿ�ʵ�ֻص�ʾ��
    /// </summary>
    public interface IMyInterface
    {
        void DoWork();
    }

    public class MyClassWithCallback
    {
        private IMyInterface _myInterface;

        public void AddCallback(IMyInterface myInterface)
        {
            _myInterface = myInterface;
        }

        public void RemoveCallback()
        {
            _myInterface = null;
        }

        public void DoWork()
        {
            if (_myInterface != null)
                _myInterface.DoWork();
        }
    }

    public class MyBaseClass : IMyInterface
    {
        public void DoWork()
        {
            Console.WriteLine("Call interface method.");
        }

        public static void Main()//Main_7_4_1
        {
            MyClassWithCallback mc = new MyClassWithCallback();
            IMyInterface mi = new MyBaseClass();

            mc.AddCallback(mi);
            mc.DoWork();
            mc.RemoveCallback();
        }
    }

}
