// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.OOThink.Interface
// Release     : 2007/12/19 1.0
// Description : 1.5 ��ת�ӿ�

using System;
using System.Collections.Generic;

namespace InsideDotNet.OOThink.Interface
{
    class InterfaceBase
    {
    }

    public interface IDriveable
    {
        void Drive();
    }

    public class BusDriver : IDriveable
    {
        public void Drive()
        {
            Console.WriteLine("�о����˾�����Լ�ʻ����������");
        }
    }

    public class CarDriver : IDriveable
    {
        public void Drive()
        {
            Console.WriteLine("С��˾����С������");
        }
    }

    public class TractorDriver : IDriveable
    {
        public void Drive()
        {
            Console.WriteLine("������˾����ʻ��������");
        }
    }

    public class AircraftDriver : IDriveable
    {
        public void Drive()
        {
            Console.WriteLine("����Ա���Լ�ʻ�ɻ���");
        }
    }

    public class DriverSchool
    {
        public static void Main_1_5_1()//Main_1_5_1
        {
            IList<IDriveable> drivers = new List<IDriveable>();
            drivers.Add(new BusDriver());
            drivers.Add(new CarDriver());
            drivers.Add(new TractorDriver());

            foreach (IDriveable driver in drivers)
            {
                driver.Drive();
            }
        }
    }

    //public sealed class String : IComparable, ICloneable, IConvertible, IComparable<string>, IEnumerable<char>, IEnumerable, IEquatable<string>

}
