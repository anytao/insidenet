// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Framework.Equals
// Release     : 2007/10/24 1.0
// Description : 8.2 规则而定：对象判等

using System;
using System.Collections.Generic;
using System.Text;

namespace InsideDotNet.Framework.Equals
{
    class EqualsAndHashCode
    {
    }

    public class Person
    {
        //每个人有唯一的身份证号，因此可以作为Person的标识码
        private string id = null;
        private string name = null;

        //以id作为哈希码是可靠的, 而name则有可能相同
        public override int GetHashCode()
        {
            return id.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj)) return true;

            Person person = obj as Person;
            if (person == null) return false;

            //Equals也以用户身份证号作为判等依据
            if (this.id == person.id) return true;

            return false;
        }
    }
}
