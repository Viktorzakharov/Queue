using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{
    public class Queue<T>
    {
        public LinkedList<T> list;

        public Queue()
        {
            list = new LinkedList<T>();
        }

        public void Enqueue(T item)
        {
            list.AddFirst(item);
        }

        public T Dequeue()
        {
            if (list.Count <= 0) return default(T);
            var result = list.Last.Value;
            list.RemoveLast();
            return result;
        }

        public int Size()
        {
            return list.Count;
        }

        public void TurnAround(int n)
        {
            if (list.Count > 1)
                for (int i = 0; i < n; i++)
                    Enqueue(Dequeue());
        }
    }
}
