// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.Framework.Equals
// Release     : 2007/10/24 1.0
// Description : 8.2 ��������������е�

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
        //ÿ������Ψһ�����֤�ţ���˿�����ΪPerson�ı�ʶ��
        private string id = null;
        private string name = null;

        //��id��Ϊ��ϣ���ǿɿ���, ��name���п�����ͬ
        public override int GetHashCode()
        {
            return id.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj)) return true;

            Person person = obj as Person;
            if (person == null) return false;

            //EqualsҲ���û����֤����Ϊ�е�����
            if (this.id == person.id) return true;

            return false;
        }
    }
}
