// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.Conception.Collections
// Release     : 2007/11/17 1.0
// Description : 7.9 ����ͨ��--�Զ��弯��ʵ��

using System;
using System.Collections;

namespace InsideDotNet.Conception.Collections
{
    class CustomArray
    {
    }

    #region ���ϲ����Ķ�������
    public class Student
    {
        //ѧ������
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //ѧ������
        private Int32 age;

        public Int32 Age
        {
            get { return age; }
            set { age = value; }
        }

        public Student(string name, Int32 age)
        {
            this.name = name;
            this.age = age;
        }
    }

    #endregion

    #region �Զ���ǿ���ͼ�����
    [Serializable]
    public class StudentCollection : CollectionBase
    {
        //���캯������
        public StudentCollection()
        {
        }

        public StudentCollection(Student[] students)
        {
            this.AddRange(students);
        }

        //���Ϸ���ʵ��
        public int Add(Student student)
        {
            return base.List.Add(student);
        }

        public void AddRange(Student[] students)
        {
            if (students == null)
                throw new ArgumentNullException("Student is null.");

            for (Int32 i = 0; i < students.Length; i++)
            {
                this.Add(students[i]);
            }
        }

        public void AddRange(StudentCollection studentCollection)
        {
            if (studentCollection == null)
                throw new ArgumentNullException("Student is null");

            foreach (Student s in studentCollection)
            {
                this.Add(s);
            }
        }

        public bool Contains(Student student)
        {
            return base.List.Contains(student);
        }

        public void CopyTo(Student[] students, Int32 index)
        {
            base.List.CopyTo(students, index);
        }

        public int IndexOf(Student student)
        {
            return base.List.IndexOf(student);
        }

        public void Insert(Int32 index, Student student)
        {
            base.List.Insert(index, student);
        }

        public void Remove(Student student)
        {
            base.List.Remove(student);
        }

        //ʡ����������ʵ��......

        //ʵ��������
        public Student this[int index]
        {
            get { return (Student)base.List[index]; }
            set { base.List[index] = value; }
        }
    }

    #endregion

    class Test_StudentCollection
    {
        public static void Main_7_9_8()//Main_7_9_8
        {
            StudentCollection sc = new StudentCollection();
            sc.Add(new Student("С��", 27));
            sc.Add(new Student("С��", 22));

            Student s = new Student("����", 36);
            sc.Insert(1, s);
            sc.Remove(s);

            foreach (Student student in sc)
            {
                Console.WriteLine("Name:{0}\tAge:{1}", student.Name, student.Age);
            }
        }
    }
}
