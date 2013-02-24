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
    class MyClass
    {
    }

    struct MyStruct
    {
    }
    class EqualsEx
    {
        //����ֵ���ͳ�Աms
        private MyStruct ms;
        //�����������ͳ�Աmc
        private MyClass mc;

        public override bool Equals(object obj)
        {
            //Ϊnull����ز����
            if (obj == null) return false;

            //�����е�Ϊ�棬����߱ض����
            if (ReferenceEquals(this, obj)) return true;

            //�����ж�
            EqualsEx objEx = obj as EqualsEx;
            if (objEx == null) return false;

            //����ǳ�Ա�жϣ���ֵ���ͳ�Ա���������ͳ�Ա
            //ͨ�������ṩǿ���͵��еȷ�������������Ը�����Ա���е�
            return EqualsHelper(this, objEx);
        }

        private static bool EqualsHelper(EqualsEx objA, EqualsEx objB)
        {
            //ֵ���ͳ�Ա�ж�
            if (!objA.ms.Equals(objA.ms)) return false;
            //�������ͳ�Ա�ж�
            if (!Equals(objA.mc, objB.mc)) return false;

            //��󣬲ſ����ж�������������ȵ�
            return true;
        }
    }
}
