// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Type.Arguments
// Release     : 2007/07/05 1.0
// Description : 4.3  参数之惑---传递的艺术

using System;
using System.Collections.Generic;
using System.Text;

namespace InsideDotNet.Type.Arguments
{
    class Student
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Student(string _name)
        {
            name = _name;
        }
        static void Main_4_3_4()//Main_4_3_4
        {
            Student s = new Student("zhang3");
            ChageName(ref s);
            Console.WriteLine(s.Name);
        }

        static void ChageName(ref Student s)
        {
            s = new Student("li4");
        }


    }

    class TestStu
    {

    }
}