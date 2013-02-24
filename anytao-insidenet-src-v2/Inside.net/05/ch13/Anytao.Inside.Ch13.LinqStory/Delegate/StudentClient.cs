// Copyright   : 你必须知道的.NET，第2版
// Author      : Anytao，http://www.anytao.com
// FileName    : Anytao.Inside.Ch13.LinqStory
// Release     : 2011/01/05 1.0
// Description : 13.4  LINQ江湖

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anytao.Inside.Ch13.LinqStory.Delegate
{
    public class StudentClient
    {
        // 01 定义委托
        public delegate bool StudentDelegate(Student student);

        // 02 实现执行逻辑
        private bool IsQualified(Student s)
        {
            return s.AvgScore > 60;
        }

        // 03 模拟实现静态的Where方法
        public static class MyExtensions
        {
            public static IList<Student> Where(IList<Student> source, StudentDelegate d)
            {
                IList<Student> result = new List<Student>();

                foreach (var item in source)
                {
                    if (d(item))
                    {
                        result.Add(item);
                    }
                }

                return result;
            }

            public static IEnumerable<T> Where<T>(IEnumerable<T> source, Func<T, bool> d)
            {
                foreach (var item in source)
                {
                    if (d(item))
                    {
                        yield return item;
                    }
                }
            }


        }

        // 04 应用委托实现的查询
        public IList<Student> GetStudent(IList<Student> students)
        {
            StudentDelegate d = new StudentDelegate(this.IsQualified);

            var result = MyExtensions.Where(students, d);

            return result;
        }

    }
}
