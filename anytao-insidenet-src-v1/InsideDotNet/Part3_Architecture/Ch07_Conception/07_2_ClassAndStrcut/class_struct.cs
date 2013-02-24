// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Conception.ClassAndStruct
// Release     : 2007/04/24 1.0
// Description : 7.2  后来居上：class和struct

using System;

namespace InsideDotNet.Conception.ClassAndStruct
{
    interface IPerson
    {
        void GetSex();
    }

    public class Person
    {
        public Person()
        {
        }

        public Person(string name, int age)
        {
            _name = name;
            _age = age;
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
    }

    //可以继承自接口，不可继承类或结构
    struct Family : IPerson
    {
        public string name;
        public int age;
        public bool sex;
        public string country;
        public Person person;

        //不可以包含显式的无参构造函数和析构函数
        public Family(string name, int age, bool sex, string country, Person person)
        {
            this.name = name;
            this.age = age;
            this.sex = sex;
            this.country = country;
            this.person = person;
        }

        //不可以实现protected、virtual、sealed和override成员
        public void GetSex()
        {
            if (sex)
                Console.WriteLine(person.Name + " is a boy.");
            else
                Console.WriteLine(person.Name + " is a girl.");
        }

        public void ShowPerson()
        {
            Console.WriteLine("This is {0} from {1}", new Person(name, 22).Name, country);
        }

        //可以重载ToString虚方法
        public override string ToString()
        {
            return String.Format("{0} is {1}, {2} from {3}", person.Name, age, sex ? "Boy" : "Girl", country);
        }
    }

    class MyTest
    {
        static void Main(string[] args)//Main_7_2_1
        {
            //不使用new来生成结构，其内部成员将初始化为0
            Family newFamily;
            newFamily.name = "Anytao Family";
            newFamily.sex = true;
            Console.WriteLine(newFamily.name);

            //以new来生成结构，调用带参数构造器
            Family myFamily = new Family("Anytao Family", 26, true, "China", new Person("Anytao", 26));

            Person person = new Person();
            person.Name = "Anytao";

            //按值传递参数
            ShowFamily(myFamily);
            //按引用传递参数
            ShowPerson(person);

            Console.WriteLine("***************************");
            Console.WriteLine("I'm {0}", myFamily.name);
            Console.WriteLine("I'm {0}", person.Name);
            myFamily.GetSex();
            myFamily.ShowPerson();
            Console.WriteLine("***************************");
            Console.WriteLine(myFamily.ToString());
        }

        public static void ShowPerson(Person person)
        {
            person.Name = "Emma";
            Console.WriteLine("This is {0}", person.Name);
        }

        public static void ShowFamily(Family family)
        {
            family.name = "Aeor";
            Console.WriteLine("This is {0}", family.name);
        }
    }
}
