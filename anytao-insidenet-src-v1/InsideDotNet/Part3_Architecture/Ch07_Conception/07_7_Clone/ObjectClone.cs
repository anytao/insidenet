// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.Conception.Clone
// Release     : 2007/10/05 1.0
// Description : 7.7 ������ǳ�Ŀ�¡��ǳ���������

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
            //ʵ��ǳ����
            return MemberwiseClone();
        }
    }

    class Enrollment : ICloneable
    {
        //���������������ݳ�Ա
        public List<Student> students = new List<Student>();

        //����Ĭ�Ϲ��캯��
        public Enrollment()
        {
        }

        //�ṩʵ�������˽��ʵ���������캯��
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
            //ִ��ǳ����
            //return MemberwiseClone();
            //ִ�����
            return new Enrollment(students);
        }
    }

    class Test_ObjectClone
    {
        public static void Main()//Main_7_7_1
        {
            //�������͵�ǳ����
            Student s1 = new Student("Wang", 22);
            //ִ��ǳ������
            Student s2 = s1;
            s2.Age = 27;
            s1.ShowInfo();


            //ֵ���͵����
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
            sourceStudentsList.students.Add(new Student("��С��", 27));
            sourceStudentsList.students.Add(new Student("����", 22));

            //ʵ�ֶ���Ŀ�¡��ִ��ǳ�������������
            //ȡ����Clone�����ľ���ʵ��
            Enrollment cloneStudentsList = sourceStudentsList.Clone() as Enrollment;

            sourceStudentsList.ShowEnrollmentInfo();
            cloneStudentsList.ShowEnrollmentInfo();

            cloneStudentsList.students[1].Name = "����";
            cloneStudentsList.students[1].Age = 36;

            sourceStudentsList.ShowEnrollmentInfo();
            cloneStudentsList.ShowEnrollmentInfo();

        }

    }

}
