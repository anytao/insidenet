// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.OOThink.ObjTravel
// Release     : 2007/08/23 1.0
// Description : 1.1 对象的旅行

using System;

namespace InsideDotNet.OOThink.ObjTravel
{
    public class Person
    {
    }

    interface IPerson
    {
        string Name
        {
            get;
            set;
        }

        Int32 Age
        {
            get;
            set;
        }

        void DoWork();
    }

    class PersonAtHome : IPerson
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private Int32 age;

        public Int32 Age
        {
            get { return age; }
            set { age = value; }
        }


        public void DoWork()
        { 
        }
    }

    class PersonAtSchool : IPerson
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private Int32 age;

        public Int32 Age
        {
            get { return age; }
            set { age = value; }
        }


        public void DoWork()
        {
        }
    }

    class PersonOnBus : IPerson
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private Int32 age;

        public Int32 Age
        {
            get { return age; }
            set { age = value; }
        }


        public void DoWork()
        {
        }
    }

    class Test
    {
        public static void Main()
        {
            //Person aPerson = new Person("Xiao Wang", 27);
            //aPerson.ChangeName("Apple Boy");

            //IBusRole passager = new Person();
            //passager.BuyTicket();

            //ISchoolRole student = new Person();
            //student.PlayBall();
            IPerson aPerson = new PersonAtHome();
            aPerson.DoWork();
            IPerson bPerson = new PersonOnBus();
            bPerson.DoWork();

        }
    }
}
