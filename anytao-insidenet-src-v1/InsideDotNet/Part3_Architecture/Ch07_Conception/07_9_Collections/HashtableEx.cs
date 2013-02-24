// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.Conception.Collections
// Release     : 2007/11/17 1.0
// Description : 7.9 ����ͨ��--HashtableӦ��

using System;
using System.Collections;

namespace InsideDotNet.Conception.Collections
{
    class HashtableEx
    {
        public static void Main_7_9_5()//Main_7_9_5
        {
            Hashtable ht = new Hashtable();

            //��Ӽ���Ԫ��
            ht.Add("Name", "С��");
            ht.Add("Age", 27);
            ht.Add("Degree", "˶ʿ");

            //�Լ�ֵ���Ҽ���
            Console.WriteLine("{0}��������{1}", ht["Name"], ht["Age"]);

            //���ϱ���
            foreach (DictionaryEntry de in ht)
            {
                Console.WriteLine("{0}--{1}", de.Key.ToString(), de.Value.ToString());
            }

            //ɾ������Ԫ��
            ht.Remove("Age");

            //��������
            ArrayList als = new ArrayList(ht.Keys);
            als.Sort();
            foreach (string key in als)
            {
                Console.WriteLine("{0}--{1}", key, ht[key].ToString());
            }

            //�������
            ht.Clear();
        }
    }
}
