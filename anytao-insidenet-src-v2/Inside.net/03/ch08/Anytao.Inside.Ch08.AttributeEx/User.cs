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
    public class User
    {
        public int Id { get; set; }

        [Trim(typeof(string))]
        public string Name { get; set; }

        [Required(ErrorMessage = "Age is required.")]
        [Range(1, 200)]
        public int Age { get; set; }

        [Required]
        [RegularExpression("^[a-z0-9_\\+-]+(\\.[a-z0-9_\\+-]+)*@[a-z0-9-]+(\\.[a-z0-9-]+)*\\.([a-z]{2,4})$", ErrorMessage = "A invalid email.")]
        public string Email { get; set; }

        public string Desc { get; set; }
    }
}
