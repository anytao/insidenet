// Copyright   : 你必须知道的.NET，第2版
// Author      : Anytao，http://www.anytao.com
// FileName    : Anytao.Inside.Ch13.LinqStory
// Release     : 2011/01/05 1.0
// Description : 13.4  LINQ江湖

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anytao.Inside.Ch13.LinqStory.Lambda
{
    public class StudentClient
    {
        public IList<Student> GetStudent(IList<Student> students)
        {
            // var result = Enumerable.Where(students, 
            //     (Student s) => { return s.AvgScore > 60; }).ToList();

            var result = Enumerable.Where(students, s => s.AvgScore > 60).ToList();

            return result;
        }
    }
}
