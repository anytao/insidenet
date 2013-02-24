// Copyright   : 你必须知道的.NET，第2版
// Author      : Anytao，http://www.anytao.com
// FileName    : Anytao.Inside.Ch13.LinqStory
// Release     : 2011/01/05 1.0
// Description : 13.4  LINQ江湖

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anytao.Inside.Ch13.LinqStory.AnonymousType
{
    public class StudentIdName
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IEnumerable<StudentIdName> GetStudents(IList<Student> students)
        {
            var result = students.Select(s => new StudentIdName 
            { 
                Id = s.Id, 
                Name = s.Name 
            });

            return result;


            var result1 = students.Select(s => new { Id = s.Id, Name = s.Name});
            var result2 = students.Select(s => new { Id = s.Id, Age = s.Age });
            var result3 = students.Select(s => new { Id = s.Id, Class = GetClass(s.Id) });
            // ......
        }

        private object GetClass(int p)
        {
            throw new NotImplementedException();
        }
    }
}
