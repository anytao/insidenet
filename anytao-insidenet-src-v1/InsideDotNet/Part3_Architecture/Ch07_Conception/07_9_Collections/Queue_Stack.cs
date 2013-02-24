// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.Conception.Collections
// Release     : 2007/11/17 1.0
// Description : 7.9 ����ͨ��--Queue��StackӦ��

using System;
using System.Collections;

namespace InsideDotNet.Conception.Collections
{
    class Queue_Stack
    {
        public static void Main_7_9_6()//Main_7_9_6
        {
            Queue myQueue = new Queue();
            //��Queueβ�����Ԫ��
            myQueue.Enqueue("��");
            myQueue.Enqueue("��");
            myQueue.Enqueue("˭");

            //����Queueu��ʼ��Ԫ��
            Console.WriteLine(myQueue.Peek());
            //���ز��Ƴ�Queue��ʼ��Ԫ��
            myQueue.Dequeue();

            //����Queue
            foreach (object o in myQueue)
                Console.WriteLine(o.ToString());

            Stack myStack = new Stack();
            //��Stack��������Ԫ��
            myStack.Push("��");
            myStack.Push("��");
            myStack.Push("˭");

            //����Stack������Ԫ��
            Console.WriteLine(myStack.Peek());
            //���ز��Ƴ�Stack������Ԫ��
            myStack.Pop();

            //����Stack
            foreach (object o in myStack)
                Console.WriteLine(o.ToString());
        }
    }
}
