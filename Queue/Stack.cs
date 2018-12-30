using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{
    public class Stack<T>
    {
        public List<T> StackArray;

        public Stack()
        {
            StackArray = new List<T>();
        }

        public int Size()
        {
            return StackArray.Count;
        }

        public T Pop()
        {
            if (StackArray.Count <= 0) return default(T);
            var item = StackArray[StackArray.Count - 1];
            StackArray.RemoveAt(StackArray.Count - 1);
            return item;
        }

        public void Push(T item)
        {
            StackArray.Add(item);
        }

        public T Peek()
        {
            if (StackArray.Count <= 0) return default(T);
            return StackArray[StackArray.Count - 1];
        }
    }
}