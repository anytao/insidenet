using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;
using Anytao.Inside.Ch13.LinqStory;

namespace Anytao.Inside.Ch13.Test.LinqStory
{
    public class StudentDelegateFact
    {
        IList<Student> students;

        public StudentDelegateFact()
        {
            students = new List<Student> 
            { 
                new Student{ Id = 1, AvgScore = 80, FirstName = "Wang", LastName = "Tao" },
                new Student{ Id = 1, AvgScore = 50, FirstName = "Wang", LastName = "Er" },
                new Student{ Id = 1, AvgScore = 96, FirstName = "Zhang", LastName = "San" },
                new Student{ Id = 1, AvgScore = 30, FirstName = "Li", LastName = "Si" },
            };
        }

        [Fact]
        public void GetTest()
        {
            var a = new Anytao.Inside.Ch13.LinqStory.Delegate.StudentClient();

            var result = a.GetStudent(students);

            Assert.Equal(2, result.Count);

        }
    }
}
