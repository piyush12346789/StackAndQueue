using System;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Enqueue(56);
            linkedList.Enqueue(30);
            linkedList.Enqueue(70);
            linkedList.Display();
            linkedList.Dequeue();
            linkedList.Display();
        }
    }
}