// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.Memory.Performance
// Release     : 2007/12/01 1.0
// Description : 5.4 ���ܿ��ƵĶ෽̽��

using System;
using System.Collections.Generic;
using System.Text;

namespace InsideDotNet.Memory.Performance
{
    public class MyClass
    {
    }

    class WeakRefEx
    {
        public void WeakRef()
        {
            MyClass mc = new MyClass();

            //������������
            WeakReference wr = new WeakReference(mc);
            //�Ƴ�ǿ����
            mc = null;

            if (wr.IsAlive)
            {
                //������ת��Ϊǿ���ã���������ٴ�ʹ��
                mc = wr.Target as MyClass;
            }
            else
            {
                //�����Ѿ������գ����´���
                mc = new MyClass();
            }
        }
    }
}
