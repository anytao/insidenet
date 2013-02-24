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
    public class StudentClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Class Class { get; set; }

        public IEnumerable<StudentClass> GetStudentClass(IList<Student> students)
        {
            var result = students.Select(s => new StudentClass
            {
                Id = s.Id,
                Name = s.Name,
                Class = GetClass(s.Id)
            });

            return result;
        }

        private AnonymousType.Class GetClass(int p)
        {
            throw new NotImplementedException();
        }
    }
}
