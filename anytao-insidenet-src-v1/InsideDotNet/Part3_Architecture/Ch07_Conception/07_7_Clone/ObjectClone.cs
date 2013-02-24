// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Conception.Clone
// Release     : 2007/10/05 1.0
// Description : 7.7 有深有浅的克隆：浅拷贝和深拷贝

using System;
using System.Collections.Generic;
using System.Text;

namespace InsideDotNet.Conception.Clone
{
    class Student : ICloneable
    {
        public string Name;
        public Int32 Age;

        public Student(string name, Int32 age)
        {
            Name = name;
            Age = age;
        }

        public void ShowInfo()
        {
            Console.WriteLine("{0}'s age is {1}", Name, Age);
        }

        public Object Clone()
        {
            //实现浅拷贝
            return MemberwiseClone();
        }
    }

    class Enrollment : ICloneable
    {
        //定义引用类型数据成员
        public List<Student> students = new List<Student>();

        //定义默认构造函数
        public Enrollment()
        {
        }

        //提供实现深拷贝的私有实例创建构造函数
        private Enrollment(List<Student> studentList)
        {
            foreach (Student s in studentList)
            {
                students.Add((Student)s.Clone());
            }
        }

        public void ShowEnrollmentInfo()
        {
            Console.WriteLine("Students enrollment information:");
            foreach (Student s in students)
            {
                Console.WriteLine("{0}'s age is {1}", s.Name, s.Age);
            }
        }

        public object Clone()
        {
            //执行浅拷贝
            //return MemberwiseClone();
            //执行深拷贝
            return new Enrollment(students);
        }
    }

    class Test_ObjectClone
    {
        public static void Main()//Main_7_7_1
        {
            //引用类型的浅拷贝
            Student s1 = new Student("Wang", 22);
            //执行浅拷贝，
            Student s2 = s1;
            s2.Age = 27;
            s1.ShowInfo();


            //值类型的深拷贝
            //Int32 i = 100;
            //Int32 j = i;
            //j = 200;
            //Console.WriteLine(i);

        }

        public static void Main_7_7_2()//Main_7_7_2
        {
            Student s1 = new Student("Wang", 22);
            Student s3 = (Student)s1.Clone();
            s3.ShowInfo();
            s3.Name = "Hao";
            s3.Age = 27;
            s3.ShowInfo();
            s1.ShowInfo();
        }

        public static void Main_7_7_3()//Main_7_7_3
        {
            Enrollment sourceStudentsList = new Enrollment();
            sourceStudentsList.students.Add(new Student("王小二", 27));
            sourceStudentsList.students.Add(new Student("张三", 22));

            //实现对象的克隆，执行浅拷贝还是深拷贝，
            //取决于Clone方法的具体实现
            Enrollment cloneStudentsList = sourceStudentsList.Clone() as Enrollment;

            sourceStudentsList.ShowEnrollmentInfo();
            cloneStudentsList.ShowEnrollmentInfo();

            cloneStudentsList.students[1].Name = "李四";
            cloneStudentsList.students[1].Age = 36;

            sourceStudentsList.ShowEnrollmentInfo();
            cloneStudentsList.ShowEnrollmentInfo();

        }

    }

}
