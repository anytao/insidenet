// Copyright   : 你必须知道的.NET，第2版
// Author      : Anytao，http://www.anytao.com
// FileName    : Anytao.Inside.Ch13.LinqStory
// Release     : 2011/01/05 1.0
// Description : 13.4  LINQ江湖

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anytao.Inside.Ch13.LinqStory
{
    public class StudentClient
    {
        private IList<Student> students;

        public IList<Graduate> GetGraduates()
        {
            var result = (from student in students
                          where student.AvgScore > 60
                          select new Graduate
                          {
                              Id = student.Id,
                              Name = student.FirstName + " " + student.LastName
                          }).ToList();

            return result;
        }

        public IList<Graduate> GetGraduates2()
        {
            var result =
                students.Where(student => student.AvgScore > 60)
                .Select(student => new Graduate
                {
                    Id = student.Id,
                    Name = student.FirstName + " " + student.LastName
                })
                .ToList();

            return result;
        }

        public IList<Graduate> GetGraduates3()
        {
            IList<Graduate> result =
                Enumerable.ToList<Graduate>(
                    Enumerable.Select<Student, Graduate>(
                        Enumerable.Where<Student>(students,
                            delegate(Student s)
                            {
                                return s.AvgScore > 60;
                            }),
                                delegate(Student s)
                                {
                                    Graduate s1 = new Graduate();
                                    s1.Name = s.FirstName + " " + s.LastName;

                                    return s1;
                                }
                            )
                        );

            return result;
        }

        public void Get()
        {
            var result = students.Select(s => 
            {
                // var g = new Graduate();
                // var g = new Graduate(s.Id, s.FirstName + " " + s.LastName);
                var g = new Graduate { Id = s.Id, Name = s.FirstName + " " + s.LastName };

                g.Id = s.Id;
                g.Name = s.FirstName + " " + s.LastName;

                return g;
            });

            var result2 = students.Select(student => new Graduate
                {
                    Id = student.Id,
                    Name = student.FirstName + " " + student.LastName
                });

            var result3 = students.Select(student => new 
            { 
                Id = student.Id, 
                Desc = student.Name + ":" + student.Age  
            });
        }
    }
}
