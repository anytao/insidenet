// Copyright   : 你必须知道的.NET，第2版
// Author      : Anytao，http://www.anytao.com
// FileName    : Anytao.Inside.Ch08.AttributeEx
// Release     : 2010/08/02 1.0
// Description : 8.3  历史纠葛：特性和属性

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Anytao.Inside.Ch08.AttributeEx
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.Id = 1;
            user.Name = " Wang Tao  ";
            user.Email = "aBC";
            user.Desc = " , is a .NET geek.    ";

            var context = new ValidationContext(user, null, null);
            var result = new List<ValidationResult>();

            var isValid = Validator.TryValidateObject(user, context, result, true);

            if (!isValid)
            {
                result.ForEach(x => Console.WriteLine(x.ErrorMessage));
            }
            else
            {
                //DB.Execute(user);
            }

            //user.Trim();

            //user.Name.Trim();
            //user.Desc.Trim();

            // Console.WriteLine(user.Name + " " + user.Desc);
        }
    }
}
