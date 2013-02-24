// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.OOThink.Interface
// Release     : 2007/12/19 1.0
// Description : 1.5 玩转接口

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
            Console.WriteLine("有经验的司机可以驾驶公共汽车。");
        }
    }

    public class CarDriver : IDriveable
    {
        public void Drive()
        {
            Console.WriteLine("小车司机开小汽车。");
        }
    }

    public class TractorDriver : IDriveable
    {
        public void Drive()
        {
            Console.WriteLine("拖拉机司机驾驶拖拉机。");
        }
    }

    public class AircraftDriver : IDriveable
    {
        public void Drive()
        {
            Console.WriteLine("飞行员可以驾驶飞机。");
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
