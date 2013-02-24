// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Conception.Collections
// Release     : 2007/11/17 1.0
// Description : 7.9 集合通论--自定义集合实现

using System;
using System.Collections;

namespace InsideDotNet.Conception.Collections
{
    class CustomArray
    {
    }

    #region 集合操作的对象类型
    public class Student
    {
        //学生姓名
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //学生年龄
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

    #region 自定义强类型集合类
    [Serializable]
    public class StudentCollection : CollectionBase
    {
        //构造函数定义
        public StudentCollection()
        {
        }

        public StudentCollection(Student[] students)
        {
            this.AddRange(students);
        }

        //集合方法实现
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

        //省略其他方法实现......

        //实现索引器
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
            sc.Add(new Student("小王", 27));
            sc.Add(new Student("小佳", 22));

            Student s = new Student("张三", 36);
            sc.Insert(1, s);
            sc.Remove(s);

            foreach (Student student in sc)
            {
                Console.WriteLine("Name:{0}\tAge:{1}", student.Name, student.Age);
            }
        }
    }
}
