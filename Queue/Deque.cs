using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{
    public class Deque<T>
    {
        public LinkedList<T> list;

        public Deque()
        {
            list = new LinkedList<T>();
        }

        public void AddFront(T item)
        {
            list.AddFirst(item);
        }

        public void AddTail(T item)
        {
            list.AddLast(item);
        }

        public T RemoveFront()
        {
            if (list.Count <= 0) return default(T);
            var result = list.First.Value;
            list.RemoveFirst();
            return result;
        }

        public T RemoveTail()
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

        public void TurnAroundToTail(int n)
        {
            if (list.Count > 1)
                for (int i = 0; i < n; i++)
                    AddFront(RemoveTail());
        }

        public void TurnAroundToFront(int n)
        {
            if (list.Count > 1)
                for (int i = 0; i < n; i++)
                    AddTail(RemoveFront());
        }

        public static bool IsPalindrom(string line)
        {
            var queue = new Deque<char>();
            foreach (var e in line)
                if (e != ' ') queue.AddFront(char.ToLower(e));

            while (queue.Size() > 1)
                if (queue.RemoveFront() != queue.RemoveTail()) return false;
            return true;
        }
    }
}
