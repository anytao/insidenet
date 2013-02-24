// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Conception.Collections
// Release     : 2007/11/17 1.0
// Description : 7.9 集合通论--Queue和Stack应用

using System;
using System.Collections;

namespace InsideDotNet.Conception.Collections
{
    class Queue_Stack
    {
        public static void Main_7_9_6()//Main_7_9_6
        {
            Queue myQueue = new Queue();
            //向Queue尾部添加元素
            myQueue.Enqueue("我");
            myQueue.Enqueue("是");
            myQueue.Enqueue("谁");

            //返回Queueu开始的元素
            Console.WriteLine(myQueue.Peek());
            //返回并移除Queue开始的元素
            myQueue.Dequeue();

            //遍历Queue
            foreach (object o in myQueue)
                Console.WriteLine(o.ToString());

            Stack myStack = new Stack();
            //向Stack顶部插入元素
            myStack.Push("我");
            myStack.Push("是");
            myStack.Push("谁");

            //返回Stack顶部的元素
            Console.WriteLine(myStack.Peek());
            //返回并移除Stack顶部的元素
            myStack.Pop();

            //遍历Stack
            foreach (object o in myStack)
                Console.WriteLine(o.ToString());
        }
    }
}
